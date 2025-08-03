using Adaptive.Data.Vault.UI.Controls;

namespace Adaptive.Data.Vault.UI;

partial class EditWebAccountControl
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
        ErrorProvider = new ErrorProvider(components);
        ttp = new ToolTip(components);
        NameText = new TextBox();
        DescText = new TextBox();
        UrlText = new TextBox();
        UserIdText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
        PasswordText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
        MfaCheck = new CheckBox();
        MfaTypeText = new TextBox();
        MfaAddressText = new TextBox();
        NamePanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        NameLabelPanel = new Panel();
        NewNameLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        DescPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        DescLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        DescLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        UrlPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        UrlLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        UrlLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        UseridPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        UserIdLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        UserIdLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        PwdPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        PwdLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        PasswordLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        MafAddressPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        MfaAddLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        MfaCheckLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        MfaTypePanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        MfaTypeLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        MfaTypeLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        MfaCheckPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        MfaCheckLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        MfaDeviceLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
        NamePanel.SuspendLayout();
        NameLabelPanel.SuspendLayout();
        DescPanel.SuspendLayout();
        DescLabelPanel.SuspendLayout();
        UrlPanel.SuspendLayout();
        UrlLabelPanel.SuspendLayout();
        UseridPanel.SuspendLayout();
        UserIdLabelPanel.SuspendLayout();
        PwdPanel.SuspendLayout();
        PwdLabelPanel.SuspendLayout();
        MafAddressPanel.SuspendLayout();
        MfaAddLabelPanel.SuspendLayout();
        MfaTypePanel.SuspendLayout();
        MfaTypeLabelPanel.SuspendLayout();
        MfaCheckPanel.SuspendLayout();
        MfaCheckLabelPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // NameText
        // 
        NameText.Dock = DockStyle.Fill;
        NameText.Location = new Point(100, 0);
        NameText.Name = "NameText";
        NameText.PlaceholderText = "(Name)";
        NameText.Size = new Size(495, 25);
        NameText.TabIndex = 0;
        ttp.SetToolTip(NameText, "Enter a name for this general data entry.");
        // 
        // DescText
        // 
        DescText.Dock = DockStyle.Fill;
        DescText.Location = new Point(100, 0);
        DescText.Name = "DescText";
        DescText.PlaceholderText = "(Description of Entry)";
        DescText.Size = new Size(495, 25);
        DescText.TabIndex = 0;
        ttp.SetToolTip(DescText, "Optionally, enter a description for this entry.");
        // 
        // UrlText
        // 
        UrlText.Dock = DockStyle.Fill;
        UrlText.Location = new Point(100, 0);
        UrlText.Name = "UrlText";
        UrlText.PlaceholderText = "(http://www.siteToLoginTo.com)";
        UrlText.Size = new Size(495, 25);
        UrlText.TabIndex = 0;
        ttp.SetToolTip(UrlText, "Enter the website address used when logging into the site for this entry.");
        // 
        // UserIdText
        // 
        UserIdText.Dock = DockStyle.Fill;
        UserIdText.Font = new Font("Segoe UI", 9.75F);
        UserIdText.Location = new Point(100, 0);
        UserIdText.Margin = new Padding(4);
        UserIdText.Name = "UserIdText";
        UserIdText.PlaceholderText = "(User ID or Login Name)";
        UserIdText.Size = new Size(495, 25);
        UserIdText.TabIndex = 0;
        ttp.SetToolTip(UserIdText, "Enter your user Id or login name used when logging into this site.");
        // 
        // PasswordText
        // 
        PasswordText.Dock = DockStyle.Fill;
        PasswordText.Font = new Font("Segoe UI", 9.75F);
        PasswordText.Location = new Point(100, 0);
        PasswordText.Margin = new Padding(4);
        PasswordText.Name = "PasswordText";
        PasswordText.PlaceholderText = "(Password)";
        PasswordText.Size = new Size(495, 25);
        PasswordText.TabIndex = 0;
        ttp.SetToolTip(PasswordText, "Enter your password used when logging into this site.");
        // 
        // MfaCheck
        // 
        MfaCheck.AutoSize = true;
        MfaCheck.Dock = DockStyle.Top;
        MfaCheck.Location = new Point(100, 0);
        MfaCheck.Name = "MfaCheck";
        MfaCheck.Padding = new Padding(8, 8, 0, 6);
        MfaCheck.Size = new Size(495, 28);
        MfaCheck.TabIndex = 1;
        ttp.SetToolTip(MfaCheck, "Check here if the account requires multi-factor authentication (MFA).");
        MfaCheck.UseVisualStyleBackColor = true;
        // 
        // MfaTypeText
        // 
        MfaTypeText.Dock = DockStyle.Fill;
        MfaTypeText.Location = new Point(100, 0);
        MfaTypeText.Name = "MfaTypeText";
        MfaTypeText.PlaceholderText = "(Type of MFA : Email, Phone, Authenticator... etc).";
        MfaTypeText.Size = new Size(495, 25);
        MfaTypeText.TabIndex = 1;
        ttp.SetToolTip(MfaTypeText, "Enter a name for the type of MFA/2FA used - email, phone, authenticator, etc.");
        // 
        // MfaAddressText
        // 
        MfaAddressText.Dock = DockStyle.Fill;
        MfaAddressText.Location = new Point(100, 0);
        MfaAddressText.Name = "MfaAddressText";
        MfaAddressText.PlaceholderText = "(myemail@myserver.com or 111-123-4567)";
        MfaAddressText.Size = new Size(495, 25);
        MfaAddressText.TabIndex = 1;
        ttp.SetToolTip(MfaAddressText, "If MFA is used, enter the phone number, email address, or other value indicating where the code is sent.");
        // 
        // NamePanel
        // 
        NamePanel.Controls.Add(NameText);
        NamePanel.Controls.Add(NameLabelPanel);
        NamePanel.Dock = DockStyle.Top;
        NamePanel.Location = new Point(0, 10);
        NamePanel.Name = "NamePanel";
        NamePanel.Padding = new Padding(0, 0, 5, 0);
        NamePanel.Size = new Size(600, 30);
        NamePanel.TabIndex = 0;
        // 
        // NameLabelPanel
        // 
        NameLabelPanel.Controls.Add(NewNameLabel);
        NameLabelPanel.Dock = DockStyle.Left;
        NameLabelPanel.Location = new Point(0, 0);
        NameLabelPanel.Name = "NameLabelPanel";
        NameLabelPanel.Size = new Size(100, 30);
        NameLabelPanel.TabIndex = 2;
        // 
        // NewNameLabel
        // 
        NewNameLabel.Dock = DockStyle.Top;
        NewNameLabel.Font = new Font("Segoe UI", 9.75F);
        NewNameLabel.ForeColor = Color.DimGray;
        NewNameLabel.Location = new Point(0, 0);
        NewNameLabel.Name = "NewNameLabel";
        NewNameLabel.Size = new Size(100, 26);
        NewNameLabel.TabIndex = 2;
        NewNameLabel.TabStop = false;
        NewNameLabel.Text = "&name:";
        NewNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // DescPanel
        // 
        DescPanel.Controls.Add(DescText);
        DescPanel.Controls.Add(DescLabelPanel);
        DescPanel.Dock = DockStyle.Top;
        DescPanel.Location = new Point(0, 40);
        DescPanel.Name = "DescPanel";
        DescPanel.Padding = new Padding(0, 0, 5, 0);
        DescPanel.Size = new Size(600, 30);
        DescPanel.TabIndex = 1;
        // 
        // DescLabelPanel
        // 
        DescLabelPanel.Controls.Add(DescLabel);
        DescLabelPanel.Dock = DockStyle.Left;
        DescLabelPanel.Location = new Point(0, 0);
        DescLabelPanel.Name = "DescLabelPanel";
        DescLabelPanel.Size = new Size(100, 30);
        DescLabelPanel.TabIndex = 0;
        // 
        // DescLabel
        // 
        DescLabel.Dock = DockStyle.Top;
        DescLabel.Font = new Font("Segoe UI", 9.75F);
        DescLabel.ForeColor = Color.DimGray;
        DescLabel.Location = new Point(0, 0);
        DescLabel.Name = "DescLabel";
        DescLabel.Size = new Size(100, 26);
        DescLabel.TabIndex = 3;
        DescLabel.TabStop = false;
        DescLabel.Text = "&description:";
        DescLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UrlPanel
        // 
        UrlPanel.Controls.Add(UrlText);
        UrlPanel.Controls.Add(UrlLabelPanel);
        UrlPanel.Dock = DockStyle.Top;
        UrlPanel.Location = new Point(0, 70);
        UrlPanel.Name = "UrlPanel";
        UrlPanel.Padding = new Padding(0, 0, 5, 0);
        UrlPanel.Size = new Size(600, 30);
        UrlPanel.TabIndex = 2;
        // 
        // UrlLabelPanel
        // 
        UrlLabelPanel.Controls.Add(UrlLabel);
        UrlLabelPanel.Dock = DockStyle.Left;
        UrlLabelPanel.Location = new Point(0, 0);
        UrlLabelPanel.Name = "UrlLabelPanel";
        UrlLabelPanel.Size = new Size(100, 30);
        UrlLabelPanel.TabIndex = 0;
        // 
        // UrlLabel
        // 
        UrlLabel.Dock = DockStyle.Top;
        UrlLabel.Font = new Font("Segoe UI", 9.75F);
        UrlLabel.ForeColor = Color.DimGray;
        UrlLabel.Location = new Point(0, 0);
        UrlLabel.Name = "UrlLabel";
        UrlLabel.Size = new Size(100, 26);
        UrlLabel.TabIndex = 5;
        UrlLabel.TabStop = false;
        UrlLabel.Text = "url / &address:";
        UrlLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // UseridPanel
        // 
        UseridPanel.Controls.Add(UserIdText);
        UseridPanel.Controls.Add(UserIdLabelPanel);
        UseridPanel.Dock = DockStyle.Top;
        UseridPanel.Location = new Point(0, 100);
        UseridPanel.Name = "UseridPanel";
        UseridPanel.Padding = new Padding(0, 0, 5, 0);
        UseridPanel.Size = new Size(600, 30);
        UseridPanel.TabIndex = 3;
        // 
        // UserIdLabelPanel
        // 
        UserIdLabelPanel.Controls.Add(UserIdLabel);
        UserIdLabelPanel.Dock = DockStyle.Left;
        UserIdLabelPanel.Location = new Point(0, 0);
        UserIdLabelPanel.Name = "UserIdLabelPanel";
        UserIdLabelPanel.Size = new Size(100, 30);
        UserIdLabelPanel.TabIndex = 0;
        // 
        // UserIdLabel
        // 
        UserIdLabel.Dock = DockStyle.Top;
        UserIdLabel.Font = new Font("Segoe UI", 9.75F);
        UserIdLabel.ForeColor = Color.DimGray;
        UserIdLabel.Location = new Point(0, 0);
        UserIdLabel.Name = "UserIdLabel";
        UserIdLabel.Size = new Size(100, 26);
        UserIdLabel.TabIndex = 7;
        UserIdLabel.TabStop = false;
        UserIdLabel.Text = "&user name:";
        UserIdLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // PwdPanel
        // 
        PwdPanel.Controls.Add(PasswordText);
        PwdPanel.Controls.Add(PwdLabelPanel);
        PwdPanel.Dock = DockStyle.Top;
        PwdPanel.Location = new Point(0, 130);
        PwdPanel.Name = "PwdPanel";
        PwdPanel.Padding = new Padding(0, 0, 5, 0);
        PwdPanel.Size = new Size(600, 30);
        PwdPanel.TabIndex = 4;
        // 
        // PwdLabelPanel
        // 
        PwdLabelPanel.Controls.Add(PasswordLabel);
        PwdLabelPanel.Dock = DockStyle.Left;
        PwdLabelPanel.Location = new Point(0, 0);
        PwdLabelPanel.Name = "PwdLabelPanel";
        PwdLabelPanel.Size = new Size(100, 30);
        PwdLabelPanel.TabIndex = 0;
        // 
        // PasswordLabel
        // 
        PasswordLabel.Dock = DockStyle.Top;
        PasswordLabel.Font = new Font("Segoe UI", 9.75F);
        PasswordLabel.ForeColor = Color.DimGray;
        PasswordLabel.Location = new Point(0, 0);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(100, 26);
        PasswordLabel.TabIndex = 9;
        PasswordLabel.TabStop = false;
        PasswordLabel.Text = "&password:";
        PasswordLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // MafAddressPanel
        // 
        MafAddressPanel.Controls.Add(MfaCheck);
        MafAddressPanel.Controls.Add(MfaAddLabelPanel);
        MafAddressPanel.Dock = DockStyle.Top;
        MafAddressPanel.Location = new Point(0, 160);
        MafAddressPanel.Name = "MafAddressPanel";
        MafAddressPanel.Padding = new Padding(0, 0, 5, 0);
        MafAddressPanel.Size = new Size(600, 30);
        MafAddressPanel.TabIndex = 7;
        // 
        // MfaAddLabelPanel
        // 
        MfaAddLabelPanel.Controls.Add(MfaCheckLabel);
        MfaAddLabelPanel.Dock = DockStyle.Left;
        MfaAddLabelPanel.Location = new Point(0, 0);
        MfaAddLabelPanel.Name = "MfaAddLabelPanel";
        MfaAddLabelPanel.Size = new Size(100, 30);
        MfaAddLabelPanel.TabIndex = 0;
        // 
        // MfaCheckLabel
        // 
        MfaCheckLabel.Dock = DockStyle.Top;
        MfaCheckLabel.Font = new Font("Segoe UI", 9.75F);
        MfaCheckLabel.ForeColor = Color.DimGray;
        MfaCheckLabel.Location = new Point(0, 0);
        MfaCheckLabel.Name = "MfaCheckLabel";
        MfaCheckLabel.Size = new Size(100, 26);
        MfaCheckLabel.TabIndex = 10;
        MfaCheckLabel.TabStop = false;
        MfaCheckLabel.Text = "uses &mfa:";
        MfaCheckLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // MfaTypePanel
        // 
        MfaTypePanel.Controls.Add(MfaTypeText);
        MfaTypePanel.Controls.Add(MfaTypeLabelPanel);
        MfaTypePanel.Dock = DockStyle.Top;
        MfaTypePanel.Location = new Point(0, 190);
        MfaTypePanel.Name = "MfaTypePanel";
        MfaTypePanel.Padding = new Padding(0, 0, 5, 0);
        MfaTypePanel.Size = new Size(600, 30);
        MfaTypePanel.TabIndex = 6;
        // 
        // MfaTypeLabelPanel
        // 
        MfaTypeLabelPanel.Controls.Add(MfaTypeLabel);
        MfaTypeLabelPanel.Dock = DockStyle.Left;
        MfaTypeLabelPanel.Location = new Point(0, 0);
        MfaTypeLabelPanel.Name = "MfaTypeLabelPanel";
        MfaTypeLabelPanel.Size = new Size(100, 30);
        MfaTypeLabelPanel.TabIndex = 0;
        // 
        // MfaTypeLabel
        // 
        MfaTypeLabel.Dock = DockStyle.Top;
        MfaTypeLabel.Font = new Font("Segoe UI", 9.75F);
        MfaTypeLabel.ForeColor = Color.DimGray;
        MfaTypeLabel.Location = new Point(0, 0);
        MfaTypeLabel.Name = "MfaTypeLabel";
        MfaTypeLabel.Size = new Size(100, 26);
        MfaTypeLabel.TabIndex = 10;
        MfaTypeLabel.TabStop = false;
        MfaTypeLabel.Text = "mfa type:";
        MfaTypeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // MfaCheckPanel
        // 
        MfaCheckPanel.Controls.Add(MfaAddressText);
        MfaCheckPanel.Controls.Add(MfaCheckLabelPanel);
        MfaCheckPanel.Dock = DockStyle.Top;
        MfaCheckPanel.Location = new Point(0, 220);
        MfaCheckPanel.Name = "MfaCheckPanel";
        MfaCheckPanel.Padding = new Padding(0, 0, 5, 0);
        MfaCheckPanel.Size = new Size(600, 30);
        MfaCheckPanel.TabIndex = 5;
        // 
        // MfaCheckLabelPanel
        // 
        MfaCheckLabelPanel.Controls.Add(MfaDeviceLabel);
        MfaCheckLabelPanel.Dock = DockStyle.Left;
        MfaCheckLabelPanel.Location = new Point(0, 0);
        MfaCheckLabelPanel.Name = "MfaCheckLabelPanel";
        MfaCheckLabelPanel.Size = new Size(100, 30);
        MfaCheckLabelPanel.TabIndex = 0;
        // 
        // MfaDeviceLabel
        // 
        MfaDeviceLabel.Dock = DockStyle.Top;
        MfaDeviceLabel.Font = new Font("Segoe UI", 9.75F);
        MfaDeviceLabel.ForeColor = Color.DimGray;
        MfaDeviceLabel.Location = new Point(0, 0);
        MfaDeviceLabel.Name = "MfaDeviceLabel";
        MfaDeviceLabel.Size = new Size(100, 26);
        MfaDeviceLabel.TabIndex = 11;
        MfaDeviceLabel.TabStop = false;
        MfaDeviceLabel.Text = "mfa device:";
        MfaDeviceLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // EditWebAccountControl
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.White;
        Controls.Add(MfaCheckPanel);
        Controls.Add(MfaTypePanel);
        Controls.Add(MafAddressPanel);
        Controls.Add(PwdPanel);
        Controls.Add(UseridPanel);
        Controls.Add(UrlPanel);
        Controls.Add(DescPanel);
        Controls.Add(NamePanel);
        ForeColor = Color.Black;
        Margin = new Padding(4, 5, 4, 5);
        Name = "EditWebAccountControl";
        Padding = new Padding(0, 10, 0, 0);
        Size = new Size(600, 255);
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
        NamePanel.ResumeLayout(false);
        NamePanel.PerformLayout();
        NameLabelPanel.ResumeLayout(false);
        DescPanel.ResumeLayout(false);
        DescPanel.PerformLayout();
        DescLabelPanel.ResumeLayout(false);
        UrlPanel.ResumeLayout(false);
        UrlPanel.PerformLayout();
        UrlLabelPanel.ResumeLayout(false);
        UseridPanel.ResumeLayout(false);
        UserIdLabelPanel.ResumeLayout(false);
        PwdPanel.ResumeLayout(false);
        PwdLabelPanel.ResumeLayout(false);
        MafAddressPanel.ResumeLayout(false);
        MafAddressPanel.PerformLayout();
        MfaAddLabelPanel.ResumeLayout(false);
        MfaTypePanel.ResumeLayout(false);
        MfaTypePanel.PerformLayout();
        MfaTypeLabelPanel.ResumeLayout(false);
        MfaCheckPanel.ResumeLayout(false);
        MfaCheckPanel.PerformLayout();
        MfaCheckLabelPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ToolTip ttp;
    private ErrorProvider ErrorProvider;
    private Intelligence.Shared.UI.GradientPanel MfaTypePanel;
    private Intelligence.Shared.UI.GradientPanel MafAddressPanel;
    private Intelligence.Shared.UI.GradientPanel PwdPanel;
    private Intelligence.Shared.UI.GradientPanel UseridPanel;
    private Intelligence.Shared.UI.GradientPanel UrlPanel;
    private Intelligence.Shared.UI.GradientPanel DescPanel;
    private Intelligence.Shared.UI.GradientPanel NamePanel;
    private Intelligence.Shared.UI.GradientPanel MfaCheckPanel;
    private Intelligence.Shared.UI.GradientPanel MfaCheckLabelPanel;
    private Intelligence.Shared.UI.GradientPanel MfaTypeLabelPanel;
    private Intelligence.Shared.UI.GradientPanel MfaAddLabelPanel;
    private Intelligence.Shared.UI.GradientPanel PwdLabelPanel;
    private Intelligence.Shared.UI.GradientPanel UserIdLabelPanel;
    private Intelligence.Shared.UI.GradientPanel UrlLabelPanel;
    private Intelligence.Shared.UI.GradientPanel DescLabelPanel;
    private TextBox NameText;
    private Intelligence.Shared.UI.AdvancedLabel UrlLabel;
    private Intelligence.Shared.UI.AdvancedLabel DescLabel;
    private Intelligence.Shared.UI.PasswordTextBox PasswordText;
    private Intelligence.Shared.UI.AdvancedLabel PasswordLabel;
    private Intelligence.Shared.UI.PasswordTextBox UserIdText;
    private Intelligence.Shared.UI.AdvancedLabel UserIdLabel;
    private TextBox UrlText;
    private TextBox DescText;
    private Intelligence.Shared.UI.AdvancedLabel MfaTypeLabel;
    private CheckBox MfaCheck;
    private Intelligence.Shared.UI.AdvancedLabel MfaCheckLabel;
    private TextBox MfaAddressText;
    private TextBox MfaTypeText;
    private Intelligence.Shared.UI.AdvancedLabel MfaDeviceLabel;
    private Panel NameLabelPanel;
    private Intelligence.Shared.UI.AdvancedLabel NewNameLabel;
}