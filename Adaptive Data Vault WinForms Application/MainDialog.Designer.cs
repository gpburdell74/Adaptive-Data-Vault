namespace Adaptive.Data.Vault.UI;

partial class MainDialog
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components;

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
        MainMenu = new MenuStrip();
        FileMenu = new ToolStripMenuItem();
        FileMenuNewFile = new ToolStripMenuItem();
        FileMenuOpenFile = new ToolStripMenuItem();
        FileMenuCloseFile = new ToolStripMenuItem();
        FileMenuDividerA = new ToolStripSeparator();
        FileMenuSave = new ToolStripMenuItem();
        FileMenuSaveAs = new ToolStripMenuItem();
        FileMenuDividerB = new ToolStripSeparator();
        FileMenuExit = new ToolStripMenuItem();
        ToolMenu = new ToolStripMenuItem();
        ToolMenuDividerA = new ToolStripSeparator();
        ToolMenuOptions = new ToolStripMenuItem();
        WindowMenu = new ToolStripMenuItem();
        WindowMenuDividerA = new ToolStripSeparator();
        MainStatus = new StatusStrip();
        MainStatusLabel = new ToolStripStatusLabel();
        MainStatusPrg = new ToolStripProgressBar();
        MainToolbar = new ToolStrip();
        NewFileButton = new ToolStripButton();
        OpenFileButton = new ToolStripButton();
        CloseFileButton = new ToolStripButton();
        ToolbarSeparatorA = new ToolStripSeparator();
        SaveButton = new ToolStripButton();
        SaveAsButton = new ToolStripButton();
        ToolbarSaveDivider = new ToolStripSeparator();
        OptionsButton = new ToolStripButton();
        Container = new SplitContainer();
        CatTree = new CategoriesTreeControl();
        Data = new CategorizedItemsContainerControl();
        ttp = new ToolTip(components);
        MainMenu.SuspendLayout();
        MainStatus.SuspendLayout();
        MainToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)Container).BeginInit();
        Container.Panel1.SuspendLayout();
        Container.Panel2.SuspendLayout();
        Container.SuspendLayout();
        SuspendLayout();
        // 
        // MainMenu
        // 
        MainMenu.Items.AddRange(new ToolStripItem[] { FileMenu, ToolMenu, WindowMenu });
        MainMenu.Location = new Point(0, 0);
        MainMenu.Name = "MainMenu";
        MainMenu.Size = new Size(930, 24);
        MainMenu.TabIndex = 0;
        MainMenu.Text = "menuStrip1";
        // 
        // FileMenu
        // 
        FileMenu.DropDownItems.AddRange(new ToolStripItem[] { FileMenuNewFile, FileMenuOpenFile, FileMenuCloseFile, FileMenuDividerA, FileMenuSave, FileMenuSaveAs, FileMenuDividerB, FileMenuExit });
        FileMenu.Name = "FileMenu";
        FileMenu.Size = new Size(37, 20);
        FileMenu.Text = "&File";
        // 
        // FileMenuNewFile
        // 
        FileMenuNewFile.Image = Properties.Resources.New_File_16x16;
        FileMenuNewFile.Name = "FileMenuNewFile";
        FileMenuNewFile.ShortcutKeyDisplayString = "Ctrl+N";
        FileMenuNewFile.Size = new Size(214, 22);
        FileMenuNewFile.Text = "Create &New File...";
        FileMenuNewFile.ToolTipText = "Create a new secure file for storing passwords and secure data.";
        // 
        // FileMenuOpenFile
        // 
        FileMenuOpenFile.Image = Properties.Resources.OpenButton_Image;
        FileMenuOpenFile.Name = "FileMenuOpenFile";
        FileMenuOpenFile.ShortcutKeyDisplayString = "Ctrl+O";
        FileMenuOpenFile.Size = new Size(214, 22);
        FileMenuOpenFile.Text = "&Open File...";
        FileMenuOpenFile.ToolTipText = "Open an existing Adaptive Data Vault file.";
        // 
        // FileMenuCloseFile
        // 
        FileMenuCloseFile.Name = "FileMenuCloseFile";
        FileMenuCloseFile.Size = new Size(214, 22);
        FileMenuCloseFile.Text = "C&lose";
        FileMenuCloseFile.ToolTipText = "Close the current file.";
        FileMenuCloseFile.Visible = false;
        // 
        // FileMenuDividerA
        // 
        FileMenuDividerA.Name = "FileMenuDividerA";
        FileMenuDividerA.Size = new Size(211, 6);
        // 
        // FileMenuSave
        // 
        FileMenuSave.Image = Properties.Resources.Save_16x16_Blue;
        FileMenuSave.Name = "FileMenuSave";
        FileMenuSave.ShortcutKeyDisplayString = "Ctrl+S";
        FileMenuSave.Size = new Size(214, 22);
        FileMenuSave.Text = "Save File";
        FileMenuSave.ToolTipText = "Save the current file.";
        FileMenuSave.Visible = false;
        // 
        // FileMenuSaveAs
        // 
        FileMenuSaveAs.Image = Properties.Resources.Save_16x16;
        FileMenuSaveAs.Name = "FileMenuSaveAs";
        FileMenuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        FileMenuSaveAs.Size = new Size(214, 22);
        FileMenuSaveAs.Text = "Safe File &As...";
        FileMenuSaveAs.ToolTipText = "Save the current file under a new location and/or name.";
        FileMenuSaveAs.Visible = false;
        // 
        // FileMenuDividerB
        // 
        FileMenuDividerB.Name = "FileMenuDividerB";
        FileMenuDividerB.Size = new Size(211, 6);
        FileMenuDividerB.Visible = false;
        // 
        // FileMenuExit
        // 
        FileMenuExit.Name = "FileMenuExit";
        FileMenuExit.ShortcutKeys = Keys.Alt | Keys.F4;
        FileMenuExit.Size = new Size(214, 22);
        FileMenuExit.Text = "E&xit";
        FileMenuExit.ToolTipText = "Exit the application.";
        // 
        // ToolMenu
        // 
        ToolMenu.DropDownItems.AddRange(new ToolStripItem[] { ToolMenuDividerA, ToolMenuOptions });
        ToolMenu.Name = "ToolMenu";
        ToolMenu.Size = new Size(46, 20);
        ToolMenu.Text = "&Tools";
        // 
        // ToolMenuDividerA
        // 
        ToolMenuDividerA.Name = "ToolMenuDividerA";
        ToolMenuDividerA.Size = new Size(122, 6);
        // 
        // ToolMenuOptions
        // 
        ToolMenuOptions.Name = "ToolMenuOptions";
        ToolMenuOptions.Size = new Size(125, 22);
        ToolMenuOptions.Text = "&Options...";
        // 
        // WindowMenu
        // 
        WindowMenu.DropDownItems.AddRange(new ToolStripItem[] { WindowMenuDividerA });
        WindowMenu.Name = "WindowMenu";
        WindowMenu.Size = new Size(63, 20);
        WindowMenu.Text = "&Window";
        // 
        // WindowMenuDividerA
        // 
        WindowMenuDividerA.Name = "WindowMenuDividerA";
        WindowMenuDividerA.Size = new Size(57, 6);
        // 
        // MainStatus
        // 
        MainStatus.Items.AddRange(new ToolStripItem[] { MainStatusLabel, MainStatusPrg });
        MainStatus.Location = new Point(0, 539);
        MainStatus.Name = "MainStatus";
        MainStatus.Size = new Size(930, 22);
        MainStatus.TabIndex = 1;
        MainStatus.Text = "statusStrip1";
        // 
        // MainStatusLabel
        // 
        MainStatusLabel.Name = "MainStatusLabel";
        MainStatusLabel.Size = new Size(39, 17);
        MainStatusLabel.Text = "Ready";
        // 
        // MainStatusPrg
        // 
        MainStatusPrg.Name = "MainStatusPrg";
        MainStatusPrg.Size = new Size(100, 16);
        MainStatusPrg.Visible = false;
        // 
        // MainToolbar
        // 
        MainToolbar.Items.AddRange(new ToolStripItem[] { NewFileButton, OpenFileButton, CloseFileButton, ToolbarSeparatorA, SaveButton, SaveAsButton, ToolbarSaveDivider, OptionsButton });
        MainToolbar.Location = new Point(0, 24);
        MainToolbar.Name = "MainToolbar";
        MainToolbar.Size = new Size(930, 25);
        MainToolbar.TabIndex = 2;
        MainToolbar.Text = "toolStrip1";
        // 
        // NewFileButton
        // 
        NewFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        NewFileButton.Image = Properties.Resources.New_File_16x16;
        NewFileButton.ImageTransparentColor = Color.Magenta;
        NewFileButton.Name = "NewFileButton";
        NewFileButton.Size = new Size(23, 22);
        NewFileButton.ToolTipText = "Create a new secure file.";
        // 
        // OpenFileButton
        // 
        OpenFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        OpenFileButton.Image = Properties.Resources.OpenButton_Image;
        OpenFileButton.ImageTransparentColor = Color.Magenta;
        OpenFileButton.Name = "OpenFileButton";
        OpenFileButton.Size = new Size(23, 22);
        OpenFileButton.ToolTipText = "Open an existing secure file.";
        // 
        // CloseFileButton
        // 
        CloseFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        CloseFileButton.Image = (Image)resources.GetObject("CloseFileButton.Image");
        CloseFileButton.ImageTransparentColor = Color.Magenta;
        CloseFileButton.Name = "CloseFileButton";
        CloseFileButton.Size = new Size(23, 22);
        CloseFileButton.ToolTipText = "Close the current file.";
        CloseFileButton.Visible = false;
        // 
        // ToolbarSeparatorA
        // 
        ToolbarSeparatorA.Name = "ToolbarSeparatorA";
        ToolbarSeparatorA.Size = new Size(6, 25);
        // 
        // SaveButton
        // 
        SaveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        SaveButton.Image = Properties.Resources.Save_16x16_Blue;
        SaveButton.ImageTransparentColor = Color.Magenta;
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(23, 22);
        SaveButton.ToolTipText = "Save the current file.";
        SaveButton.Visible = false;
        // 
        // SaveAsButton
        // 
        SaveAsButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        SaveAsButton.Image = Properties.Resources.Save_16x16;
        SaveAsButton.ImageTransparentColor = Color.Magenta;
        SaveAsButton.Name = "SaveAsButton";
        SaveAsButton.Size = new Size(23, 22);
        SaveAsButton.ToolTipText = "Save the current file under a new location and / or name.";
        SaveAsButton.Visible = false;
        // 
        // ToolbarSaveDivider
        // 
        ToolbarSaveDivider.Name = "ToolbarSaveDivider";
        ToolbarSaveDivider.Size = new Size(6, 25);
        ToolbarSaveDivider.Visible = false;
        // 
        // OptionsButton
        // 
        OptionsButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
        OptionsButton.Image = Properties.Resources.Settings_Flat_16x16;
        OptionsButton.ImageTransparentColor = Color.Magenta;
        OptionsButton.Name = "OptionsButton";
        OptionsButton.Size = new Size(23, 22);
        OptionsButton.ToolTipText = "User Preferences and Options";
        // 
        // Container
        // 
        Container.Dock = DockStyle.Fill;
        Container.Location = new Point(0, 49);
        Container.Name = "Container";
        // 
        // Container.Panel1
        // 
        Container.Panel1.Controls.Add(CatTree);
        // 
        // Container.Panel2
        // 
        Container.Panel2.AutoScroll = true;
        Container.Panel2.Controls.Add(Data);
        Container.Size = new Size(930, 490);
        Container.SplitterDistance = 309;
        Container.TabIndex = 3;
        // 
        // CatTree
        // 
        CatTree.Dock = DockStyle.Fill;
        CatTree.Font = new Font("Segoe UI", 9.75F);
        CatTree.Location = new Point(0, 0);
        CatTree.Margin = new Padding(48, 22, 48, 22);
        CatTree.Name = "CatTree";
        CatTree.Size = new Size(309, 490);
        CatTree.TabIndex = 0;
        // 
        // Data
        // 
        Data.Dock = DockStyle.Fill;
        Data.Font = new Font("Segoe UI", 9.75F);
        Data.Location = new Point(0, 0);
        Data.Name = "Data";
        Data.Size = new Size(617, 490);
        Data.TabIndex = 0;
        Data.Visible = false;
        // 
        // MainDialog
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(930, 561);
        Controls.Add(Container);
        Controls.Add(MainToolbar);
        Controls.Add(MainStatus);
        Controls.Add(MainMenu);
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        MainMenuStrip = MainMenu;
        Name = "MainDialog";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Adaptive Data Vault";
        MainMenu.ResumeLayout(false);
        MainMenu.PerformLayout();
        MainStatus.ResumeLayout(false);
        MainStatus.PerformLayout();
        MainToolbar.ResumeLayout(false);
        MainToolbar.PerformLayout();
        Container.Panel1.ResumeLayout(false);
        Container.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)Container).EndInit();
        Container.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip MainMenu;
    private StatusStrip MainStatus;
    private ToolStrip MainToolbar;
    private SplitContainer Container;
    private ToolStripMenuItem FileMenu;
    private ToolStripMenuItem ToolMenu;
    private ToolStripMenuItem FileMenuNewFile;
    private ToolStripMenuItem FileMenuOpenFile;
    private ToolStripMenuItem FileMenuCloseFile;
    private ToolStripSeparator FileMenuDividerA;
    private ToolStripMenuItem FileMenuSave;
    private ToolStripMenuItem FileMenuSaveAs;
    private ToolStripSeparator FileMenuDividerB;
    private ToolStripMenuItem FileMenuExit;
    private ToolStripMenuItem WindowMenu;
    private ToolStripSeparator ToolMenuDividerA;
    private ToolStripMenuItem ToolMenuOptions;
    private ToolStripSeparator WindowMenuDividerA;
    private ToolStripStatusLabel MainStatusLabel;
    private ToolStripProgressBar MainStatusPrg;
    private ToolStripButton NewFileButton;
    private ToolStripButton OpenFileButton;
    private ToolStripButton CloseFileButton;
    private ToolStripSeparator ToolbarSeparatorA;
    private ToolStripButton SaveButton;
    private ToolStripButton SaveAsButton;
    private ToolStripSeparator ToolbarSaveDivider;
    private ToolStripButton OptionsButton;
    private ToolTip ttp;
    private CategoriesTreeControl CatTree;
    private CategorizedItemsContainerControl Data;
}
