namespace Adaptive.Data.Vault.UI
{
    partial class EncryptFileDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ContentPanel = new Panel();
            SaveCancel = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
            PinText = new Adaptive.Intelligence.Shared.UI.IntegerTextBox();
            SecondaryText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
            PrimaryText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
            PinTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            SecondaryTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            PrimaryTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            FileSecurityTitle = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
            DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            OpenFile = new FileBrowseSelectControl();
            SaveFile = new FileBrowseSelectControl();
            ttp = new ToolTip(components);
            ContainerPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(ContentPanel);
            ContainerPanel.Padding = new Padding(5, 6, 5, 6);
            ContainerPanel.Size = new Size(640, 327);
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(SaveFile);
            ContentPanel.Controls.Add(OpenFile);
            ContentPanel.Controls.Add(SaveCancel);
            ContentPanel.Controls.Add(PinText);
            ContentPanel.Controls.Add(SecondaryText);
            ContentPanel.Controls.Add(PrimaryText);
            ContentPanel.Controls.Add(PinTitleLabel);
            ContentPanel.Controls.Add(SecondaryTitleLabel);
            ContentPanel.Controls.Add(PrimaryTitleLabel);
            ContentPanel.Controls.Add(FileSecurityTitle);
            ContentPanel.Controls.Add(DialogHeader);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(5, 6);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(630, 315);
            ContentPanel.TabIndex = 0;
            // 
            // SaveCancel
            // 
            SaveCancel.CancelEnabled = true;
            SaveCancel.CancelText = "Cancel";
            SaveCancel.CancelVisible = true;
            SaveCancel.Dock = DockStyle.Bottom;
            SaveCancel.Font = new Font("Segoe UI", 9.75F);
            SaveCancel.Location = new Point(0, 267);
            SaveCancel.Margin = new Padding(48, 22, 48, 22);
            SaveCancel.Name = "SaveCancel";
            SaveCancel.SaveEnabled = true;
            SaveCancel.SaveText = "Encrypt";
            SaveCancel.SaveVisible = true;
            SaveCancel.Size = new Size(630, 48);
            SaveCancel.TabIndex = 10;
            // 
            // PinText
            // 
            PinText.Location = new Point(160, 240);
            PinText.Name = "PinText";
            PinText.Size = new Size(100, 25);
            PinText.TabIndex = 9;
            PinText.Text = "0";
            ttp.SetToolTip(PinText, "Enter the PIN value used to encrypt the file.");
            // 
            // SecondaryText
            // 
            SecondaryText.Font = new Font("Segoe UI", 9.75F);
            SecondaryText.Location = new Point(160, 210);
            SecondaryText.Margin = new Padding(48, 22, 48, 22);
            SecondaryText.Name = "SecondaryText";
            SecondaryText.PlaceholderText = "(Password)";
            SecondaryText.Size = new Size(284, 25);
            SecondaryText.TabIndex = 7;
            ttp.SetToolTip(SecondaryText, "Enter the secondary password/passphrase value used to encrypt the file.");
            // 
            // PrimaryText
            // 
            PrimaryText.Font = new Font("Segoe UI", 9.75F);
            PrimaryText.Location = new Point(160, 180);
            PrimaryText.Margin = new Padding(48, 22, 48, 22);
            PrimaryText.Name = "PrimaryText";
            PrimaryText.PlaceholderText = "(Password)";
            PrimaryText.Size = new Size(284, 25);
            PrimaryText.TabIndex = 5;
            ttp.SetToolTip(PrimaryText, "Enter the primary password/passphrase value used to encrypt the file.");
            // 
            // PinTitleLabel
            // 
            PinTitleLabel.Font = new Font("Segoe UI", 9.75F);
            PinTitleLabel.Location = new Point(10, 240);
            PinTitleLabel.Name = "PinTitleLabel";
            PinTitleLabel.Size = new Size(145, 25);
            PinTitleLabel.TabIndex = 8;
            PinTitleLabel.TabStop = false;
            PinTitleLabel.Text = "File PIN &Number:";
            PinTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SecondaryTitleLabel
            // 
            SecondaryTitleLabel.Font = new Font("Segoe UI", 9.75F);
            SecondaryTitleLabel.Location = new Point(10, 210);
            SecondaryTitleLabel.Name = "SecondaryTitleLabel";
            SecondaryTitleLabel.Size = new Size(145, 25);
            SecondaryTitleLabel.TabIndex = 6;
            SecondaryTitleLabel.TabStop = false;
            SecondaryTitleLabel.Text = "Se&condary Pass Phrase:";
            SecondaryTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PrimaryTitleLabel
            // 
            PrimaryTitleLabel.Font = new Font("Segoe UI", 9.75F);
            PrimaryTitleLabel.Location = new Point(10, 180);
            PrimaryTitleLabel.Name = "PrimaryTitleLabel";
            PrimaryTitleLabel.Size = new Size(145, 25);
            PrimaryTitleLabel.TabIndex = 4;
            PrimaryTitleLabel.TabStop = false;
            PrimaryTitleLabel.Text = "&Primary Pass Phrase:";
            PrimaryTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FileSecurityTitle
            // 
            FileSecurityTitle.Location = new Point(10, 139);
            FileSecurityTitle.Margin = new Padding(48, 23, 48, 23);
            FileSecurityTitle.Name = "FileSecurityTitle";
            FileSecurityTitle.Size = new Size(610, 29);
            FileSecurityTitle.TabIndex = 3;
            FileSecurityTitle.TabStop = false;
            FileSecurityTitle.Text = "File Security";
            // 
            // DialogHeader
            // 
            DialogHeader.Dock = DockStyle.Top;
            DialogHeader.Location = new Point(0, 0);
            DialogHeader.Name = "DialogHeader";
            DialogHeader.Size = new Size(630, 66);
            DialogHeader.TabIndex = 0;
            DialogHeader.TabStop = false;
            DialogHeader.TitleText = "ENCRYPT FILE";
            // 
            // OpenFile
            // 
            OpenFile.FileName = "";
            OpenFile.FilePrompt = "Select File to Encrypt:";
            OpenFile.FilePromptWidth = 150;
            OpenFile.Font = new Font("Segoe UI", 9.75F);
            OpenFile.Location = new Point(10, 80);
            OpenFile.Margin = new Padding(48, 22, 48, 22);
            OpenFile.Name = "OpenFile";
            OpenFile.OpenFileMode = true;
            OpenFile.Size = new Size(610, 25);
            OpenFile.TabIndex = 1;
            ttp.SetToolTip(OpenFile, "Select a file to be encrypted.");
            // 
            // SaveFile
            // 
            SaveFile.FileName = "";
            SaveFile.FilePrompt = "Save Encrypted File As:";
            SaveFile.FilePromptWidth = 150;
            SaveFile.Font = new Font("Segoe UI", 9.75F);
            SaveFile.Location = new Point(10, 110);
            SaveFile.Margin = new Padding(48, 22, 48, 22);
            SaveFile.Name = "SaveFile";
            SaveFile.OpenFileMode = false;
            SaveFile.Size = new Size(610, 25);
            SaveFile.TabIndex = 2;
            ttp.SetToolTip(SaveFile, "Specify the new file to write the encrypted data to.");
            // 
            // EncryptFileDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 327);
            Margin = new Padding(48, 25, 48, 25);
            Name = "EncryptFileDialog";
            Text = "EncryptFileDialog";
            ContainerPanel.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Controls.SaveCancelBar SaveCancel;
        private Intelligence.Shared.UI.IntegerTextBox PinText;
        private Intelligence.Shared.UI.PasswordTextBox SecondaryText;
        private Intelligence.Shared.UI.PasswordTextBox PrimaryText;
        private Intelligence.Shared.UI.AdvancedLabel PinTitleLabel;
        private Intelligence.Shared.UI.AdvancedLabel SecondaryTitleLabel;
        private Intelligence.Shared.UI.AdvancedLabel PrimaryTitleLabel;
        private Intelligence.Shared.UI.SectionTitleHeader FileSecurityTitle;
        private Controls.VaultDialogHeader DialogHeader;
        private FileBrowseSelectControl SaveFile;
        private FileBrowseSelectControl OpenFile;
        private ToolTip ttp;
    }
}