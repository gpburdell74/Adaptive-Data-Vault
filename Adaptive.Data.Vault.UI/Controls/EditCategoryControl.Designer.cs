using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI
{
    partial class EditCategoryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameText = new TextBox();
            NameLabelPanel = new Panel();
            NameLabel = new AdvancedLabel();
            NameLabelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NameText
            // 
            NameText.AcceptsReturn = true;
            NameText.Dock = DockStyle.Fill;
            NameText.Location = new Point(0, 5);
            NameText.Name = "NameText";
            NameText.PlaceholderText = "(Name)";
            NameText.Size = new Size(495, 25);
            NameText.TabIndex = 2;
            // 
            // NameLabelPanel
            // 
            NameLabelPanel.Controls.Add(NameLabel);
            NameLabelPanel.Dock = DockStyle.Left;
            NameLabelPanel.ForeColor = Color.White;
            NameLabelPanel.Location = new Point(0, 5);
            NameLabelPanel.Name = "NameLabelPanel";
            NameLabelPanel.Size = new Size(100, 25);
            NameLabelPanel.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI", 9.75F);
            NameLabel.Location = new Point(0, 0);
            NameLabel.Margin = new Padding(3, 5, 3, 3);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(100, 25);
            NameLabel.TabIndex = 0;
            NameLabel.TabStop = false;
            NameLabel.Text = "name:";
            NameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EditCategoryControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Transparent;
            Controls.Add(NameLabelPanel);
            Controls.Add(NameText);
            Margin = new Padding(3);
            MaximumSize = new Size(9999, 35);
            MinimumSize = new Size(100, 35);
            Name = "EditCategoryControl";
            Padding = new Padding(0, 5, 5, 5);
            Size = new Size(500, 35);
            NameLabelPanel.ResumeLayout(false);
            NameLabelPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameText;
        private Panel NameLabelPanel;
        private AdvancedLabel NameLabel;
    }
}
