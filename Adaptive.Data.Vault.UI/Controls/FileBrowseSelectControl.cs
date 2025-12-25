using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides a control for selecting a file to open or save.
    /// </summary>
    public partial class FileBrowseSelectControl : AdaptiveControlBase
    {
        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="FileBrowseSelectControl"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public FileBrowseSelectControl()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed && disposing)
            {
                components?.Dispose();
            }
            components = null;
            base.Dispose(disposing);
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the name of the selected file.
        /// </summary>
        /// <value>
        /// A string containing the fully-qualified path and name of the file that was selected or entered.
        /// </value>
        [Browsable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
         Category("Data"),
         Description("Gets or sets the path and name of the file.")]
        public string FileName
        {
            get => FileText.Text;
            set
            {
                FileText.Text = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text of the prompt on the control.
        /// </summary>
        /// <remarks>
        /// A string containing the text to be displayed.
        /// </remarks>
        [Browsable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
         Category("Appearance"),
         Description("Gets or sets the text to be displayed on the control.")]
        public string FilePrompt
        {
            get => InstructLabel.Text;
            set
            {
                InstructLabel.Text = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the prompt on the control.
        /// </summary>
        /// <value>
        /// An integer specifying the width, in pixels.
        /// </value>
        [Browsable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
         Category("Appearance"),
         Description("Gets or sets the width of the text to be displayed on the control.")]
        public int FilePromptWidth
        {
            get => InstructLabel.Width;
            set
            {
                InstructLabel.Width = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets a value indicating whether the contained text is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the file specification for this instance is valid; otherwise, <c>false</c>.
        /// </value>
        [Browsable(false),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsValid
        {
            get
            {
                bool isValid = false;

                if (FileText.Text.Length > 0)
                {
                    string path = Path.GetDirectoryName(FileText.Text) ?? string.Empty;
                    string fileName = Path.GetFileName(FileText.Text);

                    isValid = (!string.IsNullOrEmpty(path) &&
                       !string.IsNullOrEmpty(fileName) &&
                       System.IO.Directory.Exists(path));
                    if (OpenFileMode)
                    {
                        isValid &= System.IO.File.Exists(FileText.Text);
                    }
                }
                return isValid;
            }
        }
        /// <summary>
        /// Gets or sets the operation mode for the control.
        /// </summary>
        /// <value>
        /// <b>true</b> if the browse operation is for opening a file,
        /// otherwise, for saving a file.
        /// </value>

        [Browsable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
         Category("Behavior"),
         Description("Gets or sets a valuei indicating whether to open or save a file.")]
        public bool OpenFileMode { get; set; } = true;
        #endregion

        #region Protected Method Overrides
        /// <summary>
        /// Assigns event handlers to control events.
        /// </summary>
        protected override void AssignEventHandlers()
        {
            BrowseButton.Click += HandleBrowseClicked;
        }

        /// <summary>
        /// Removes the event handlers from control events.
        /// </summary>
        protected override void RemoveEventHandlers()
        {
            BrowseButton.Click -= HandleBrowseClicked;
        }

        /// <summary>
        /// Sets the control state prior to loading data.
        /// </summary>
        protected override void SetPreLoadState()
        {
            Cursor = Cursors.WaitCursor;
            BrowseButton.Enabled = false;
            FileText.Enabled = false;
            Application.DoEvents();
            SuspendLayout();
        }

        /// <summary>
        /// Sets the control state after loading data.
        /// </summary>
        protected override void SetPostLoadState()
        {
            Cursor = Cursors.Default;
            BrowseButton.Enabled = true;
            FileText.Enabled = true;
            ResumeLayout();
        }
        #endregion

        #region Private Event Handlers
        /// <summary>
        /// Handles the event when the Browse (...) button is clicked.
        /// </summary>
        /// <param name="sender">
        /// The source of the event.
        /// </param>
        /// <param name="e">
        /// The <see cref="EventArgs"/> instance containing the data for the event.
        /// </param>
        private void HandleBrowseClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            if (OpenFileMode)
                ShowOpenFileDialog();
            else
                ShowSaveFileDialog();

            SetPostLoadState();
        }
        #endregion

        #region Private Methods / Functions
        /// <summary>
        /// Displays the open file dialog.
        /// </summary>
        private void ShowOpenFileDialog()
        {
            OpenFileDialog dialog = new()
            {
                Title = "Select a File to Open",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                InitialDirectory = System.IO.Path.GetDirectoryName(FileText.Text) ?? string.Empty,
                FileName = System.IO.Path.GetFileName(FileText.Text) ?? string.Empty,
                Filter = "All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileText.Text = dialog.FileName;
                    OnContentChanged(EventArgs.Empty);
                }
            }
            dialog.Dispose();
        }
        /// <summary>
        /// Displays the save file dialog.
        /// </summary>
        private void ShowSaveFileDialog()
        {
            using SaveFileDialog dialog = new()
            {
                Title = "Select a File to Save",
                OverwritePrompt = true,
                AddExtension = true,
                InitialDirectory = System.IO.Path.GetDirectoryName(FileText.Text) ?? string.Empty,
                FileName = System.IO.Path.GetFileName(FileText.Text) ?? string.Empty,
                Filter = "All Files (*.*)|*.*"
            };
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (FileText.Text != dialog.FileName)
                {
                    FileText.Text = dialog.FileName;
                    OnContentChanged(EventArgs.Empty);
                }
            }
            dialog.Dispose();
        }
        #endregion
    }
}
