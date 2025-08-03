using Adaptive.Data.Vault.OS;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides the dialog for showing the detail information for a web account entry.
    /// </summary>
    /// <seealso cref="AdaptiveDialogBase" />
    public partial class WebAccountInfoDialog : AdaptiveDialogBase
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
        /// This is called by <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetState" /> after <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetSecurityState" /> is called.
        /// </remarks>
        protected override void SetDisplayState()
        {

        }
        #endregion


        #region Private Event Handlers

        private bool _userIdChecked;

        private void HandleAddressClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();

            OSUtilities.StartBrowser(_account.Url);

            SetPostLoadState();
        }
        private void HandleShowUserIdClicked(object? sender, EventArgs e)
        {
            ShowUserIdButton.Checked = !ShowUserIdButton.Checked;
            if (ShowUserIdButton.Checked)
                UserIdLabel.Text = _account.UserId;
            else
                UserIdLabel.Text = new string('*', _account.UserId.Length);

        }
        private void HandleShowPasswordClicked(object? sender, EventArgs e)
        {
            ShowPasswordButton.Checked = !ShowPasswordButton.Checked;
            if (ShowPasswordButton.Checked)
                PasswordLabel.Text = _account.Password;
            else
                PasswordLabel.Text = new string('*', _account.Password.Length);
            Invalidate();
        }

        private void HandleCopyPasswordClicked(object? sender, EventArgs e)
        {
            Clipboard.SetText(_account.Password);
        }
        private void HandleCopyUrlClicked(object? sender, EventArgs e)
        {
            Clipboard.SetText(_account.Url);
        }
        private void HandleCopyUserIdClicked(object? sender, EventArgs e)
        {
            Clipboard.SetText(_account.UserId);
        }
        private void HandleCloseClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            Application.DoEvents();
            DialogResult = DialogResult.OK;
            Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }
        #endregion

        private void CopyUrlButton_Click(object sender, EventArgs e)
        {

        }
    }
}
