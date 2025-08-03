using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.Security;

namespace Adaptive.Data.Vault
{
    /// <summary>
    /// Provides and contains the parameters for creating or accessing a secure file.
    /// </summary>
    /// <seealso cref="DisposableObjectBase" />
    public sealed class SecureFileParameters : DisposableObjectBase
    {
        #region Private Member Declarations		
        /// <summary>
        /// The new file name.
        /// </summary>
        private string? _fileName;
        /// <summary>
        /// The user name for the file.
        /// </summary>
        private SecureString? _userName;
        /// <summary>
        /// The password for the file.
        /// </summary>
        private SecureString? _password;
        /// <summary>
        /// The PIN for the file.
        /// </summary>
        private SecureInt32? _pin;
        #endregion

        #region Constructor / Dispose Methods		
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureFileParameters"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public SecureFileParameters()
        {
            _userName = new SecureString();
            _password = new SecureString();
            _pin = new SecureInt32();
        }
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><b>true</b> to release both managed and unmanaged resources;
        /// <b>false</b> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed && disposing)
            {
                _userName?.Dispose();
                _password?.Dispose();
                _pin?.Dispose();
            }
            _fileName = null;
            _userName = null;
            _password = null;
            _pin = null;
            base.Dispose(disposing);
        }
        #endregion

        #region Public Properties		
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// A string containing the fully-qualified path and name of the file.
        /// </value>
        public string? FileName
        {
            get => _fileName;
            set => _fileName = value;
        }
        /// <summary>
        /// Gets or sets the password value.
        /// </summary>
        /// <value>
        /// A string containing the password value.
        /// </value>
        public string? Password
        {
            get => _password?.Value;
            set
            {
                if (_password != null)
                    _password.Value = value;
            }
        }
        /// <summary>
        /// Gets or sets the PIN value.
        /// </summary>
        /// <value>
        /// An integer containing the PIN value.
        /// </value>
        public int Pin
        {
            get
            {
                return _pin?.Value ?? 0;
            }
            set
            {
                if (_pin != null)
                    _pin.Value = value;
            }
        }
        /// <summary>
        /// Gets or sets the user name or ID value.
        /// </summary>
        /// <value>
        /// A string containing the user name value.
        /// </value>
        public string? UserId
        {
            get => _userName?.Value;
            set
            {
                if (_userName != null)
                    _userName.Value = value;
            }
        }
        #endregion
    }
}
