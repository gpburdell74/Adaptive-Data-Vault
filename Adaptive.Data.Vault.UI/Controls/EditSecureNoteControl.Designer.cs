namespace Adaptive.Data.Vault.UI
{
    partial class EditSecureNoteControl
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
            ContentPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            ContentText = new TextBox();
            ContentLabelPanel = new Panel();
            ContentLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            NamePanel.SuspendLayout();
            NameLabelPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            ContentLabelPanel.SuspendLayout();
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
            // 
            // NameText
            // 
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
            // ContentPanel
            // 
            ContentPanel.Controls.Add(ContentText);
            ContentPanel.Controls.Add(ContentLabelPanel);
            ContentPanel.Dock = DockStyle.Top;
            ContentPanel.Location = new Point(0, 40);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Padding = new Padding(0, 0, 5, 0);
            ContentPanel.Size = new Size(600, 267);
            ContentPanel.TabIndex = 2;
            // 
            // ContentText
            // 
            ContentText.Dock = DockStyle.Fill;
            ContentText.Location = new Point(100, 0);
            ContentText.Multiline = true;
            ContentText.Name = "ContentText";
            ContentText.PlaceholderText = "(Content)";
            ContentText.Size = new Size(495, 267);
            ContentText.TabIndex = 0;
            // 
            // ContentLabelPanel
            // 
            ContentLabelPanel.Controls.Add(ContentLabel);
            ContentLabelPanel.Dock = DockStyle.Left;
            ContentLabelPanel.Location = new Point(0, 0);
            ContentLabelPanel.Name = "ContentLabelPanel";
            ContentLabelPanel.Size = new Size(100, 267);
            ContentLabelPanel.TabIndex = 2;
            // 
            // ContentLabel
            // 
            ContentLabel.Dock = DockStyle.Top;
            ContentLabel.Font = new Font("Segoe UI", 9.75F);
            ContentLabel.ForeColor = Color.DimGray;
            ContentLabel.Location = new Point(0, 0);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(100, 26);
            ContentLabel.TabIndex = 2;
            ContentLabel.TabStop = false;
            ContentLabel.Text = "&content:";
            ContentLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EditSecureNoteControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(ContentPanel);
            Controls.Add(NamePanel);
            Margin = new Padding(3);
            Name = "EditSecureNoteControl";
            Padding = new Padding(0, 10, 0, 0);
            Size = new Size(600, 312);
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            NameLabelPanel.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ContentLabelPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Intelligence.Shared.UI.GradientPanel NamePanel;
        private TextBox NameText;
        private Panel NameLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel NewNameLabel;
        private Intelligence.Shared.UI.GradientPanel ContentPanel;
        private TextBox ContentText;
        private Panel ContentLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel ContentLabel;
    }
}
