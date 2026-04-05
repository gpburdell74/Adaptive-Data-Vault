using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI.Dialogs
{
    /// <summary>
    /// Provides a dialog for converting numbers to hexadecimal format.
    /// </summary>
    /// <seealso cref="AdaptiveDialogBase" />
    /// <seealso cref="BorderedDialog"/>
    public partial class NumberToHexDialog : BorderedDialog
    {
        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberToHexDialog"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public NumberToHexDialog()
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

        #region Protected Method OVerrides        
        /// <summary>
        /// Assigns the event handlers for the controls on the dialog.
        /// </summary>
        protected override void AssignEventHandlers()
        {
            NumberText.TextChanged += HandleTextChanged;
            ClearButton.Click += HandleClearClicked;
            CopyButton.Click += HandleCopyClicked;
            SaveCancel.CancelClicked += HandleCloseClicked;
        }

        /// <summary>
        /// Removes the event handlers for the controls on the dialog.
        /// </summary>
        protected override void RemoveEventHandlers()
        {
            NumberText.TextChanged += HandleTextChanged;
            ClearButton.Click += HandleClearClicked;
            CopyButton.Click -= HandleCopyClicked;
            SaveCancel.CancelClicked -= HandleCloseClicked;
        }
        #endregion

        #region Private Event Handlers
        /// <summary>
        /// Handles the event when the Clear button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleClearClicked(object? sender, EventArgs e)
        {
            NumberText.Text = "0";
            NumberText.SelectionStart = 0;
            NumberText.SelectionLength = 1;
            NumberText.Focus();

        }
        /// <summary>
        /// Handles the event when the user changes the text in the NumberText control.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleTextChanged(object? sender, EventArgs e)
        {
            if (int.TryParse(NumberText.Text, out int value))
            {
                HexText.Text = $"0x{value:X}";
            }
        }

        /// <summary>
        /// Handles the event when the Copy button is clicked.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HandleCopyClicked(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HexText.Text))
            {
                Clipboard.SetText(HexText.Text);
            }
        }

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
