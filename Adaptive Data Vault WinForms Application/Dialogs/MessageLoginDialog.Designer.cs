namespace Adaptive.Data.Vault.UI;

partial class MessageLoginDialog
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageLoginDialog));
        BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ContentPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        InstructionsText = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
        SecParamsLabel = new Adaptive.Intelligence.Shared.UI.VerticalLabel();
        PinImage = new PictureBox();
        PinText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
        PinLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        PwdImage = new PictureBox();
        UserIdImage = new PictureBox();
        NameText = new TextBox();
        PasswordText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
        PasswordLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        NameLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        ButtonBar = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
        DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
        ErrorProvider = new ErrorProvider(components);
        BorderPanel.SuspendLayout();
        ContentPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PinImage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PwdImage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)UserIdImage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(ContentPanel);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(5);
        BorderPanel.Size = new Size(497, 355);
        BorderPanel.TabIndex = 0;
        BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        // 
        // ContentPanel
        // 
        ContentPanel.Controls.Add(InstructionsText);
        ContentPanel.Controls.Add(SecParamsLabel);
        ContentPanel.Controls.Add(PinImage);
        ContentPanel.Controls.Add(PinText);
        ContentPanel.Controls.Add(PinLabel);
        ContentPanel.Controls.Add(PwdImage);
        ContentPanel.Controls.Add(UserIdImage);
        ContentPanel.Controls.Add(NameText);
        ContentPanel.Controls.Add(PasswordText);
        ContentPanel.Controls.Add(PasswordLabel);
        ContentPanel.Controls.Add(NameLabel);
        ContentPanel.Controls.Add(ButtonBar);
        ContentPanel.Controls.Add(DialogHeader);
        ContentPanel.Dock = DockStyle.Fill;
        ContentPanel.Location = new Point(5, 5);
        ContentPanel.Name = "ContentPanel";
        ContentPanel.Size = new Size(487, 345);
        ContentPanel.TabIndex = 0;
        ContentPanel.TemplateFile = null;
        // 
        // InstructionsText
        // 
        InstructionsText.Location = new Point(53, 64);
        InstructionsText.Margin = new Padding(48, 23, 48, 23);
        InstructionsText.Name = "InstructionsText";
        InstructionsText.Size = new Size(422, 36);
        InstructionsText.TabIndex = 0;
        InstructionsText.TabStop = false;
        InstructionsText.Text = "The values below must be communicated to the recipient and re-entered in order to decode the message,";
        // 
        // SecParamsLabel
        // 
        SecParamsLabel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        SecParamsLabel.ForeColor = Color.RoyalBlue;
        SecParamsLabel.Location = new Point(6, 107);
        SecParamsLabel.Name = "SecParamsLabel";
        SecParamsLabel.Size = new Size(31, 200);
        SecParamsLabel.TabIndex = 2;
        SecParamsLabel.Text = "Security Parameters";
        SecParamsLabel.TextAlign = ContentAlignment.MiddleLeft;
        SecParamsLabel.UseCompatibleTextRendering = true;
        // 
        // PinImage
        // 
        PinImage.Image = (Image)resources.GetObject("PinImage.Image");
        PinImage.Location = new Point(53, 253);
        PinImage.Name = "PinImage";
        PinImage.Size = new Size(32, 32);
        PinImage.SizeMode = PictureBoxSizeMode.StretchImage;
        PinImage.TabIndex = 20;
        PinImage.TabStop = false;
        // 
        // PinText
        // 
        PinText.Font = new Font("Segoe UI", 9.75F);
        PinText.Location = new Point(90, 270);
        PinText.Margin = new Padding(4);
        PinText.Name = "PinText";
        PinText.NumericOnly = true;
        PinText.PlaceholderText = "(Numeric PIN Value)";
        PinText.Size = new Size(385, 25);
        PinText.TabIndex = 8;
        // 
        // PinLabel
        // 
        PinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PinLabel.Location = new Point(87, 245);
        PinLabel.Name = "PinLabel";
        PinLabel.Size = new Size(385, 20);
        PinLabel.TabIndex = 7;
        PinLabel.TabStop = false;
        PinLabel.Text = "Enter the Message P&IN:";
        PinLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PwdImage
        // 
        PwdImage.Image = Properties.Resources.Password_Lock;
        PwdImage.Location = new Point(53, 179);
        PwdImage.Name = "PwdImage";
        PwdImage.Size = new Size(32, 32);
        PwdImage.TabIndex = 19;
        PwdImage.TabStop = false;
        // 
        // UserIdImage
        // 
        UserIdImage.Image = Properties.Resources.User_Info_32x32;
        UserIdImage.Location = new Point(53, 108);
        UserIdImage.Name = "UserIdImage";
        UserIdImage.Size = new Size(32, 32);
        UserIdImage.TabIndex = 17;
        UserIdImage.TabStop = false;
        // 
        // NameText
        // 
        NameText.Location = new Point(90, 126);
        NameText.Name = "NameText";
        NameText.Size = new Size(385, 25);
        NameText.TabIndex = 4;
        // 
        // PasswordText
        // 
        PasswordText.Font = new Font("Segoe UI", 9.75F);
        PasswordText.Location = new Point(90, 196);
        PasswordText.Margin = new Padding(4);
        PasswordText.Name = "PasswordText";
        PasswordText.PlaceholderText = "(Password)";
        PasswordText.Size = new Size(385, 25);
        PasswordText.TabIndex = 6;
        // 
        // PasswordLabel
        // 
        PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PasswordLabel.Location = new Point(87, 171);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(385, 20);
        PasswordLabel.TabIndex = 5;
        PasswordLabel.TabStop = false;
        PasswordLabel.Text = "Enter the Message &Password:";
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameLabel
        // 
        NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        NameLabel.Location = new Point(87, 101);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(385, 20);
        NameLabel.TabIndex = 3;
        NameLabel.TabStop = false;
        NameLabel.Text = "Enter Your &Name (or User ID or other information): ";
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ButtonBar
        // 
        ButtonBar.CancelEnabled = true;
        ButtonBar.CancelText = "Cancel";
        ButtonBar.CancelVisible = true;
        ButtonBar.Dock = DockStyle.Bottom;
        ButtonBar.Font = new Font("Segoe UI", 9.75F);
        ButtonBar.Location = new Point(0, 305);
        ButtonBar.Margin = new Padding(48, 22, 48, 22);
        ButtonBar.Name = "ButtonBar";
        ButtonBar.SaveEnabled = true;
        ButtonBar.SaveText = "Save";
        ButtonBar.SaveVisible = true;
        ButtonBar.Size = new Size(487, 40);
        ButtonBar.TabIndex = 9;
        // 
        // DialogHeader
        // 
        DialogHeader.Dock = DockStyle.Top;
        DialogHeader.Location = new Point(0, 0);
        DialogHeader.Name = "DialogHeader";
        DialogHeader.Size = new Size(487, 60);
        DialogHeader.TabIndex = 0;
        DialogHeader.TitleText = "SECURE MESSAGE LOGIN";
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // MessageLoginDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(497, 355);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "MessageLoginDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContentPanel.ResumeLayout(false);
        ContentPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PinImage).EndInit();
        ((System.ComponentModel.ISupportInitialize)PwdImage).EndInit();
        ((System.ComponentModel.ISupportInitialize)UserIdImage).EndInit();
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Intelligence.Shared.UI.GradientPanel BorderPanel;
    private Intelligence.Shared.UI.GradientPanel ContentPanel;
    private Controls.VaultDialogHeader DialogHeader;
    private Intelligence.Shared.UI.VerticalLabel SecParamsLabel;
    private PictureBox PinImage;
    private Intelligence.Shared.UI.PasswordTextBox PinText;
    private Intelligence.Shared.UI.AdvancedLabel PinLabel;
    private PictureBox PwdImage;
    private PictureBox UserIdImage;
    private TextBox NameText;
    private Intelligence.Shared.UI.PasswordTextBox PasswordText;
    private Intelligence.Shared.UI.AdvancedLabel PasswordLabel;
    private Intelligence.Shared.UI.AdvancedLabel NameLabel;
    private Controls.SaveCancelBar ButtonBar;
    private Intelligence.Shared.UI.SectionTitleHeader InstructionsText;
    private ErrorProvider ErrorProvider;
}