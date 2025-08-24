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
        SaveCancel = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
        CategoryList = new ListBox();
        DialogHeader = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
        ContainerPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(CategoryList);
        ContainerPanel.Controls.Add(DialogHeader);
        ContainerPanel.Controls.Add(SaveCancel);
        ContainerPanel.Size = new Size(410, 410);
        // 
        // SaveCancel
        // 
        SaveCancel.CancelEnabled = true;
        SaveCancel.CancelText = "Cancel";
        SaveCancel.CancelVisible = true;
        SaveCancel.Dock = DockStyle.Bottom;
        SaveCancel.Font = new Font("Segoe UI", 9.75F);
        SaveCancel.Location = new Point(5, 357);
        SaveCancel.Margin = new Padding(48, 22, 48, 22);
        SaveCancel.Name = "SaveCancel";
        SaveCancel.SaveEnabled = true;
        SaveCancel.SaveText = "Select";
        SaveCancel.SaveVisible = true;
        SaveCancel.Size = new Size(400, 48);
        SaveCancel.TabIndex = 2;
        // 
        // CategoryList
        // 
        CategoryList.Dock = DockStyle.Fill;
        CategoryList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        CategoryList.FormattingEnabled = true;
        CategoryList.Location = new Point(5, 75);
        CategoryList.Name = "CategoryList";
        CategoryList.Size = new Size(400, 282);
        CategoryList.TabIndex = 1;
        // 
        // DialogHeader
        // 
        DialogHeader.Dock = DockStyle.Top;
        DialogHeader.Location = new Point(5, 5);
        DialogHeader.Name = "DialogHeader";
        DialogHeader.Size = new Size(400, 70);
        DialogHeader.TabIndex = 0;
        DialogHeader.TitleText = "SELECT CATEGORY";
        // 
        // SelectCategoryDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(410, 410);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "SelectCategoryDialog";
        ContainerPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Controls.VaultDialogHeader DialogHeader;
    private ListBox CategoryList;
    private Controls.SaveCancelBar SaveCancel;
}