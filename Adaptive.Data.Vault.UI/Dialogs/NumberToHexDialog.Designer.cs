using Adaptive.Data.Vault.UI.Properties;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI.Dialogs
{
    partial class NumberToHexDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberToHexDialog));
            SaveCancel = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
            DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            ItemsContainerPanel = new TemplatedGradientPanel();
            HexText = new TextBox();
            NumberText = new IntegerTextBox();
            PromptLabel = new Label();
            ClearButton = new TemplatedButton();
            CopyButton = new TemplatedButton();
            ContainerPanel.SuspendLayout();
            ItemsContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(ItemsContainerPanel);
            ContainerPanel.Controls.Add(DialogHeader);
            ContainerPanel.Size = new Size(499, 264);
            // 
            // SaveCancel
            // 
            SaveCancel.CancelEnabled = true;
            SaveCancel.CancelText = "Close";
            SaveCancel.CancelVisible = true;
            SaveCancel.Dock = DockStyle.Bottom;
            SaveCancel.Font = new Font("Segoe UI", 9.75F);
            SaveCancel.Location = new Point(0, 143);
            SaveCancel.Margin = new Padding(48, 22, 48, 22);
            SaveCancel.Name = "SaveCancel";
            SaveCancel.SaveEnabled = false;
            SaveCancel.SaveText = "Copy";
            SaveCancel.SaveVisible = false;
            SaveCancel.Size = new Size(489, 48);
            SaveCancel.TabIndex = 6;
            // 
            // DialogHeader
            // 
            DialogHeader.Dock = DockStyle.Top;
            DialogHeader.Location = new Point(5, 5);
            DialogHeader.Name = "DialogHeader";
            DialogHeader.Size = new Size(489, 63);
            DialogHeader.TabIndex = 0;
            DialogHeader.TabStop = false;
            DialogHeader.TitleText = "NUMBER TO HEX CONVERTER";
            // 
            // ItemsContainerPanel
            // 
            ItemsContainerPanel.Controls.Add(HexText);
            ItemsContainerPanel.Controls.Add(NumberText);
            ItemsContainerPanel.Controls.Add(PromptLabel);
            ItemsContainerPanel.Controls.Add(ClearButton);
            ItemsContainerPanel.Controls.Add(CopyButton);
            ItemsContainerPanel.Controls.Add(SaveCancel);
            ItemsContainerPanel.Dock = DockStyle.Fill;
            ItemsContainerPanel.Location = new Point(5, 68);
            ItemsContainerPanel.Name = "ItemsContainerPanel";
            ItemsContainerPanel.Size = new Size(489, 191);
            ItemsContainerPanel.TabIndex = 1;
            ItemsContainerPanel.TemplateFromFile = null;
            ItemsContainerPanel.TemplateJson = null;
            // 
            // HexText
            // 
            HexText.BackColor = Color.LightGray;
            HexText.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HexText.Location = new Point(13, 89);
            HexText.Margin = new Padding(4);
            HexText.Name = "HexText";
            HexText.Size = new Size(332, 46);
            HexText.TabIndex = 4;
            // 
            // NumberText
            // 
            NumberText.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumberText.Location = new Point(13, 35);
            NumberText.Margin = new Padding(4);
            NumberText.Name = "NumberText";
            NumberText.Size = new Size(332, 46);
            NumberText.TabIndex = 2;
            NumberText.Text = "0";
            // 
            // PromptLabel
            // 
            PromptLabel.AutoSize = true;
            PromptLabel.BackColor = Color.Transparent;
            PromptLabel.Location = new Point(10, 10);
            PromptLabel.Margin = new Padding(4, 0, 4, 0);
            PromptLabel.Name = "PromptLabel";
            PromptLabel.Size = new Size(164, 21);
            PromptLabel.TabIndex = 1;
            PromptLabel.Text = "&Enter an integer value:";
            // 
            // ClearButton
            // 
            ClearButton.Checked = false;
            ClearButton.ImageAlign = ContentAlignment.MiddleLeft;
            ClearButton.Location = new Point(352, 35);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(130, 46);
            ClearButton.TabIndex = 3;
            ClearButton.TemplateFromFile = null;
            ClearButton.TemplateJson = resources.GetString("ClearButton.TemplateJson");
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            CopyButton.Checked = false;
            CopyButton.ImageAlign = ContentAlignment.MiddleLeft;
            CopyButton.Location = new Point(352, 89);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(130, 46);
            CopyButton.TabIndex = 5;
            CopyButton.TemplateFromFile = null;
            CopyButton.TemplateJson = resources.GetString("CopyButton.TemplateJson");
            CopyButton.Text = "&Copy";
            CopyButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CopyButton.UseVisualStyleBackColor = true;
            // 
            // NumberToHexDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 264);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(62, 27, 62, 27);
            Name = "NumberToHexDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            ContainerPanel.ResumeLayout(false);
            ItemsContainerPanel.ResumeLayout(false);
            ItemsContainerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.SaveCancelBar SaveCancel;
        private Controls.VaultDialogHeader DialogHeader;
        private TemplatedGradientPanel ItemsContainerPanel;
        private TextBox HexText;
        private IntegerTextBox NumberText;
        private Label PromptLabel;
        private TemplatedButton ClearButton;
        private TemplatedButton CopyButton;
    }
}