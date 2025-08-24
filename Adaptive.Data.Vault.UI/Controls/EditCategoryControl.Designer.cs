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
            NamePanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            NameText = new TextBox();
            NameLabelPanel = new Panel();
            NewNameLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            NamePanel.SuspendLayout();
            NameLabelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NamePanel
            // 
            NamePanel.Controls.Add(NameText);
            NamePanel.Controls.Add(NameLabelPanel);
            NamePanel.Dock = DockStyle.Top;
            NamePanel.Location = new Point(0, 10);
            NamePanel.Name = "NamePanel";
            NamePanel.Padding = new Padding(0, 0, 5, 0);
            NamePanel.Size = new Size(600, 30);
            NamePanel.TabIndex = 1;
            NamePanel.TemplateFile = null;
            // 
            // NameText
            // 
            NameText.AcceptsReturn = true;
            NameText.Dock = DockStyle.Fill;
            NameText.Location = new Point(100, 0);
            NameText.Name = "NameText";
            NameText.PlaceholderText = "(Name)";
            NameText.Size = new Size(495, 25);
            NameText.TabIndex = 0;
            // 
            // NameLabelPanel
            // 
            NameLabelPanel.Controls.Add(NewNameLabel);
            NameLabelPanel.Dock = DockStyle.Left;
            NameLabelPanel.Location = new Point(0, 0);
            NameLabelPanel.Name = "NameLabelPanel";
            NameLabelPanel.Size = new Size(100, 30);
            NameLabelPanel.TabIndex = 2;
            // 
            // NewNameLabel
            // 
            NewNameLabel.Dock = DockStyle.Top;
            NewNameLabel.Font = new Font("Segoe UI", 9.75F);
            NewNameLabel.ForeColor = Color.DimGray;
            NewNameLabel.Location = new Point(0, 0);
            NewNameLabel.Name = "NewNameLabel";
            NewNameLabel.Size = new Size(100, 26);
            NewNameLabel.TabIndex = 2;
            NewNameLabel.TabStop = false;
            NewNameLabel.Text = "&name:";
            NewNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EditCategoryControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(NamePanel);
            Margin = new Padding(3);
            Name = "EditCategoryControl";
            Padding = new Padding(0, 10, 0, 0);
            Size = new Size(600, 45);
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            NameLabelPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Intelligence.Shared.UI.GradientPanel NamePanel;
        private TextBox NameText;
        private Panel NameLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel NewNameLabel;
    }
}
