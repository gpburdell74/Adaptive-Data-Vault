using Adaptive.Data.Vault.UI.Controls;
using Adaptive.Intelligence.Shared.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Adaptive.Data.Vault.UI;

partial class LoginDialog
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDialog));
        DialogHeader = new VaultDialogHeader();
        NameLabel = new AdvancedLabel();
        PasswordLabel = new AdvancedLabel();
        PasswordText = new PasswordTextBox();
        NameText = new TextBox();
        UserIdImage = new PictureBox();
        PwdImage = new PictureBox();
        ttp = new ToolTip(components);
        CloseButton = new TemplatedButton();
        OkButton = new TemplatedButton();
        PinText = new PasswordTextBox();
        PinLabel = new AdvancedLabel();
        ErrorProvider = new ErrorProvider(components);
        ButtonPanel = new Panel();
        DividerLine = new LineControl();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)UserIdImage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PwdImage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
        ButtonPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // DialogHeader
        // 
        DialogHeader.Dock = DockStyle.Top;
        DialogHeader.Location = new Point(0, 0);
        DialogHeader.Name = "DialogHeader";
        DialogHeader.Size = new Size(460, 77);
        DialogHeader.TabIndex = 0;
        DialogHeader.TabStop = false;
        DialogHeader.TitleText = "ADAPTIVE DATA VAULT";
        // 
        // NameLabel
        // 
        NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        NameLabel.Location = new Point(52, 90);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(385, 20);
        NameLabel.TabIndex = 1;
        NameLabel.TabStop = false;
        NameLabel.Text = "Enter Your &Name (or User ID): ";
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PasswordLabel
        // 
        PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PasswordLabel.Location = new Point(52, 160);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(385, 20);
        PasswordLabel.TabIndex = 3;
        PasswordLabel.TabStop = false;
        PasswordLabel.Text = "Enter the File &Password:";
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
        ttp.SetToolTip(PasswordLabel, "Enter the password for this file.");
        // 
        // PasswordText
        // 
        PasswordText.Font = new Font("Segoe UI", 9.75F);
        PasswordText.Location = new Point(55, 185);
        PasswordText.Margin = new Padding(4);
        PasswordText.Name = "PasswordText";
        PasswordText.PlaceholderText = "(Password)";
        PasswordText.Size = new Size(385, 25);
        PasswordText.TabIndex = 4;
        ttp.SetToolTip(PasswordText, "Enter the password for this file.");
        // 
        // NameText
        // 
        NameText.Location = new Point(55, 115);
        NameText.Name = "NameText";
        NameText.Size = new Size(385, 25);
        NameText.TabIndex = 2;
        ttp.SetToolTip(NameText, "Enter the name or user ID of the person associated with this file.");
        // 
        // UserIdImage
        // 
        UserIdImage.Image = Properties.Resources.User_ID_Keys;
        UserIdImage.Location = new Point(18, 97);
        UserIdImage.Name = "UserIdImage";
        UserIdImage.Size = new Size(32, 32);
        UserIdImage.TabIndex = 5;
        UserIdImage.TabStop = false;
        // 
        // PwdImage
        // 
        PwdImage.Image = Properties.Resources.Password_Lock;
        PwdImage.Location = new Point(18, 168);
        PwdImage.Name = "PwdImage";
        PwdImage.Size = new Size(32, 32);
        PwdImage.TabIndex = 6;
        PwdImage.TabStop = false;
        // 
        // CloseButton
        // 
        CloseButton.Checked = false;
        CloseButton.ImageAlign = ContentAlignment.MiddleLeft;
        CloseButton.Location = new Point(340, 10);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(100, 32);
        CloseButton.TabIndex = 1;
        CloseButton.ResourceTemplate = Properties.Resources.ButtonTemplateCancel;
        CloseButton.Text = "Cancel";
        CloseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        ttp.SetToolTip(CloseButton, "Click here to Cancel.");
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // OkButton
        // 
        OkButton.Checked = false;
        OkButton.Enabled = false;
        OkButton.ImageAlign = ContentAlignment.MiddleLeft;
        OkButton.Location = new Point(234, 10);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(100, 32);
        OkButton.TabIndex = 0;
        OkButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
        OkButton.Text = "OK";
        OkButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        ttp.SetToolTip(OkButton, "Click here to log in to the file and load the contents.");
        OkButton.UseVisualStyleBackColor = true;
        // 
        // PinText
        // 
        PinText.Font = new Font("Segoe UI", 9.75F);
        PinText.Location = new Point(55, 259);
        PinText.Margin = new Padding(4);
        PinText.Name = "PinText";
        PinText.NumericOnly = true;
        PinText.PlaceholderText = "(Password)";
        PinText.Size = new Size(385, 25);
        PinText.TabIndex = 6;
        ttp.SetToolTip(PinText, "Enter the PIN number for this file.");
        // 
        // PinLabel
        // 
        PinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PinLabel.Location = new Point(52, 234);
        PinLabel.Name = "PinLabel";
        PinLabel.Size = new Size(385, 20);
        PinLabel.TabIndex = 5;
        PinLabel.TabStop = false;
        PinLabel.Text = "Enter the File P&IN:";
        PinLabel.TextAlign = ContentAlignment.MiddleLeft;
        ttp.SetToolTip(PinLabel, "Enter the password for this file.");
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // ButtonPanel
        // 
        ButtonPanel.Controls.Add(CloseButton);
        ButtonPanel.Controls.Add(OkButton);
        ButtonPanel.Controls.Add(DividerLine);
        ButtonPanel.Dock = DockStyle.Bottom;
        ButtonPanel.Location = new Point(0, 305);
        ButtonPanel.Name = "ButtonPanel";
        ButtonPanel.Size = new Size(460, 51);
        ButtonPanel.TabIndex = 7;
        // 
        // DividerLine
        // 
        DividerLine.BevelBottomColor = SystemColors.ControlLight;
        DividerLine.BevelTopColor = SystemColors.ControlDark;
        DividerLine.Direction = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
        DividerLine.Dock = DockStyle.Top;
        DividerLine.EndColor = Color.FromArgb(255, 128, 0);
        DividerLine.LineWidth = 3;
        DividerLine.Location = new Point(0, 0);
        DividerLine.Mode = LineControlMode.Line;
        DividerLine.Name = "DividerLine";
        DividerLine.Orientation = LineControlOrientation.Horizontal;
        DividerLine.Size = new Size(460, 3);
        DividerLine.StartColor = Color.DodgerBlue;
        DividerLine.TabIndex = 10;
        DividerLine.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(18, 242);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(32, 32);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 11;
        pictureBox1.TabStop = false;
        // 
        // LoginDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(460, 356);
        ControlBox = false;
        Controls.Add(pictureBox1);
        Controls.Add(PinText);
        Controls.Add(PinLabel);
        Controls.Add(ButtonPanel);
        Controls.Add(PwdImage);
        Controls.Add(UserIdImage);
        Controls.Add(NameText);
        Controls.Add(PasswordText);
        Controls.Add(PasswordLabel);
        Controls.Add(NameLabel);
        Controls.Add(DialogHeader);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        KeyPreview = true;
        Margin = new Padding(4, 5, 4, 5);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginDialog";
        StartPosition = FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)UserIdImage).EndInit();
        ((System.ComponentModel.ISupportInitialize)PwdImage).EndInit();
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
        ButtonPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private VaultDialogHeader DialogHeader;
    private AdvancedLabel NameLabel;
    private AdvancedLabel PasswordLabel;
    private PasswordTextBox PasswordText;
    private TextBox NameText;
    private PictureBox UserIdImage;
    private PictureBox PwdImage;
    private ToolTip ttp;
    private ErrorProvider ErrorProvider;
    private Panel ButtonPanel;
    private PictureBox pictureBox1;
    private PasswordTextBox PinText;
    private AdvancedLabel PinLabel;
    private TemplatedButton CloseButton;
    private TemplatedButton OkButton;
    private LineControl DividerLine;
}
