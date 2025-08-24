using Adaptive.Data.Vault.UI.Controls;

namespace Adaptive.Data.Vault.UI;

partial class CategoriesTreeControl
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
        components = new System.ComponentModel.Container();
        Header = new VaultDialogHeader();
        CategoryList = new ListBox();
        ContextMenu = new ContextMenuStrip(components);
        CategoryMenuAdd = new ToolStripMenuItem();
        CategoryMenuEdit = new ToolStripMenuItem();
        CategoryMenuRemove = new ToolStripMenuItem();
        ttp = new ToolTip(components);
        ContextMenu.SuspendLayout();
        SuspendLayout();
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Name = "Header";
        Header.Size = new Size(487, 64);
        Header.TabIndex = 0;
        Header.TitleText = "CATEGORIES";
        // 
        // CategoryList
        // 
        CategoryList.ContextMenuStrip = ContextMenu;
        CategoryList.Dock = DockStyle.Fill;
        CategoryList.Font = new Font("OCR A Extended", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        CategoryList.FormattingEnabled = true;
        CategoryList.Location = new Point(0, 64);
        CategoryList.Name = "CategoryList";
        CategoryList.Size = new Size(487, 323);
        CategoryList.TabIndex = 1;
        // 
        // ContextMenu
        // 
        ContextMenu.Items.AddRange(new ToolStripItem[] { CategoryMenuAdd, CategoryMenuEdit, CategoryMenuRemove });
        ContextMenu.Name = "ContextMenu";
        ContextMenu.Size = new Size(169, 70);
        // 
        // CategoryMenuAdd
        // 
        CategoryMenuAdd.Image = Properties.Resources.Add16x16;
        CategoryMenuAdd.Name = "CategoryMenuAdd";
        CategoryMenuAdd.Size = new Size(168, 22);
        CategoryMenuAdd.Text = "&Add Category...";
        CategoryMenuAdd.ToolTipText = "Create and add a new category for entries.";
        // 
        // CategoryMenuEdit
        // 
        CategoryMenuEdit.Image = Properties.Resources.Edit_16x16;
        CategoryMenuEdit.Name = "CategoryMenuEdit";
        CategoryMenuEdit.Size = new Size(168, 22);
        CategoryMenuEdit.Text = "&Edit Category...";
        CategoryMenuEdit.ToolTipText = "Change the name of this category.";
        // 
        // CategoryMenuRemove
        // 
        CategoryMenuRemove.Image = Properties.Resources.Delete_16x16;
        CategoryMenuRemove.Name = "CategoryMenuRemove";
        CategoryMenuRemove.Size = new Size(168, 22);
        CategoryMenuRemove.Text = "&Remove Category";
        CategoryMenuRemove.ToolTipText = "Delete this category.";
        // 
        // CategoriesTreeControl
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(CategoryList);
        Controls.Add(Header);
        Name = "CategoriesTreeControl";
        Size = new Size(487, 387);
        ContextMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private VaultDialogHeader Header;
    private ListBox CategoryList;
    private ToolTip ttp;
    private ContextMenuStrip ContextMenu;
    private ToolStripMenuItem CategoryMenuAdd;
    private ToolStripMenuItem CategoryMenuEdit;
    private ToolStripMenuItem CategoryMenuRemove;
}
