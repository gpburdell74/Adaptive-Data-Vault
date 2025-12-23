namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides a dialog for viewing the release notes for the application.
    /// </summary>
    /// <seealso cref="BorderedDialog" />
    public partial class ReleaseNotesDialog : BorderedDialog
    {
        #region Constructor / Dispose Methods        
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseNotesDialog"/> class.
        /// </summary>
        public ReleaseNotesDialog()
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
            SaveCancelBar.CancelClicked += HandleCancelClicked;
        }

        /// <summary>
        /// Removes the event handlers for the controls on the dialog.
        /// </summary>
        protected override void RemoveEventHandlers()
        {
            SaveCancelBar.CancelClicked -= HandleCancelClicked;
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
            Close();
        }
        #endregion
    }
}
