namespace Adaptive.Data.Vault.UI;

partial class SecureEraseFileDialog
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
        BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        CloseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        DeleteButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        StatusPrg = new ProgressBar();
        StatusLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        BrowseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        FileText = new TextBox();
        FileLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        Header = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
        BorderPanel.SuspendLayout();
        ContainerPanel.SuspendLayout();
        SuspendLayout();
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(ContainerPanel);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(5);
        BorderPanel.Size = new Size(750, 263);
        BorderPanel.TabIndex = 0;
        BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(CloseButton);
        ContainerPanel.Controls.Add(DeleteButton);
        ContainerPanel.Controls.Add(StatusPrg);
        ContainerPanel.Controls.Add(StatusLabel);
        ContainerPanel.Controls.Add(BrowseButton);
        ContainerPanel.Controls.Add(FileText);
        ContainerPanel.Controls.Add(FileLabel);
        ContainerPanel.Controls.Add(Header);
        ContainerPanel.Dock = DockStyle.Fill;
        ContainerPanel.Location = new Point(5, 5);
        ContainerPanel.Name = "ContainerPanel";
        ContainerPanel.Size = new Size(740, 253);
        ContainerPanel.TabIndex = 0;
        ContainerPanel.TemplateFile = null;
        // 
        // CloseButton
        // 
        CloseButton.Checked = false;
        CloseButton.Location = new Point(632, 205);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(100, 40);
        CloseButton.TabIndex = 8;
        CloseButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Cancel  Template.template";
        CloseButton.Text = "Cancel";
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // DeleteButton
        // 
        DeleteButton.Checked = false;
        DeleteButton.Enabled = false;
        DeleteButton.ImageAlign = ContentAlignment.MiddleLeft;
        DeleteButton.Location = new Point(471, 205);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new Size(155, 40);
        DeleteButton.TabIndex = 7;
        DeleteButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Delete Template.template";
        DeleteButton.Text = "Secure Delete";
        DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        DeleteButton.UseVisualStyleBackColor = true;
        // 
        // StatusPrg
        // 
        StatusPrg.Location = new Point(115, 142);
        StatusPrg.Name = "StatusPrg";
        StatusPrg.Size = new Size(617, 23);
        StatusPrg.TabIndex = 6;
        StatusPrg.Visible = false;
        // 
        // StatusLabel
        // 
        StatusLabel.AutoSize = true;
        StatusLabel.Font = new Font("Segoe UI", 9.75F);
        StatusLabel.Location = new Point(115, 119);
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new Size(53, 17);
        StatusLabel.TabIndex = 5;
        StatusLabel.TabStop = false;
        StatusLabel.Text = "Ready...";
        StatusLabel.TextAlign = ContentAlignment.TopCenter;
        StatusLabel.Visible = false;
        // 
        // BrowseButton
        // 
        BrowseButton.Checked = false;
        BrowseButton.Location = new Point(692, 76);
        BrowseButton.Name = "BrowseButton";
        BrowseButton.Size = new Size(40, 25);
        BrowseButton.TabIndex = 3;
        BrowseButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        BrowseButton.Text = "...";
        BrowseButton.UseVisualStyleBackColor = true;
        // 
        // FileText
        // 
        FileText.Location = new Point(115, 76);
        FileText.Name = "FileText";
        FileText.Size = new Size(575, 25);
        FileText.TabIndex = 2;
        // 
        // FileLabel
        // 
        FileLabel.Font = new Font("Segoe UI", 9.75F);
        FileLabel.Location = new Point(9, 76);
        FileLabel.Name = "FileLabel";
        FileLabel.Size = new Size(100, 25);
        FileLabel.TabIndex = 1;
        FileLabel.TabStop = false;
        FileLabel.Text = "Specify &File:";
        FileLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Name = "Header";
        Header.Size = new Size(740, 60);
        Header.TabIndex = 0;
        Header.TitleText = "SECURE DELETE";
        // 
        // SecureEraseFileDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(750, 263);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "SecureEraseFileDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContainerPanel.ResumeLayout(false);
        ContainerPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Intelligence.Shared.UI.GradientPanel BorderPanel;
    private Intelligence.Shared.UI.GradientPanel ContainerPanel;
    private Controls.VaultDialogHeader Header;
    private ProgressBar StatusPrg;
    private Intelligence.Shared.UI.AdvancedLabel StatusLabel;
    private Intelligence.Shared.UI.TemplatedButton BrowseButton;
    private TextBox FileText;
    private Intelligence.Shared.UI.AdvancedLabel FileLabel;
    private Intelligence.Shared.UI.TemplatedButton CloseButton;
    private Intelligence.Shared.UI.TemplatedButton DeleteButton;
}