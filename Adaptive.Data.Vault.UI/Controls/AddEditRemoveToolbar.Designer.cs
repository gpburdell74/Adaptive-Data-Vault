using Adaptive.Intelligence.Shared.UI;
using Adaptive.Intelligence.Shared.UI.Controls;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Adaptive.Data.Vault.UI
{
    partial class AddEditRemoveToolbar
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
            AddButton = new TemplatedButton();
            EditButton = new TemplatedButton();
            RemoveButton = new TemplatedButton();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Checked = false;
            AddButton.Image = Properties.Resources.Add16x16;
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.ResourceTemplate = null;
            AddButton.Size = new Size(100, 25);
            AddButton.TabIndex = 0;
            AddButton.TemplateFile = null;
            AddButton.Text = "&Add Entry";
            AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
            AddButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Checked = false;
            EditButton.Enabled = false;
            EditButton.ImageAlign = ContentAlignment.MiddleLeft;
            EditButton.Location = new Point(109, 3);
            EditButton.Name = "EditButton";
            EditButton.ResourceTemplate = null;
            EditButton.Size = new Size(100, 25);
            EditButton.TabIndex = 1;
            EditButton.TemplateFile = null;
            EditButton.Text = "&Edit Entry";
            EditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
            EditButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Checked = false;
            RemoveButton.Enabled = false;
            RemoveButton.ImageAlign = ContentAlignment.MiddleLeft;
            RemoveButton.Location = new Point(215, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.ResourceTemplate = null;
            RemoveButton.Size = new Size(112, 25);
            RemoveButton.TabIndex = 2;
            RemoveButton.TemplateFile = null;
            RemoveButton.Text = "&Remove Entry";
            RemoveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RemoveButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddEditRemoveToolbar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RemoveButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Margin = new Padding(3);
            MaximumSize = new Size(0, 32);
            MinimumSize = new Size(332, 32);
            Name = "AddEditRemoveToolbar";
            Size = new Size(332, 32);
            ResumeLayout(false);
        }

        #endregion

        private TemplatedButton AddButton;
        private TemplatedButton EditButton;
        private TemplatedButton RemoveButton;
    }
}