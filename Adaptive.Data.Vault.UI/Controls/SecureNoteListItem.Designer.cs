using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

partial class SecureNoteListItem
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
        ContainerPanel = new GradientPanel();
        ContextMenu = new ContextMenuStrip(components);
        ContextMenuNew = new ToolStripMenuItem();
        ContextMenuEdit = new ToolStripMenuItem();
        ContextMenuDelete = new ToolStripMenuItem();
        ContextMenuDividerA = new ToolStripSeparator();
        ContextMenuCategorize = new ToolStripMenuItem();
        ContextMenuDividerB = new ToolStripSeparator();
        ContextMenuProperties = new ToolStripMenuItem();
        DividerLine = new LineControl();
        NamePanel = new Panel();
        DescriptionLabel = new AdvancedLabel();
        NameLabel = new AdvancedLabel();
        ButtonsPanel = new GradientPanel();
        UserInfoButton = new TemplatedButton();
        ButtonDividerA = new Panel();
        EditButton = new TemplatedButton();
        ButtonDividerB = new Panel();
        DeleteButton = new TemplatedButton();
        SelectionIndicator = new GradientPanel();
        ttp = new ToolTip(components);
        ContainerPanel.SuspendLayout();
        ContextMenu.SuspendLayout();
        NamePanel.SuspendLayout();
        ButtonsPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ContainerPanel
        // 
        ContainerPanel.ContextMenuStrip = ContextMenu;
        ContainerPanel.Controls.Add(DividerLine);
        ContainerPanel.Controls.Add(NamePanel);
        ContainerPanel.Controls.Add(ButtonsPanel);
        ContainerPanel.Controls.Add(SelectionIndicator);
        ContainerPanel.Dock = DockStyle.Fill;
        ContainerPanel.Location = new Point(0, 0);
        ContainerPanel.Name = "ContainerPanel";
        ContainerPanel.Size = new Size(440, 54);
        ContainerPanel.TabIndex = 0;
        ContainerPanel.TemplateFile = "";
        // 
        // ContextMenu
        // 
        ContextMenu.Items.AddRange(new ToolStripItem[] { ContextMenuNew, ContextMenuEdit, ContextMenuDelete, ContextMenuDividerA, ContextMenuCategorize, ContextMenuDividerB, ContextMenuProperties });
        ContextMenu.Name = "ContextMenu";
        ContextMenu.ShowCheckMargin = true;
        ContextMenu.Size = new Size(198, 126);
        // 
        // ContextMenuNew
        // 
        ContextMenuNew.Image = Properties.Resources.Add16x16;
        ContextMenuNew.Name = "ContextMenuNew";
        ContextMenuNew.Size = new Size(197, 22);
        ContextMenuNew.Text = "New...";
        ContextMenuNew.ToolTipText = "Create a new Web Account entry...";
        // 
        // ContextMenuEdit
        // 
        ContextMenuEdit.Image = Properties.Resources.Edit_16x16;
        ContextMenuEdit.Name = "ContextMenuEdit";
        ContextMenuEdit.Size = new Size(197, 22);
        ContextMenuEdit.Text = "Edit...";
        ContextMenuEdit.ToolTipText = "Edit this Account information.";
        // 
        // ContextMenuDelete
        // 
        ContextMenuDelete.Image = Properties.Resources.Delete_16x16;
        ContextMenuDelete.Name = "ContextMenuDelete";
        ContextMenuDelete.Size = new Size(197, 22);
        ContextMenuDelete.Text = "Delete";
        ContextMenuDelete.ToolTipText = "Delete this account.";
        // 
        // ContextMenuDividerA
        // 
        ContextMenuDividerA.Name = "ContextMenuDividerA";
        ContextMenuDividerA.Size = new Size(194, 6);
        // 
        // ContextMenuCategorize
        // 
        ContextMenuCategorize.Image = Properties.Resources.Delete_2_16x16;
        ContextMenuCategorize.Name = "ContextMenuCategorize";
        ContextMenuCategorize.Size = new Size(197, 22);
        ContextMenuCategorize.Text = "Change Category...";
        ContextMenuCategorize.ToolTipText = "Change the category this item belongs to.";
        // 
        // ContextMenuDividerB
        // 
        ContextMenuDividerB.Name = "ContextMenuDividerB";
        ContextMenuDividerB.Size = new Size(194, 6);
        // 
        // ContextMenuProperties
        // 
        ContextMenuProperties.Name = "ContextMenuProperties";
        ContextMenuProperties.ShortcutKeys = Keys.F5;
        ContextMenuProperties.Size = new Size(197, 22);
        ContextMenuProperties.Text = "Properties";
        ContextMenuProperties.ToolTipText = "Show the detail information for this entry.";
        // 
        // DividerLine
        // 
        DividerLine.BevelBottomColor = SystemColors.ControlLight;
        DividerLine.BevelTopColor = SystemColors.ControlDark;
        DividerLine.Direction = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
        DividerLine.Dock = DockStyle.Bottom;
        DividerLine.EndColor = Color.FromArgb(136, 181, 255);
        DividerLine.LineWidth = 2;
        DividerLine.Location = new Point(5, 52);
        DividerLine.Mode = LineControlMode.Line;
        DividerLine.Name = "DividerLine";
        DividerLine.Orientation = LineControlOrientation.Horizontal;
        DividerLine.Size = new Size(281, 2);
        DividerLine.StartColor = SystemColors.Control;
        DividerLine.TabIndex = 9;
        // 
        // NamePanel
        // 
        NamePanel.BackColor = Color.Transparent;
        NamePanel.Controls.Add(DescriptionLabel);
        NamePanel.Controls.Add(NameLabel);
        NamePanel.Dock = DockStyle.Top;
        NamePanel.Location = new Point(5, 0);
        NamePanel.Name = "NamePanel";
        NamePanel.Size = new Size(281, 34);
        NamePanel.TabIndex = 5;
        // 
        // DescriptionLabel
        // 
        DescriptionLabel.BackColor = Color.Transparent;
        DescriptionLabel.Dock = DockStyle.Top;
        DescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DescriptionLabel.Location = new Point(0, 20);
        DescriptionLabel.Name = "DescriptionLabel";
        DescriptionLabel.Size = new Size(281, 15);
        DescriptionLabel.TabIndex = 1;
        DescriptionLabel.TabStop = false;
        DescriptionLabel.Text = "Description Text Here";
        DescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // NameLabel
        // 
        NameLabel.BackColor = Color.Transparent;
        NameLabel.ContextMenuStrip = ContextMenu;
        NameLabel.Dock = DockStyle.Top;
        NameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        NameLabel.Location = new Point(0, 0);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(281, 20);
        NameLabel.TabIndex = 0;
        NameLabel.TabStop = false;
        NameLabel.Text = "Entry Name Here";
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ButtonsPanel
        // 
        ButtonsPanel.BackColor = Color.LightGray;
        ButtonsPanel.ContextMenuStrip = ContextMenu;
        ButtonsPanel.Controls.Add(UserInfoButton);
        ButtonsPanel.Controls.Add(ButtonDividerA);
        ButtonsPanel.Controls.Add(EditButton);
        ButtonsPanel.Controls.Add(ButtonDividerB);
        ButtonsPanel.Controls.Add(DeleteButton);
        ButtonsPanel.Dock = DockStyle.Right;
        ButtonsPanel.Location = new Point(286, 0);
        ButtonsPanel.Name = "ButtonsPanel";
        ButtonsPanel.Padding = new Padding(5);
        ButtonsPanel.Size = new Size(154, 54);
        ButtonsPanel.TabIndex = 4;
        ButtonsPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        // 
        // UserInfoButton
        // 
        UserInfoButton.Checked = false;
        UserInfoButton.Dock = DockStyle.Right;
        UserInfoButton.Location = new Point(7, 5);
        UserInfoButton.Name = "UserInfoButton";
        UserInfoButton.ResourceTemplate = Properties.Resources.ButtonTemplateUserInfo;
        UserInfoButton.Size = new Size(44, 44);
        UserInfoButton.TabIndex = 1;
        UserInfoButton.TemplateFile = null;
        ttp.SetToolTip(UserInfoButton, "Show the sensitive login information.");
        UserInfoButton.UseVisualStyleBackColor = false;
        // 
        // ButtonDividerA
        // 
        ButtonDividerA.BackColor = Color.Transparent;
        ButtonDividerA.Dock = DockStyle.Right;
        ButtonDividerA.Location = new Point(51, 5);
        ButtonDividerA.Name = "ButtonDividerA";
        ButtonDividerA.Size = new Size(5, 44);
        ButtonDividerA.TabIndex = 3;
        // 
        // EditButton
        // 
        EditButton.Checked = false;
        EditButton.Dock = DockStyle.Right;
        EditButton.Location = new Point(56, 5);
        EditButton.Name = "EditButton";
        EditButton.ResourceTemplate = Properties.Resources.ButtonTemplateEditUser;
        EditButton.Size = new Size(44, 44);
        EditButton.TabIndex = 2;
        EditButton.TemplateFile = null;
        ttp.SetToolTip(EditButton, "Edit the account information.");
        EditButton.UseVisualStyleBackColor = false;
        // 
        // ButtonDividerB
        // 
        ButtonDividerB.BackColor = Color.Transparent;
        ButtonDividerB.Dock = DockStyle.Right;
        ButtonDividerB.Location = new Point(100, 5);
        ButtonDividerB.Name = "ButtonDividerB";
        ButtonDividerB.Size = new Size(5, 44);
        ButtonDividerB.TabIndex = 4;
        // 
        // DeleteButton
        // 
        DeleteButton.Checked = false;
        DeleteButton.Dock = DockStyle.Right;
        DeleteButton.Image = Properties.Resources.Delete_2_16x16;
        DeleteButton.Location = new Point(105, 5);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.ResourceTemplate = Properties.Resources.ButtonTemplateDelete;
        DeleteButton.Size = new Size(44, 44);
        DeleteButton.TabIndex = 0;
        DeleteButton.TemplateFile = null;
        ttp.SetToolTip(DeleteButton, "Delete this entry.");
        DeleteButton.UseVisualStyleBackColor = false;
        // 
        // SelectionIndicator
        // 
        SelectionIndicator.Dock = DockStyle.Left;
        SelectionIndicator.Location = new Point(0, 0);
        SelectionIndicator.Name = "SelectionIndicator";
        SelectionIndicator.Size = new Size(5, 54);
        SelectionIndicator.TabIndex = 10;
        SelectionIndicator.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        SelectionIndicator.Visible = false;
        // 
        // SecureNoteListItem
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        Controls.Add(ContainerPanel);
        Margin = new Padding(3);
        Name = "SecureNoteListItem";
        Size = new Size(440, 54);
        ContainerPanel.ResumeLayout(false);
        ContextMenu.ResumeLayout(false);
        NamePanel.ResumeLayout(false);
        ButtonsPanel.ResumeLayout(false);
        ResumeLayout(false);
    }
    #endregion

    private GradientPanel ContainerPanel;
    private GradientPanel ButtonsPanel;
    private Panel NamePanel;
    private AdvancedLabel NameLabel;
    private AdvancedLabel DescriptionLabel;
    private TemplatedButton EditButton;
    private TemplatedButton UserInfoButton;
    private TemplatedButton DeleteButton;
    private Panel ButtonDividerB;
    private Panel ButtonDividerA;
    private ToolTip ttp;
    private LineControl DividerLine;
    private GradientPanel SelectionIndicator;
    private ContextMenuStrip ContextMenu;
    private ToolStripMenuItem ContextMenuNew;
    private ToolStripMenuItem ContextMenuEdit;
    private ToolStripMenuItem ContextMenuDelete;
    private ToolStripSeparator ContextMenuDividerA;
    private ToolStripMenuItem ContextMenuCategorize;
    private ToolStripSeparator ContextMenuDividerB;
    private ToolStripMenuItem ContextMenuProperties;
}
