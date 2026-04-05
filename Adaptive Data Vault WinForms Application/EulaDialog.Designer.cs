using Adaptive.Intelligence.Shared.UI;

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
            ContainerPanel = new TemplatedGradientPanel();
            EulaPanel = new TemplatedGradientPanel();
            TextPanel = new Panel();
            EulaText = new RichTextBox();
            DateLabel = new AdvancedLabel();
            ButtonsPanel = new TemplatedGradientPanel();
            AgreeCheck = new CheckBox();
            CloseButton = new TemplatedButton();
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
            ContainerPanel.Padding = new Padding(5);
            ContainerPanel.Size = new Size(800, 600);
            ContainerPanel.TabIndex = 1;
            ContainerPanel.TemplateFromFile = null;
            ContainerPanel.TemplateJson = null;
            // 
            // EulaPanel
            // 
            EulaPanel.Controls.Add(TextPanel);
            EulaPanel.Controls.Add(ButtonsPanel);
            EulaPanel.Controls.Add(Header);
            EulaPanel.Dock = DockStyle.Fill;
            EulaPanel.Location = new Point(5, 5);
            EulaPanel.Name = "EulaPanel";
            EulaPanel.Size = new Size(790, 590);
            EulaPanel.TabIndex = 0;
            EulaPanel.TemplateFromFile = null;
            EulaPanel.TemplateJson = null;
            // 
            // TextPanel
            // 
            TextPanel.Controls.Add(EulaText);
            TextPanel.Controls.Add(DateLabel);
            TextPanel.Dock = DockStyle.Fill;
            TextPanel.Location = new Point(0, 68);
            TextPanel.Name = "TextPanel";
            TextPanel.Padding = new Padding(10);
            TextPanel.Size = new Size(790, 479);
            TextPanel.TabIndex = 2;
            // 
            // EulaText
            // 
            EulaText.BorderStyle = BorderStyle.None;
            EulaText.Dock = DockStyle.Fill;
            EulaText.Location = new Point(10, 27);
            EulaText.Name = "EulaText";
            EulaText.ReadOnly = true;
            EulaText.ScrollBars = RichTextBoxScrollBars.Vertical;
            EulaText.Size = new Size(770, 442);
            EulaText.TabIndex = 1;
            EulaText.Text = resources.GetString("EulaText.Text");
            // 
            // DateLabel
            // 
            DateLabel.Dock = DockStyle.Top;
            DateLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(10, 10);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(770, 17);
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
            ButtonsPanel.Location = new Point(0, 547);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(790, 43);
            ButtonsPanel.TabIndex = 2;
            ButtonsPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\General Background.panel.template.json";
            ButtonsPanel.TemplateJson = resources.GetString("ButtonsPanel.TemplateJson");
            // 
            // AgreeCheck
            // 
            AgreeCheck.AutoSize = true;
            AgreeCheck.BackColor = Color.Transparent;
            AgreeCheck.Location = new Point(43, 12);
            AgreeCheck.Name = "AgreeCheck";
            AgreeCheck.Size = new Size(221, 21);
            AgreeCheck.TabIndex = 1;
            AgreeCheck.Text = "I agree to the terms listed above.";
            AgreeCheck.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            CloseButton.Checked = false;
            CloseButton.Location = new Point(662, 6);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(118, 32);
            CloseButton.TabIndex = 0;
            CloseButton.TemplateFromFile = null;
            CloseButton.TemplateJson = resources.GetString("CloseButton.TemplateJson");
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // Header
            // 
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(790, 68);
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
            ButtonsPanel.ResumeLayout(false);
            ButtonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TemplatedGradientPanel ContainerPanel;
        private TemplatedGradientPanel EulaPanel;
        private Panel TextPanel;
        private TemplatedGradientPanel ButtonsPanel;
        private Controls.VaultDialogHeader Header;
        private Intelligence.Shared.UI.AdvancedLabel DateLabel;
        private CheckBox AgreeCheck;
        private Intelligence.Shared.UI.TemplatedButton CloseButton;
        private RichTextBox EulaText;
    }
}