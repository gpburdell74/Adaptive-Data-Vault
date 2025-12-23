using Adaptive.Data.Vault.UI.Properties;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Displays the end-user license agreement (EULA) to the user.
    /// </summary>
    /// <seealso cref=".AdaptiveDialogBase" />
    public partial class EulaDialog : AdaptiveDialogBase
    {
        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="EulaDialog"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public EulaDialog()
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
        /// Gets a value indicating whether the user has agreed to the EULA terms.
        /// </summary>
        /// <value>
        ///   <c>true</c> if checked; otherwise, <c>false</c>.
        /// </value>
        [Browsable(false),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Checked => AgreeCheck.Checked;
        #endregion

        #region Protected Method Overrides        
        /// <summary>
        /// Assigns the event handlers for the controls on the dialog.
        /// </summary>
        protected override void AssignEventHandlers()
        {
            CloseButton.Click += HandleCloseClicked;
        }

        /// <summary>
        /// Removes the event handlers for the controls on the dialog.
        /// </summary>
        protected override void RemoveEventHandlers()
        {
            CloseButton.Click -= HandleCloseClicked;
        }

        /// <summary>
        /// Initializes the control and dialog state according to the form data.
        /// </summary>
        protected override void InitializeDataContent()
        {
            EulaText.Rtf = System.Text.Encoding.UTF8.GetString(Resources.EULA);
        }
        #endregion

        #region Private Event Handlers
        /// <summary>
        /// Handles the event when the Close button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleCloseClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion
    }
}
