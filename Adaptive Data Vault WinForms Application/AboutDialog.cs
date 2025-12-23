using Adaptive.Data.Vault.OS;

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides a dialog for displaying information about the application.
    /// </summary>
    public partial class AboutDialog : BorderedDialog
    {
        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutDialog"/>
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public AboutDialog()
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
        /// Assigns event handlers for the dialog controls.
        /// </summary>
        protected override void AssignEventHandlers()
        {
            CloseButton.Click += HandleCloseClicked;
            EmailLabel.Click += HandleEmailClicked;
            SiteLabel.Click += HandleSiteClicked;
        }

        /// <summary>
        /// Removes event handlers for the dialog controls.
        /// </summary>
        protected override void RemoveEventHandlers()
        {
            CloseButton.Click -= HandleCloseClicked;
            EmailLabel.Click -= HandleEmailClicked;
            SiteLabel.Click -= HandleSiteClicked;
        }

        /// <summary>
        /// Initializes the data content for the dialog.
        /// </summary>
        protected override void InitializeDataContent()
        {
            AppVersionLabel.Text = "Version " + OSUtilities.GetVersionOfExecutable().ToString();
            FrameworkVersionLabel.Text = "Version " + OSUtilities.GetAdaptiveFrameworkVersion().ToString();
        }
        #endregion

        #region Private Event Handlers
        /// <summary>
        /// Handles the event when the Close button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleCloseClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            Close();
        }
        /// <summary>
        /// Handles the event when the Email label is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleEmailClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            OSUtilities.StartBrowserOnWindows( "mailto://gpburdell74@outlook.com?subject=About%20Adaptive%20Data%20Vault");
            Application.DoEvents();
            EmailLabel.ForeColor = System.Drawing.Color.Purple;
            Application.DoEvents();
            Thread.Sleep(250);
            SetPostLoadState();
        }
        /// <summary>
        /// Handles the event when the Website label is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleSiteClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            OSUtilities.StartBrowser("https://samjones.azurewebsites.net/");
            Application.DoEvents();
            SiteLabel.ForeColor = System.Drawing.Color.Purple;
            Application.DoEvents();
            Thread.Sleep(250);
            SetPostLoadState();
        }
        #endregion
    }
}
