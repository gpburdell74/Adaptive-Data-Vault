using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the central dialog for the application.
/// </summary>
/// <seealso cref="AdaptiveDialogBase" />
public partial class MainDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// Manages the most recently used file list.
    /// </summary>
    private MruManager? _mru;

    /// <summary>
    /// The manager instance.
    /// </summary>
    private VaultManager? _manager;

    /// <summary>
    /// The security parameters for a file.
    /// </summary>
    private SecureFileParameters? _secParams;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="MainDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public MainDialog()
    {
        InitializeComponent();
        _mru = new MruManager();
        AddMruMenuItems();
    }

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            _mru?.Dispose();
            _manager?.Dispose();
            components?.Dispose();
        }

        _mru = null;
        components = null;
        _manager = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        // Menu
        FileMenuNewFile.Click += HandleFileMenuNewClicked;
        FileMenuOpenFile.Click += HandleFileMenuOpenClicked;
        FileMenuCloseFile.Click += HandleFileMenuCloseClicked;
        FileMenuSave.Click += HandleFileMenuSaveClicked;
        FileMenuSaveAs.Click += HandleFileMenuSaveAsClicked;
        FileMenuExit.Click += HandleFileMenuExitClicked;
        MruMenuClear.Click += HandleClearMruClicked;

        // Tool Menu
        ToolMenuSecureMessage.Click += HandleToolMenuSecureMessageClicked;
        ToolMenuDecryptMessage.Click += HandleToolMenuDecryptMessageClicked;
        ToolMenuEraseFile.Click += HandleToolMenuEraseFileClicked;

        // Tool bar
        NewFileButton.Click += HandleFileMenuNewClicked;
        OpenFileButton.Click += HandleFileMenuOpenClicked;
        CloseFileButton.Click += HandleFileMenuCloseClicked;
        SaveButton.Click += HandleFileMenuSaveClicked;
        SaveAsButton.Click += HandleFileMenuSaveAsClicked;

        // Categories
        CatTree.CategoryCreated += HandleCategoryCreated;
        CatTree.CategoryEdited += HandleCategoryEdited;
        CatTree.CategoryRemoved += HandleCategoryRemoved;
        CatTree.CategorySelectionChanged += HandleCategoryChanged;

        // Items List.
        Data.ContentChanged += HandleDataContentChanged;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        // Menu
        FileMenuNewFile.Click -= HandleFileMenuNewClicked;
        FileMenuOpenFile.Click -= HandleFileMenuOpenClicked;
        FileMenuCloseFile.Click -= HandleFileMenuCloseClicked;
        FileMenuSave.Click -= HandleFileMenuSaveClicked;
        FileMenuSaveAs.Click -= HandleFileMenuSaveAsClicked;
        FileMenuExit.Click -= HandleFileMenuExitClicked;
        MruMenuClear.Click -= HandleClearMruClicked;
        // Tool Menu
        ToolMenuSecureMessage.Click -= HandleToolMenuSecureMessageClicked;
        ToolMenuDecryptMessage.Click -= HandleToolMenuDecryptMessageClicked;
        ToolMenuEraseFile.Click -= HandleToolMenuEraseFileClicked;

        // Tool bar
        NewFileButton.Click -= HandleFileMenuNewClicked;
        OpenFileButton.Click -= HandleFileMenuOpenClicked;
        CloseFileButton.Click -= HandleFileMenuCloseClicked;
        SaveButton.Click -= HandleFileMenuSaveClicked;
        SaveAsButton.Click -= HandleFileMenuSaveAsClicked;

        // Categories
        CatTree.CategoryCreated -= HandleCategoryCreated;
        CatTree.CategoryEdited -= HandleCategoryEdited;
        CatTree.CategoryRemoved -= HandleCategoryRemoved;
        CatTree.CategorySelectionChanged -= HandleCategoryChanged;

        // Items List.
        Data.ContentChanged -= HandleDataContentChanged;
    }

    protected override void InitializeDataContent()
    {
        if (!_mru.EulaAccepted)
        {
            EulaDialog dialog = new EulaDialog();
            dialog.ShowDialog();

        }
    }
    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        MainMenu.Enabled = false;
        MainToolbar.Enabled = false;
        MainStatus.Enabled = false;
        MainStatusLabel.Text = "... Processing ... ";
        MainStatusPrg.Visible = true;
        MainStatusPrg.Value = 0;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        MainMenu.Enabled = true;
        MainToolbar.Enabled = true;
        MainStatus.Enabled = true;
        MainStatusLabel.Text = "Ready";
        MainStatusPrg.Visible = false;
        MainStatusPrg.Value = 0;
        ResumeLayout();
    }

    /// <summary>
    /// When implemented in a derived class, sets the display state for the controls on the dialog based on
    /// current conditions.
    /// </summary>
    /// <remarks>
    /// This is called by <see cref="SetState" /> after <see cref="SetSecurityState" /> is called.
    /// </remarks>
    protected override void SetDisplayState()
    {
        bool isOpen = _manager != null;
        bool hasMru = _mru.Count > 0;

        FileMenuCloseFile.Visible = isOpen;
        FileMenuSave.Visible = isOpen;
        FileMenuSaveAs.Visible = isOpen;
        FileMenuDividerA.Visible = isOpen;
        FileMenuMruDivider.Visible = hasMru;
        FileMenuRecentFiles.Visible = hasMru;

        ToolbarSaveDivider.Visible = isOpen;
        CloseFileButton.Visible = isOpen;
        SaveButton.Visible = isOpen;
        SaveAsButton.Visible = isOpen;
        
        MainContainer.Panel1Collapsed = !isOpen;
        CatTree.Visible = isOpen;
        Data.Visible = isOpen;
    }
    #endregion

    #region Private Event Handlers

    #region File Menu and Tool Bar Handlers
    /// <summary>
    /// Handles the event when the File - New menu item or New File tool bar button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileMenuNewClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        // Prompt the user for the new file name.
        string? fileName = GetNewFileName();
        if (!string.IsNullOrEmpty(fileName))
        {
            // Prompt the user for the security credentials for the new file.
            SecureFileParameters? secParams = ShowFileLogin(fileName);
            if (secParams != null)
            {
                // Close all old data.
                PerformClose();

                // Save the new file.
                _secParams = secParams;
                PerformSave();

                // Set the categories list.
                CatTree.Categories = _manager!.Categories;
                Data.Manager = _manager;
                Data.SelectedCategory = CatTree.SelectedCategory;

                // Add to the MRU list.
                AddMruItem(fileName);
            }
        }

        SetPostLoadState();
        SetState();
    }
    /// <summary>
    /// Handles the event when the File - New menu item or New File tool bar button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileMenuOpenClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        // Prompt the user for the file name.
        string? fileName = GetOpenFileName();
        if (!string.IsNullOrEmpty(fileName))
        {
            // Close all old data.
            PerformClose();

            // Open the new file.
            PerformOpenFile(fileName);
        }

        SetPostLoadState();
        SetState();
    }
    /// <summary>
    /// Handles the event when the File - New menu item or New File tool bar button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileMenuCloseClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        PerformClose();

        SetPostLoadState();
        SetState();
    }
    /// <summary>
    /// Handles the event when the File - New menu item or New File tool bar button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileMenuSaveClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        _manager?.Save();

        SetPostLoadState();
        SetState();
    }
    /// <summary>
    /// Handles the event when the File - New menu item or New File tool bar button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileMenuSaveAsClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        // Prompt the user for the new file name.
        string? fileName = GetNewFileName();
        if (!string.IsNullOrEmpty(fileName))
        {
            // Save the new file.
            if (_secParams != null)
            {
                _secParams.FileName = fileName;
                PerformSave();

                // Add to the MRU list.
                AddMruItem(fileName);
            }
        }

        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the File - New menu item or New File tool bar button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleFileMenuExitClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        PerformClose();
        Close();
    }
    /// <summary>
    /// Handles the event when the Clear MRU menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleClearMruClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        _mru.Clear();
        while (FileMenuRecentFiles.DropDownItems.Count > 2)
        {
            FileMenuRecentFiles.DropDownItems[0].Click -= HandleMruItemClicked;
            FileMenuRecentFiles.DropDownItems.RemoveAt(0);
        }
        
        SetPostLoadState();
        SetState();

    }
    #endregion

    #region Tool Menu
    /// <summary>
    /// Handles the event when the Tool Menu -- Create Secure Message item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleToolMenuSecureMessageClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        CreateSecureMessageDialog dialog = new CreateSecureMessageDialog();
        dialog.ShowDialog();
        dialog.Dispose();

        SetPostLoadState();
        SetDisplayState();
    }

    /// <summary>
    /// Handles the event when the Tool Menu -- Secure Erase item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleToolMenuEraseFileClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        SecureEraseFileDialog dialog = new SecureEraseFileDialog();
        dialog.ShowDialog();
        dialog.Dispose();

        SetPostLoadState();
        SetDisplayState();
    }
    
    /// <summary>
    /// Handles the event when the Tool Menu -- Decode Secure Message item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleToolMenuDecryptMessageClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        DecodeSecureMessageDialog dialog = new DecodeSecureMessageDialog();
        dialog.ShowDialog();
        dialog.Dispose();

        SetPostLoadState();
        SetDisplayState();
    }

    /// <summary>
    /// Handles the event when an MRU File entry menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleMruItemClicked(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            SetPreLoadState();
            string fileName = (string)((ToolStripMenuItem)sender).Tag;

            // Close anything currently open.
            PerformClose();

            // Open and load the specified file.
            PerformOpenFile(fileName);

            SetPostLoadState();
            SetState();
        }
    }
    #endregion

        #region Category Tree    
        /// <summary>
        /// Handles the event when a category is created.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs{T}"/> instance containing the <see cref="UserCategory"/>
        /// instance that was created.
        /// </param>
    private void HandleCategoryCreated(object? sender, EventArgs<UserCategory> e)
    {
        if (_manager != null && _manager.Categories != null && e.Data != null)
        {
            _manager.Categories.Add(e.Data);
            _manager.Save();
        }
    }
    /// <summary>
    /// Handles the event when a category is edited.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">
    /// The <see cref="EventArgs{T}"/> instance containing the <see cref="UserCategory"/>
    /// instance that was created.
    /// </param>
    private void HandleCategoryEdited(object? sender, EventArgs<UserCategory> e)
    {
        if (_manager != null && _manager.Categories != null && e.Data != null)
        {
            _manager.Save();
        }
    }
    /// <summary>
    /// Handles the event when a category is removed.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">
    /// The <see cref="EventArgs{T}"/> instance containing the <see cref="UserCategory"/>
    /// instance that was created.
    /// </param>
    private void HandleCategoryRemoved(object? sender, EventArgs<UserCategory> e)
    {
        if (_manager != null && _manager.Categories != null && e.Data != null)
        {
            _manager.Categories.Remove(e.Data);
            e.Data.Dispose();
            _manager.Save();
        }
    }

    /// <summary>
    /// Handles the event when the selected category changes.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCategoryChanged(object? sender, EventArgs e)
    {
        SetPreLoadState();
        Data.SelectedCategory = CatTree.SelectedCategory;
        SetPostLoadState();
    }

    /// <summary>
    /// Handles the event when the data content changes.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleDataContentChanged(object? sender, EventArgs e)
    {
        _manager?.Save();
    }
    #endregion

    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Adds the new MRU file listing to the manager and drop-down menu list.
    /// </summary>
    /// <param name="fileName">
    /// A string containing the path and name of the file.
    /// </param>
    private void AddMruItem(string fileName)
    {
        if (_mru != null && !_mru.Contains(fileName))
        {
            _mru.Add(fileName);
            ToolStripMenuItem item = new ToolStripMenuItem(fileName);
            item.Tag = fileName;
            item.Click += HandleMruItemClicked;

            FileMenuRecentFiles.DropDownItems.Insert(0, item);

        }
    }

    /// <summary>
    /// Adds the MRU menu items when first loaded.
    /// </summary>
    private void AddMruMenuItems()
    {
        if (_mru != null && _mru.Count > 0)
        {
            FileMenuRecentFiles.Visible = true;
            FileMenuMruDivider.Visible = true;
            foreach (string mruFile in _mru.RecentFileList)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(mruFile);
                item.Tag = mruFile;
                item.Click += HandleMruItemClicked;

                FileMenuRecentFiles.DropDownItems.Insert(0, item);
            }
        }
        else
        {
            FileMenuRecentFiles.Visible = false;
            FileMenuMruDivider.Visible = false;
        }
    }

    /// <summary>
    /// Displays the Save As dialog for creating new files or saving files to prompt the
    /// user for a path and file name.
    /// </summary>
    /// <param name="saveAs">
    /// A value indicating whether this is a save current file as operation, as opposed to a create new
    /// file operation.
    /// </param>
    /// <returns>
    /// A string containing the user-specified path and file name if successful;
    /// otherwise, returns <b>null</b>.
    /// </returns>
    private string? GetNewFileName(bool saveAs =false)
    {
        string? fileName = null;

        SaveFileDialog dialog = DialogProvider.CreateSaveFileDialog();
        if (saveAs)
            dialog.Title = "Save Adaptive Data Vault As";
        else
            dialog.Title = "Create New Adaptive Data Vault";

        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            fileName = dialog.FileName;
        }
        dialog.Dispose();

        return fileName;
    }

    /// <summary>
    /// Displays the Open File dialog for opening files to prompt the
    /// user for a path and file name.
    /// </summary>
    /// <returns>
    /// A string containing the user-specified path and file name if successful;
    /// otherwise, returns <b>null</b>.
    /// </returns>
    private string? GetOpenFileName()
    {
        string? fileName = null;

        OpenFileDialog dialog = DialogProvider.CreateOpenFileDialog();
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            fileName = dialog.FileName;
        }
        dialog.Dispose();

        return fileName;
    }

    /// <summary>
    /// Performs operation to close the file.
    /// </summary>
    private void PerformClose()
    {
        // Prevent unnecessary re-painting issues.
        CatTree.Visible = false;
        Data.Visible = false;
        Application.DoEvents();

        // Clear the current UI controls.
        CatTree.ClearContent();
        Data.ClearContent();

        // Auto-save, if possible.
        _manager?.Save();

        _manager?.Dispose();
        _secParams?.Dispose();

        _manager = null;
        _secParams = null;
        GC.Collect();
    }

    /// <summary>
    /// Performs the process of logging into and opening the specified file.
    /// </summary>
    /// <param name="fileName">
    /// A string containing the fully-qualified path and name of the file to be opened.
    /// </param>
    private void PerformOpenFile(string fileName)
    {
        // Open and load the specified file.

        // Prompt the user for the security credentials for the file, and
        // attempt to open the file.
        SecureFileParameters? secParams = ShowFileLogin(fileName);
        if (secParams != null)
        {
            _secParams = secParams;
            _manager = new VaultManager();
            bool success = _manager.Load(
                _secParams.FileName,
                _secParams.UserId,
                _secParams.Password,
                _secParams.Pin);

            if (success)
            {
                // Set the categories list.
                CatTree.Categories = _manager!.Categories;
                Data.Manager = _manager;
                Data.SelectedCategory = CatTree.SelectedCategory;

                // Add to the MRU list.
                AddMruItem(fileName);

            }
            else
            {
                ShowError("Invalid Credentials", "The specified file could not be read.");

                _secParams.Dispose();
                _manager?.Dispose();
                _secParams = null;
                _manager = null;
            }
        }
    }

    /// <summary>
    /// Performs the data save operation.
    /// </summary>
    private void PerformSave()
    {
        if (_secParams != null)
        {
            if (_manager == null)
                _manager = new VaultManager();

            _manager.Save(
                _secParams.FileName,
                _secParams.UserId,
                _secParams.Password,
                _secParams.Pin);
        }
    }
    /// <summary>
    /// Shows the login dialog to create or acquire the security parameters for the related file.
    /// </summary>
    /// <param name="newFileName">
    /// A string containing the name of the file.
    /// </param>
    /// <returns>
    /// <b>true</b> if the login and load of the file is successful; otherwise,
    /// returns <b>false</b>.
    /// </returns>
    private SecureFileParameters? ShowFileLogin(string newFileName)
    {
        SecureFileParameters? secParams = null;

        secParams = DialogProvider.DisplayLoginDialog(newFileName);
        if (secParams != null)
            secParams.FileName = newFileName;

        return secParams;

    }

    #endregion
}
