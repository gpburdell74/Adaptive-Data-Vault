using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the UI for viewing or editing a secure note list item.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class SecureNoteListItem : AdaptiveControlBase
{
    #region Public Events
    /// <summary>
    /// Occurs when the user is categorizing the instance.
    /// </summary>
    public event EventHandler? CategorizeRequest;

    /// <summary>
    /// Occurs when an item is being deleted.
    /// </summary>
    public event Intelligence.Shared.EventHandler<SecureNote>? DeleteRequest;
    #endregion

    #region Private Member Declarations    
    /// <summary>
    /// The note instance.
    /// </summary>
    private SecureNote? _note;

    /// <summary>
    /// The selection flag.
    /// </summary>
    private bool _selected;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureNoteListItem"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public SecureNoteListItem()
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

        _note = null;
        components = null;
        base.Dispose(disposing);
    }

    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the Secure Note being edited.
    /// </summary>
    /// <value>
    /// The <see cref="SecureNote"/> being viewed or edited.
    /// </value>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public SecureNote? Note
    {
        get
        {
            return _note;
        }
        set
        {
            _note = value;
            SetControlValues();
            Invalidate();
        }
    }

    /// <summary>
    /// Gets a value indicating whether this <see cref="SecureNoteListItem"/> is selected.
    /// </summary>
    /// <value>
    ///   <c>true</c> if selected; otherwise, <c>false</c>.
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
        NameLabel.Click += HandleToggleSelection;
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
        NameLabel.Click -= HandleToggleSelection;
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
        EditButton.Enabled = true;
        UserInfoButton.Enabled = true;
        DeleteButton.Enabled = true;
        Application.DoEvents();
        SuspendLayout();
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
            CategorizeRequest?.Invoke(this, e);
        });
    }
    /// <summary>
    /// Raises the <see cref="E:DeleteRequest" /> event.
    /// </summary>
    /// <param name="evArgs">The <see cref="EventArgs{SecureNote}"/> instance containing the event data.</param>
    private void OnDeleteRequest(EventArgs<SecureNote> evArgs)
    {
        ContinueInMainThread(delegate
        {
            DeleteRequest?.Invoke(this, evArgs);
        });
    }

    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the User Info button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleUserClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_note != null)
        {
            SecureNoteInfoDialog secureNoteInfoDialog = new SecureNoteInfoDialog();
            secureNoteInfoDialog.Note = _note;
            secureNoteInfoDialog.ShowDialog();
            secureNoteInfoDialog.Dispose();
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the New menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleNewClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        AddEditSecureNoteDialog addEditSecureNoteDialog = new AddEditSecureNoteDialog();
        DialogResult dialogResult = addEditSecureNoteDialog.ShowDialog();
        if (dialogResult == DialogResult.OK && base.Parent != null)
        {
            ((SecureNoteListControl)base.Parent).AddNewItem();
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Edit button or menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleEditClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        AddEditSecureNoteDialog addEditSecureNoteDialog = new AddEditSecureNoteDialog();
        addEditSecureNoteDialog.Note = _note;
        DialogResult dialogResult = addEditSecureNoteDialog.ShowDialog();
        if (dialogResult == DialogResult.OK)
        {
            SetControlValues();
            OnContentChanged(EventArgs.Empty);
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Delete button or menu item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleDeleteClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_note != null && AdaptiveControlBase.GetUserConfirmation("Delete This Entry?", "Are you sure you want to delete the entry for: " + _note.Name + "?  This action cannot be undone."))
        {
            OnDeleteRequest(new EventArgs<SecureNote>(_note));
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
    /// Sets the data content on the control.
    /// </summary>
    private void SetControlValues()
    {
        if (_note != null)
        {
            NameLabel.Text = _note.Name;
        }
    }
    #endregion
}
