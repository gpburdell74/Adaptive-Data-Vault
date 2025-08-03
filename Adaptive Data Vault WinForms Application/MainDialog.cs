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
    }

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            _manager?.Dispose();
            components?.Dispose();
        }

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

        FileMenuCloseFile.Visible = isOpen;
        FileMenuSave.Visible = isOpen;
        FileMenuSaveAs.Visible = isOpen;
        FileMenuDividerA.Visible = isOpen;

        ToolbarSaveDivider.Visible = isOpen;
        CloseFileButton.Visible = isOpen;
        SaveButton.Visible = isOpen;
        SaveAsButton.Visible = isOpen;

        Container.Panel1Collapsed = !isOpen;
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
            // Prompt the user for the security credentials for the file, and
            // attempt to open the file.
            SecureFileParameters? secParams = ShowFileLogin(fileName);
            if (secParams != null)
            {
                // Close all old data.
                PerformClose();

                _secParams = secParams;
                _manager = new VaultManager();
                _manager.Load(
                    _secParams.FileName,
                    _secParams.UserId,
                    _secParams.Password,
                    _secParams.Pin);

                // Set the categories list.
                CatTree.Categories = _manager!.Categories;
                Data.Manager = _manager;
                Data.SelectedCategory = CatTree.SelectedCategory;
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
    #endregion
}
