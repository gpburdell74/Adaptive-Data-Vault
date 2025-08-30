namespace Adaptive.Data.Vault.UI
{
    partial class EulaDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EulaDialog));
            ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            EulaPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            TextPanel = new Panel();
            EulaText = new RichTextBox();
            DateLabel = new Adaptive.Intelligence.Shared.UI.AdvancedLabel();
            ButtonsPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
            AgreeCheck = new CheckBox();
            CloseButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
            Header = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            ContainerPanel.SuspendLayout();
            EulaPanel.SuspendLayout();
            TextPanel.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(EulaPanel);
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(0, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Padding = new Padding(10);
            ContainerPanel.Size = new Size(800, 600);
            ContainerPanel.TabIndex = 1;
            ContainerPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
            // 
            // EulaPanel
            // 
            EulaPanel.Controls.Add(TextPanel);
            EulaPanel.Controls.Add(ButtonsPanel);
            EulaPanel.Controls.Add(Header);
            EulaPanel.Dock = DockStyle.Fill;
            EulaPanel.Location = new Point(10, 10);
            EulaPanel.Name = "EulaPanel";
            EulaPanel.Size = new Size(780, 580);
            EulaPanel.TabIndex = 0;
            EulaPanel.TemplateFile = null;
            // 
            // TextPanel
            // 
            TextPanel.Controls.Add(EulaText);
            TextPanel.Controls.Add(DateLabel);
            TextPanel.Dock = DockStyle.Fill;
            TextPanel.Location = new Point(0, 68);
            TextPanel.Name = "TextPanel";
            TextPanel.Padding = new Padding(10);
            TextPanel.Size = new Size(780, 469);
            TextPanel.TabIndex = 2;
            // 
            // EulaText
            // 
            EulaText.BorderStyle = BorderStyle.None;
            EulaText.Dock = DockStyle.Fill;
            EulaText.Location = new Point(10, 27);
            EulaText.Multiline = true;
            EulaText.Name = "EulaText";
            EulaText.ReadOnly = true;
            EulaText.ScrollBars = RichTextBoxScrollBars.Vertical;
            EulaText.Size = new Size(760, 432);
            EulaText.TabIndex = 1;
            EulaText.Text = resources.GetString("EulaText.Text");
            // 
            // DateLabel
            // 
            DateLabel.Dock = DockStyle.Top;
            DateLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(10, 10);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(760, 17);
            DateLabel.TabIndex = 0;
            DateLabel.TabStop = false;
            DateLabel.Text = "Last updated August 01, 2025";
            DateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(AgreeCheck);
            ButtonsPanel.Controls.Add(CloseButton);
            ButtonsPanel.Dock = DockStyle.Bottom;
            ButtonsPanel.Location = new Point(0, 537);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(780, 43);
            ButtonsPanel.TabIndex = 2;
            ButtonsPanel.TemplateFile = null;
            // 
            // AgreeCheck
            // 
            AgreeCheck.AutoSize = true;
            AgreeCheck.Location = new Point(43, 12);
            AgreeCheck.Name = "AgreeCheck";
            AgreeCheck.Size = new Size(221, 21);
            AgreeCheck.TabIndex = 1;
            AgreeCheck.Text = "I agree to the terms listed above.";
            AgreeCheck.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            CloseButton.Checked = false;
            CloseButton.Location = new Point(670, 6);
            CloseButton.Name = "CloseButton";
            CloseButton.ResourceTemplate = Properties.Resources.ButtonStandard;
            CloseButton.Size = new Size(100, 32);
            CloseButton.TabIndex = 0;
            CloseButton.TemplateFile = null;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // Header
            // 
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(780, 68);
            Header.TabIndex = 0;
            Header.TabStop = false;
            Header.TitleText = "END USER LICENSE AGREEMENT";
            // 
            // EulaDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            ControlBox = false;
            Controls.Add(ContainerPanel);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "EulaDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EulaDialog";
            ContainerPanel.ResumeLayout(false);
            EulaPanel.ResumeLayout(false);
            TextPanel.ResumeLayout(false);
            TextPanel.PerformLayout();
            ButtonsPanel.ResumeLayout(false);
            ButtonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Intelligence.Shared.UI.GradientPanel ContainerPanel;
        private Intelligence.Shared.UI.GradientPanel EulaPanel;
        private Panel TextPanel;
        private Intelligence.Shared.UI.GradientPanel ButtonsPanel;
        private Controls.VaultDialogHeader Header;
        private Intelligence.Shared.UI.AdvancedLabel DateLabel;
        private CheckBox AgreeCheck;
        private Intelligence.Shared.UI.TemplatedButton CloseButton;
        private RichTextBox EulaText;
    }
}