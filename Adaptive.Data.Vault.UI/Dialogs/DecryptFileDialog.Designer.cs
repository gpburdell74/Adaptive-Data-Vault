namespace Adaptive.Data.Vault.UI
{
    partial class DecryptFileDialog
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
            StatusPanel = new Panel();
            Progress = new ProgressBar();
            ProgressTitle = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
            SecurityPanel = new Panel();
            PinText = new Adaptive.Intelligence.Shared.UI.IntegerTextBox();
            SecondaryText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
            PrimaryText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
            PinTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            SecondaryTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            PrimaryTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            FileSecurityTitle = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
            FileSelectionPanel = new Panel();
            SaveFile = new FileBrowseSelectControl();
            OpenFile = new FileBrowseSelectControl();
            SaveCancel = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
            DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            ttp = new ToolTip(components);
            ErrorProvider = new ErrorProvider(components);
            ContainerPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            SecurityPanel.SuspendLayout();
            FileSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(ContentPanel);
            ContainerPanel.Padding = new Padding(5, 6, 5, 6);
            ContainerPanel.Size = new Size(630, 345);
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(StatusPanel);
            ContentPanel.Controls.Add(SecurityPanel);
            ContentPanel.Controls.Add(FileSelectionPanel);
            ContentPanel.Controls.Add(SaveCancel);
            ContentPanel.Controls.Add(DialogHeader);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(5, 6);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(620, 333);
            ContentPanel.TabIndex = 0;
            // 
            // StatusPanel
            // 
            StatusPanel.Controls.Add(Progress);
            StatusPanel.Controls.Add(ProgressTitle);
            StatusPanel.Dock = DockStyle.Top;
            StatusPanel.Location = new Point(0, 256);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(620, 73);
            StatusPanel.TabIndex = 2;
            StatusPanel.Visible = false;
            // 
            // Progress
            // 
            Progress.Location = new Point(10, 40);
            Progress.Name = "Progress";
            Progress.Size = new Size(600, 23);
            Progress.TabIndex = 1;
            // 
            // ProgressTitle
            // 
            ProgressTitle.Dock = DockStyle.Top;
            ProgressTitle.Location = new Point(0, 0);
            ProgressTitle.Margin = new Padding(48, 23, 48, 23);
            ProgressTitle.Name = "ProgressTitle";
            ProgressTitle.Size = new Size(620, 30);
            ProgressTitle.TabIndex = 0;
            ProgressTitle.Text = "Progress";
            // 
            // SecurityPanel
            // 
            SecurityPanel.Controls.Add(PinText);
            SecurityPanel.Controls.Add(SecondaryText);
            SecurityPanel.Controls.Add(PrimaryText);
            SecurityPanel.Controls.Add(PinTitleLabel);
            SecurityPanel.Controls.Add(SecondaryTitleLabel);
            SecurityPanel.Controls.Add(PrimaryTitleLabel);
            SecurityPanel.Controls.Add(FileSecurityTitle);
            SecurityPanel.Dock = DockStyle.Top;
            SecurityPanel.Location = new Point(0, 131);
            SecurityPanel.Name = "SecurityPanel";
            SecurityPanel.Size = new Size(620, 125);
            SecurityPanel.TabIndex = 1;
            // 
            // PinText
            // 
            PinText.Location = new Point(155, 95);
            PinText.Name = "PinText";
            PinText.Size = new Size(100, 25);
            PinText.TabIndex = 6;
            PinText.Text = "0";
            ttp.SetToolTip(PinText, "Enter the PIN value used to encrypt the file.");
            // 
            // SecondaryText
            // 
            SecondaryText.Font = new Font("Segoe UI", 9.75F);
            SecondaryText.Location = new Point(155, 65);
            SecondaryText.Margin = new Padding(48, 22, 48, 22);
            SecondaryText.Name = "SecondaryText";
            SecondaryText.PlaceholderText = "(Password)";
            SecondaryText.Size = new Size(284, 25);
            SecondaryText.TabIndex = 4;
            ttp.SetToolTip(SecondaryText, "Enter the secondary password/passphrase value used to encrypt the file.");
            // 
            // PrimaryText
            // 
            PrimaryText.Font = new Font("Segoe UI", 9.75F);
            PrimaryText.Location = new Point(155, 35);
            PrimaryText.Margin = new Padding(48, 22, 48, 22);
            PrimaryText.Name = "PrimaryText";
            PrimaryText.PlaceholderText = "(Password)";
            PrimaryText.Size = new Size(284, 25);
            PrimaryText.TabIndex = 2;
            ttp.SetToolTip(PrimaryText, "Enter the primary password/passphrase value used to encrypt the file.");
            // 
            // PinTitleLabel
            // 
            PinTitleLabel.Font = new Font("Segoe UI", 9.75F);
            PinTitleLabel.Location = new Point(5, 95);
            PinTitleLabel.Name = "PinTitleLabel";
            PinTitleLabel.Size = new Size(145, 25);
            PinTitleLabel.TabIndex = 5;
            PinTitleLabel.TabStop = false;
            PinTitleLabel.Text = "File PIN &Number:";
            PinTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SecondaryTitleLabel
            // 
            SecondaryTitleLabel.Font = new Font("Segoe UI", 9.75F);
            SecondaryTitleLabel.Location = new Point(5, 65);
            SecondaryTitleLabel.Name = "SecondaryTitleLabel";
            SecondaryTitleLabel.Size = new Size(145, 25);
            SecondaryTitleLabel.TabIndex = 3;
            SecondaryTitleLabel.TabStop = false;
            SecondaryTitleLabel.Text = "Se&condary Pass Phrase:";
            SecondaryTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PrimaryTitleLabel
            // 
            PrimaryTitleLabel.Font = new Font("Segoe UI", 9.75F);
            PrimaryTitleLabel.Location = new Point(5, 35);
            PrimaryTitleLabel.Name = "PrimaryTitleLabel";
            PrimaryTitleLabel.Size = new Size(145, 25);
            PrimaryTitleLabel.TabIndex = 1;
            PrimaryTitleLabel.TabStop = false;
            PrimaryTitleLabel.Text = "&Primary Pass Phrase:";
            PrimaryTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FileSecurityTitle
            // 
            FileSecurityTitle.Dock = DockStyle.Top;
            FileSecurityTitle.Location = new Point(0, 0);
            FileSecurityTitle.Margin = new Padding(48, 23, 48, 23);
            FileSecurityTitle.Name = "FileSecurityTitle";
            FileSecurityTitle.Size = new Size(620, 30);
            FileSecurityTitle.TabIndex = 0;
            FileSecurityTitle.TabStop = false;
            FileSecurityTitle.Text = "File Security";
            // 
            // FileSelectionPanel
            // 
            FileSelectionPanel.Controls.Add(SaveFile);
            FileSelectionPanel.Controls.Add(OpenFile);
            FileSelectionPanel.Dock = DockStyle.Top;
            FileSelectionPanel.Location = new Point(0, 66);
            FileSelectionPanel.Name = "FileSelectionPanel";
            FileSelectionPanel.Size = new Size(620, 65);
            FileSelectionPanel.TabIndex = 0;
            // 
            // SaveFile
            // 
            SaveFile.FileName = "";
            SaveFile.FilePrompt = "Save Decrypted File As:";
            SaveFile.FilePromptWidth = 150;
            SaveFile.Font = new Font("Segoe UI", 9.75F);
            SaveFile.Location = new Point(5, 35);
            SaveFile.Margin = new Padding(48, 22, 48, 22);
            SaveFile.Name = "SaveFile";
            SaveFile.OpenFileMode = false;
            SaveFile.Size = new Size(610, 25);
            SaveFile.TabIndex = 1;
            ttp.SetToolTip(SaveFile, "Specify the new file to write the decrypted data to.");
            // 
            // OpenFile
            // 
            OpenFile.FileName = "";
            OpenFile.FilePrompt = "Select File to Decrypt:";
            OpenFile.FilePromptWidth = 150;
            OpenFile.Font = new Font("Segoe UI", 9.75F);
            OpenFile.Location = new Point(5, 5);
            OpenFile.Margin = new Padding(48, 22, 48, 22);
            OpenFile.Name = "OpenFile";
            OpenFile.OpenFileMode = true;
            OpenFile.Size = new Size(610, 25);
            OpenFile.TabIndex = 0;
            ttp.SetToolTip(OpenFile, "Select a file to be decrypted.");
            // 
            // SaveCancel
            // 
            SaveCancel.CancelEnabled = true;
            SaveCancel.CancelText = "Cancel";
            SaveCancel.CancelVisible = true;
            SaveCancel.Dock = DockStyle.Bottom;
            SaveCancel.Font = new Font("Segoe UI", 9.75F);
            SaveCancel.Location = new Point(0, 285);
            SaveCancel.Margin = new Padding(48, 22, 48, 22);
            SaveCancel.Name = "SaveCancel";
            SaveCancel.SaveEnabled = false;
            SaveCancel.SaveText = "Decrypt";
            SaveCancel.SaveVisible = true;
            SaveCancel.Size = new Size(620, 48);
            SaveCancel.TabIndex = 3;
            // 
            // DialogHeader
            // 
            DialogHeader.Dock = DockStyle.Top;
            DialogHeader.Location = new Point(0, 0);
            DialogHeader.Name = "DialogHeader";
            DialogHeader.Size = new Size(620, 66);
            DialogHeader.TabIndex = 0;
            DialogHeader.TabStop = false;
            DialogHeader.TitleText = "DECRYPT FILE";
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // DecryptFileDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 345);
            Margin = new Padding(48, 25, 48, 25);
            Name = "DecryptFileDialog";
            Text = "DecryptFileDialog";
            ContainerPanel.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            StatusPanel.ResumeLayout(false);
            SecurityPanel.ResumeLayout(false);
            SecurityPanel.PerformLayout();
            FileSelectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Controls.SaveCancelBar SaveCancel;
        private Controls.VaultDialogHeader DialogHeader;
        private ToolTip ttp;
        private Panel StatusPanel;
        private Panel SecurityPanel;
        private Panel FileSelectionPanel;
        private FileBrowseSelectControl SaveFile;
        private FileBrowseSelectControl OpenFile;
        private ProgressBar Progress;
        private Intelligence.Shared.UI.SectionTitleHeader ProgressTitle;
        private Intelligence.Shared.UI.IntegerTextBox PinText;
        private Intelligence.Shared.UI.PasswordTextBox SecondaryText;
        private Intelligence.Shared.UI.PasswordTextBox PrimaryText;
        private Intelligence.Shared.UI.AdvancedLabel PinTitleLabel;
        private Intelligence.Shared.UI.AdvancedLabel SecondaryTitleLabel;
        private Intelligence.Shared.UI.AdvancedLabel PrimaryTitleLabel;
        private Intelligence.Shared.UI.SectionTitleHeader FileSecurityTitle;
        private ErrorProvider ErrorProvider;
    }
}