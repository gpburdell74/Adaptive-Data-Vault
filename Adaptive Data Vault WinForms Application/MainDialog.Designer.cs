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
        ToolMenuSecureMessage = new ToolStripMenuItem();
        ToolMenuDecryptMessage = new ToolStripMenuItem();
        ToolMenuDividerA = new ToolStripSeparator();
        ToolMenuEraseFile = new ToolStripMenuItem();
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
        MainContainer = new SplitContainer();
        CatTree = new CategoriesTreeControl();
        Data = new CategorizedItemsContainerControl();
        ttp = new ToolTip(components);
        FileMenuRecentFiles = new ToolStripMenuItem();
        FileMenuMruDivider = new ToolStripSeparator();
        MruDivider = new ToolStripSeparator();
        MruMenuClear = new ToolStripMenuItem();
        MainMenu.SuspendLayout();
        MainStatus.SuspendLayout();
        MainToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
        MainContainer.Panel1.SuspendLayout();
        MainContainer.Panel2.SuspendLayout();
        MainContainer.SuspendLayout();
        SuspendLayout();
        // 
        // MainMenu
        // 
        MainMenu.Items.AddRange(new ToolStripItem[] { FileMenu, ToolMenu });
        MainMenu.Location = new Point(0, 0);
        MainMenu.Name = "MainMenu";
        MainMenu.Size = new Size(930, 24);
        MainMenu.TabIndex = 0;
        MainMenu.Text = "menuStrip1";
        // 
        // FileMenu
        // 
        FileMenu.DropDownItems.AddRange(new ToolStripItem[] { FileMenuNewFile, FileMenuOpenFile, FileMenuCloseFile, FileMenuDividerA, FileMenuSave, FileMenuSaveAs, FileMenuMruDivider, FileMenuRecentFiles, FileMenuDividerB, FileMenuExit });
        FileMenu.Name = "FileMenu";
        FileMenu.Size = new Size(37, 20);
        FileMenu.Text = "&File";
        // 
        // FileMenuNewFile
        // 
        FileMenuNewFile.Image = Properties.Resources.New_File_16x16;
        FileMenuNewFile.Name = "FileMenuNewFile";
        FileMenuNewFile.ShortcutKeyDisplayString = "Ctrl+N";
        FileMenuNewFile.Size = new Size(216, 22);
        FileMenuNewFile.Text = "Create &New File...";
        FileMenuNewFile.ToolTipText = "Create a new secure file for storing passwords and secure data.";
        // 
        // FileMenuOpenFile
        // 
        FileMenuOpenFile.Image = Properties.Resources.OpenButton_Image;
        FileMenuOpenFile.Name = "FileMenuOpenFile";
        FileMenuOpenFile.ShortcutKeyDisplayString = "Ctrl+O";
        FileMenuOpenFile.Size = new Size(216, 22);
        FileMenuOpenFile.Text = "&Open File...";
        FileMenuOpenFile.ToolTipText = "Open an existing Adaptive Data Vault file.";
        // 
        // FileMenuCloseFile
        // 
        FileMenuCloseFile.Image = Properties.Resources.Close_16x161;
        FileMenuCloseFile.Name = "FileMenuCloseFile";
        FileMenuCloseFile.Size = new Size(216, 22);
        FileMenuCloseFile.Text = "C&lose";
        FileMenuCloseFile.ToolTipText = "Close the current file.";
        FileMenuCloseFile.Visible = false;
        // 
        // FileMenuDividerA
        // 
        FileMenuDividerA.Name = "FileMenuDividerA";
        FileMenuDividerA.Size = new Size(213, 6);
        // 
        // FileMenuSave
        // 
        FileMenuSave.Image = Properties.Resources.Save_16x16_Blue;
        FileMenuSave.Name = "FileMenuSave";
        FileMenuSave.ShortcutKeyDisplayString = "Ctrl+S";
        FileMenuSave.Size = new Size(216, 22);
        FileMenuSave.Text = "Save File";
        FileMenuSave.ToolTipText = "Save the current file.";
        FileMenuSave.Visible = false;
        // 
        // FileMenuSaveAs
        // 
        FileMenuSaveAs.Image = Properties.Resources.Save_16x16;
        FileMenuSaveAs.Name = "FileMenuSaveAs";
        FileMenuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        FileMenuSaveAs.Size = new Size(216, 22);
        FileMenuSaveAs.Text = "Save File &As...";
        FileMenuSaveAs.ToolTipText = "Save the current file under a new location and/or name.";
        FileMenuSaveAs.Visible = false;
        // 
        // FileMenuDividerB
        // 
        FileMenuDividerB.Name = "FileMenuDividerB";
        FileMenuDividerB.Size = new Size(213, 6);
        // 
        // FileMenuExit
        // 
        FileMenuExit.Name = "FileMenuExit";
        FileMenuExit.ShortcutKeys = Keys.Alt | Keys.F4;
        FileMenuExit.Size = new Size(216, 22);
        FileMenuExit.Text = "E&xit";
        FileMenuExit.ToolTipText = "Exit the application.";
        // 
        // ToolMenu
        // 
        ToolMenu.DropDownItems.AddRange(new ToolStripItem[] { ToolMenuSecureMessage, ToolMenuDecryptMessage, ToolMenuDividerA, ToolMenuEraseFile });
        ToolMenu.Name = "ToolMenu";
        ToolMenu.Size = new Size(46, 20);
        ToolMenu.Text = "&Tools";
        // 
        // ToolMenuSecureMessage
        // 
        ToolMenuSecureMessage.Image = Properties.Resources.Secure_File_16x16;
        ToolMenuSecureMessage.Name = "ToolMenuSecureMessage";
        ToolMenuSecureMessage.Size = new Size(211, 22);
        ToolMenuSecureMessage.Text = "Create &Secure Message...";
        ToolMenuSecureMessage.ToolTipText = "Create an encrypted message.";
        // 
        // ToolMenuDecryptMessage
        // 
        ToolMenuDecryptMessage.Image = Properties.Resources.Secure_File_16x16;
        ToolMenuDecryptMessage.Name = "ToolMenuDecryptMessage";
        ToolMenuDecryptMessage.Size = new Size(211, 22);
        ToolMenuDecryptMessage.Text = "&Decrypt Secure Message...";
        ToolMenuDecryptMessage.ToolTipText = "Decrypt and view a secure message.";
        // 
        // ToolMenuDividerA
        // 
        ToolMenuDividerA.Name = "ToolMenuDividerA";
        ToolMenuDividerA.Size = new Size(208, 6);
        // 
        // ToolMenuEraseFile
        // 
        ToolMenuEraseFile.Image = Properties.Resources.Misc_194;
        ToolMenuEraseFile.Name = "ToolMenuEraseFile";
        ToolMenuEraseFile.Size = new Size(211, 22);
        ToolMenuEraseFile.Text = "Secure &Erase File...";
        ToolMenuEraseFile.ToolTipText = "Securely Erase a file.";
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
        MainToolbar.Items.AddRange(new ToolStripItem[] { NewFileButton, OpenFileButton, CloseFileButton, ToolbarSeparatorA, SaveButton, SaveAsButton, ToolbarSaveDivider });
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
        CloseFileButton.Image = Properties.Resources.Close_16x16;
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
        // MainContainer
        // 
        MainContainer.Dock = DockStyle.Fill;
        MainContainer.Location = new Point(0, 49);
        MainContainer.Name = "MainContainer";
        // 
        // MainContainer.Panel1
        // 
        MainContainer.Panel1.Controls.Add(CatTree);
        // 
        // MainContainer.Panel2
        // 
        MainContainer.Panel2.AutoScroll = true;
        MainContainer.Panel2.Controls.Add(Data);
        MainContainer.Size = new Size(930, 490);
        MainContainer.SplitterDistance = 309;
        MainContainer.TabIndex = 3;
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
        // FileMenuRecentFiles
        // 
        FileMenuRecentFiles.DropDownItems.AddRange(new ToolStripItem[] { MruDivider, MruMenuClear });
        FileMenuRecentFiles.Name = "FileMenuRecentFiles";
        FileMenuRecentFiles.Size = new Size(216, 22);
        FileMenuRecentFiles.Text = "Recent";
        // 
        // FileMenuMruDivider
        // 
        FileMenuMruDivider.Name = "FileMenuMruDivider";
        FileMenuMruDivider.Size = new Size(213, 6);
        // 
        // MruDivider
        // 
        MruDivider.Name = "MruDivider";
        MruDivider.Size = new Size(177, 6);
        // 
        // MruMenuClear
        // 
        MruMenuClear.Name = "MruMenuClear";
        MruMenuClear.Size = new Size(180, 22);
        MruMenuClear.Text = "Clear Recent List";
        // 
        // MainDialog
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(930, 561);
        Controls.Add(MainContainer);
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
        MainContainer.Panel1.ResumeLayout(false);
        MainContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
        MainContainer.ResumeLayout(false);
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
    private SplitContainer MainContainer;
    private ToolStripMenuItem ToolMenuSecureMessage;
    private ToolStripMenuItem ToolMenuEraseFile;
    private ToolStripMenuItem ToolMenuDecryptMessage;
    private ToolStripSeparator FileMenuMruDivider;
    private ToolStripMenuItem FileMenuRecentFiles;
    private ToolStripSeparator MruDivider;
    private ToolStripMenuItem MruMenuClear;
}
