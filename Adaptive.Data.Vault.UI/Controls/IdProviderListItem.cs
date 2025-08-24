using Adaptive.Data.Vault.OS;
using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the UI to represent a list item in the Identity Providers list.
/// </summary>
/// <seealso cref="Adaptive.Intelligence.Shared.UI.AdaptiveControlBase" />
public partial class IdProviderListItem : AdaptiveControlBase
{
    #region Public Events    
    /// <summary>
    /// Occurs when a category change request is made.
    /// </summary>
    public event EventHandler? CategorizeRequest;

    /// <summary>
    /// Occurs when an item is deleted.
    /// </summary>
    public event Intelligence.Shared.EventHandler<IdentityProvider>? DeleteRequest;
    #endregion

    #region Private Member Declarations
    /// <summary>
    /// The ID provider instance being displayed.
    /// </summary>
    private IdentityProvider? _provider;

    /// <summary>
    /// The selected flag.
    /// </summary>
    private bool _selected;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="IdProviderListItem"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public IdProviderListItem()
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

        _provider = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the reference to the ID provider record being displayed.
    /// </summary>
    /// <value>
    /// The <see cref="IdentityProvider"/> instance whose content is being displayed.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IdentityProvider? Provider
    {
        get
        {
            return _provider;
        }
        set
        {
            _provider = value;
            SetControlValues();
            Invalidate();
        }
    }

    /// <summary>
    /// Gets a value indicating whether this <see cref="IdProviderListItem"/> is selected.
    /// </summary>
    /// <value>
    ///   <c>true</c> if the current item is marked as selected; otherwise, <c>false</c>.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool Selected => _selected;
    #endregion

    #region Protected Method Overrides    
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    /// <remarks>
    /// It is recommended that the overrides of this method call the base method.
    /// </remarks>
    protected override void AssignEventHandlers()
    {
        base.Click += HandleToggleSelection;
        SelectionIndicator.Click += HandleToggleSelection;
        UrlLabel.Click += HandleUrlLabelClick;
        NameLabel.Click += HandleToggleSelection;
        UrlLabel.Click += HandleToggleSelection;
        ContextMenuNew.Click += HandleNewClicked;
        ContextMenuEdit.Click += HandleEditClicked;
        ContextMenuDelete.Click += HandleDeleteClicked;
        ContextMenuCategorize.Click += HandleCategorizeClicked;
        ContextMenuProperties.Click += HandleUserClicked;
        UserInfoButton.Click += HandleUserClicked;
        EditButton.Click += HandleEditClicked;
        DeleteButton.Click += HandleDeleteClicked;
        ContainerPanel.Click += HandleToggleSelection;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    /// <remarks>
    /// It is recommended that the overrides of this method call the base method.
    /// </remarks>
    protected override void RemoveEventHandlers()
    {
        base.Click -= HandleToggleSelection;
        SelectionIndicator.Click -= HandleToggleSelection;
        UrlLabel.Click -= HandleUrlLabelClick;
        NameLabel.Click -= HandleToggleSelection;
        UrlLabel.Click -= HandleToggleSelection;
        ContextMenuNew.Click -= HandleNewClicked;
        ContextMenuEdit.Click -= HandleEditClicked;
        ContextMenuDelete.Click -= HandleDeleteClicked;
        ContextMenuCategorize.Click -= HandleCategorizeClicked;
        ContextMenuProperties.Click -= HandleUserClicked;
        UserInfoButton.Click -= HandleUserClicked;
        EditButton.Click -= HandleEditClicked;
        DeleteButton.Click -= HandleDeleteClicked;
        ContainerPanel.Click -= HandleToggleSelection;
    }

    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    /// <remarks>
    /// It is recommended that the overrides of this method call the base method.
    /// </remarks>
    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        NameLabel.Enabled = false;
        DescriptionLabel.Enabled = false;
        UrlLabel.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    /// <remarks>
    /// It is recommended that the overrides of this method call the base method.
    /// </remarks>
    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        NameLabel.Enabled = true;
        DescriptionLabel.Enabled = true;
        UrlLabel.Enabled = true;
        EditButton.Enabled = true;
        UserInfoButton.Enabled = true;
        DeleteButton.Enabled = true;
        Application.DoEvents();
        SuspendLayout();
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
        UrlLabel.TextAlign = ContentAlignment.MiddleLeft;
    }
    #endregion

    #region Private Event Methods    
    /// <summary>
    /// Raises the <see cref="E:CategorizeRequest" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void OnCategorizeRequest(EventArgs e)
    {
        ContinueInMainThread(delegate
        {
            this.CategorizeRequest?.Invoke(this, e);
        });
    }

    /// <summary>
    /// Raises the <see cref="E:DeleteRequest" /> event.
    /// </summary>
    /// <param name="evArgs">The <see cref="EventArgs{IdentityProvider}"/> instance containing the event data.</param>
    private void OnDeleteRequest(EventArgs<IdentityProvider> evArgs)
    {
        ContinueInMainThread(delegate
        {
            this.DeleteRequest?.Invoke(this, evArgs);
        });
    }
    #endregion

    #region Private Event Handlers

    /// <summary>
    /// Handles the event when the URL label is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleUrlLabelClick(object? sender, EventArgs e)
    {
        SetPreLoadState();
        OSUtilities.StartBrowser(_provider?.Url ?? string.Empty);
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the User Info button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleUserClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        IdentityProviderInfoDialog identityProviderInfoDialog = new IdentityProviderInfoDialog();
        identityProviderInfoDialog.IdProvider = _provider;
        identityProviderInfoDialog.ShowDialog();
        identityProviderInfoDialog.Dispose();
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the New button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleNewClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        AddEditIdentityProviderDialog addEditIdentityProviderDialog = new AddEditIdentityProviderDialog();
        DialogResult dialogResult = addEditIdentityProviderDialog.ShowDialog();
        if (dialogResult == DialogResult.OK && base.Parent != null)
        {
            ((IdentityProviderListControl)base.Parent).AddNewItem();
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Edit button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleEditClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        AddEditIdentityProviderDialog addEditIdentityProviderDialog = new AddEditIdentityProviderDialog();
        addEditIdentityProviderDialog.IdProvider = _provider;
        DialogResult dialogResult = addEditIdentityProviderDialog.ShowDialog();
        if (dialogResult == DialogResult.OK)
        {
            SetControlValues();
            OnContentChanged(EventArgs.Empty);
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Delete button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleDeleteClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && GetUserConfirmation("Delete This Entry?", "Are you sure you want to delete the entry for: " + _provider.Name + "?  This action cannot be undone."))
        {
            OnDeleteRequest(new EventArgs<IdentityProvider>(_provider));
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Categorize menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleCategorizeClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        OnCategorizeRequest(e);
        SetPostLoadState();
    }

    /// <summary>
    /// Handles the toggle selection event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleToggleSelection(object? sender, EventArgs e)
    {
        _selected = !_selected;
        SelectionIndicator.Visible = _selected;
        Invalidate();
        Refresh();
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Sets the control content from the underlying data.
    /// </summary>
    private void SetControlValues()
    {
        if (_provider != null)
        {
            NameLabel.Text = _provider.ProviderTypeName;
            DescriptionLabel.Text = _provider.Name;
            UrlLabel.Text = _provider.Url;
        }
    }
    #endregion
}
