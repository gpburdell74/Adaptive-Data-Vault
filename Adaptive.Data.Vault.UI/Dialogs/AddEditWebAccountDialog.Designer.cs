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
        BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        DialogHeader = new VaultDialogHeader();
        WebEdit = new EditWebAccountControl();
        SaveCancel = new SaveCancelBar();
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
        BorderPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ErrorProvider
        // 
        ErrorProvider.ContainerControl = this;
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(SaveCancel);
        BorderPanel.Controls.Add(WebEdit);
        BorderPanel.Controls.Add(DialogHeader);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(5);
        BorderPanel.Size = new Size(800, 378);
        BorderPanel.TabIndex = 2;
        BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Button.template";
        // 
        // DialogHeader
        // 
        DialogHeader.Dock = DockStyle.Top;
        DialogHeader.Location = new Point(5, 5);
        DialogHeader.Name = "DialogHeader";
        DialogHeader.Size = new Size(790, 70);
        DialogHeader.TabIndex = 1;
        DialogHeader.TitleText = "WEB ACCOUNT";
        // 
        // WebEdit
        // 
        WebEdit.BackColor = Color.White;
        WebEdit.Dock = DockStyle.Top;
        WebEdit.Font = new Font("Segoe UI", 9.75F);
        WebEdit.ForeColor = Color.Black;
        WebEdit.Location = new Point(5, 75);
        WebEdit.Margin = new Padding(4, 5, 4, 5);
        WebEdit.Name = "WebEdit";
        WebEdit.Padding = new Padding(0, 10, 0, 0);
        WebEdit.Size = new Size(790, 250);
        WebEdit.TabIndex = 2;
        // 
        // SaveCancel
        // 
        SaveCancel.CancelEnabled = true;
        SaveCancel.CancelText = "Cancel";
        SaveCancel.CancelVisible = true;
        SaveCancel.Dock = DockStyle.Bottom;
        SaveCancel.Font = new Font("Segoe UI", 9.75F);
        SaveCancel.Location = new Point(5, 325);
        SaveCancel.Margin = new Padding(48, 22, 48, 22);
        SaveCancel.Name = "SaveCancel";
        SaveCancel.SaveEnabled = true;
        SaveCancel.SaveText = "Save";
        SaveCancel.SaveVisible = true;
        SaveCancel.Size = new Size(790, 48);
        SaveCancel.TabIndex = 3;
        // 
        // AddEditWebAccountDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(800, 378);
        ControlBox = false;
        Controls.Add(BorderPanel);
        ForeColor = Color.Black;
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Margin = new Padding(4, 5, 4, 5);
        Name = "AddEditWebAccountDialog";
        StartPosition = FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
        BorderPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ToolTip ttp;
    private ErrorProvider ErrorProvider;
    private Intelligence.Shared.UI.GradientPanel BorderPanel;
    private SaveCancelBar SaveCancel;
    private EditWebAccountControl WebEdit;
    private VaultDialogHeader DialogHeader;
}