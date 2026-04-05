using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI.Dialogs
{
    partial class TextToBase64Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToBase64Dialog));
            ContainerPanel = new TemplatedGradientPanel();
            ClearButton = new TemplatedButton();
            ResultText = new TextBox();
            OriginalText = new TextBox();
            PromptLabel = new Label();
            ConvertButton = new TemplatedButton();
            CopyButton = new TemplatedButton();
            CloseButton = new TemplatedButton();
            Header = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            BorderPanel = new TemplatedGradientPanel();
            ttp = new ToolTip(components);
            ContainerPanel.SuspendLayout();
            BorderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(ClearButton);
            ContainerPanel.Controls.Add(ResultText);
            ContainerPanel.Controls.Add(OriginalText);
            ContainerPanel.Controls.Add(PromptLabel);
            ContainerPanel.Controls.Add(ConvertButton);
            ContainerPanel.Controls.Add(CopyButton);
            ContainerPanel.Controls.Add(CloseButton);
            ContainerPanel.Controls.Add(Header);
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(5, 5);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(790, 392);
            ContainerPanel.TabIndex = 0;
            ContainerPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\General Background.panel.template.json";
            ContainerPanel.TemplateJson = resources.GetString("ContainerPanel.TemplateJson");
            // 
            // ClearButton
            // 
            ClearButton.Checked = false;
            ClearButton.Image = (Image)resources.GetObject("ClearButton.Image");
            ClearButton.ImageAlign = ContentAlignment.MiddleLeft;
            ClearButton.Location = new Point(660, 132);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(125, 40);
            ClearButton.TabIndex = 4;
            ClearButton.TemplateFromFile = null;
            ClearButton.TemplateJson = resources.GetString("ClearButton.TemplateJson");
            ClearButton.Text = "C&lear";
            ttp.SetToolTip(ClearButton, "Click to clear the text content on the dialog.");
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ResultText
            // 
            ResultText.BackColor = Color.LightGray;
            ResultText.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultText.Location = new Point(10, 231);
            ResultText.Margin = new Padding(4);
            ResultText.Multiline = true;
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(644, 155);
            ResultText.TabIndex = 5;
            ttp.SetToolTip(ResultText, "This is the converted text in base-64 format, ready to be copied to the clipboard.");
            // 
            // OriginalText
            // 
            OriginalText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OriginalText.Location = new Point(10, 86);
            OriginalText.Margin = new Padding(4);
            OriginalText.Multiline = true;
            OriginalText.Name = "OriginalText";
            OriginalText.Size = new Size(644, 134);
            OriginalText.TabIndex = 2;
            ttp.SetToolTip(OriginalText, "Enter the text to be converted here.");
            // 
            // PromptLabel
            // 
            PromptLabel.AutoSize = true;
            PromptLabel.BackColor = Color.Transparent;
            PromptLabel.Location = new Point(10, 65);
            PromptLabel.Margin = new Padding(4, 0, 4, 0);
            PromptLabel.Name = "PromptLabel";
            PromptLabel.Size = new Size(68, 17);
            PromptLabel.TabIndex = 1;
            PromptLabel.Text = "&Enter Text:";
            // 
            // ConvertButton
            // 
            ConvertButton.Checked = false;
            ConvertButton.Image = (Image)resources.GetObject("ConvertButton.Image");
            ConvertButton.ImageAlign = ContentAlignment.MiddleLeft;
            ConvertButton.Location = new Point(660, 86);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(125, 40);
            ConvertButton.TabIndex = 3;
            ConvertButton.TemplateFromFile = null;
            ConvertButton.TemplateJson = resources.GetString("ConvertButton.TemplateJson");
            ConvertButton.Text = "Con&vert";
            ttp.SetToolTip(ConvertButton, "Click to convert the text on the left to base-64 format.");
            ConvertButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            CopyButton.Checked = false;
            CopyButton.ImageAlign = ContentAlignment.MiddleLeft;
            CopyButton.Location = new Point(660, 231);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(125, 40);
            CopyButton.TabIndex = 6;
            CopyButton.TemplateFromFile = null;
            CopyButton.TemplateJson = resources.GetString("CopyButton.TemplateJson");
            CopyButton.Text = "&Copy";
            CopyButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttp.SetToolTip(CopyButton, "Click to copy the converted text on the left to the clipboard.");
            CopyButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            CloseButton.Checked = false;
            CloseButton.Location = new Point(660, 346);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(125, 40);
            CloseButton.TabIndex = 7;
            CloseButton.TemplateFromFile = null;
            CloseButton.TemplateJson = resources.GetString("CloseButton.TemplateJson");
            CloseButton.Text = "Close";
            ttp.SetToolTip(CloseButton, "Close this window.");
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // Header
            // 
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(790, 60);
            Header.TabIndex = 0;
            Header.TitleText = "TEXT TO BASE-64";
            // 
            // BorderPanel
            // 
            BorderPanel.Controls.Add(ContainerPanel);
            BorderPanel.Dock = DockStyle.Fill;
            BorderPanel.Location = new Point(0, 0);
            BorderPanel.Name = "BorderPanel";
            BorderPanel.Padding = new Padding(5);
            BorderPanel.Size = new Size(800, 402);
            BorderPanel.TabIndex = 1;
            BorderPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\Standard Panel.json";
            BorderPanel.TemplateJson = resources.GetString("BorderPanel.TemplateJson");
            // 
            // TextToBase64Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            ControlBox = false;
            Controls.Add(BorderPanel);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TextToBase64Dialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ContainerPanel.ResumeLayout(false);
            ContainerPanel.PerformLayout();
            BorderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TemplatedGradientPanel ContainerPanel;
        private TemplatedButton CloseButton;
        private Controls.VaultDialogHeader Header;
        private TemplatedGradientPanel BorderPanel;
        private TextBox ResultText;
        private TextBox OriginalText;
        private Label PromptLabel;
        private Intelligence.Shared.UI.TemplatedButton ConvertButton;
        private Intelligence.Shared.UI.TemplatedButton CopyButton;
        private TemplatedButton ClearButton;
        private ToolTip ttp;
    }
}