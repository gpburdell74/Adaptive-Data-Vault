using Adaptive.Data.Vault.UI.Controls;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

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
        components = new Container();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MessageLoginDialog));
        ErrorProvider = new ErrorProvider(components);
        DialogHeader = new VaultDialogHeader();
        SecParamsLabel = new VerticalLabel();
        PinImage = new PictureBox();
        PinText = new PasswordTextBox();
        PinLabel = new AdvancedLabel();
        PwdImage = new PictureBox();
        UserIdImage = new PictureBox();
        NameText = new TextBox();
        PasswordText = new PasswordTextBox();
        PasswordLabel = new AdvancedLabel();
        NameLabel = new AdvancedLabel();
        ButtonBar = new SaveCancelBar();
        InstructionsLabel = new AdvancedLabel();
        ContainerPanel.SuspendLayout();
        ((ISupportInitialize)ErrorProvider).BeginInit();
        ((ISupportInitialize)PinImage).BeginInit();
        ((ISupportInitialize)PwdImage).BeginInit();
        ((ISupportInitialize)UserIdImage).BeginInit();
        SuspendLayout();
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(InstructionsLabel);
        ContainerPanel.Controls.Add(ButtonBar);
        ContainerPanel.Controls.Add(SecParamsLabel);
        ContainerPanel.Controls.Add(PinImage);
        ContainerPanel.Controls.Add(PinText);
        ContainerPanel.Controls.Add(PinLabel);
        ContainerPanel.Controls.Add(PwdImage);
        ContainerPanel.Controls.Add(UserIdImage);
        ContainerPanel.Controls.Add(NameText);
        ContainerPanel.Controls.Add(PasswordText);
        ContainerPanel.Controls.Add(PasswordLabel);
        ContainerPanel.Controls.Add(NameLabel);
        ContainerPanel.Controls.Add(DialogHeader);
        ContainerPanel.Size = new Size(475, 414);
        ContainerPanel.TemplateJson = resources.GetString("ContainerPanel.TemplateJson");
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // DialogHeader
        // 
        DialogHeader.Dock = DockStyle.Top;
        DialogHeader.Location = new Point(5, 5);
        DialogHeader.Name = "DialogHeader";
        DialogHeader.Size = new Size(465, 60);
        DialogHeader.TabIndex = 0;
        DialogHeader.TitleText = "SECURE MESSAGE LOGIN";
        // 
        // SecParamsLabel
        // 
        SecParamsLabel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        SecParamsLabel.ForeColor = Color.RoyalBlue;
        SecParamsLabel.Location = new Point(5, 72);
        SecParamsLabel.Name = "SecParamsLabel";
        SecParamsLabel.Size = new Size(31, 287);
        SecParamsLabel.TabIndex = 1;
        SecParamsLabel.Text = "Security Parameters";
        SecParamsLabel.TextAlign = ContentAlignment.MiddleLeft;
        SecParamsLabel.UseCompatibleTextRendering = true;
        // 
        // PinImage
        // 
        PinImage.BackColor = Color.Transparent;
        PinImage.Image = Properties.Resources.User_ID_Keys1;
        PinImage.Location = new Point(41, 270);
        PinImage.Name = "PinImage";
        PinImage.Size = new Size(32, 32);
        PinImage.SizeMode = PictureBoxSizeMode.StretchImage;
        PinImage.TabIndex = 31;
        PinImage.TabStop = false;
        // 
        // PinText
        // 
        PinText.Font = new Font("Segoe UI", 9.75F);
        PinText.Location = new Point(82, 292);
        PinText.Margin = new Padding(4);
        PinText.Name = "PinText";
        PinText.NumericOnly = true;
        PinText.PlaceholderText = "(Numeric PIN Value)";
        PinText.Size = new Size(385, 25);
        PinText.TabIndex = 8;
        // 
        // PinLabel
        // 
        PinLabel.BackColor = Color.Transparent;
        PinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PinLabel.Location = new Point(79, 267);
        PinLabel.Name = "PinLabel";
        PinLabel.Size = new Size(385, 20);
        PinLabel.TabIndex = 7;
        PinLabel.TabStop = false;
        PinLabel.Text = "Enter the Message P&IN:";
        PinLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PwdImage
        // 
        PwdImage.BackColor = Color.Transparent;
        PwdImage.Image = Properties.Resources.Password_Lock;
        PwdImage.Location = new Point(43, 195);
        PwdImage.Name = "PwdImage";
        PwdImage.Size = new Size(32, 32);
        PwdImage.TabIndex = 30;
        PwdImage.TabStop = false;
        // 
        // UserIdImage
        // 
        UserIdImage.BackColor = Color.Transparent;
        UserIdImage.Image = Properties.Resources.User_Info_32x32;
        UserIdImage.Location = new Point(43, 124);
        UserIdImage.Name = "UserIdImage";
        UserIdImage.Size = new Size(32, 32);
        UserIdImage.TabIndex = 29;
        UserIdImage.TabStop = false;
        // 
        // NameText
        // 
        NameText.Location = new Point(82, 148);
        NameText.Name = "NameText";
        NameText.Size = new Size(385, 25);
        NameText.TabIndex = 4;
        // 
        // PasswordText
        // 
        PasswordText.Font = new Font("Segoe UI", 9.75F);
        PasswordText.Location = new Point(82, 218);
        PasswordText.Margin = new Padding(4);
        PasswordText.Name = "PasswordText";
        PasswordText.PlaceholderText = "(Password)";
        PasswordText.Size = new Size(385, 25);
        PasswordText.TabIndex = 6;
        // 
        // PasswordLabel
        // 
        PasswordLabel.BackColor = Color.Transparent;
        PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PasswordLabel.Location = new Point(79, 193);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(385, 20);
        PasswordLabel.TabIndex = 5;
        PasswordLabel.TabStop = false;
        PasswordLabel.Text = "Enter the Message &Password:";
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameLabel
        // 
        NameLabel.BackColor = Color.Transparent;
        NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        NameLabel.Location = new Point(79, 123);
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
        ButtonBar.Location = new Point(5, 359);
        ButtonBar.Margin = new Padding(48, 22, 48, 22);
        ButtonBar.Name = "ButtonBar";
        ButtonBar.SaveEnabled = true;
        ButtonBar.SaveText = "Save";
        ButtonBar.SaveVisible = true;
        ButtonBar.Size = new Size(465, 50);
        ButtonBar.TabIndex = 9;
        // 
        // InstructionsLabel
        // 
        InstructionsLabel.BackColor = Color.Transparent;
        InstructionsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        InstructionsLabel.Location = new Point(43, 72);
        InstructionsLabel.Name = "InstructionsLabel";
        InstructionsLabel.Size = new Size(424, 46);
        InstructionsLabel.TabIndex = 2;
        InstructionsLabel.TabStop = false;
        InstructionsLabel.Text = "The values below must be communicated to the recipient and re-entered in order to decode the message.";
        InstructionsLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // MessageLoginDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(475, 414);
        Name = "MessageLoginDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        ContainerPanel.ResumeLayout(false);
        ContainerPanel.PerformLayout();
        ((ISupportInitialize)ErrorProvider).EndInit();
        ((ISupportInitialize)PinImage).EndInit();
        ((ISupportInitialize)PwdImage).EndInit();
        ((ISupportInitialize)UserIdImage).EndInit();
        ResumeLayout(false);
    }
    private ErrorProvider ErrorProvider;

    #endregion

    private AdvancedLabel InstructionsLabel;
    private SaveCancelBar ButtonBar;
    private VerticalLabel SecParamsLabel;
    private PictureBox PinImage;
    private PasswordTextBox PinText;
    private AdvancedLabel PinLabel;
    private PictureBox PwdImage;
    private PictureBox UserIdImage;
    private TextBox NameText;
    private PasswordTextBox PasswordText;
    private AdvancedLabel PasswordLabel;
    private AdvancedLabel NameLabel;
    private VaultDialogHeader DialogHeader;
}