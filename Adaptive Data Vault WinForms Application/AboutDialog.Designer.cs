namespace Adaptive.Data.Vault.UI
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            ContentPanel = new Panel();
            WarningLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            SiteLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            SiteTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            EmailLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            BottomLine = new Adaptive.Intelligence.Shared.UI.LineControl();
            TopLine = new Adaptive.Intelligence.Shared.UI.LineControl();
            CloseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
            EmailTitleLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            FrameworkAllrightsLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            FrameworkCopyrightLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            FrameworkVersionLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            FrameworkNameLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            AppAllrightsLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            AppCopyrightLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            AppVersionLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            AppNameLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            ContainerPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(ContentPanel);
            ContainerPanel.Padding = new Padding(5, 6, 5, 6);
            ContainerPanel.Size = new Size(650, 273);
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(WarningLabel);
            ContentPanel.Controls.Add(SiteLabel);
            ContentPanel.Controls.Add(SiteTitleLabel);
            ContentPanel.Controls.Add(EmailLabel);
            ContentPanel.Controls.Add(BottomLine);
            ContentPanel.Controls.Add(TopLine);
            ContentPanel.Controls.Add(CloseButton);
            ContentPanel.Controls.Add(EmailTitleLabel);
            ContentPanel.Controls.Add(FrameworkAllrightsLabel);
            ContentPanel.Controls.Add(FrameworkCopyrightLabel);
            ContentPanel.Controls.Add(FrameworkVersionLabel);
            ContentPanel.Controls.Add(FrameworkNameLabel);
            ContentPanel.Controls.Add(AppAllrightsLabel);
            ContentPanel.Controls.Add(AppCopyrightLabel);
            ContentPanel.Controls.Add(AppVersionLabel);
            ContentPanel.Controls.Add(AppNameLabel);
            ContentPanel.Controls.Add(DialogHeader);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(5, 6);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(640, 261);
            ContentPanel.TabIndex = 0;
            // 
            // WarningLabel
            // 
            WarningLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WarningLabel.Location = new Point(10, 208);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(494, 46);
            WarningLabel.TabIndex = 15;
            WarningLabel.TabStop = false;
            WarningLabel.Text = resources.GetString("WarningLabel.Text");
            WarningLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SiteLabel
            // 
            SiteLabel.AutoSize = true;
            SiteLabel.Cursor = Cursors.Hand;
            SiteLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            SiteLabel.ForeColor = Color.Blue;
            SiteLabel.Location = new Point(234, 176);
            SiteLabel.Name = "SiteLabel";
            SiteLabel.Size = new Size(216, 17);
            SiteLabel.TabIndex = 13;
            SiteLabel.TabStop = false;
            SiteLabel.Text = "https://samjones.azurewebsites.net/";
            SiteLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // SiteTitleLabel
            // 
            SiteTitleLabel.AutoSize = true;
            SiteTitleLabel.Font = new Font("Segoe UI", 9.75F);
            SiteTitleLabel.Location = new Point(171, 176);
            SiteTitleLabel.Name = "SiteTitleLabel";
            SiteTitleLabel.Size = new Size(57, 17);
            SiteTitleLabel.TabIndex = 12;
            SiteTitleLabel.TabStop = false;
            SiteTitleLabel.Text = "Website:";
            SiteTitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Cursor = Cursors.Hand;
            EmailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.Blue;
            EmailLabel.Location = new Point(234, 153);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(163, 17);
            EmailLabel.TabIndex = 11;
            EmailLabel.TabStop = false;
            EmailLabel.Text = "gpburdell74@outlook.com";
            EmailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BottomLine
            // 
            BottomLine.BevelBottomColor = SystemColors.ControlLight;
            BottomLine.BevelTopColor = SystemColors.ControlDark;
            BottomLine.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            BottomLine.EndColor = Color.Blue;
            BottomLine.LineWidth = 2;
            BottomLine.Location = new Point(20, 200);
            BottomLine.Mode = Intelligence.Shared.UI.LineControlMode.Line;
            BottomLine.Name = "BottomLine";
            BottomLine.Orientation = Intelligence.Shared.UI.LineControlOrientation.Horizontal;
            BottomLine.Size = new Size(600, 2);
            BottomLine.StartColor = Color.Lime;
            BottomLine.TabIndex = 14;
            BottomLine.TabStop = false;
            // 
            // TopLine
            // 
            TopLine.BevelBottomColor = SystemColors.ControlLight;
            TopLine.BevelTopColor = SystemColors.ControlDark;
            TopLine.Direction = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            TopLine.EndColor = Color.Lime;
            TopLine.LineWidth = 2;
            TopLine.Location = new Point(20, 145);
            TopLine.Mode = Intelligence.Shared.UI.LineControlMode.Line;
            TopLine.Name = "TopLine";
            TopLine.Orientation = Intelligence.Shared.UI.LineControlOrientation.Horizontal;
            TopLine.Size = new Size(600, 2);
            TopLine.StartColor = Color.Blue;
            TopLine.TabIndex = 9;
            TopLine.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Checked = false;
            CloseButton.Location = new Point(520, 220);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(108, 32);
            CloseButton.TabIndex = 16;
            CloseButton.TemplateFile = null;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // EmailTitleLabel
            // 
            EmailTitleLabel.AutoSize = true;
            EmailTitleLabel.Font = new Font("Segoe UI", 9.75F);
            EmailTitleLabel.Location = new Point(20, 153);
            EmailTitleLabel.Name = "EmailTitleLabel";
            EmailTitleLabel.Size = new Size(208, 17);
            EmailTitleLabel.TabIndex = 10;
            EmailTitleLabel.TabStop = false;
            EmailTitleLabel.Text = "Send Suggestions / Comments To:";
            EmailTitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrameworkAllrightsLabel
            // 
            FrameworkAllrightsLabel.AutoSize = true;
            FrameworkAllrightsLabel.Font = new Font("Segoe UI", 9.75F);
            FrameworkAllrightsLabel.Location = new Point(425, 125);
            FrameworkAllrightsLabel.Name = "FrameworkAllrightsLabel";
            FrameworkAllrightsLabel.Size = new Size(117, 17);
            FrameworkAllrightsLabel.TabIndex = 8;
            FrameworkAllrightsLabel.TabStop = false;
            FrameworkAllrightsLabel.Text = "All rights reserved.";
            FrameworkAllrightsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrameworkCopyrightLabel
            // 
            FrameworkCopyrightLabel.AutoSize = true;
            FrameworkCopyrightLabel.Font = new Font("Segoe UI", 9.75F);
            FrameworkCopyrightLabel.Location = new Point(425, 110);
            FrameworkCopyrightLabel.Name = "FrameworkCopyrightLabel";
            FrameworkCopyrightLabel.Size = new Size(172, 17);
            FrameworkCopyrightLabel.TabIndex = 7;
            FrameworkCopyrightLabel.TabStop = false;
            FrameworkCopyrightLabel.Text = "© 2024-2026 by Sam Jones.";
            FrameworkCopyrightLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrameworkVersionLabel
            // 
            FrameworkVersionLabel.AutoSize = true;
            FrameworkVersionLabel.Font = new Font("Segoe UI", 9.75F);
            FrameworkVersionLabel.Location = new Point(425, 95);
            FrameworkVersionLabel.Name = "FrameworkVersionLabel";
            FrameworkVersionLabel.Size = new Size(92, 17);
            FrameworkVersionLabel.TabIndex = 6;
            FrameworkVersionLabel.TabStop = false;
            FrameworkVersionLabel.Text = "Version 0.0.0.0";
            FrameworkVersionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrameworkNameLabel
            // 
            FrameworkNameLabel.AutoSize = true;
            FrameworkNameLabel.Font = new Font("Segoe UI", 9.75F);
            FrameworkNameLabel.Location = new Point(425, 80);
            FrameworkNameLabel.Name = "FrameworkNameLabel";
            FrameworkNameLabel.Size = new Size(196, 17);
            FrameworkNameLabel.TabIndex = 5;
            FrameworkNameLabel.TabStop = false;
            FrameworkNameLabel.Text = "Adaptive Intelligence Framework";
            FrameworkNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // AppAllrightsLabel
            // 
            AppAllrightsLabel.AutoSize = true;
            AppAllrightsLabel.Font = new Font("Segoe UI", 9.75F);
            AppAllrightsLabel.Location = new Point(20, 125);
            AppAllrightsLabel.Name = "AppAllrightsLabel";
            AppAllrightsLabel.Size = new Size(117, 17);
            AppAllrightsLabel.TabIndex = 4;
            AppAllrightsLabel.TabStop = false;
            AppAllrightsLabel.Text = "All rights reserved.";
            AppAllrightsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // AppCopyrightLabel
            // 
            AppCopyrightLabel.AutoSize = true;
            AppCopyrightLabel.Font = new Font("Segoe UI", 9.75F);
            AppCopyrightLabel.Location = new Point(20, 110);
            AppCopyrightLabel.Name = "AppCopyrightLabel";
            AppCopyrightLabel.Size = new Size(172, 17);
            AppCopyrightLabel.TabIndex = 3;
            AppCopyrightLabel.TabStop = false;
            AppCopyrightLabel.Text = "© 2025-2026 by Sam Jones.";
            AppCopyrightLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // AppVersionLabel
            // 
            AppVersionLabel.AutoSize = true;
            AppVersionLabel.Font = new Font("Segoe UI", 9.75F);
            AppVersionLabel.Location = new Point(20, 95);
            AppVersionLabel.Name = "AppVersionLabel";
            AppVersionLabel.Size = new Size(92, 17);
            AppVersionLabel.TabIndex = 2;
            AppVersionLabel.TabStop = false;
            AppVersionLabel.Text = "Version 0.0.0.0";
            AppVersionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // AppNameLabel
            // 
            AppNameLabel.AutoSize = true;
            AppNameLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppNameLabel.Location = new Point(20, 80);
            AppNameLabel.Name = "AppNameLabel";
            AppNameLabel.Shadow = true;
            AppNameLabel.Size = new Size(274, 19);
            AppNameLabel.TabIndex = 1;
            AppNameLabel.TabStop = false;
            AppNameLabel.Text = "Adaptive Intelligence - Adaptive Data Vault ";
            AppNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DialogHeader
            // 
            DialogHeader.Dock = DockStyle.Top;
            DialogHeader.Location = new Point(0, 0);
            DialogHeader.Name = "DialogHeader";
            DialogHeader.Size = new Size(640, 64);
            DialogHeader.TabIndex = 0;
            DialogHeader.TitleText = "ADAPTIVE DATA VAULT";
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 273);
            Margin = new Padding(48, 25, 48, 25);
            Name = "AboutDialog";
            Text = "AboutDialog";
            ContainerPanel.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Intelligence.Shared.UI.TemplatedButton CloseButton;
        private Intelligence.Shared.UI.AdvancedLabel EmailTitleLabel;
        private Intelligence.Shared.UI.AdvancedLabel FrameworkAllrightsLabel;
        private Intelligence.Shared.UI.AdvancedLabel FrameworkCopyrightLabel;
        private Intelligence.Shared.UI.AdvancedLabel FrameworkVersionLabel;
        private Intelligence.Shared.UI.AdvancedLabel FrameworkNameLabel;
        private Intelligence.Shared.UI.AdvancedLabel AppAllrightsLabel;
        private Intelligence.Shared.UI.AdvancedLabel AppCopyrightLabel;
        private Intelligence.Shared.UI.AdvancedLabel AppVersionLabel;
        private Intelligence.Shared.UI.AdvancedLabel AppNameLabel;
        private Controls.VaultDialogHeader DialogHeader;
        private Intelligence.Shared.UI.AdvancedLabel SiteTitleLabel;
        private Intelligence.Shared.UI.AdvancedLabel EmailLabel;
        private Intelligence.Shared.UI.LineControl BottomLine;
        private Intelligence.Shared.UI.LineControl TopLine;
        private Intelligence.Shared.UI.AdvancedLabel WarningLabel;
        private Intelligence.Shared.UI.AdvancedLabel SiteLabel;
    }
}