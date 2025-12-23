using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI
{
    public partial class BorderedDialog : AdaptiveDialogBase
    {
        public BorderedDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
