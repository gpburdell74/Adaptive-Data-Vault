using Adaptive.Intelligence.Shared;

#pragma warning disable CS4014

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides a dialog for decrypting files.
    /// </summary>
    /// <seealso cref="BorderedDialog" />
    public partial class DecryptFileDialog : BorderedDialog
    {
        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptFileDialog"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public DecryptFileDialog()
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

        #region Protected Method Overrides
        /// <summary>
        /// Assigns the event handlers for the controls on the dialog.
        /// </summary>
        protected override void AssignEventHandlers()
        {
            OpenFile.ContentChanged += HandleOpenFileContentChanged;
            SaveFile.ContentChanged += HandleGenericControlChange; ;
            PrimaryText.ContentChanged += HandleGenericControlChange;
            SecondaryText.ContentChanged += HandleGenericControlChange;
            PinText.TextChanged += HandleGenericControlChange;

            SaveCancel.CancelClicked += HandleCancelClicked;
            SaveCancel.SaveClicked += HandleSaveClicked;
        }

        /// <summary>
        /// Removes the event handlers for the controls on the dialog.
        /// </summary>
        protected override void RemoveEventHandlers()
        {
            OpenFile.ContentChanged -= HandleOpenFileContentChanged;
            SaveFile.ContentChanged -= HandleGenericControlChange; ;
            PrimaryText.ContentChanged -= HandleGenericControlChange;
            SecondaryText.ContentChanged -= HandleGenericControlChange;
            PinText.TextChanged -= HandleGenericControlChange;

            SaveCancel.CancelClicked -= HandleCancelClicked;
            SaveCancel.SaveClicked -= HandleSaveClicked;
        }

        /// <summary>
        /// Sets the state of the UI controls before the data content is loaded.
        /// </summary>
        protected override void SetPreLoadState()
        {
            Cursor = Cursors.WaitCursor;
            OpenFile.Enabled = false;
            SaveFile.Enabled = false;
            PrimaryText.Enabled = false;
            SecondaryText.Enabled = false;
            PinText.Enabled = false;
            Application.DoEvents();
            SuspendLayout();
        }

        /// <summary>
        /// Sets the state of the UI controls after the data content is loaded.
        /// </summary>
        protected override void SetPostLoadState()
        {
            Cursor = Cursors.Default;
            OpenFile.Enabled = true;
            SaveFile.Enabled = true;
            PrimaryText.Enabled = true;
            SecondaryText.Enabled = true;
            PinText.Enabled = true;
            ResumeLayout();
        }

        /// <summary>
        /// When implemented in a derived class, sets the display state for the controls on the dialog based on
        /// current conditions.
        /// </summary>
        /// <remarks>
        /// This is called by <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetState" /> after <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetSecurityState" /> is called.
        /// </remarks>
        protected override void SetDisplayState()
        {
            bool canEncrypt = false;

            ErrorProvider.Clear();

            if (!OpenFile.IsValid)
            {
                ErrorProvider.SetError(OpenFile, "Please select a valid file to encrypt.");
            }
            else if (!SaveFile.IsValid)
            {
                ErrorProvider.SetError(SaveFile, "Please select a valid destination file.");
            }
            else if (PrimaryText.Text.Length == 0)
            {
                ErrorProvider.SetError(PrimaryText, "Please enter a primary encryption key.");
            }
            else if (SecondaryText.Text.Length == 0)
            {
                ErrorProvider.SetError(SecondaryText, "Please enter a secondary encryption key.");
            }
            else if (PinText.Text.Length == 0)
            {
                ErrorProvider.SetError(PinText, "Please enter a PIN value.");
            }
            else
            {
                canEncrypt = true;
            }

            SaveCancel.SaveEnabled = canEncrypt;
        }
        #endregion

        #region Private Event Handlers
        /// <summary>
        /// Handles the event when the Cancel button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleCancelClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            DialogResult = DialogResult.Cancel;
            Close();
        }
        /// <summary>
        /// Handles the event when the Encrypt button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleSaveClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();

            PerformFileDecryptionAsync(
                OpenFile.FileName,
                SaveFile.FileName,
                PrimaryText.Text,
                SecondaryText.Text,
                PinText.Value);
        }

        /// <summary>
        /// Handles the event when the Open File content changes.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleOpenFileContentChanged(object? sender, EventArgs e)
        {
            if (SaveFile.FileName.Length == 0 && OpenFile.FileName.Length > 0)
            {
                SaveFile.FileName = OpenFile.FileName + ".enc";
            }
            SetDisplayState();
        }
        /// <summary>
        /// Handles the event when the encryption process starts.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void HandleDecryptionStart(object? sender, ProgressUpdateEventArgs e)
        {
            ContinueInMainThread(() =>
            {
                SecurityPanel.Visible = false;
                StatusPanel.Visible = true;
                Progress.Value = 0;
                SaveCancel.SaveEnabled = false;
                SaveCancel.CancelEnabled = false;
                Application.DoEvents();
                Application.DoEvents();
            });
        }

        /// <summary>
        /// Handles the event when the encryption process completes.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void HandleDecryptionEnd(object? sender, ProgressUpdateEventArgs e)
        {
            ContinueInMainThread(() =>
            {
                Progress.Value = 100;
                Application.DoEvents();
                Application.DoEvents();

                DialogResult = DialogResult.OK;
                Close();
            });
        }

        /// <summary>
        /// Handles the event when the encryption process updates the current progress.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ProgressUpdateEventArgs"/> instance containing the event data.</param>
        private void HandleDecryptionProgress(object? sender, ProgressUpdateEventArgs e)
        {
            ContinueInMainThread(() =>
            {
                Progress.Value = e.PercentDone;
                Application.DoEvents();
                Application.DoEvents();
            });
        }

        #endregion

        #region Private Methods / Functions
        /// <summary>
        /// Performs the task of decrypting hte specified file asynchronously.
        /// </summary>
        /// <param name="sourceFile">
        /// A string containing the fully-qualified path and name of the file whose contents are to be encrypted.
        /// </param>
        /// <param name="destinationFile">
        /// /// A string containing the fully-qualified path and name of the file to which the encrypted content is written.
        /// </param>
        /// <param name="primaryKey">
        /// A string containing the value used to generate the primary encryption key.
        /// </param>
        /// <param name="secondaryKey">
        /// A string containing the value used to generate the secondary encryption key.
        /// </param>
        /// <param name="pin">
        /// An integer containing the PIN value used in the encryption process.
        /// </param>
        private async Task PerformFileDecryptionAsync(
            string sourceFile,
            string destinationFile,
            string primaryKey,
            string secondaryKey,
            int pin)
        {
            FileCryptographer crypt = new FileCryptographer(
               PrimaryText.Text,
               SecondaryText.Text,
               int.Parse(PinText.Text));

            crypt.DecryptionStart += HandleDecryptionStart;
            crypt.DecryptionComplete += HandleDecryptionEnd;
            crypt.CryptoProgress += HandleDecryptionProgress;

            await crypt.DecryptFileAsync(OpenFile.FileName, SaveFile.FileName).ConfigureAwait(false);

            crypt.DecryptionStart -= HandleDecryptionStart;
            crypt.DecryptionComplete -= HandleDecryptionEnd;
            crypt.CryptoProgress -= HandleDecryptionProgress;

            crypt.Dispose();
        }
        #endregion
    }
}
