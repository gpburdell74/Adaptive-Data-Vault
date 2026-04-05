namespace Adaptive.Data.Vault.UI
{
    partial class FileBrowseSelectControl
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
            InstructLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            BrowseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
            FileText = new TextBox();
            SuspendLayout();
            // 
            // InstructLabel
            // 
            InstructLabel.Dock = DockStyle.Left;
            InstructLabel.Font = new Font("Segoe UI", 9.75F);
            InstructLabel.Location = new Point(0, 0);
            InstructLabel.Name = "InstructLabel";
            InstructLabel.Size = new Size(106, 24);
            InstructLabel.TabIndex = 0;
            InstructLabel.TabStop = false;
            InstructLabel.Text = "(Instruction Text):";
            InstructLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BrowseButton
            // 
            BrowseButton.Checked = false;
            BrowseButton.Dock = DockStyle.Right;
            BrowseButton.Location = new Point(869, 0);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(32, 24);
            BrowseButton.TabIndex = 2;
            BrowseButton.TemplateFromFile = null;
            BrowseButton.TemplateJson = null;
            BrowseButton.Text = "...";
            BrowseButton.UseVisualStyleBackColor = true;
            // 
            // FileText
            // 
            FileText.Dock = DockStyle.Fill;
            FileText.Location = new Point(106, 0);
            FileText.Name = "FileText";
            FileText.PlaceholderText = "(Path and File Name)";
            FileText.Size = new Size(763, 25);
            FileText.TabIndex = 1;
            // 
            // FileBrowseSelectControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FileText);
            Controls.Add(BrowseButton);
            Controls.Add(InstructLabel);
            Name = "FileBrowseSelectControl";
            Size = new Size(901, 24);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Intelligence.Shared.UI.AdvancedLabel InstructLabel;
        private Intelligence.Shared.UI.TemplatedButton BrowseButton;
        private TextBox FileText;
    }
}
