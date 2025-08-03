namespace Adaptive.Data.Vault.UI;

partial class WebAccountInfoDialog
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebAccountInfoDialog));
        BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ContentPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        CloseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        CopyPasswordButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        ShowPasswordButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        CopyUserIdButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        ShowUserIdButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        CopyUrlButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        PasswordLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        PasswordTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        UserIdLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        UserIdTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        AddressLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        Header = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
        AddressTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
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
        BorderPanel.Size = new Size(587, 248);
        BorderPanel.TabIndex = 0;
        BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Button.template";
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
        ContentPanel.Size = new Size(577, 238);
        ContentPanel.TabIndex = 0;
        ContentPanel.TemplateFile = null;
        // 
        // CloseButton
        // 
        CloseButton.Checked = false;
        CloseButton.Location = new Point(485, 187);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(80, 40);
        CloseButton.TabIndex = 12;
        CloseButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Cancel  Template.template";
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
        CopyPasswordButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Copy Button Template.template";
        ttp.SetToolTip(CopyPasswordButton, "Copy the password to the clipboard.");
        CopyPasswordButton.UseVisualStyleBackColor = true;
        // 
        // ShowPasswordButton
        // 
        ShowPasswordButton.Checked = false;
        ShowPasswordButton.Location = new Point(485, 125);
        ShowPasswordButton.Name = "ShowPasswordButton";
        ShowPasswordButton.Size = new Size(40, 40);
        ShowPasswordButton.TabIndex = 10;
        ShowPasswordButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV ShowHide Template.template";
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
        CopyUserIdButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Copy Button Template.template";
        ttp.SetToolTip(CopyUserIdButton, "Copy the User ID / Login Name to the clipboard.");
        CopyUserIdButton.UseVisualStyleBackColor = true;
        // 
        // ShowUserIdButton
        // 
        ShowUserIdButton.Checked = false;
        ShowUserIdButton.Location = new Point(485, 85);
        ShowUserIdButton.Name = "ShowUserIdButton";
        ShowUserIdButton.Size = new Size(40, 40);
        ShowUserIdButton.TabIndex = 8;
        ShowUserIdButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV ShowHide Template.template";
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
        CopyUrlButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Copy Button Template.template";
        ttp.SetToolTip(CopyUrlButton, "Copy this URL to the clipboard.");
        CopyUrlButton.UseVisualStyleBackColor = true;
        CopyUrlButton.Click += CopyUrlButton_Click;
        // 
        // PasswordLabel
        // 
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
        PasswordTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        PasswordTitleLabel.Location = new Point(10, 85);
        PasswordTitleLabel.Name = "PasswordTitleLabel";
        PasswordTitleLabel.Size = new Size(105, 40);
        PasswordTitleLabel.TabIndex = 5;
        PasswordTitleLabel.TabStop = false;
        PasswordTitleLabel.Text = "Password:";
        PasswordTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UserIdLabel
        // 
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
        UserIdTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        UserIdTitleLabel.Location = new Point(10, 45);
        UserIdTitleLabel.Name = "UserIdTitleLabel";
        UserIdTitleLabel.Size = new Size(105, 40);
        UserIdTitleLabel.TabIndex = 3;
        UserIdTitleLabel.TabStop = false;
        UserIdTitleLabel.Text = "User ID:";
        UserIdTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // AddressLabel
        // 
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
        Header.Size = new Size(577, 39);
        Header.TabIndex = 1;
        Header.Text = "(Header)";
        // 
        // AddressTitleLabel
        // 
        AddressTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        AddressTitleLabel.Location = new Point(10, 125);
        AddressTitleLabel.Name = "AddressTitleLabel";
        AddressTitleLabel.Size = new Size(105, 40);
        AddressTitleLabel.TabIndex = 0;
        AddressTitleLabel.TabStop = false;
        AddressTitleLabel.Text = "Address:";
        AddressTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // WebAccountInfoDialog
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(587, 248);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "WebAccountInfoDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContentPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Intelligence.Shared.UI.GradientPanel BorderPanel;
    private Intelligence.Shared.UI.GradientPanel ContentPanel;
    private Intelligence.Shared.UI.TemplatedButton CopyPasswordButton;
    private Intelligence.Shared.UI.TemplatedButton ShowPasswordButton;
    private Intelligence.Shared.UI.TemplatedButton CopyUserIdButton;
    private Intelligence.Shared.UI.TemplatedButton ShowUserIdButton;
    private Intelligence.Shared.UI.TemplatedButton CopyUrlButton;
    private Intelligence.Shared.UI.AdvancedLabel PasswordLabel;
    private Intelligence.Shared.UI.AdvancedLabel PasswordTitleLabel;
    private Intelligence.Shared.UI.AdvancedLabel UserIdLabel;
    private Intelligence.Shared.UI.AdvancedLabel UserIdTitleLabel;
    private Intelligence.Shared.UI.AdvancedLabel AddressLabel;
    private Intelligence.Shared.UI.SectionTitleHeader Header;
    private Intelligence.Shared.UI.AdvancedLabel AddressTitleLabel;
    private Intelligence.Shared.UI.TemplatedButton CloseButton;
    private ToolTip ttp;
}