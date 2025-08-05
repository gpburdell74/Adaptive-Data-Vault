using Adaptive.Data.Vault.OS;
using Adaptive.Intelligence.Shared;
using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a control for displaying a Secure Note as a line item.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class SecureNoteListItem : AdaptiveControlBase
{
    #region Public Events
    /// <summary>
    /// Occurs when the user clicks the Categorize menu item.
    /// </summary>
    public event EventHandler? CategorizeRequest;

    /// <summary>
    /// Occurs when a user attempts to delete an entry.
    /// </summary>
    public event Intelligence.Shared.EventHandler<SecureNote>? DeleteRequest;
    #endregion

    #region Private Member Declarations
    /// <summary>
    /// The account
    /// </summary>
    private SecureNote? _note;

    /// <summary>
    /// The selected flag.
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
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
    /// Gets or sets the reference to the secure note being shown.
    /// </summary>
    /// <value>
    /// The <see cref="SecureNote"/> instance.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public SecureNote? Note
    {
        get => _note;
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
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool Selected => _selected;

    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        // General
        Click += HandleToggleSelection;
        SelectionIndicator.Click += HandleToggleSelection;

        // Labels.
        NameLabel.Click += HandleToggleSelection;

        // Menu.
        ContextMenuNew.Click += HandleNewClicked;
        ContextMenuEdit.Click += HandleEditClicked;
        ContextMenuDelete.Click += HandleDeleteClicked;
        ContextMenuCategorize.Click += HandleCategorizeClicked;
        ContextMenuProperties.Click += HandleUserClicked;

        // Buttons.
        UserInfoButton.Click += HandleUserClicked;
        EditButton.Click += HandleEditClicked;
        DeleteButton.Click += HandleDeleteClicked;
        ContainerPanel.Click += HandleToggleSelection;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        // General
        Click -= HandleToggleSelection;
        SelectionIndicator.Click -= HandleToggleSelection;

        // Labels.
        NameLabel.Click -= HandleToggleSelection;

        // Menu.
        ContextMenuNew.Click -= HandleNewClicked;
        ContextMenuEdit.Click -= HandleEditClicked;
        ContextMenuDelete.Click -= HandleDeleteClicked;
        ContextMenuCategorize.Click -= HandleCategorizeClicked;
        ContextMenuProperties.Click -= HandleUserClicked;

        // Buttons.
        UserInfoButton.Click -= HandleUserClicked;
        EditButton.Click -= HandleEditClicked;
        DeleteButton.Click -= HandleDeleteClicked;
        ContainerPanel.Click -= HandleToggleSelection;
    }
    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
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
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    /// <returns></returns>
    private void OnCategorizeRequest(EventArgs e)
    {
        ContinueInMainThread(() =>
        {
            CategorizeRequest?.Invoke(this, e);
        });
    }

    /// <summary>
    /// Raises the <see cref="DeleteRequest" /> event.
    /// </summary>
    /// <param name="evArgs">
    /// The <see cref="EventArgs{T}"/> of <see cref="SecureNote"/> instance containing the 
    /// reference to the <see cref="SecureNote"/> entry to be deleted.
    /// </param>
    private void OnDeleteRequest(EventArgs<SecureNote> evArgs)
    {
        ContinueInMainThread(() =>
        {
            DeleteRequest?.Invoke(this, evArgs);
        });
    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the user info button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleUserClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        if (_note != null)
        {
            SecureNoteInfoDialog dialog = new SecureNoteInfoDialog();
            dialog.Note = _note;
            dialog.ShowDialog();

            dialog.Dispose();
        }

        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the Context Menu New Item is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleNewClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        AddEditSecureNoteDialog dialog = new AddEditSecureNoteDialog();
        DialogResult result = dialog.ShowDialog();

        if (result == DialogResult.OK)
        {
            if (Parent != null)
                ((SecureNoteListControl)Parent).AddNewItem();
        }

        SetPostLoadState();
        SetState();
    }
    /// <summary>
    /// Handles the event when the edit button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleEditClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        AddEditSecureNoteDialog dialog = new AddEditSecureNoteDialog();
        dialog.Note = _note;
        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            SetControlValues();
            OnContentChanged(EventArgs.Empty);
        }
        SetPostLoadState();
        SetState();
    }

    /// <summary>
    /// Handles the event when the delete button is clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleDeleteClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();

        if (_note != null)
        {
            bool canDelete = GetUserConfirmation("Delete This Entry?",
                $"Are you sure you want to delete the entry for: {_note.Name}?  This action cannot be undone.");

            if (canDelete)
            {
                OnDeleteRequest(new EventArgs<SecureNote>(_note));
            }
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
    /// Handles the event when the control is clicked to toggle a selected / not selected status.
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
    /// Sets the control values based on the business object.
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
