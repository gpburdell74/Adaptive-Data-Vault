using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI.Controls
{
    partial class SaveCancelBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveCancelBar));
            ContainerPanel = new TemplatedGradientPanel();
            ButtonPanel = new TemplatedGradientPanel();
            SaveButton = new TemplatedButton();
            SpacerPanel = new Panel();
            CancelButton = new TemplatedButton();
            ContainerPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(ButtonPanel);
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(0, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(1039, 48);
            ContainerPanel.TabIndex = 0;
            ContainerPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\Save Cancel Panel.panel.template.json";
            ContainerPanel.TemplateJson = resources.GetString("ContainerPanel.TemplateJson");
            // 
            // ButtonPanel
            // 
            ButtonPanel.BackColor = Color.Transparent;
            ButtonPanel.Controls.Add(SaveButton);
            ButtonPanel.Controls.Add(SpacerPanel);
            ButtonPanel.Controls.Add(CancelButton);
            ButtonPanel.Dock = DockStyle.Right;
            ButtonPanel.Location = new Point(782, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Padding = new Padding(5);
            ButtonPanel.Size = new Size(257, 48);
            ButtonPanel.TabIndex = 0;
            ButtonPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\General Background.panel.template.json";
            ButtonPanel.TemplateJson = resources.GetString("ButtonPanel.TemplateJson");
            // 
            // SaveButton
            // 
            SaveButton.Checked = false;
            SaveButton.Dock = DockStyle.Right;
            SaveButton.Image = (Image)resources.GetObject("SaveButton.Image");
            SaveButton.ImageAlign = ContentAlignment.MiddleLeft;
            SaveButton.Location = new Point(7, 5);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(120, 38);
            SaveButton.TabIndex = 2;
            SaveButton.TemplateFromFile = null;
            SaveButton.TemplateJson = resources.GetString("SaveButton.TemplateJson");
            SaveButton.Text = "Save";
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // SpacerPanel
            // 
            SpacerPanel.BackColor = Color.Transparent;
            SpacerPanel.Dock = DockStyle.Right;
            SpacerPanel.Location = new Point(127, 5);
            SpacerPanel.Name = "SpacerPanel";
            SpacerPanel.Size = new Size(5, 38);
            SpacerPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            CancelButton.Checked = false;
            CancelButton.Dock = DockStyle.Right;
            CancelButton.Image = Properties.Resources.Cancel_16x16;
            CancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            CancelButton.Location = new Point(132, 5);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(120, 38);
            CancelButton.TabIndex = 0;
            CancelButton.TemplateFromFile = null;
            CancelButton.TemplateJson = resources.GetString("CancelButton.TemplateJson");
            CancelButton.Text = "Cancel";
            CancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveCancelBar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContainerPanel);
            Name = "SaveCancelBar";
            Size = new Size(1039, 48);
            ContainerPanel.ResumeLayout(false);
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TemplatedGradientPanel ContainerPanel;
        private TemplatedGradientPanel ButtonPanel;
        private Intelligence.Shared.UI.TemplatedButton SaveButton;
        private Panel SpacerPanel;
        private Intelligence.Shared.UI.TemplatedButton CancelButton;
    }
}
