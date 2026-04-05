using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides a simple UI-inherited dialog with a border and padding, designed to serve as a base for other dialogs that require a consistent look and feel. This dialog can be used to create various types of dialogs within the application, ensuring a uniform user experience across different dialog implementations.
    /// </summary>
    public partial class BorderedDialog : AdaptiveDialogBase
    {
        /// <summary>
        /// Initializes a new instance of the BorderedDialog class.
        /// </summary>
        public BorderedDialog()
        {
            InitializeComponent();
        }
    }
}
