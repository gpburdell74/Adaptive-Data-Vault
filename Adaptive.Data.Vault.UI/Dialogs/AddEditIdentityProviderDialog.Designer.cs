namespace Adaptive.Data.Vault.UI
{
    partial class AddEditIdentityProviderDialog
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
            IdProviderEdit = new EditIdentityProviderControl();
            ContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(IdProviderEdit);
            ContainerPanel.Controls.Add(SaveCancel);
            ContainerPanel.Controls.Add(DialogHeader);
            ContainerPanel.Size = new Size(800, 405);
            // 
            // SaveCancel
            // 
            SaveCancel.CancelEnabled = true;
            SaveCancel.CancelText = "Cancel";
            SaveCancel.CancelVisible = true;
            SaveCancel.Dock = DockStyle.Bottom;
            SaveCancel.Font = new Font("Segoe UI", 9.75F);
            SaveCancel.Location = new Point(5, 352);
            SaveCancel.Margin = new Padding(48, 22, 48, 22);
            SaveCancel.Name = "SaveCancel";
            SaveCancel.SaveEnabled = true;
            SaveCancel.SaveText = "Save";
            SaveCancel.SaveVisible = true;
            SaveCancel.Size = new Size(790, 48);
            SaveCancel.TabIndex = 1;
            // 
            // DialogHeader
            // 
            DialogHeader.Dock = DockStyle.Top;
            DialogHeader.Location = new Point(5, 5);
            DialogHeader.Name = "DialogHeader";
            DialogHeader.Size = new Size(790, 70);
            DialogHeader.TabIndex = 2;
            DialogHeader.TitleText = "IDENTITY PROVIDER";
            // 
            // IdProviderEdit
            // 
            IdProviderEdit.Dock = DockStyle.Fill;
            IdProviderEdit.Font = new Font("Segoe UI", 9.75F);
            IdProviderEdit.Location = new Point(5, 75);
            IdProviderEdit.Name = "IdProviderEdit";
            IdProviderEdit.Padding = new Padding(0, 10, 0, 0);
            IdProviderEdit.Size = new Size(790, 277);
            IdProviderEdit.TabIndex = 0;
            // 
            // AddEditIdentityProviderDialog
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 405);
            Name = "AddEditIdentityProviderDialog";
            ContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.SaveCancelBar SaveCancel;
        private Controls.VaultDialogHeader DialogHeader;
        private EditIdentityProviderControl IdProviderEdit;
    }
}