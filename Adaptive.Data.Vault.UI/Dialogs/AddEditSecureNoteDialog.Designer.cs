namespace Adaptive.Data.Vault.UI
{
    partial class AddEditSecureNoteDialog
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
            SecureNoteEdit = new EditSecureNoteControl();
            ContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(SecureNoteEdit);
            ContainerPanel.Controls.Add(SaveCancel);
            ContainerPanel.Controls.Add(DialogHeader);
            ContainerPanel.Size = new Size(800, 435);
            // 
            // SaveCancel
            // 
            SaveCancel.CancelEnabled = true;
            SaveCancel.CancelText = "Cancel";
            SaveCancel.CancelVisible = true;
            SaveCancel.Dock = DockStyle.Bottom;
            SaveCancel.Font = new Font("Segoe UI", 9.75F);
            SaveCancel.Location = new Point(5, 382);
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
            DialogHeader.TitleText = "SECURE NOTE";
            // 
            // SecureNoteEdit
            // 
            SecureNoteEdit.Dock = DockStyle.Fill;
            SecureNoteEdit.Font = new Font("Segoe UI", 9.75F);
            SecureNoteEdit.Location = new Point(5, 75);
            SecureNoteEdit.Name = "SecureNoteEdit";
            SecureNoteEdit.Padding = new Padding(0, 10, 0, 0);
            SecureNoteEdit.Size = new Size(790, 307);
            SecureNoteEdit.TabIndex = 0;
            // 
            // AddEditSecureNoteDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 435);
            ForeColor = Color.Black;
            Margin = new Padding(5);
            Name = "AddEditSecureNoteDialog";
            ContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.SaveCancelBar SaveCancel;
        private Controls.VaultDialogHeader DialogHeader;
        private EditSecureNoteControl SecureNoteEdit;
    }
}