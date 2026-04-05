using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

partial class IdentityProviderInfoDialog
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentityProviderInfoDialog));
        BorderPanel = new TemplatedGradientPanel();
        ContentPanel = new TemplatedGradientPanel();
        CloseButton = new TemplatedButton();
        CopyPasswordButton = new TemplatedButton();
        ShowPasswordButton = new TemplatedButton();
        CopyUserIdButton = new TemplatedButton();
        ShowUserIdButton = new TemplatedButton();
        CopyUrlButton = new TemplatedButton();
        PasswordLabel = new AdvancedLabel();
        PasswordTitleLabel = new AdvancedLabel();
        UserIdLabel = new AdvancedLabel();
        UserIdTitleLabel = new AdvancedLabel();
        AddressLabel = new AdvancedLabel();
        Header = new SectionTitleHeader();
        AddressTitleLabel = new AdvancedLabel();
        ttp = new ToolTip(components);
        BorderPanel.SuspendLayout();
        ContentPanel.SuspendLayout();
        SuspendLayout();
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(ContentPanel);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(5);
        BorderPanel.Size = new Size(580, 243);
        BorderPanel.TabIndex = 0;
        BorderPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\Standard Panel.json";
        BorderPanel.TemplateJson = resources.GetString("BorderPanel.TemplateJson");
        // 
        // ContentPanel
        // 
        ContentPanel.Controls.Add(CloseButton);
        ContentPanel.Controls.Add(CopyPasswordButton);
        ContentPanel.Controls.Add(ShowPasswordButton);
        ContentPanel.Controls.Add(CopyUserIdButton);
        ContentPanel.Controls.Add(ShowUserIdButton);
        ContentPanel.Controls.Add(CopyUrlButton);
        ContentPanel.Controls.Add(PasswordLabel);
        ContentPanel.Controls.Add(PasswordTitleLabel);
        ContentPanel.Controls.Add(UserIdLabel);
        ContentPanel.Controls.Add(UserIdTitleLabel);
        ContentPanel.Controls.Add(AddressLabel);
        ContentPanel.Controls.Add(Header);
        ContentPanel.Controls.Add(AddressTitleLabel);
        ContentPanel.Dock = DockStyle.Fill;
        ContentPanel.Location = new Point(5, 5);
        ContentPanel.Name = "ContentPanel";
        ContentPanel.Size = new Size(570, 233);
        ContentPanel.TabIndex = 0;
        ContentPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\General Background.panel.template.json";
        ContentPanel.TemplateJson = resources.GetString("ContentPanel.TemplateJson");
        // 
        // CloseButton
        // 
        CloseButton.Checked = false;
        CloseButton.Location = new Point(485, 187);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(80, 40);
        CloseButton.TabIndex = 12;
        CloseButton.TemplateFromFile = null;
        CloseButton.TemplateJson = resources.GetString("CloseButton.TemplateJson");
        CloseButton.Text = "Close";
        ttp.SetToolTip(CloseButton, "Close this window.");
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // CopyPasswordButton
        // 
        CopyPasswordButton.Checked = false;
        CopyPasswordButton.Location = new Point(525, 125);
        CopyPasswordButton.Name = "CopyPasswordButton";
        CopyPasswordButton.Size = new Size(40, 40);
        CopyPasswordButton.TabIndex = 11;
        CopyPasswordButton.TemplateFromFile = null;
        CopyPasswordButton.TemplateJson = resources.GetString("CopyPasswordButton.TemplateJson");
        ttp.SetToolTip(CopyPasswordButton, "Copy the password to the clipboard.");
        CopyPasswordButton.UseVisualStyleBackColor = true;
        // 
        // ShowPasswordButton
        // 
        ShowPasswordButton.Checked = false;
        ShowPasswordButton.Image = Properties.Resources.Edit_32x32;
        ShowPasswordButton.Location = new Point(485, 125);
        ShowPasswordButton.Name = "ShowPasswordButton";
        ShowPasswordButton.Size = new Size(40, 40);
        ShowPasswordButton.TabIndex = 10;
        ShowPasswordButton.TemplateFromFile = null;
        ShowPasswordButton.TemplateJson = resources.GetString("ShowPasswordButton.TemplateJson");
        ttp.SetToolTip(ShowPasswordButton, "Show or Hide the Password.");
        ShowPasswordButton.UseVisualStyleBackColor = true;
        // 
        // CopyUserIdButton
        // 
        CopyUserIdButton.Checked = false;
        CopyUserIdButton.Location = new Point(525, 85);
        CopyUserIdButton.Name = "CopyUserIdButton";
        CopyUserIdButton.Size = new Size(40, 40);
        CopyUserIdButton.TabIndex = 9;
        CopyUserIdButton.TemplateFromFile = null;
        CopyUserIdButton.TemplateJson = resources.GetString("CopyUserIdButton.TemplateJson");
        ttp.SetToolTip(CopyUserIdButton, "Copy the User ID / Login Name to the clipboard.");
        CopyUserIdButton.UseVisualStyleBackColor = true;
        // 
        // ShowUserIdButton
        // 
        ShowUserIdButton.Checked = false;
        ShowUserIdButton.Image = Properties.Resources.Edit_32x32;
        ShowUserIdButton.Location = new Point(485, 85);
        ShowUserIdButton.Name = "ShowUserIdButton";
        ShowUserIdButton.Size = new Size(40, 40);
        ShowUserIdButton.TabIndex = 8;
        ShowUserIdButton.TemplateFromFile = null;
        ShowUserIdButton.TemplateJson = resources.GetString("ShowUserIdButton.TemplateJson");
        ttp.SetToolTip(ShowUserIdButton, "Show or Hide the User Id.");
        ShowUserIdButton.UseVisualStyleBackColor = true;
        // 
        // CopyUrlButton
        // 
        CopyUrlButton.Checked = false;
        CopyUrlButton.Location = new Point(485, 45);
        CopyUrlButton.Name = "CopyUrlButton";
        CopyUrlButton.Size = new Size(40, 40);
        CopyUrlButton.TabIndex = 7;
        CopyUrlButton.TemplateFromFile = null;
        CopyUrlButton.TemplateJson = resources.GetString("CopyUrlButton.TemplateJson");
        ttp.SetToolTip(CopyUrlButton, "Copy this URL to the clipboard.");
        CopyUrlButton.UseVisualStyleBackColor = true;
        // 
        // PasswordLabel
        // 
        PasswordLabel.BackColor = Color.Transparent;
        PasswordLabel.Font = new Font("Segoe UI", 14.25F);
        PasswordLabel.Location = new Point(121, 125);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(360, 40);
        PasswordLabel.TabIndex = 6;
        PasswordLabel.TabStop = false;
        PasswordLabel.Text = "****";
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PasswordTitleLabel
        // 
        PasswordTitleLabel.BackColor = Color.Transparent;
        PasswordTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        PasswordTitleLabel.Location = new Point(7, 125);
        PasswordTitleLabel.Name = "PasswordTitleLabel";
        PasswordTitleLabel.Size = new Size(105, 40);
        PasswordTitleLabel.TabIndex = 5;
        PasswordTitleLabel.TabStop = false;
        PasswordTitleLabel.Text = "Password:";
        PasswordTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UserIdLabel
        // 
        UserIdLabel.BackColor = Color.Transparent;
        UserIdLabel.Font = new Font("Segoe UI", 14.25F);
        UserIdLabel.Location = new Point(121, 85);
        UserIdLabel.Name = "UserIdLabel";
        UserIdLabel.Size = new Size(360, 40);
        UserIdLabel.TabIndex = 4;
        UserIdLabel.TabStop = false;
        UserIdLabel.Text = "****";
        UserIdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // UserIdTitleLabel
        // 
        UserIdTitleLabel.BackColor = Color.Transparent;
        UserIdTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        UserIdTitleLabel.Location = new Point(7, 83);
        UserIdTitleLabel.Name = "UserIdTitleLabel";
        UserIdTitleLabel.Size = new Size(105, 40);
        UserIdTitleLabel.TabIndex = 3;
        UserIdTitleLabel.TabStop = false;
        UserIdTitleLabel.Text = "User ID:";
        UserIdTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // AddressLabel
        // 
        AddressLabel.BackColor = Color.Transparent;
        AddressLabel.Cursor = Cursors.Hand;
        AddressLabel.Font = new Font("Segoe UI", 14.25F);
        AddressLabel.ForeColor = Color.Blue;
        AddressLabel.Location = new Point(121, 45);
        AddressLabel.Name = "AddressLabel";
        AddressLabel.Size = new Size(360, 40);
        AddressLabel.TabIndex = 2;
        AddressLabel.TabStop = false;
        AddressLabel.Text = "https://samjones.azurewebsites.net/";
        AddressLabel.TextAlign = ContentAlignment.MiddleLeft;
        ttp.SetToolTip(AddressLabel, "Click here to open the website.");
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Margin = new Padding(48, 23, 48, 23);
        Header.Name = "Header";
        Header.Size = new Size(570, 39);
        Header.TabIndex = 1;
        Header.Text = "(Header)";
        // 
        // AddressTitleLabel
        // 
        AddressTitleLabel.BackColor = Color.Transparent;
        AddressTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        AddressTitleLabel.Location = new Point(7, 45);
        AddressTitleLabel.Name = "AddressTitleLabel";
        AddressTitleLabel.Size = new Size(105, 40);
        AddressTitleLabel.TabIndex = 0;
        AddressTitleLabel.TabStop = false;
        AddressTitleLabel.Text = "Address:";
        AddressTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // IdentityProviderInfoDialog
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(580, 243);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "IdentityProviderInfoDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContentPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
    #endregion

    private TemplatedGradientPanel BorderPanel;
    private TemplatedGradientPanel ContentPanel;
    private TemplatedButton CopyPasswordButton;
    private TemplatedButton ShowPasswordButton;
    private TemplatedButton CopyUserIdButton;
    private TemplatedButton ShowUserIdButton;
    private TemplatedButton CopyUrlButton;
    private AdvancedLabel PasswordLabel;
    private AdvancedLabel PasswordTitleLabel;
    private AdvancedLabel UserIdLabel;
    private AdvancedLabel UserIdTitleLabel;
    private AdvancedLabel AddressLabel;
    private SectionTitleHeader Header;
    private AdvancedLabel AddressTitleLabel;
    private TemplatedButton CloseButton;
    private ToolTip ttp;

}