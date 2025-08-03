using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a control for displaying a list of categories.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class CategoriesTreeControl : AdaptiveControlBase
{
    #region Public Event Declarations
    /// <summary>
    /// Occurs when a category is created.
    /// </summary>
    public event Intelligence.Shared.EventHandler<UserCategory>? CategoryCreated;
    /// <summary>
    /// Occurs when a category is edited.
    /// </summary>
    public event Intelligence.Shared.EventHandler<UserCategory>? CategoryEdited;
    /// <summary>
    /// Occurs when a category is deleted/removed.
    /// </summary>
    public event Intelligence.Shared.EventHandler<UserCategory>? CategoryRemoved;
    /// <summary>
    /// Occurs when a new category is selected.
    /// </summary>
    public event EventHandler? CategorySelectionChanged;
    #endregion

    #region Private Member Declarations
    /// <summary>
    /// The categories list.
    /// </summary>
    private UserCategoryCollection? _categories;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="CategoriesTreeControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public CategoriesTreeControl()
    {
        InitializeComponent();
        _categories = new UserCategoryCollection();
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
            _categories?.Clear();
        }

        _categories = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the currently selected category.
    /// </summary>
    /// <value>
    /// The reference to the selected <see cref="UserCategory"/> instance, or 
    /// <b>null</b> for all the uncategorized items.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public UserCategory? SelectedCategory
    {
        get
        {
            UserCategory? selected = null;

            int index = CategoryList.SelectedIndex;
            if (index > 0 && _categories != null)
            {
                selected = _categories[index - 1];
            }
            return selected;
        }
    }
    /// <summary>
    /// Gets the ID of the currently selected category.
    /// </summary>
    /// <value>
    /// A <see cref="Guid"/> containing the ID value, if present, otherwise,
    /// returns <see cref="Guid.Empty"/>.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Guid? SelectedCategoryId
    {
        get
        {
            UserCategory? category = SelectedCategory;
            if (category == null)
                return Guid.Empty;
            else
                return category.Id;
        }
    }


    /// <summary>
    /// Gets or sets the reference to the list of categories to display in the control.
    /// </summary>
    /// <value>
    /// The reference to the <see cref="UserCategoryCollection"/> instance.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public UserCategoryCollection? Categories
    {
        get => _categories;
        set
        {
            if (value == null)
                _categories.Clear();
            else
            {
                // Copy the original
                _categories = new UserCategoryCollection(value.ToEntityList());
            }
            InitializeDataContent();
        }
    }
    #endregion

    #region Protected Event Methods
    /// <summary>
    /// Raises the <see cref="CategoryCreated"/> event.
    /// </summary>
    /// <param name="e">
    /// An <see cref="EventArgs{T}"/> containing the <see cref="UserCategory"/> instance 
    /// that was created.
    /// </param>
    public void OnCategoryCreated(object? sender, EventArgs<UserCategory> e)
    {
        ContinueInMainThread(() =>
        {
            CategoryCreated?.Invoke(this, e);
            SetState();
        });
    }

    /// <summary>
    /// Raises the <see cref="CategoryEdited"/> event.
    /// </summary>
    /// <param name="e">
    /// An <see cref="EventArgs{T}"/> containing the <see cref="UserCategory"/> instance 
    /// that was edited.
    /// </param>
    public void OnCategoryEdited(object? sender, EventArgs<UserCategory> e)
    {
        ContinueInMainThread(() =>
        {
            CategoryEdited?.Invoke(this, e);
            SetState();
        });
    }

    /// <summary>
    /// Raises the <see cref="CategoryRemoved"/> event.
    /// </summary>
    /// <param name="e">
    /// An <see cref="EventArgs{T}"/> containing the <see cref="UserCategory"/> instance 
    /// that was deleted / removed.
    /// </param>
    public void OnCategoryRemoved(object? sender, EventArgs<UserCategory> e)
    {
        ContinueInMainThread(() =>
        {
            CategoryRemoved?.Invoke(this, e);
            SetState();
        });
    }

    /// <summary>
    /// Raises the<see cref="CategorySelectionChanged"/> event.
    /// </summary>
    /// <param name="e">
    /// The <see cref="EventArgs"/> instance containing the event data.
    /// </param>
    /// 
    public void OnCategorySelectionChanged(object? sender, EventArgs e)
    {
        ContinueInMainThread(() =>
        {
            CategorySelectionChanged?.Invoke(this, e);
            SetState();
        });
    }
    #endregion

    #region Protected Method Overrides    
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        CategoryList.SelectedIndexChanged += HandleSelectedIndexChanged;

        CategoryMenuAdd.Click += HandleMenuAddClicked;
        CategoryMenuEdit.Click += HandleMenuEditClicked;
        CategoryMenuRemove.Click += HandleMenuRemoveClicked;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        CategoryList.SelectedIndexChanged -= HandleSelectedIndexChanged;

        CategoryMenuAdd.Click -= HandleMenuAddClicked;
        CategoryMenuEdit.Click -= HandleMenuEditClicked;
        CategoryMenuRemove.Click -= HandleMenuRemoveClicked;
    }

    /// <summary>
    /// Initializes the control and dialog state according to the form data.
    /// </summary>
    protected override void InitializeDataContent()
    {
        CategoryList.Items.Add("(Uncategorized)");
        if (_categories == null)
            _categories = new UserCategoryCollection();


        foreach (UserCategory category in _categories)
        {
            CategoryList.Items.Add(category.Name!);
        }

        CategoryList.SelectedIndex = 0;
    }

    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        CategoryList.Enabled = false;
        ContextMenu.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        CategoryList.Enabled = true;
        ContextMenu.Enabled = true;
        ResumeLayout();
    }

    /// <summary>
    /// When implemented in a derived class, sets the display state for the controls on the dialog based on
    /// current conditions.
    /// </summary>
    /// <remarks>
    /// This is called by <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveControlBase.SetState" /> after <see cref="M:Adaptive.Intelligence.Shared.UI.AdaptiveControlBase.SetSecurityState" /> is called.
    /// </remarks>
    protected override void SetDisplayState()
    {
        bool hasCategories = _categories != null && _categories.Count > 0;
        bool isSelected = CategoryList.SelectedIndex > 0;

        CategoryMenuEdit.Enabled = hasCategories && isSelected;
        CategoryMenuRemove.Enabled = hasCategories && isSelected;
    }
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Clears the content of th UI control.
    /// </summary>
    public void ClearContent()
    {
        _categories = null;
        CategoryList.Items.Clear();
    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the selected index changes.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleSelectedIndexChanged(object? sender, EventArgs e)
    {
        OnCategorySelectionChanged(sender, e);
        SetState();
    }

    /// <summary>
    /// Handles the event when the Add menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleMenuAddClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        AddEditCategoryDialog dialog = new AddEditCategoryDialog();
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            UserCategory? newCategory = dialog.Category;
            if (newCategory != null)
            {
                _categories!.Add(newCategory);
                OnCategoryCreated(this, new EventArgs<UserCategory>(newCategory));
                CategoryList.Items.Add(newCategory.Name!);
            }
        }

        dialog.Dispose();
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the EDit menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleMenuEditClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        AddEditCategoryDialog dialog = new AddEditCategoryDialog();
        dialog.Category = SelectedCategory;
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            if (dialog.Category != null)
            {
                OnCategoryEdited(this, new EventArgs<UserCategory>(dialog.Category));
                int index = CategoryList.SelectedIndex;
                CategoryList.Items[index] = dialog.Category.Name!;
            }
        }

        dialog.Dispose();
        SetPostLoadState();
        SetState();
    }


    /// <summary>
    /// Handles the event when the Remove menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleMenuRemoveClicked(object? sender, EventArgs e)
    {
        int index = CategoryList.SelectedIndex;
        if (index > 0 && _categories != null && index <= _categories.Count )
        {
            SetPreLoadState();
            bool isOk = GetUserConfirmation("Delete Category?", "Are you sure you wish to delete this category?  Any items assigned to this category will be re-assigned as non-categorized.  Continue?");
            if (isOk)
            {
                UserCategory item = _categories[index - 1];
                _categories.RemoveAt(index - 1);

                OnCategoryRemoved(this, new EventArgs<UserCategory>(item));
                CategoryList.Items.RemoveAt(index);
                
            }
        }

        SetPostLoadState();
        SetState();
    }
    #endregion
}
