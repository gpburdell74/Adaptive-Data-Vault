namespace Adaptive.Data.Vault.UI
{
    partial class ReleaseNotesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseNotesDialog));
            vaultDialogHeader1 = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
            SaveCancelBar = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
            DataText = new TextBox();
            ContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContainerPanel
            // 
            ContainerPanel.Controls.Add(DataText);
            ContainerPanel.Controls.Add(SaveCancelBar);
            ContainerPanel.Controls.Add(vaultDialogHeader1);
            ContainerPanel.Size = new Size(800, 600);
            // 
            // vaultDialogHeader1
            // 
            vaultDialogHeader1.Dock = DockStyle.Top;
            vaultDialogHeader1.Location = new Point(5, 5);
            vaultDialogHeader1.Name = "vaultDialogHeader1";
            vaultDialogHeader1.Size = new Size(790, 64);
            vaultDialogHeader1.TabIndex = 0;
            vaultDialogHeader1.TitleText = "RELEASE NOTES";
            // 
            // SaveCancelBar
            // 
            SaveCancelBar.CancelEnabled = true;
            SaveCancelBar.CancelText = "Close";
            SaveCancelBar.CancelVisible = true;
            SaveCancelBar.Dock = DockStyle.Bottom;
            SaveCancelBar.Font = new Font("Segoe UI", 9.75F);
            SaveCancelBar.Location = new Point(5, 547);
            SaveCancelBar.Margin = new Padding(48, 22, 48, 22);
            SaveCancelBar.Name = "SaveCancelBar";
            SaveCancelBar.SaveEnabled = true;
            SaveCancelBar.SaveText = "Save";
            SaveCancelBar.SaveVisible = false;
            SaveCancelBar.Size = new Size(790, 48);
            SaveCancelBar.TabIndex = 1;
            // 
            // DataText
            // 
            DataText.Dock = DockStyle.Fill;
            DataText.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataText.Location = new Point(5, 69);
            DataText.Multiline = true;
            DataText.Name = "DataText";
            DataText.ReadOnly = true;
            DataText.ScrollBars = ScrollBars.Both;
            DataText.Size = new Size(790, 478);
            DataText.TabIndex = 2;
            DataText.Text = resources.GetString("DataText.Text");
            // 
            // ReleaseNotesDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Name = "ReleaseNotesDialog";
            Text = "ReleaseNotesDialog";
            ContainerPanel.ResumeLayout(false);
            ContainerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox DataText;
        private Controls.SaveCancelBar SaveCancelBar;
        private Controls.VaultDialogHeader vaultDialogHeader1;
    }
}