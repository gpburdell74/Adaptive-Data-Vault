using Adaptive.Data.Vault.OS;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides the dialog for showing the detail information for a web account entry.
    /// </summary>
    /// <seealso cref="AdaptiveDialogBase" />
    public partial class WebAccountInfoDialog : BorderedDialog
    {
        #region Private Member Declarations
        /// <summary>
        /// The account instance to show.
        /// </summary>
        private WebAccount? _account;
        #endregion

        #region Constructor / Dispose Methods        
        /// <summary>
        /// Initializes a new instance of the <see cref="WebAccountInfoDialog"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public WebAccountInfoDialog()
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

            _account = null;
            components = null;
            base.Dispose(disposing);
        }
        #endregion

        [Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public WebAccount Account
        {
            get => _account;
            set
            {
                _account = value;
                Invalidate();
            }
        }
        #region Protected Method Overrides        
        /// <summary>
        /// Initializes the control and dialog state according to the form data.
        /// </summary>
        protected override void InitializeDataContent()
        {
            Header.Text = _account.Name;
            AddressLabel.Text = _account.Url;
            UserIdLabel.Text = new string('*', _account.UserId.Length);
            PasswordLabel.Text = new string('*', _account.Password.Length);
        }

        /// <summary>
        /// Assigns the event handlers for the controls on the dialog.
        /// </summary>
        protected override void AssignEventHandlers()
        {
            AddressLabel.Click += HandleAddressClicked;
            ShowUserIdButton.Click += HandleShowUserIdClicked;
            ShowPasswordButton.Click += HandleShowPasswordClicked;
            CopyPasswordButton.Click += HandleCopyPasswordClicked;
            CopyUrlButton.Click += HandleCopyUrlClicked;
            CopyUserIdButton.Click += HandleCopyUserIdClicked;
            CloseButton.Click += HandleCloseClicked;
        }

        /// <summary>
        /// Removes the event handlers for the controls on the dialog.
        /// </summary>
        protected override void RemoveEventHandlers()
        {
            AddressLabel.Click -= HandleAddressClicked;
            ShowUserIdButton.Click -= HandleShowUserIdClicked;
            ShowPasswordButton.Click -= HandleShowPasswordClicked;
            CopyPasswordButton.Click -= HandleCopyPasswordClicked;
            CopyUrlButton.Click -= HandleCopyUrlClicked;
            CopyUserIdButton.Click -= HandleCopyUserIdClicked;
            CloseButton.Click -= HandleCloseClicked;
        }

        /// <summary>
        /// Sets the state of the UI controls before the data content is loaded.
        /// </summary>
        protected override void SetPreLoadState()
        {
            Cursor = Cursors.WaitCursor;
            ShowUserIdButton.Enabled = false;
            ShowPasswordButton.Enabled = false;
            CopyPasswordButton.Enabled = false;
            CopyUrlButton.Enabled = false;
            CopyUserIdButton.Enabled = false;
            CloseButton.Enabled = false;
            Application.DoEvents();
            SuspendLayout();
        }

        /// <summary>
        /// Sets the state of the UI controls after the data content is loaded.
        /// </summary>
        protected override void SetPostLoadState()
        {
            Cursor = Cursors.Default;
            ShowUserIdButton.Enabled = true;
            ShowPasswordButton.Enabled = true;
            CopyPasswordButton.Enabled = true;
            CopyUrlButton.Enabled = true;
            CopyUserIdButton.Enabled = true;
            CloseButton.Enabled = true;

            ResumeLayout();
            Invalidate();
            Application.DoEvents();
        }

        /// <summary>
        /// When implemented in a derived class, sets the display state for the controls on the dialog based on
        /// current conditions.
        /// </summary>
        /// <remarks>
        /// This is called by <see cref="SetState" /> after <see cref="SetSecurityState" /> is called.
        /// </remarks>
        protected override void SetDisplayState()
        {
        }
        #endregion


        #region Private Event Handlers
        /// <summary>
        /// Handles the event when the address label is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleAddressClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();

            if (_account != null && _account.Url != null)
                OSUtilities.StartBrowser(_account.Url);

            SetPostLoadState();
        }

        /// <summary>
        /// Handles the event when the Show/Hide user ID button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleShowUserIdClicked(object? sender, EventArgs e)
        {
            ShowUserIdButton.Checked = !ShowUserIdButton.Checked;
            if (ShowUserIdButton.Checked)
                UserIdLabel.Text = _account.UserId;
            else
                UserIdLabel.Text = new string('*', _account.UserId.Length);

        }

        /// <summary>
        /// Handles the event when the Show/Hide Password button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleShowPasswordClicked(object? sender, EventArgs e)
        {
            ShowPasswordButton.Checked = !ShowPasswordButton.Checked;
            if (ShowPasswordButton.Checked)
                PasswordLabel.Text = _account.Password;
            else
                PasswordLabel.Text = new string('*', _account.Password.Length);
            Invalidate();
        }

        /// <summary>
        /// Handles the event when the Copy Password button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleCopyPasswordClicked(object? sender, EventArgs e)
        {
            Clipboard.SetText(_account.Password);
        }

        /// <summary>
        /// Handles the event when the Copy URL button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleCopyUrlClicked(object? sender, EventArgs e)
        {
            Clipboard.SetText(_account.Url);
        }


        /// <summary>
        /// Handles the event when the Copy User ID button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleCopyUserIdClicked(object? sender, EventArgs e)
        {
            Clipboard.SetText(_account.UserId);
        }

        /// <summary>
        /// Handles the event when the Close button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleCloseClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            Application.DoEvents();
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

    }
}
