using Adaptive.Data.Vault.UI.Controls;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI
{
    partial class SecureEraseFileDialog
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
            this.BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            this.ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            this.CloseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
            this.DeleteButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
            this.StatusPrg = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            this.BrowseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
            this.FileText = new System.Windows.Forms.TextBox();
            this.FileLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            this.Header = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            this.BorderPanel.SuspendLayout();
            this.ContainerPanel.SuspendLayout();
            base.SuspendLayout();
            this.BorderPanel.Controls.Add(this.ContainerPanel);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Padding = new System.Windows.Forms.Padding(5);
            this.BorderPanel.Size = new System.Drawing.Size(750, 263);
            this.BorderPanel.TabIndex = 0;
            this.BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
            this.ContainerPanel.Controls.Add(this.CloseButton);
            this.ContainerPanel.Controls.Add(this.DeleteButton);
            this.ContainerPanel.Controls.Add(this.StatusPrg);
            this.ContainerPanel.Controls.Add(this.StatusLabel);
            this.ContainerPanel.Controls.Add(this.BrowseButton);
            this.ContainerPanel.Controls.Add(this.FileText);
            this.ContainerPanel.Controls.Add(this.FileLabel);
            this.ContainerPanel.Controls.Add(this.Header);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(5, 5);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(740, 253);
            this.ContainerPanel.TabIndex = 0;
            this.ContainerPanel.TemplateFile = null;
            this.CloseButton.Checked = false;
            this.CloseButton.Location = new System.Drawing.Point(632, 205);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 40);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.ResourceTemplate = Properties.Resources.ButtonTemplateCancel;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Checked = false;
            this.DeleteButton.Enabled = false;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(471, 205);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(155, 40);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.ResourceTemplate = Properties.Resources.ButtonTemplateDelete;
            this.DeleteButton.Text = "Secure Delete";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.StatusPrg.Location = new System.Drawing.Point(115, 142);
            this.StatusPrg.Name = "StatusPrg";
            this.StatusPrg.Size = new System.Drawing.Size(617, 23);
            this.StatusPrg.TabIndex = 6;
            this.StatusPrg.Visible = false;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75f);
            this.StatusLabel.Location = new System.Drawing.Point(115, 119);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(53, 17);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.TabStop = false;
            this.StatusLabel.Text = "Ready...";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusLabel.Visible = false;
            this.BrowseButton.Checked = false;
            this.BrowseButton.Location = new System.Drawing.Point(692, 76);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(40, 25);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.FileText.Location = new System.Drawing.Point(115, 76);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(575, 25);
            this.FileText.TabIndex = 2;
            this.FileLabel.Font = new System.Drawing.Font("Segoe UI", 9.75f);
            this.FileLabel.Location = new System.Drawing.Point(9, 76);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(100, 25);
            this.FileLabel.TabIndex = 1;
            this.FileLabel.TabStop = false;
            this.FileLabel.Text = "Specify &File:";
            this.FileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(740, 60);
            this.Header.TabIndex = 0;
            this.Header.TitleText = "SECURE DELETE";
            base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(750, 263);
            base.ControlBox = false;
            base.Controls.Add(this.BorderPanel);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            base.KeyPreview = true;
            base.Name = "SecureEraseFileDialog";
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BorderPanel.ResumeLayout(false);
            this.ContainerPanel.ResumeLayout(false);
            this.ContainerPanel.PerformLayout();
            base.ResumeLayout(false);
        }
        #endregion

        private GradientPanel BorderPanel;
        private GradientPanel ContainerPanel;
        private VaultDialogHeader Header;
        private ProgressBar StatusPrg;
        private AdvancedLabel StatusLabel;
        private TemplatedButton BrowseButton;
        private TextBox FileText;
        private AdvancedLabel FileLabel;
        private TemplatedButton CloseButton;
        private TemplatedButton DeleteButton;

    }
}