namespace Adaptive.Data.Vault.UI
{
    partial class AddEditCategoryDialog
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
            SaveCancel = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
            DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            CategoryEdit = new EditCategoryControl();
            ContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(CategoryEdit);
            ContainerPanel.Controls.Add(SaveCancel);
            ContainerPanel.Controls.Add(DialogHeader);
            ContainerPanel.Size = new Size(432, 182);
            // 
            // SaveCancel
            // 
            SaveCancel.CancelEnabled = true;
            SaveCancel.CancelText = "Cancel";
            SaveCancel.CancelVisible = true;
            SaveCancel.Dock = DockStyle.Bottom;
            SaveCancel.Font = new Font("Segoe UI", 9.75F);
            SaveCancel.Location = new Point(5, 129);
            SaveCancel.Margin = new Padding(48, 22, 48, 22);
            SaveCancel.Name = "SaveCancel";
            SaveCancel.SaveEnabled = true;
            SaveCancel.SaveText = "Save";
            SaveCancel.SaveVisible = true;
            SaveCancel.Size = new Size(422, 48);
            SaveCancel.TabIndex = 1;
            // 
            // DialogHeader
            // 
            DialogHeader.Dock = DockStyle.Top;
            DialogHeader.Location = new Point(5, 5);
            DialogHeader.Name = "DialogHeader";
            DialogHeader.Size = new Size(422, 70);
            DialogHeader.TabIndex = 2;
            DialogHeader.TitleText = "CATEGORY";
            // 
            // CategoryEdit
            // 
            CategoryEdit.Dock = DockStyle.Fill;
            CategoryEdit.Font = new Font("Segoe UI", 9.75F);
            CategoryEdit.Location = new Point(5, 75);
            CategoryEdit.Name = "CategoryEdit";
            CategoryEdit.Padding = new Padding(0, 10, 0, 0);
            CategoryEdit.Size = new Size(422, 54);
            CategoryEdit.TabIndex = 0;
            // 
            // AddEditCategoryDialog
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(432, 182);
            Name = "AddEditCategoryDialog";
            ContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.SaveCancelBar SaveCancel;
        private Controls.VaultDialogHeader DialogHeader;
        private EditCategoryControl CategoryEdit;
    }
}