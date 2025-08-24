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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adaptive.Data.Vault.UI.WebAccountInfoDialog));
        this.BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        this.ContentPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        this.CloseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.CopyPasswordButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.ShowPasswordButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.CopyUserIdButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.ShowUserIdButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.CopyUrlButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.PasswordLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        this.PasswordTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        this.UserIdLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        this.UserIdTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        this.AddressLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        this.Header = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
        this.AddressTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
        this.ttp = new System.Windows.Forms.ToolTip(this.components);
        this.BorderPanel.SuspendLayout();
        this.ContentPanel.SuspendLayout();
        base.SuspendLayout();
        this.BorderPanel.Controls.Add(this.ContentPanel);
        this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.BorderPanel.Location = new System.Drawing.Point(0, 0);
        this.BorderPanel.Name = "BorderPanel";
        this.BorderPanel.Padding = new System.Windows.Forms.Padding(5);
        this.BorderPanel.Size = new System.Drawing.Size(587, 248);
        this.BorderPanel.TabIndex = 0;
        this.BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        this.ContentPanel.Controls.Add(this.CloseButton);
        this.ContentPanel.Controls.Add(this.CopyPasswordButton);
        this.ContentPanel.Controls.Add(this.ShowPasswordButton);
        this.ContentPanel.Controls.Add(this.CopyUserIdButton);
        this.ContentPanel.Controls.Add(this.ShowUserIdButton);
        this.ContentPanel.Controls.Add(this.CopyUrlButton);
        this.ContentPanel.Controls.Add(this.PasswordLabel);
        this.ContentPanel.Controls.Add(this.PasswordTitleLabel);
        this.ContentPanel.Controls.Add(this.UserIdLabel);
        this.ContentPanel.Controls.Add(this.UserIdTitleLabel);
        this.ContentPanel.Controls.Add(this.AddressLabel);
        this.ContentPanel.Controls.Add(this.Header);
        this.ContentPanel.Controls.Add(this.AddressTitleLabel);
        this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ContentPanel.Location = new System.Drawing.Point(5, 5);
        this.ContentPanel.Name = "ContentPanel";
        this.ContentPanel.Size = new System.Drawing.Size(577, 238);
        this.ContentPanel.TabIndex = 0;
        this.ContentPanel.TemplateFile = null;
        this.CloseButton.Checked = false;
        this.CloseButton.Location = new System.Drawing.Point(485, 187);
        this.CloseButton.Name = "CloseButton";
        this.CloseButton.Size = new System.Drawing.Size(80, 40);
        this.CloseButton.TabIndex = 12;
        this.CloseButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Cancel  Template.template";
        this.CloseButton.Text = "Close";
        this.ttp.SetToolTip(this.CloseButton, "Close this window.");
        this.CloseButton.UseVisualStyleBackColor = true;
        this.CopyPasswordButton.Checked = false;
        this.CopyPasswordButton.Location = new System.Drawing.Point(525, 125);
        this.CopyPasswordButton.Name = "CopyPasswordButton";
        this.CopyPasswordButton.Size = new System.Drawing.Size(40, 40);
        this.CopyPasswordButton.TabIndex = 11;
        this.CopyPasswordButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Copy Button Template.template";
        this.ttp.SetToolTip(this.CopyPasswordButton, "Copy the password to the clipboard.");
        this.CopyPasswordButton.UseVisualStyleBackColor = true;
        this.ShowPasswordButton.Checked = false;
        this.ShowPasswordButton.Location = new System.Drawing.Point(485, 125);
        this.ShowPasswordButton.Name = "ShowPasswordButton";
        this.ShowPasswordButton.Size = new System.Drawing.Size(40, 40);
        this.ShowPasswordButton.TabIndex = 10;
        this.ShowPasswordButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV ShowHide Template.template";
        this.ttp.SetToolTip(this.ShowPasswordButton, "Show or Hide the Password.");
        this.ShowPasswordButton.UseVisualStyleBackColor = true;
        this.CopyUserIdButton.Checked = false;
        this.CopyUserIdButton.Location = new System.Drawing.Point(525, 85);
        this.CopyUserIdButton.Name = "CopyUserIdButton";
        this.CopyUserIdButton.Size = new System.Drawing.Size(40, 40);
        this.CopyUserIdButton.TabIndex = 9;
        this.CopyUserIdButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Copy Button Template.template";
        this.ttp.SetToolTip(this.CopyUserIdButton, "Copy the User ID / Login Name to the clipboard.");
        this.CopyUserIdButton.UseVisualStyleBackColor = true;
        this.ShowUserIdButton.Checked = false;
        this.ShowUserIdButton.Location = new System.Drawing.Point(485, 85);
        this.ShowUserIdButton.Name = "ShowUserIdButton";
        this.ShowUserIdButton.Size = new System.Drawing.Size(40, 40);
        this.ShowUserIdButton.TabIndex = 8;
        this.ShowUserIdButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV ShowHide Template.template";
        this.ttp.SetToolTip(this.ShowUserIdButton, "Show or Hide the User Id.");
        this.ShowUserIdButton.UseVisualStyleBackColor = true;
        this.CopyUrlButton.Checked = false;
        this.CopyUrlButton.Location = new System.Drawing.Point(485, 45);
        this.CopyUrlButton.Name = "CopyUrlButton";
        this.CopyUrlButton.Size = new System.Drawing.Size(40, 40);
        this.CopyUrlButton.TabIndex = 7;
        this.CopyUrlButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Copy Button Template.template";
        this.ttp.SetToolTip(this.CopyUrlButton, "Copy this URL to the clipboard.");
        this.CopyUrlButton.UseVisualStyleBackColor = true;
        this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25f);
        this.PasswordLabel.Location = new System.Drawing.Point(121, 125);
        this.PasswordLabel.Name = "PasswordLabel";
        this.PasswordLabel.Size = new System.Drawing.Size(360, 40);
        this.PasswordLabel.TabIndex = 6;
        this.PasswordLabel.TabStop = false;
        this.PasswordLabel.Text = "****";
        this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.PasswordTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold);
        this.PasswordTitleLabel.Location = new System.Drawing.Point(10, 85);
        this.PasswordTitleLabel.Name = "PasswordTitleLabel";
        this.PasswordTitleLabel.Size = new System.Drawing.Size(105, 40);
        this.PasswordTitleLabel.TabIndex = 5;
        this.PasswordTitleLabel.TabStop = false;
        this.PasswordTitleLabel.Text = "Password:";
        this.PasswordTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.UserIdLabel.Font = new System.Drawing.Font("Segoe UI", 14.25f);
        this.UserIdLabel.Location = new System.Drawing.Point(121, 85);
        this.UserIdLabel.Name = "UserIdLabel";
        this.UserIdLabel.Size = new System.Drawing.Size(360, 40);
        this.UserIdLabel.TabIndex = 4;
        this.UserIdLabel.TabStop = false;
        this.UserIdLabel.Text = "****";
        this.UserIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.UserIdTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold);
        this.UserIdTitleLabel.Location = new System.Drawing.Point(10, 45);
        this.UserIdTitleLabel.Name = "UserIdTitleLabel";
        this.UserIdTitleLabel.Size = new System.Drawing.Size(105, 40);
        this.UserIdTitleLabel.TabIndex = 3;
        this.UserIdTitleLabel.TabStop = false;
        this.UserIdTitleLabel.Text = "User ID:";
        this.UserIdTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.AddressLabel.Cursor = System.Windows.Forms.Cursors.Hand;
        this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 14.25f);
        this.AddressLabel.ForeColor = System.Drawing.Color.Blue;
        this.AddressLabel.Location = new System.Drawing.Point(121, 45);
        this.AddressLabel.Name = "AddressLabel";
        this.AddressLabel.Size = new System.Drawing.Size(360, 40);
        this.AddressLabel.TabIndex = 2;
        this.AddressLabel.TabStop = false;
        this.AddressLabel.Text = "https://samjones.azurewebsites.net/";
        this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.ttp.SetToolTip(this.AddressLabel, "Click here to open the website.");
        this.Header.Dock = System.Windows.Forms.DockStyle.Top;
        this.Header.Location = new System.Drawing.Point(0, 0);
        this.Header.Margin = new System.Windows.Forms.Padding(48, 23, 48, 23);
        this.Header.Name = "Header";
        this.Header.Size = new System.Drawing.Size(577, 39);
        this.Header.TabIndex = 1;
        this.Header.Text = "(Header)";
        this.AddressTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25f, System.Drawing.FontStyle.Bold);
        this.AddressTitleLabel.Location = new System.Drawing.Point(10, 125);
        this.AddressTitleLabel.Name = "AddressTitleLabel";
        this.AddressTitleLabel.Size = new System.Drawing.Size(105, 40);
        this.AddressTitleLabel.TabIndex = 0;
        this.AddressTitleLabel.TabStop = false;
        this.AddressTitleLabel.Text = "Address:";
        this.AddressTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        base.AutoScaleDimensions = new System.Drawing.SizeF(96f, 96f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        base.ClientSize = new System.Drawing.Size(587, 248);
        base.ControlBox = false;
        base.Controls.Add(this.BorderPanel);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        base.KeyPreview = true;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "WebAccountInfoDialog";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.BorderPanel.ResumeLayout(false);
        this.ContentPanel.ResumeLayout(false);
        base.ResumeLayout(false);
    }
    #endregion

    private GradientPanel BorderPanel;
    private GradientPanel ContentPanel;
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