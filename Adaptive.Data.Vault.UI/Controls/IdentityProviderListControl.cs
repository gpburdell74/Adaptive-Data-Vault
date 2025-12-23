using Adaptive.Intelligence.Shared;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the control to display the list of identity providers in the selected category.
/// </summary>
/// <seealso cref="UserControl" />
public partial class IdentityProviderListControl : UserControl
{
    #region Public Events
    /// <summary>
    /// Occurs when the content in the control is modified.
    /// </summary>
    public event EventHandler? ContentChanged;

    /// <summary>
    /// Occurs when an item is added to the list.
    /// </summary>
    public event Intelligence.Shared.EventHandler<IdentityProvider>? ItemAdded;

    /// <summary>
    /// Occurs when an item is deleted from the list.
    /// </summary>
    public event Intelligence.Shared.EventHandler<IdentityProvider>? ItemDeleted;
    #endregion

    #region Private Member Declarations
    /// <summary>
    /// The list of ID providers.
    /// </summary>
    private IdentityProviderCollection? _list;

    /// <summary>
    /// The manager.
    /// </summary>
    private VaultManager? _manager;

    /// <summary>
    /// The currently specified category.
    /// </summary>
    private UserCategory? _category;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityProviderListControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public IdentityProviderListControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources;
    /// <c>false</c> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            components?.Dispose();
        }

        components = null;
        _list = null;
        _manager = null;
        _category = null;

        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the currently selected category.
    /// </summary>
    /// <value>
    /// The <see cref="UserCategory"/> instance selected by the user.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public UserCategory? Category
    {
        get
        {
            return _category;
        }
        set
        {
            _category = value;
            PopulateList();
            Invalidate();
        }
    }

    /// <summary>
    /// Gets or sets the reference to the vault manager.
    /// </summary>
    /// <value>
    /// The <see cref="VaultManager"/> instance used to manage the secure data.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public VaultManager? Manager
    {
        get
        {
            return _manager;
        }
        set
        {
            _manager = value;
            Guid? categoryId = _category?.Id;
            if (!categoryId.HasValue)
            {
                categoryId = Guid.Empty;
            }
            if (_manager != null)
            {
                _list = _manager.GetIdentityProvidersForCategory(categoryId);
            }
            else
            {
                _list?.Clear();
            }
            PopulateList();
            Invalidate();
        }
    }
    #endregion

    #region Protected Method Overrides    
    /// <summary>
    /// Raises the <see cref="E:Load" /> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AssignEventHandlers();
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
    protected override void OnHandleDestroyed(EventArgs e)
    {
        RemoveEventHandlers();
        base.OnHandleDestroyed(e);
    }
    #endregion

    #region Private Event Methods
    /// <summary>
    /// Raises the <see cref="E:ItemAdded" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs{IdentityProvider}"/> instance containing the event data.</param>
    private void OnItemAdded(EventArgs<IdentityProvider> e)
    {
        ItemAdded?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="E:ItemDeleted" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs{IdentityProvider}"/> instance containing the event data.</param>
    private void OnItemDeleted(EventArgs<IdentityProvider> e)
    {
        ItemDeleted?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="E:ContentChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void OnContentChanged(EventArgs e)
    {
        ContentChanged?.Invoke(this, e);
    }
    #endregion

    #region Private Event Handlers

    /// <summary>
    /// Handles the event when the  New Account button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleNewAccountButtonClicked(object? sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        ContainerPanel.Enabled = false;
        AddEditIdentityProviderDialog addEditIdentityProviderDialog = new AddEditIdentityProviderDialog();
        DialogResult dialogResult = addEditIdentityProviderDialog.ShowDialog();
        if (dialogResult == DialogResult.OK)
        {
            IdentityProvider? idProvider = addEditIdentityProviderDialog.IdProvider;
            if (_list != null && idProvider != null)
            {
                ContainerPanel.Visible = false;
                _list.Add(idProvider);
                _list.SortAlpha();
                OnItemAdded(new EventArgs<IdentityProvider>(idProvider));
                PopulateList();
                ContainerPanel.Visible = true;
                OnContentChanged(EventArgs.Empty);
            }
        }
        ContainerPanel.Enabled = true;
        Cursor = Cursors.Default;
    }

    /// <summary>
    /// Handles the event when the Delete request is received.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs{IdentityProvider}"/> instance containing the event data.</param>
    private void HandleDeleteRequest(object? sender, EventArgs<IdentityProvider> e)
    {
        if (_list != null && e.Data != null)
        {
            _list.Remove(e.Data);
            IdProviderListItem? idProviderListItem = (IdProviderListItem?)sender;
            if (idProviderListItem != null && ContainerPanel.Controls.Contains(idProviderListItem))
            {
                ContainerPanel.Controls.Remove(idProviderListItem);
                idProviderListItem.ContentChanged -= HandleContentChanged;
                idProviderListItem.DeleteRequest -= HandleDeleteRequest;
                idProviderListItem.Dispose();
                OnItemDeleted(new EventArgs<IdentityProvider>(e.Data));
            }
        }
        OnContentChanged(EventArgs.Empty);
        Invalidate();
    }

    /// <summary>
    /// Handles the event when the category request.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCategoryRequest(object? sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        SelectCategoryDialog selectCategoryDialog = new SelectCategoryDialog();
        selectCategoryDialog.Manager = _manager;
        DialogResult dialogResult = selectCategoryDialog.ShowDialog();
        if (dialogResult != DialogResult.OK)
        {
            return;
        }
        UserCategory? selectedCategory = selectCategoryDialog.SelectedCategory;
        if (selectedCategory != null)
        {
            foreach (IdProviderListItem control in ContainerPanel.Controls)
            {
                if (control.Selected && control.Provider != null && selectedCategory != null)
                {
                    control.Provider.CategoryId = selectedCategory.Id;
                }
            }
        }
    }

    /// <summary>
    /// Handles the event when the content changes.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleContentChanged(object? sender, EventArgs e)
    {
        OnContentChanged(e);
    }
    #endregion

    #region Private Methods /  Functions    
    /// <summary>
    /// Adds the new item.
    /// </summary>
    public void AddNewItem()
    {
        HandleNewAccountButtonClicked(this, EventArgs.Empty);
    }

    /// <summary>
    /// Clears the list content.
    /// </summary>
    public void ClearList()
    {
        Visible = false;

        foreach (IdProviderListItem control in ContainerPanel.Controls)
        {
            control.CategorizeRequest += HandleCategoryRequest;
            control.ContentChanged -= HandleContentChanged;
            control.DeleteRequest -= HandleDeleteRequest;
            control.Dispose();
        }
        ContainerPanel.Controls.Clear();
        GC.Collect();
        
        Visible = true;
    }
    /// <summary>
    /// Assigns the event handlers.
    /// </summary>
    private void AssignEventHandlers()
    {
        NewAccountButton.Click += HandleNewAccountButtonClicked;
    }

    /// <summary>
    /// Removes the event handlers.
    /// </summary>
    private void RemoveEventHandlers()
    {
        NewAccountButton.Click -= HandleNewAccountButtonClicked;
    }

    /// <summary>
    /// Populates the list content.
    /// </summary>
    private void PopulateList()
    {
        SuspendLayout();
        ClearList();
        ResumeLayout();
        Application.DoEvents();
        SuspendLayout();
        if (_list != null)
        {
            int index = 0;
            Control[] array = new Control[_list.Count];
            for (int count = _list.Count - 1; count >= 0; count--)
            {
                IdentityProvider provider = _list[count];
                IdProviderListItem idProviderListItem = new IdProviderListItem();
                idProviderListItem.Provider = provider;
                idProviderListItem.Dock = DockStyle.Top;
                idProviderListItem.Visible = true;
                idProviderListItem.Width = base.Width;
                idProviderListItem.CategorizeRequest += HandleCategoryRequest;
                idProviderListItem.ContentChanged += HandleContentChanged;
                idProviderListItem.DeleteRequest += HandleDeleteRequest;
                array[index] = idProviderListItem;
                index++;
            }
            ContainerPanel.Controls.AddRange(array);
        }
        ResumeLayout();
    }
    #endregion
}
