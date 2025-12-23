namespace Adaptive.Data.Vault.UI
{
    partial class EditIdentityProviderControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            UseridPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            UserIdText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
            UserIdLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            UserIdLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            UrlLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            UrlLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            UrlPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            UrlText = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            ttp = new ToolTip(components);
            NameText = new TextBox();
            DescText = new TextBox();
            IdProviderTypeList = new ComboBox();
            MfaAddressText = new TextBox();
            MfaTypeText = new TextBox();
            MfaCheck = new CheckBox();
            PasswordText = new Adaptive.Intelligence.Shared.UI.PasswordTextBox();
            NamePanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            NameLabelPanel = new Panel();
            NewNameLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            DescPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            DescLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            DescLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            IdTypeLabelPanel = new Panel();
            ProviderTypeLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            IdTypePanel = new Panel();
            MfaDeviceLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            MfaCheckPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            MfaCheckLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            MfaTypeLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            MfaTypePanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            MfaTypeLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            MfaAddLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            MfaCheckLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            MafAddressPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            PasswordLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            PwdLabelPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            PwdPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            UseridPanel.SuspendLayout();
            UserIdLabelPanel.SuspendLayout();
            UrlLabelPanel.SuspendLayout();
            UrlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            NamePanel.SuspendLayout();
            NameLabelPanel.SuspendLayout();
            DescPanel.SuspendLayout();
            DescLabelPanel.SuspendLayout();
            IdTypeLabelPanel.SuspendLayout();
            IdTypePanel.SuspendLayout();
            MfaCheckPanel.SuspendLayout();
            MfaCheckLabelPanel.SuspendLayout();
            MfaTypePanel.SuspendLayout();
            MfaTypeLabelPanel.SuspendLayout();
            MfaAddLabelPanel.SuspendLayout();
            MafAddressPanel.SuspendLayout();
            PwdLabelPanel.SuspendLayout();
            PwdPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UseridPanel
            // 
            UseridPanel.Controls.Add(UserIdText);
            UseridPanel.Controls.Add(UserIdLabelPanel);
            UseridPanel.Dock = DockStyle.Top;
            UseridPanel.Location = new Point(0, 130);
            UseridPanel.Name = "UseridPanel";
            UseridPanel.Padding = new Padding(0, 0, 5, 0);
            UseridPanel.Size = new Size(600, 30);
            UseridPanel.TabIndex = 20;
            UseridPanel.TemplateFile = null;
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
            // UserIdLabelPanel
            // 
            UserIdLabelPanel.Controls.Add(UserIdLabel);
            UserIdLabelPanel.Dock = DockStyle.Left;
            UserIdLabelPanel.Location = new Point(0, 0);
            UserIdLabelPanel.Name = "UserIdLabelPanel";
            UserIdLabelPanel.Size = new Size(100, 30);
            UserIdLabelPanel.TabIndex = 0;
            UserIdLabelPanel.TemplateFile = null;
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
            // UrlLabelPanel
            // 
            UrlLabelPanel.Controls.Add(UrlLabel);
            UrlLabelPanel.Dock = DockStyle.Left;
            UrlLabelPanel.Location = new Point(0, 0);
            UrlLabelPanel.Name = "UrlLabelPanel";
            UrlLabelPanel.Size = new Size(100, 30);
            UrlLabelPanel.TabIndex = 0;
            UrlLabelPanel.TemplateFile = null;
            // 
            // UrlPanel
            // 
            UrlPanel.Controls.Add(UrlText);
            UrlPanel.Controls.Add(UrlLabelPanel);
            UrlPanel.Dock = DockStyle.Top;
            UrlPanel.Location = new Point(0, 100);
            UrlPanel.Name = "UrlPanel";
            UrlPanel.Padding = new Padding(0, 0, 5, 0);
            UrlPanel.Size = new Size(600, 30);
            UrlPanel.TabIndex = 19;
            UrlPanel.TemplateFile = null;
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
            // IdProviderTypeList
            // 
            IdProviderTypeList.Dock = DockStyle.Top;
            IdProviderTypeList.FormattingEnabled = true;
            IdProviderTypeList.Location = new Point(100, 0);
            IdProviderTypeList.Name = "IdProviderTypeList";
            IdProviderTypeList.Size = new Size(495, 25);
            IdProviderTypeList.TabIndex = 0;
            ttp.SetToolTip(IdProviderTypeList, "Select the Identity Provider Company:");
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
            // NamePanel
            // 
            NamePanel.Controls.Add(NameText);
            NamePanel.Controls.Add(NameLabelPanel);
            NamePanel.Dock = DockStyle.Top;
            NamePanel.Location = new Point(0, 40);
            NamePanel.Name = "NamePanel";
            NamePanel.Padding = new Padding(0, 0, 5, 0);
            NamePanel.Size = new Size(600, 30);
            NamePanel.TabIndex = 17;
            NamePanel.TemplateFile = null;
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
            DescPanel.Location = new Point(0, 70);
            DescPanel.Name = "DescPanel";
            DescPanel.Padding = new Padding(0, 0, 5, 0);
            DescPanel.Size = new Size(600, 30);
            DescPanel.TabIndex = 18;
            DescPanel.TemplateFile = null;
            // 
            // DescLabelPanel
            // 
            DescLabelPanel.Controls.Add(DescLabel);
            DescLabelPanel.Dock = DockStyle.Left;
            DescLabelPanel.Location = new Point(0, 0);
            DescLabelPanel.Name = "DescLabelPanel";
            DescLabelPanel.Size = new Size(100, 30);
            DescLabelPanel.TabIndex = 0;
            DescLabelPanel.TemplateFile = null;
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
            // IdTypeLabelPanel
            // 
            IdTypeLabelPanel.Controls.Add(ProviderTypeLabel);
            IdTypeLabelPanel.Dock = DockStyle.Left;
            IdTypeLabelPanel.Location = new Point(0, 0);
            IdTypeLabelPanel.Name = "IdTypeLabelPanel";
            IdTypeLabelPanel.Size = new Size(100, 30);
            IdTypeLabelPanel.TabIndex = 0;
            // 
            // ProviderTypeLabel
            // 
            ProviderTypeLabel.Dock = DockStyle.Top;
            ProviderTypeLabel.Font = new Font("Segoe UI", 9.75F);
            ProviderTypeLabel.ForeColor = Color.DimGray;
            ProviderTypeLabel.Location = new Point(0, 0);
            ProviderTypeLabel.Name = "ProviderTypeLabel";
            ProviderTypeLabel.Size = new Size(100, 26);
            ProviderTypeLabel.TabIndex = 3;
            ProviderTypeLabel.TabStop = false;
            ProviderTypeLabel.Text = "&provider type:";
            ProviderTypeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // IdTypePanel
            // 
            IdTypePanel.Controls.Add(IdProviderTypeList);
            IdTypePanel.Controls.Add(IdTypeLabelPanel);
            IdTypePanel.Dock = DockStyle.Top;
            IdTypePanel.Location = new Point(0, 10);
            IdTypePanel.Name = "IdTypePanel";
            IdTypePanel.Padding = new Padding(0, 0, 5, 0);
            IdTypePanel.Size = new Size(600, 30);
            IdTypePanel.TabIndex = 25;
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
            // MfaCheckPanel
            // 
            MfaCheckPanel.Controls.Add(MfaAddressText);
            MfaCheckPanel.Controls.Add(MfaCheckLabelPanel);
            MfaCheckPanel.Dock = DockStyle.Top;
            MfaCheckPanel.Location = new Point(0, 250);
            MfaCheckPanel.Name = "MfaCheckPanel";
            MfaCheckPanel.Padding = new Padding(0, 0, 5, 0);
            MfaCheckPanel.Size = new Size(600, 30);
            MfaCheckPanel.TabIndex = 22;
            MfaCheckPanel.TemplateFile = null;
            // 
            // MfaCheckLabelPanel
            // 
            MfaCheckLabelPanel.Controls.Add(MfaDeviceLabel);
            MfaCheckLabelPanel.Dock = DockStyle.Left;
            MfaCheckLabelPanel.Location = new Point(0, 0);
            MfaCheckLabelPanel.Name = "MfaCheckLabelPanel";
            MfaCheckLabelPanel.Size = new Size(100, 30);
            MfaCheckLabelPanel.TabIndex = 0;
            MfaCheckLabelPanel.TemplateFile = null;
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
            // MfaTypePanel
            // 
            MfaTypePanel.Controls.Add(MfaTypeText);
            MfaTypePanel.Controls.Add(MfaTypeLabelPanel);
            MfaTypePanel.Dock = DockStyle.Top;
            MfaTypePanel.Location = new Point(0, 220);
            MfaTypePanel.Name = "MfaTypePanel";
            MfaTypePanel.Padding = new Padding(0, 0, 5, 0);
            MfaTypePanel.Size = new Size(600, 30);
            MfaTypePanel.TabIndex = 23;
            MfaTypePanel.TemplateFile = null;
            // 
            // MfaTypeLabelPanel
            // 
            MfaTypeLabelPanel.Controls.Add(MfaTypeLabel);
            MfaTypeLabelPanel.Dock = DockStyle.Left;
            MfaTypeLabelPanel.Location = new Point(0, 0);
            MfaTypeLabelPanel.Name = "MfaTypeLabelPanel";
            MfaTypeLabelPanel.Size = new Size(100, 30);
            MfaTypeLabelPanel.TabIndex = 0;
            MfaTypeLabelPanel.TemplateFile = null;
            // 
            // MfaAddLabelPanel
            // 
            MfaAddLabelPanel.Controls.Add(MfaCheckLabel);
            MfaAddLabelPanel.Dock = DockStyle.Left;
            MfaAddLabelPanel.Location = new Point(0, 0);
            MfaAddLabelPanel.Name = "MfaAddLabelPanel";
            MfaAddLabelPanel.Size = new Size(100, 30);
            MfaAddLabelPanel.TabIndex = 0;
            MfaAddLabelPanel.TemplateFile = null;
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
            // MafAddressPanel
            // 
            MafAddressPanel.Controls.Add(MfaCheck);
            MafAddressPanel.Controls.Add(MfaAddLabelPanel);
            MafAddressPanel.Dock = DockStyle.Top;
            MafAddressPanel.Location = new Point(0, 190);
            MafAddressPanel.Name = "MafAddressPanel";
            MafAddressPanel.Padding = new Padding(0, 0, 5, 0);
            MafAddressPanel.Size = new Size(600, 30);
            MafAddressPanel.TabIndex = 24;
            MafAddressPanel.TemplateFile = null;
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
            // PwdLabelPanel
            // 
            PwdLabelPanel.Controls.Add(PasswordLabel);
            PwdLabelPanel.Dock = DockStyle.Left;
            PwdLabelPanel.Location = new Point(0, 0);
            PwdLabelPanel.Name = "PwdLabelPanel";
            PwdLabelPanel.Size = new Size(100, 30);
            PwdLabelPanel.TabIndex = 0;
            PwdLabelPanel.TemplateFile = null;
            // 
            // PwdPanel
            // 
            PwdPanel.Controls.Add(PasswordText);
            PwdPanel.Controls.Add(PwdLabelPanel);
            PwdPanel.Dock = DockStyle.Top;
            PwdPanel.Location = new Point(0, 160);
            PwdPanel.Name = "PwdPanel";
            PwdPanel.Padding = new Padding(0, 0, 5, 0);
            PwdPanel.Size = new Size(600, 30);
            PwdPanel.TabIndex = 21;
            PwdPanel.TemplateFile = null;
            // 
            // EditIdentityProviderControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(MfaCheckPanel);
            Controls.Add(MfaTypePanel);
            Controls.Add(MafAddressPanel);
            Controls.Add(PwdPanel);
            Controls.Add(UseridPanel);
            Controls.Add(UrlPanel);
            Controls.Add(DescPanel);
            Controls.Add(NamePanel);
            Controls.Add(IdTypePanel);
            Margin = new Padding(3);
            Name = "EditIdentityProviderControl";
            Padding = new Padding(0, 10, 0, 0);
            Size = new Size(600, 276);
            UseridPanel.ResumeLayout(false);
            UserIdLabelPanel.ResumeLayout(false);
            UrlLabelPanel.ResumeLayout(false);
            UrlPanel.ResumeLayout(false);
            UrlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            NameLabelPanel.ResumeLayout(false);
            DescPanel.ResumeLayout(false);
            DescPanel.PerformLayout();
            DescLabelPanel.ResumeLayout(false);
            IdTypeLabelPanel.ResumeLayout(false);
            IdTypePanel.ResumeLayout(false);
            MfaCheckPanel.ResumeLayout(false);
            MfaCheckPanel.PerformLayout();
            MfaCheckLabelPanel.ResumeLayout(false);
            MfaTypePanel.ResumeLayout(false);
            MfaTypePanel.PerformLayout();
            MfaTypeLabelPanel.ResumeLayout(false);
            MfaAddLabelPanel.ResumeLayout(false);
            MafAddressPanel.ResumeLayout(false);
            MafAddressPanel.PerformLayout();
            PwdLabelPanel.ResumeLayout(false);
            PwdPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Intelligence.Shared.UI.GradientPanel UseridPanel;
        private Intelligence.Shared.UI.PasswordTextBox UserIdText;
        private ToolTip ttp;
        private Intelligence.Shared.UI.GradientPanel UserIdLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel UserIdLabel;
        private Intelligence.Shared.UI.AdvancedLabel UrlLabel;
        private Intelligence.Shared.UI.GradientPanel UrlLabelPanel;
        private Intelligence.Shared.UI.GradientPanel UrlPanel;
        private TextBox UrlText;
        private ErrorProvider ErrorProvider;
        private Intelligence.Shared.UI.GradientPanel MfaCheckPanel;
        private TextBox MfaAddressText;
        private Intelligence.Shared.UI.GradientPanel MfaCheckLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel MfaDeviceLabel;
        private Intelligence.Shared.UI.GradientPanel MfaTypePanel;
        private TextBox MfaTypeText;
        private Intelligence.Shared.UI.GradientPanel MfaTypeLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel MfaTypeLabel;
        private Intelligence.Shared.UI.GradientPanel MafAddressPanel;
        private CheckBox MfaCheck;
        private Intelligence.Shared.UI.GradientPanel MfaAddLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel MfaCheckLabel;
        private Intelligence.Shared.UI.GradientPanel PwdPanel;
        private Intelligence.Shared.UI.PasswordTextBox PasswordText;
        private Intelligence.Shared.UI.GradientPanel PwdLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel PasswordLabel;
        private Intelligence.Shared.UI.GradientPanel DescPanel;
        private TextBox DescText;
        private Intelligence.Shared.UI.GradientPanel DescLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel DescLabel;
        private Intelligence.Shared.UI.GradientPanel NamePanel;
        private TextBox NameText;
        private Panel NameLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel NewNameLabel;
        private Panel IdTypePanel;
        private ComboBox IdProviderTypeList;
        private Panel IdTypeLabelPanel;
        private Intelligence.Shared.UI.AdvancedLabel ProviderTypeLabel;
    }
}
