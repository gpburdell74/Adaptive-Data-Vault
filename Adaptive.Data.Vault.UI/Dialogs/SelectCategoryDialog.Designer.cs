namespace Adaptive.Data.Vault.UI;

partial class SelectCategoryDialog
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCategoryDialog));
        BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        SaveCancel = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
        CategoryList = new ListBox();
        DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
        BorderPanel.SuspendLayout();
        ContainerPanel.SuspendLayout();
        SuspendLayout();
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(ContainerPanel);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(10);
        BorderPanel.Size = new Size(569, 498);
        BorderPanel.TabIndex = 0;
        BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Button.template";
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(SaveCancel);
        ContainerPanel.Controls.Add(CategoryList);
        ContainerPanel.Controls.Add(DialogHeader);
        ContainerPanel.Dock = DockStyle.Fill;
        ContainerPanel.Location = new Point(10, 10);
        ContainerPanel.Name = "ContainerPanel";
        ContainerPanel.Size = new Size(549, 478);
        ContainerPanel.TabIndex = 0;
        ContainerPanel.TemplateFile = null;
        // 
        // SaveCancel
        // 
        SaveCancel.CancelEnabled = true;
        SaveCancel.CancelText = "Cancel";
        SaveCancel.CancelVisible = true;
        SaveCancel.Dock = DockStyle.Bottom;
        SaveCancel.Font = new Font("Segoe UI", 9.75F);
        SaveCancel.Location = new Point(0, 430);
        SaveCancel.Margin = new Padding(48, 22, 48, 22);
        SaveCancel.Name = "SaveCancel";
        SaveCancel.SaveEnabled = true;
        SaveCancel.SaveText = "Select";
        SaveCancel.SaveVisible = true;
        SaveCancel.Size = new Size(549, 48);
        SaveCancel.TabIndex = 2;
        // 
        // CategoryList
        // 
        CategoryList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        CategoryList.FormattingEnabled = true;
        CategoryList.Location = new Point(5, 75);
        CategoryList.Name = "CategoryList";
        CategoryList.Size = new Size(538, 354);
        CategoryList.TabIndex = 1;
        // 
        // DialogHeader
        // 
        DialogHeader.Dock = DockStyle.Top;
        DialogHeader.Location = new Point(0, 0);
        DialogHeader.Name = "DialogHeader";
        DialogHeader.Size = new Size(549, 70);
        DialogHeader.TabIndex = 0;
        DialogHeader.TitleText = "SELECT CATEGORY";
        // 
        // SelectCategoryDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(569, 498);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        Name = "SelectCategoryDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContainerPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Intelligence.Shared.UI.GradientPanel BorderPanel;
    private Intelligence.Shared.UI.GradientPanel ContainerPanel;
    private Controls.VaultDialogHeader DialogHeader;
    private ListBox CategoryList;
    private Controls.SaveCancelBar SaveCancel;
}