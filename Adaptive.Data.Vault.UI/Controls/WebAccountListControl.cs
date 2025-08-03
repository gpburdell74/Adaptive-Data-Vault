using Adaptive.Intelligence.Shared;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the container control for the custom Web Account List Item controls.
/// </summary>
/// <seealso cref="Panel" />
public partial class WebAccountListControl : UserControl
{
    #region Events
    /// <summary>
    /// Occurs when the content changes.
    /// </summary>
    public event EventHandler? ContentChanged;

    /// <summary>
    /// Occurs when a new entry is added.
    /// </summary>
    public event Intelligence.Shared.EventHandler<WebAccount>? ItemAdded;

    /// <summary>
    /// Occurs when an item is deleted.
    /// </summary>
    public event Intelligence.Shared.EventHandler<WebAccount>? ItemDeleted;
    #endregion

    #region Private Member Declarations
    /// <summary>
    /// The list of accounts to display.
    /// </summary>
    private WebAccountCollection? _list;

    /// <summary>
    /// The manager instance.
    /// </summary>
    private VaultManager? _manager;

    /// <summary>
    /// The current user category.
    /// </summary>
    private UserCategory? _category;

    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="WebAccountListControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public WebAccountListControl()
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
        _list = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the reference to the currently selected user category.
    /// </summary>
    /// <value>
    /// The <see cref="UserCategory"/> instance selected by the user.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public UserCategory? Category
    {
        get => _category;
        set
        {
            _category = value;
            PopulateList();
            Invalidate();
        }
    }

    /// <summary>
    /// Gets or sets the reference to the vault manager instance.
    /// </summary>
    /// <value>
    /// The <see cref="VaultManager"/> instance being operated on.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public VaultManager? Manager
    {
        get => _manager;
        set
        {
            _manager = value;
            Guid? categoryId = _category?.Id;
            if(categoryId == null)
                categoryId = Guid.Empty;
            if (_manager != null)
                _list = _manager.GetWebAccountsForCategory(categoryId);
            else
                _list?.Clear();

            PopulateList();
            Invalidate();
        }
    }
    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Raises the <see cref="Load" /> event.
    /// </summary>
    /// <param name="e">An <see cref="EventArgs" /> that contains the event data.
    /// </param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AssignEventHandlers();
    }

    /// <summary>
    /// Raises the <see cref="HandleDestroyed" /> event.
    /// </summary>
    /// <param name="e">
    /// An <see cref=EventArgs" /> that contains the event data.
    /// </param>
    protected override void OnHandleDestroyed(EventArgs e)
    {
        RemoveEventHandlers();
        base.OnHandleDestroyed(e);
    }

    /// <summary>
    /// Raises the <see cref="ItemAdded" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs{WebAccount}"/> instance containing the event data.</param>
    private void OnItemAdded(EventArgs<WebAccount> e)
    {
        ItemAdded?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="ItemDeleted" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs{WebAccount}"/> instance containing the event data.</param>
    private void OnItemDeleted(EventArgs<WebAccount> e)
    {
        ItemDeleted?.Invoke(this, e);
    }
    #endregion

    /// <summary>
    /// Invoked by child members to create a new account entry.
    /// </summary>
    public void AddNewItem()
    {
        HandleNewAccountButtonClicked(this, EventArgs.Empty);
    }

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the New Account button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleNewAccountButtonClicked(object? sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        ContainerPanel.Enabled = false;

        AddEditWebAccountDialog dialog = new AddEditWebAccountDialog();
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            // Add the new account to the list.
            WebAccount? newAccount = dialog.Account;
            if (_list != null && newAccount != null)
            {
                ContainerPanel.Visible = false;
                _list.Add(newAccount);
                _list.SortAlpha();

                OnItemAdded(new EventArgs<WebAccount>(newAccount));

                PopulateList();
                ContainerPanel.Visible = true;
                OnContentChanged(EventArgs.Empty);
            }
        }
        
        ContainerPanel.Enabled = true;
        Cursor = Cursors.Default;
    }
    /// <summary>
    /// Handles the event when the user deletes an entry.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs{WebAccount}"/> instance containing the event data.</param>
    private void HandleDeleteRequest(object? sender, EventArgs<WebAccount> e)
    {
        if (_list != null && e.Data != null)
        {
            // Remove the record.
            _list.Remove(e.Data);

            // Remove the control.
            WebAccountListItem? item = (WebAccountListItem?)sender;
            if (item != null && ContainerPanel.Controls.Contains(item))
            {
                // Remove the control instance.
                ContainerPanel.Controls.Remove(item);
                item.ContentChanged -= HandleContentChanged;
                item.DeleteRequest -= HandleDeleteRequest;
                item.Dispose();

                // Remove the business object.
                OnItemDeleted(new EventArgs<WebAccount>(e.Data));
            }
        }
        OnContentChanged(EventArgs.Empty);
        Invalidate();
    }

    /// <summary>
    /// Handles the event when a category request is received.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCategoryRequest(object? sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        SelectCategoryDialog dialog = new SelectCategoryDialog();
        dialog.Manager = _manager;
        DialogResult result = dialog.ShowDialog();
        
        if (result == DialogResult.OK)
        {
            UserCategory? selectedCategory = dialog.SelectedCategory;

            foreach (WebAccountListItem item in ContainerPanel.Controls)
            {
                if (item.Selected && item.Account != null && selectedCategory != null)
                    item.Account.CategoryId = selectedCategory.Id;
            }
        }

    }
    #endregion

    #region Private Event Methods
    /// <summary>
    /// Raises the <see cref="ContentChanged" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void OnContentChanged(EventArgs e)
    {
        ContentChanged?.Invoke(this, e);
    }
    /// <summary>
    /// Handles the event when the content changes for an item in the list.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleContentChanged(object? sender, EventArgs e)
    {
        OnContentChanged(e);
    }
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Clears all the contained controls.
    /// </summary>
    public void ClearList()
    {
        Visible = false;
        foreach (WebAccountListItem ctl in ContainerPanel.Controls)
        {
            ctl.CategorizeRequest += HandleCategoryRequest;
            ctl.ContentChanged -= HandleContentChanged;
            ctl.DeleteRequest -= HandleDeleteRequest;
            ctl.Dispose();
        }
        ContainerPanel.Controls.Clear();
        GC.Collect();
        Visible = true;
    }
    #endregion

    #region Private Methods / Functions
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
    /// Populates the list.
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
            int pos = 0;
            Control[] controlList = new Control[_list.Count];
            for (int index = _list.Count-1; index >= 0; index--)
            {
                WebAccount account = _list[index];
                WebAccountListItem itemEntry = new WebAccountListItem();
                itemEntry.Account = account;
                itemEntry.Dock = DockStyle.Top;
                itemEntry.Visible = true;
                itemEntry.Width = this.Width;
                itemEntry.CategorizeRequest += HandleCategoryRequest;
                itemEntry.ContentChanged += HandleContentChanged;
                itemEntry.DeleteRequest += HandleDeleteRequest;
                controlList[pos] = itemEntry;
                pos++;
            }

            ContainerPanel.Controls.AddRange(controlList);
        }

        ResumeLayout();
    }
    #endregion
}
