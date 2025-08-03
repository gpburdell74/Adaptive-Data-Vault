using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the control for displaying all the encrypted entries by categories.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class CategorizedItemsContainerControl : AdaptiveControlBase
{
    #region Private Member Declarations
    /// <summary>
    /// The selected category.
    /// </summary>
    private UserCategory? _category;

    /// <summary>
    /// The manager instance.
    /// </summary>
    private VaultManager? _manager;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="CategorizedItemsContainerControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public CategorizedItemsContainerControl()
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
        _category = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the vault data manager instance.
    /// </summary>
    /// <value>
    /// The <see cref="VaultManager"/> instance from the parent dialog.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public VaultManager? Manager
    {
        get => _manager;
        set
        {
            _manager = value;
            SetDisplayState();
        }
    }

    /// <summary>
    /// Gets or sets the currently selected category.
    /// </summary>
    /// <value>
    /// The <see cref="UserCategory"/> instance containing the ID of the currently selected 
    /// category, or <b>null</b> for all uncategorized items.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public UserCategory? SelectedCategory
    {
        get
        {
            return _category;
        }
        set
        {
            _category = value;
            SetDataContent();
            Invalidate();
        }
    }
    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        base.AssignEventHandlers();

        // Buttons.
        AccountsButton.Click += HandleAccountsClicked;
        IdProvidersButton.Click += HandleIdProvidersClicked;
        SecureNotesButton.Click += HandleSecureNotesClicked;

        // Lists.
        WebAccountsList.ContentChanged += HandleGenericContentChange;
        WebAccountsList.ItemAdded += HandleItemAdded;
        WebAccountsList.ItemDeleted += HandleItemDeleted;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        // Lists.
        WebAccountsList.ContentChanged -= HandleGenericContentChange;
        WebAccountsList.ItemAdded -= HandleItemAdded;
        WebAccountsList.ItemDeleted -= HandleItemDeleted;

        // Buttons.
        AccountsButton.Click -= HandleAccountsClicked;
        IdProvidersButton.Click -= HandleIdProvidersClicked;
        SecureNotesButton.Click -= HandleSecureNotesClicked;

        base.RemoveEventHandlers();
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
        WebAccountsList.Visible = AccountsButton.Checked;
        IdProvidersList.Visible = IdProvidersButton.Checked;
        SecureNotesList.Visible = SecureNotesButton.Checked;
    }
    #endregion

    #region Public Methods / Functions
    /// <summary>
    /// Clears the content of th UI control.
    /// </summary>
    public void ClearContent()
    {
        _manager = null;
        this.WebAccountsList.ClearList();

    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the Accounts button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleAccountsClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        AccountsButton.Checked = true;
        IdProvidersButton.Checked = false;
        SecureNotesButton.Checked = false;

        SetDataContent();
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when a new item is added.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs{T}"/> instance containing the event data.</param>
    private void HandleItemAdded(object? sender, EventArgs<WebAccount> e)
    {
        if (_manager != null && _manager.WebAccounts != null && e.Data != null)
        {
            _manager.WebAccounts.Add(e.Data);
            _manager.Save();
        }

    }

    /// <summary>
    /// Handles the event when an item is deleted.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs{T}"/> instance containing the event data.</param>
    private void HandleItemDeleted(object? sender, EventArgs<WebAccount> e)
    {
        if (_manager != null && _manager.WebAccounts != null && e.Data != null)
        {
            _manager.WebAccounts.Remove(e.Data);
        }
    }
    /// <summary>
    /// Handles the event when the Identity Providers button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleIdProvidersClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        AccountsButton.Checked = false;
        IdProvidersButton.Checked = true;
        SecureNotesButton.Checked = false;
        SetDataContent();

        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Secure Notes button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleSecureNotesClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        SecureNotesButton.Checked = true;
        IdProvidersButton.Checked = false;
        AccountsButton.Checked = false;
        SetDataContent();

        SetPostLoadState();
        SetState();

    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Sets the content of the data being displayed.
    /// </summary>
    private void SetDataContent()
    {
        SuspendLayout();
        if (AccountsButton.Checked)
        {
            WebAccountsList.Visible = true;
            SetWebAccountsList();
        }
        else if (IdProvidersButton.Checked)
        {
            IdProvidersList.Visible = true;
            SetIdProviderList();
        }
        else if (SecureNotesButton.Checked)
        {
            SecureNotesList.Visible = true;
            SetSecureNotesList();
        }
        ResumeLayout();
    }

    /// <summary>
    /// Sets the data content of the accounts list for the specified category.
    /// </summary>
    private void SetWebAccountsList()
    {
        if (_manager != null && _manager.WebAccounts != null)
        {
            // Set the list for the currently selected category.
            WebAccountsList.ClearList();
            WebAccountsList.Category = _category;
            WebAccountsList.Manager = _manager;
        }
    }

    /// <summary>
    /// Sets the data content of the id providers list for the specified category.
    /// </summary>
    private void SetIdProviderList()
    {

    }

    /// <summary>
    /// Sets the data content of the secure notes list for the specified category.
    /// </summary>
    private void SetSecureNotesList()
    {
    }
    #endregion
}