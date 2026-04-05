using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI.Dialogs
{
    /// <summary>
    /// Provides a dialog for converting text to Base64 encoding. This dialog allows users to input plain text and receive the corresponding Base64 encoded string, facilitating data encoding tasks within the application.
    /// </summary>
    public partial class TextToBase64Dialog : AdaptiveDialogBase
    {
        #region Constructor / Dispose Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="TextToBase64Dialog"/> class, setting up the user interface components and preparing the dialog for user interaction.
        /// </summary>
        /// <remarks>
        /// This is the default constructor for the <see cref="TextToBase64Dialog"/> class. It calls the <see cref="InitializeComponent"/> method to initialize the dialog's components, ensuring that all UI elements are properly set up before the dialog is displayed to the user.
        /// </remarks>
        public TextToBase64Dialog()
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
        /// Assigns event handlers required for the component's operation. Overrides the base implementation to provide
        /// additional event handler assignments as needed.
        /// </summary>
        protected override void AssignEventHandlers()
        {
            ConvertButton.Click += HandleConvertClicked;
            CopyButton.Click += HandleCopyClicked;
            CloseButton.Click += HandleCloseClicked; 
            ClearButton.Click += HandleClearClicked;
        }

        /// <summary>
        /// Removes event handlers associated with this instance.
        /// </summary>
        /// <remarks>Overrides the base implementation to detach any event handlers registered by this
        /// class. Call this method to prevent memory leaks or unwanted event invocations when the instance is no longer
        /// needed.</remarks>
        protected override void RemoveEventHandlers()
        {
            ConvertButton.Click -= HandleConvertClicked;
            CopyButton.Click -= HandleCopyClicked;
            CloseButton.Click -= HandleCloseClicked; 
            ClearButton.Click -= HandleClearClicked;
        }

        /// <summary>
        /// Prepares the form for a pre-load state by disabling user interaction and displaying a wait cursor.
        /// </summary>
        /// <remarks>Call this method before starting a long-running operation to prevent user input and
        /// indicate that processing is in progress. This method is typically used to improve user experience during
        /// initialization or data loading.</remarks>
        protected override void SetPreLoadState()
        {
            Cursor = Cursors.WaitCursor;
            ConvertButton.Enabled = false;
            CopyButton.Enabled = false;
            CloseButton.Enabled = false;
            OriginalText.Enabled = false;
            Application.DoEvents();
            SuspendLayout();
        }

        /// <summary>
        /// Sets the form's controls to their enabled state after loading is complete.
        /// </summary>
        /// <remarks>Call this method to re-enable user interaction with the form after a loading or
        /// processing operation. This method is typically invoked at the end of a load sequence to restore the default
        /// state of the UI controls.</remarks>
        protected override void SetPostLoadState()
        {
            Cursor = Cursors.Default;
            ConvertButton.Enabled = true;
            CopyButton.Enabled = true;
            CloseButton.Enabled = true;
            OriginalText.Enabled = true;
            ResumeLayout();
        }
        protected override void SetDisplayState()
        {
            CopyButton.Enabled = ResultText.Text.Length > 0;
        }
        #endregion

        #region Private Event Handlers

        /// <summary>
        /// Handles the event when the close action is triggered by the user interface.
        /// </summary>
        /// <param name="sender">The source of the event, typically the control that initiated the close action.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void HandleCloseClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            Close();
        }

        /// <summary>
        /// Handles the event when the Convert button is clicked.
        /// </summary>
        /// <param name="sender">The source of the event, typically the control that initiated the close action.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void HandleConvertClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            try
            {
                var originalText = OriginalText.Text;
                var base64Encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(originalText));
                ResultText.Text = base64Encoded;
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
                ShowError("Conversion Error", "Could not convert the text content into base-64 format.");
            }

            SetPostLoadState();
            SetState();
        }

        /// <summary>
        /// Handles the event when the Clear button is clicked.
        /// </summary>
        /// <param name="sender">The source of the event, typically the control that initiated the close action.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void HandleClearClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();

            OriginalText.Text = string.Empty;
            ResultText.Text = string.Empty;

            SetPostLoadState();
            SetState();
        }


        /// <summary>
        /// Handles the event when the Copy button is clicked.
        /// </summary>
        /// <param name="sender">The source of the event, typically the control that initiated the close action.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void HandleCopyClicked(object? sender, EventArgs e)
        {
            SetPreLoadState();
            if (ResultText.Text.Length > 0)
            {
                try
                {
                    Clipboard.SetText(ResultText.Text);
                    ttp.Show("Base-64 text copied to clipboard.", CopyButton, 0, -20, 2000);
                }
                catch
                {

                }
                OriginalText.SelectionStart = 0;
                OriginalText.Focus();
            }
            SetPostLoadState();
            SetState();
        }
        #endregion
    }
}
