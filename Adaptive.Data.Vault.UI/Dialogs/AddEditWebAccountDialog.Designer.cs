using Adaptive.Data.Vault.UI.Controls;

namespace Adaptive.Data.Vault.UI;

partial class AddEditWebAccountDialog
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
        ErrorProvider = new ErrorProvider(components);
        ttp = new ToolTip(components);
        DialogHeader = new VaultDialogHeader();
        SaveCancel = new SaveCancelBar();
        WebEdit = new EditWebAccountControl();
        ContainerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(WebEdit);
        ContainerPanel.Controls.Add(SaveCancel);
        ContainerPanel.Controls.Add(DialogHeader);
        ContainerPanel.Size = new Size(800, 376);
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // DialogHeader
        // 
        DialogHeader.Dock = DockStyle.Top;
        DialogHeader.Location = new Point(5, 5);
        DialogHeader.Name = "DialogHeader";
        DialogHeader.Size = new Size(790, 70);
        DialogHeader.TabIndex = 3;
        DialogHeader.TitleText = "WEB ACCOUNT";
        // 
        // SaveCancel
        // 
        SaveCancel.CancelEnabled = true;
        SaveCancel.CancelText = "Cancel";
        SaveCancel.CancelVisible = true;
        SaveCancel.Dock = DockStyle.Bottom;
        SaveCancel.Font = new Font("Segoe UI", 9.75F);
        SaveCancel.Location = new Point(5, 323);
        SaveCancel.Margin = new Padding(48, 22, 48, 22);
        SaveCancel.Name = "SaveCancel";
        SaveCancel.SaveEnabled = true;
        SaveCancel.SaveText = "Save";
        SaveCancel.SaveVisible = true;
        SaveCancel.Size = new Size(790, 48);
        SaveCancel.TabIndex = 4;
        // 
        // WebEdit
        // 
        WebEdit.BackColor = Color.White;
        WebEdit.Dock = DockStyle.Fill;
        WebEdit.Font = new Font("Segoe UI", 9.75F);
        WebEdit.ForeColor = Color.Black;
        WebEdit.Location = new Point(5, 75);
        WebEdit.Margin = new Padding(4, 5, 4, 5);
        WebEdit.Name = "WebEdit";
        WebEdit.Padding = new Padding(0, 10, 0, 0);
        WebEdit.Size = new Size(790, 248);
        WebEdit.TabIndex = 5;
        // 
        // AddEditWebAccountDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 376);
        ForeColor = Color.Black;
        Margin = new Padding(4, 5, 4, 5);
        Name = "AddEditWebAccountDialog";
        ContainerPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ToolTip ttp;
    private ErrorProvider ErrorProvider;
    private EditWebAccountControl WebEdit;
    private SaveCancelBar SaveCancel;
    private VaultDialogHeader DialogHeader;
}