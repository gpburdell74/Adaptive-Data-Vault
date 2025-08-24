using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a dialog for adding a new or editing an existing secure note.
/// </summary>
/// <seealso cref="AdaptiveDialogBase" />
public partial class AddEditSecureNoteDialog : BorderedDialog
{
    #region Private Member Declarations
    /// <summary>
    /// The category to edit.
    /// </summary>
    private SecureNote? _note;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="AddEditSecureNoteDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public AddEditSecureNoteDialog()
    {
        InitializeComponent();
        _note = new SecureNote();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AddEditSecureNoteDialog"/> class.
    /// </summary>
    /// <param name="categoryToEdit">
    /// The reference to the <see cref="SecureNote"/> instance to edit.
    /// </param>
    public AddEditSecureNoteDialog(SecureNote categoryToEdit)
    {
        InitializeComponent();
        _note = categoryToEdit;
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
    /// Gets or sets the reference to the secure note instance to be edited.
    /// </summary>
    /// <value>
    /// The <see cref="SecureNote"/> being created and / or edited.
    /// </value>
    [Browsable(false),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public SecureNote? Note
    {
        get => SecureNoteEdit.Note;
        set
        {
            _note = value;
            SecureNoteEdit.Note = _note;
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
        SaveCancel.SaveClicked += HandleSaveClicked;
        SaveCancel.CancelClicked += HandleCancelClicked;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        SaveCancel.SaveClicked -= HandleSaveClicked;
        SaveCancel.CancelClicked -= HandleCancelClicked;
    }
    /// <summary>
    /// Initializes the control and dialog state according to the form data.
    /// </summary>
    protected override void InitializeDataContent()
    {
        SecureNoteEdit.Note = _note;
    }

    /// <summary>
    /// Sets the state of the UI controls before the data content is loaded.
    /// </summary>
    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        SaveCancel.Enabled = false;
        SecureNoteEdit.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the state of the UI controls after the data content is loaded.
    /// </summary>
    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        SaveCancel.Enabled = true;
        SecureNoteEdit.Enabled = true;
        ResumeLayout();
    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the even when the Save button is clicked.
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
    /// Handles the even when the Cancel button is clicked.
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
