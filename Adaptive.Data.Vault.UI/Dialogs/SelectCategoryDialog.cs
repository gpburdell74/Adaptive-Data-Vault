using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a dialog for selecting a category.
/// </summary>
/// <seealso cref="AdaptiveDialogBase" />
public partial class SelectCategoryDialog : AdaptiveDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// The reference to the current manager instance.
    /// </summary>
    private VaultManager? _manager;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="SelectCategoryDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public SelectCategoryDialog()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            components?.Dispose();
        }

        components = null;
        _manager = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the current vault manager instance.
    /// </summary>
    /// <value>
    /// The <see cref="VaultManager"/> instance containing the list of categories to select from.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public VaultManager? Manager
    {
        get => _manager;
        set
        {
            _manager = value;
            if (_manager != null)
            {
                CategoryList.DataSource = _manager.Categories;
                CategoryList.DisplayMember = "Name";
            }
        }
    }

    /// <summary>
    /// Gets the reference to the currently selected category instance, of any.
    /// </summary>
    /// <value>
    /// The selected <see cref="UserCategory"/> instance, if one is selected; otherwise, <b>null</b>.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public UserCategory? SelectedCategory
    {
        get
        {
            if (CategoryList.SelectedItem is UserCategory category)
            {
                return category;
            }
            return null;
        }
    }
    #endregion

    #region Protected Method Overrides    
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        SaveCancel.SaveClicked += HandleSaveClicked;
        SaveCancel.CancelClicked += HandleCancelClicked;

        CategoryList.SelectedIndexChanged += HandleGenericControlChange;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        SaveCancel.SaveClicked -= HandleSaveClicked;
        SaveCancel.CancelClicked -= HandleCancelClicked;

        CategoryList.SelectedIndexChanged -= HandleGenericControlChange;
    }

    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        base.SetPreLoadState();

        Cursor = Cursors.WaitCursor;
        CategoryList.Enabled = false;
        SaveCancel.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    protected override void SetPostLoadState()
    {
        base.SetPostLoadState();

        Cursor = Cursors.Default;
        CategoryList.Enabled = true;
        SaveCancel.Enabled = true;
        ResumeLayout();
    }

    /// <summary>
    /// When implemented in a derived class, sets the display state for the controls on the dialog based on
    /// current conditions.
    /// </summary>
    /// <remarks>
    /// This is called by <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetState" /> after <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveDialogBase.SetSecurityState" /> is called.
    /// </remarks>
    protected override void SetDisplayState()
    {
        bool canSave = (SelectedCategory != null);

        SaveCancel.SaveEnabled = canSave;
    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the Save button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleSaveClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        DialogResult = DialogResult.OK;
        Close();
    }

    /// <summary>
    /// Handles the event when the Cancel button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCancelClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        DialogResult = DialogResult.Cancel;
        Close();
    }
    #endregion
}