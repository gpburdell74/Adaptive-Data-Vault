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
        ttp = new ToolTip(components);
        AddressLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        CopyPasswordButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        ShowPasswordButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        CopyUserIdButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        ShowUserIdButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        CopyUrlButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        CloseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        ContentPanel = new Panel();
        PasswordLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        UserIdTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        UserIdLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        AddressTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        PasswordTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        Header = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
        ContainerPanel.SuspendLayout();
        ContentPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(ContentPanel);
        ContainerPanel.Size = new Size(644, 260);
        // 
        // AddressLabel
        // 
        AddressLabel.Cursor = Cursors.Hand;
        AddressLabel.Font = new Font("Segoe UI", 14.25F);
        AddressLabel.ForeColor = Color.Blue;
        AddressLabel.Location = new Point(121, 40);
        AddressLabel.Name = "AddressLabel";
        AddressLabel.Size = new Size(360, 40);
        AddressLabel.TabIndex = 2;
        AddressLabel.TabStop = false;
        AddressLabel.Text = "https://samjones.azurewebsites.net/";
        AddressLabel.TextAlign = ContentAlignment.MiddleLeft;
        ttp.SetToolTip(AddressLabel, "Click here to open the website.");
        // 
        // CopyPasswordButton
        // 
        CopyPasswordButton.Checked = false;
        CopyPasswordButton.Location = new Point(586, 132);
        CopyPasswordButton.Name = "CopyPasswordButton";
        CopyPasswordButton.ResourceTemplate = Properties.Resources.ButtonTemplateCopy;
        CopyPasswordButton.Size = new Size(40, 40);
        CopyPasswordButton.TabIndex = 11;
        CopyPasswordButton.TemplateFile = null;
        ttp.SetToolTip(CopyPasswordButton, "Copy the password to the clipboard.");
        CopyPasswordButton.UseVisualStyleBackColor = true;
        // 
        // ShowPasswordButton
        // 
        ShowPasswordButton.Checked = false;
        ShowPasswordButton.Location = new Point(540, 132);
        ShowPasswordButton.Name = "ShowPasswordButton";
        ShowPasswordButton.ResourceTemplate = Properties.Resources.ButtonTemplateShowHide;
        ShowPasswordButton.Size = new Size(40, 40);
        ShowPasswordButton.TabIndex = 10;
        ShowPasswordButton.TemplateFile = null;
        ttp.SetToolTip(ShowPasswordButton, "Show or Hide the Password.");
        ShowPasswordButton.UseVisualStyleBackColor = true;
        // 
        // CopyUserIdButton
        // 
        CopyUserIdButton.Checked = false;
        CopyUserIdButton.Location = new Point(586, 86);
        CopyUserIdButton.Name = "CopyUserIdButton";
        CopyUserIdButton.ResourceTemplate = Properties.Resources.ButtonTemplateCopy;
        CopyUserIdButton.Size = new Size(40, 40);
        CopyUserIdButton.TabIndex = 7;
        CopyUserIdButton.TemplateFile = null;
        ttp.SetToolTip(CopyUserIdButton, "Copy the User ID / Login Name to the clipboard.");
        CopyUserIdButton.UseVisualStyleBackColor = true;
        // 
        // ShowUserIdButton
        // 
        ShowUserIdButton.Checked = false;
        ShowUserIdButton.Location = new Point(540, 86);
        ShowUserIdButton.Name = "ShowUserIdButton";
        ShowUserIdButton.ResourceTemplate = Properties.Resources.ButtonTemplateShowHide;
        ShowUserIdButton.Size = new Size(40, 40);
        ShowUserIdButton.TabIndex = 6;
        ShowUserIdButton.TemplateFile = null;
        ttp.SetToolTip(ShowUserIdButton, "Show or Hide the User Id.");
        ShowUserIdButton.UseVisualStyleBackColor = true;
        // 
        // CopyUrlButton
        // 
        CopyUrlButton.Checked = false;
        CopyUrlButton.Location = new Point(540, 42);
        CopyUrlButton.Name = "CopyUrlButton";
        CopyUrlButton.ResourceTemplate = Properties.Resources.ButtonTemplateCopy;
        CopyUrlButton.Size = new Size(40, 40);
        CopyUrlButton.TabIndex = 3;
        CopyUrlButton.TemplateFile = null;
        ttp.SetToolTip(CopyUrlButton, "Copy this URL to the clipboard.");
        CopyUrlButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Checked = false;
        CloseButton.Location = new Point(497, 203);
        CloseButton.Name = "CloseButton";
        CloseButton.ResourceTemplate = Properties.Resources.ButtonTemplateCancel;
        CloseButton.Size = new Size(129, 40);
        CloseButton.TabIndex = 12;
        CloseButton.TemplateFile = null;
        CloseButton.Text = "Close";
        ttp.SetToolTip(CloseButton, "Close this window.");
        CloseButton.UseVisualStyleBackColor = true;
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
        ContentPanel.Controls.Add(UserIdTitleLabel);
        ContentPanel.Controls.Add(UserIdLabel);
        ContentPanel.Controls.Add(AddressTitleLabel);
        ContentPanel.Controls.Add(AddressLabel);
        ContentPanel.Controls.Add(PasswordTitleLabel);
        ContentPanel.Controls.Add(Header);
        ContentPanel.Dock = DockStyle.Fill;
        ContentPanel.Location = new Point(5, 5);
        ContentPanel.Name = "ContentPanel";
        ContentPanel.Size = new Size(634, 250);
        ContentPanel.TabIndex = 13;
        // 
        // PasswordLabel
        // 
        PasswordLabel.Font = new Font("Segoe UI", 14.25F);
        PasswordLabel.Location = new Point(121, 132);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(360, 40);
        PasswordLabel.TabIndex = 9;
        PasswordLabel.TabStop = false;
        PasswordLabel.Text = "****";
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // UserIdTitleLabel
        // 
        UserIdTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        UserIdTitleLabel.Location = new Point(10, 86);
        UserIdTitleLabel.Name = "UserIdTitleLabel";
        UserIdTitleLabel.Size = new Size(105, 40);
        UserIdTitleLabel.TabIndex = 4;
        UserIdTitleLabel.TabStop = false;
        UserIdTitleLabel.Text = "&User ID:";
        UserIdTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UserIdLabel
        // 
        UserIdLabel.Font = new Font("Segoe UI", 14.25F);
        UserIdLabel.Location = new Point(121, 86);
        UserIdLabel.Name = "UserIdLabel";
        UserIdLabel.Size = new Size(360, 40);
        UserIdLabel.TabIndex = 5;
        UserIdLabel.TabStop = false;
        UserIdLabel.Text = "****";
        UserIdLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AddressTitleLabel
        // 
        AddressTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        AddressTitleLabel.Location = new Point(10, 40);
        AddressTitleLabel.Name = "AddressTitleLabel";
        AddressTitleLabel.Size = new Size(105, 40);
        AddressTitleLabel.TabIndex = 1;
        AddressTitleLabel.TabStop = false;
        AddressTitleLabel.Text = "&Address:";
        AddressTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // PasswordTitleLabel
        // 
        PasswordTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
        PasswordTitleLabel.Location = new Point(10, 132);
        PasswordTitleLabel.Name = "PasswordTitleLabel";
        PasswordTitleLabel.Size = new Size(105, 40);
        PasswordTitleLabel.TabIndex = 8;
        PasswordTitleLabel.TabStop = false;
        PasswordTitleLabel.Text = "&Password:";
        PasswordTitleLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Margin = new Padding(48, 23, 48, 23);
        Header.Name = "Header";
        Header.Size = new Size(634, 39);
        Header.TabIndex = 0;
        Header.TabStop = false;
        Header.Text = "(Header)";
        // 
        // WebAccountInfoDialog
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(644, 260);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "WebAccountInfoDialog";
        ContainerPanel.ResumeLayout(false);
        ContentPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ToolTip ttp;
    private Panel ContentPanel;
    private Intelligence.Shared.UI.SectionTitleHeader Header;
    private Intelligence.Shared.UI.TemplatedButton CopyPasswordButton;
    private Intelligence.Shared.UI.TemplatedButton ShowPasswordButton;
    private Intelligence.Shared.UI.TemplatedButton CopyUserIdButton;
    private Intelligence.Shared.UI.TemplatedButton ShowUserIdButton;
    private Intelligence.Shared.UI.TemplatedButton CopyUrlButton;
    private Intelligence.Shared.UI.AdvancedLabel PasswordLabel;
    private Intelligence.Shared.UI.AdvancedLabel UserIdTitleLabel;
    private Intelligence.Shared.UI.AdvancedLabel UserIdLabel;
    private Intelligence.Shared.UI.AdvancedLabel AddressTitleLabel;
    private Intelligence.Shared.UI.AdvancedLabel AddressLabel;
    private Intelligence.Shared.UI.AdvancedLabel PasswordTitleLabel;
    private Intelligence.Shared.UI.TemplatedButton CloseButton;
}