using Adaptive.Intelligence.Shared;

#pragma warning disable CS4014

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides a dialog for encrypting files.
    /// </summary>
    /// <seealso cref="Adaptive.Data.Vault.UI.BorderedDialog" />
    public partial class EncryptFileDialog : BorderedDialog
    {
        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptFileDialog"/> class.
        /// </summary>
        public EncryptFileDialog()
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
            OpenFile.ContentChanged += HandleGenericControlChange;
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
            OpenFile.ContentChanged -= HandleGenericControlChange;
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

            canEncrypt = OpenFile.IsValid && SaveFile.IsValid && PrimaryText.Text.Length > 0
                && SecondaryText.Text.Length > 0 && PinText.Text.Length > 0;

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

            PerformFileEncryptionAsync(
                OpenFile.FileName,
                SaveFile.FileName,
                PrimaryText.Text,
                SecondaryText.Text,
                PinText.Value);
        }
        private void HandleEncryptionStart(object? sender, ProgressUpdateEventArgs e)
        {
            ContinueInMainThread(() =>
            {

            });
        }
        private void HandleEncryptionEnd(object? sender, ProgressUpdateEventArgs e)
        {
            ContinueInMainThread(() =>
            {
                DialogResult = DialogResult.OK;
                Close();
            });
        }
        private void HandleEncryptionProgress(object? sender, ProgressUpdateEventArgs e)
        {
            ContinueInMainThread(() =>
            {

            });
        }

        #endregion

        #region Private Methods / Functions
        /// <summary>
        /// Performs the task of encrypting hte specified file asynchronously.
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
        private async Task PerformFileEncryptionAsync(
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

            crypt.EncryptionStart += HandleEncryptionStart;
            crypt.EncryptionComplete += HandleEncryptionEnd;
            crypt.CryptoProgress += HandleEncryptionProgress;

            await crypt.EncryptFileAsync(OpenFile.FileName, SaveFile.FileName).ConfigureAwait(false);

            crypt.EncryptionStart -= HandleEncryptionStart;
            crypt.EncryptionComplete -= HandleEncryptionEnd;
            crypt.CryptoProgress -= HandleEncryptionProgress;

            crypt.Dispose();
        }
        #endregion
    }
}
