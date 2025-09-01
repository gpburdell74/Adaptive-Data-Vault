using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.IO;

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Manages the most-recently-used file list.f
    /// </summary>
    /// <seealso cref="Adaptive.Intelligence.Shared.DisposableObjectBase" />
    public sealed class MruManager : DisposableObjectBase
    {
        #region Private Member Declarations
        /// <summary>
        /// The MRU file to read from and write to.
        /// </summary>
        private const string MRU_FILE = "AdaptiveVault.mru";

        /// <summary>
        /// The MRU list container.
        /// </summary>
        private List<string>? _mruList = null;
        #endregion

        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="MruManager"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public MruManager()
        {
            _mruList = new List<string>();
            Load();
        }
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
        /// <b>false</b> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            Save();
            if (!IsDisposed && disposing)
            {
                _mruList?.Clear();
            }

            _mruList = null;
            base.Dispose(disposing);
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets the number of items in the MRU list.
        /// </summary>
        /// <value>
        /// An integer specifying the number of items.
        /// </value>
        public int Count
        {
            get
            {
                if (_mruList == null)
                    return 0;
                else
                    return _mruList.Count;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the EULA was accepted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the EULA was accepted; otherwise, <c>false</c>.
        /// </value>
        public bool EulaAccepted { get; set; }

        /// <summary>
        /// Gets the recent file name list.
        /// </summary>
        /// <value>
        /// A <see cref="List{T}"/> of <see cref="string"/> containing the MRU list.
        /// </value>
        public List<string> RecentFileList
        {
            get
            {
                List<string> list = new List<string>();
                if (_mruList != null && _mruList.Count > 0)
                    list.AddRange(_mruList);
                return list;
            }
        }
        #endregion

        #region Public Methods / Functions
        /// <summary>
        /// Adds the specified file name to the MRU list.
        /// </summary>
        /// <param name="fileName">
        /// A string containing the path and name of the file.
        /// </param>
        public void Add(string fileName)
        {
            if (_mruList != null)
                _mruList.Add(fileName);
            Save();
        }

        /// <summary>
        /// Clears the contents of the MRU list.
        /// </summary>
        public void Clear()
        {
            if (_mruList != null)
            {
                _mruList.Clear();
                Save();
            }
        }

        /// <summary>
        /// Determines whether the specified file is in the MRU list.
        /// </summary>
        /// <param name="fileName">
        /// A string containing the path and name of the file.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the MRU List contains the specified file name, otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string fileName)
        {
            bool exists = false;
            if (_mruList != null && _mruList.Count > 0)
            {
                exists = _mruList.Contains(fileName);
            }
            return exists;
        }

        /// <summary>
        /// Removes the specified file name from the MRU list.
        /// </summary>
        /// <param name="fileName">
        /// A string containing the path and name of the file.
        /// </param>
        public void Remove(string fileName)
        {
            if (_mruList != null)
            {
                if (_mruList.Contains(fileName))
                    _mruList.Remove(fileName);
            }
            Save();
        }
        #endregion

        #region Private Methods / Functions
        /// <summary>
        /// Generates the byte array of the content to be saved.
        /// </summary>
        /// <returns>
        /// An array of bytes containing the list of MRU entries.
        /// </returns>
        private byte[] GenerateSaveContent()
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(ms);
            if (_mruList != null)
            {
                writer.Write(EulaAccepted);

                writer.Write(_mruList.Count);
                foreach (string file in _mruList)
                {
                    writer.Write(file);
                }
                writer.Flush();
            }
            
            byte[] data = ms.ToArray();   
            writer.Close();
            ms.Close();

            return data;
        }

        /// <summary>
        /// Loads the local MRU content.
        /// </summary>
        private void Load()
        {
            if (_mruList == null)
                _mruList = new List<string>();
            else
                _mruList.Clear();

            byte[]? data = SafeIO.ReadBytesFromFile(MRU_FILE);
            if (data != null)
            {
                ReadContent(data);
                Array.Clear(data, 0, data.Length);
            }
        }

        /// <summary>
        /// Reads the byte array into a list of files.
        /// </summary>
        /// <param name="data">
        /// A byte array containing the data.</param>
        private void ReadContent(byte[] data)
        {
            if (_mruList != null)
            {
                MemoryStream ms = new MemoryStream(data);
                SafeBinaryReader reader = new SafeBinaryReader(ms);

                EulaAccepted = reader.ReadBoolean();

                int length = reader.ReadInt32();
                for (int count = 0; count < length; count++)
                {
                    string? fileName = reader.ReadString();
                    if (!string.IsNullOrEmpty(fileName))
                        _mruList.Add(fileName);
                }
                reader.Close();
                ms.Dispose();
            }
        }
        
        /// <summary>
        /// Saves the content to the local MRU file.
        /// </summary>
        private void Save()
        {
            byte[] data = GenerateSaveContent();
            SafeIO.WriteBytesToFile(MRU_FILE, data);
            Array.Clear(data, 0, data.Length);
        }
        #endregion

    }
}
