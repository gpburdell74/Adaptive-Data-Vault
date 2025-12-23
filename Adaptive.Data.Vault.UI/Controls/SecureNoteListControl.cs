using Adaptive.Intelligence.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Prvides a UI element for displaying a list of secure notes.
/// </summary>
/// <seealso cref="System.Windows.Forms.UserControl" />
public partial class SecureNoteListControl : UserControl
{
    #region Public Events    
    /// <summary>
    /// Occurs when the content changes.
    /// </summary>
    public event EventHandler? ContentChanged;

    /// <summary>
    /// Occurs when an item is added.
    /// </summary>
    public event Intelligence.Shared.EventHandler<SecureNote>? ItemAdded;

    /// <summary>
    /// Occurs when an item is deleted.
    /// </summary>
    public event Intelligence.Shared.EventHandler<SecureNote>? ItemDeleted;
    #endregion

    #region Private Member Declarations
    /// <summary>
    /// The list of secure notes.
    /// </summary>
    private SecureNoteCollection? _list;
    /// <summary>
    /// The manager reference.
    /// </summary>
    private VaultManager? _manager;
    /// <summary>
    /// The category.
    /// </summary>
    private UserCategory? _category;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureNoteListControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public SecureNoteListControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Control" /> and its child controls and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing"><see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
    protected override void Dispose(bool disposing)
    {
        if (!base.IsDisposed && disposing)
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
    /// Gets or sets the reference to the  category.
    /// </summary>
    /// <value>
    /// The <see cref="UserCategory"/> to which the secure notes belong.
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
    /// The <see cref="VaultManager"/> instance used to perform data operations.
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
                _list = _manager.GetSecureNotesForCategory(categoryId);
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
    /// Raises the <see cref="E:System.Windows.Forms.UserControl.Load" /> event.
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

    /// <summary>
    /// Raises the <see cref="E:ItemAdded" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs{SecureNote}"/> instance containing the event data.</param>
    private void OnItemAdded(EventArgs<SecureNote> e)
    {
        ItemAdded?.Invoke(this, e);
    }

    /// <summary>
    /// Raises the <see cref="E:ItemDeleted" /> event.
    /// </summary>
    /// <param name="e">The <see cref="EventArgs{SecureNote}"/> instance containing the event data.</param>
    private void OnItemDeleted(EventArgs<SecureNote> e)
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
    /// Handles the event when the New Account button clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void HandleNewAccountButtonClicked(object? sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        ContainerPanel.Enabled = false;
        AddEditSecureNoteDialog addEditSecureNoteDialog = new AddEditSecureNoteDialog();
        DialogResult dialogResult = addEditSecureNoteDialog.ShowDialog();
        if (dialogResult == DialogResult.OK)
        {
            SecureNote? note = addEditSecureNoteDialog.Note;
            if (_list != null && note != null)
            {
                ContainerPanel.Visible = false;
                _list.Add(note);
                _list.SortAlpha();
                OnItemAdded(new EventArgs<SecureNote>(note));
                PopulateList();
                ContainerPanel.Visible = true;
                OnContentChanged(EventArgs.Empty);
            }
        }
        ContainerPanel.Enabled = true;
        Cursor = Cursors.Default;
    }

    /// <summary>
    /// Handles the event for a delete request.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs{SecureNote}"/> instance containing the event data.</param>
    private void HandleDeleteRequest(object? sender, EventArgs<SecureNote> e)
    {
        if (_list != null && e.Data != null)
        {
            _list.Remove(e.Data);
            SecureNoteListItem? secureNoteListItem = (SecureNoteListItem?)sender;
            if (secureNoteListItem != null && ContainerPanel.Controls.Contains(secureNoteListItem))
            {
                ContainerPanel.Controls.Remove(secureNoteListItem);
                secureNoteListItem.ContentChanged -= HandleContentChanged;
                secureNoteListItem.DeleteRequest -= HandleDeleteRequest;
                secureNoteListItem.Dispose();
                OnItemDeleted(new EventArgs<SecureNote>(e.Data));
            }
        }
        OnContentChanged(EventArgs.Empty);
        Invalidate();
    }

    /// <summary>
    /// Handles the category request.
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
        foreach (SecureNoteListItem control in ContainerPanel.Controls)
        {
            if (control.Selected && control.Note != null && selectedCategory != null)
            {
                control.Note.CategoryId = selectedCategory.Id;
            }
        }
    }

    /// <summary>
    /// Handles the event when a contained control's content changes.
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
    /// Creates and adds a new item.
    /// </summary>
    public void AddNewItem()
    {
        HandleNewAccountButtonClicked(this, EventArgs.Empty);
    }

    /// <summary>
    /// Clears the list.
    /// </summary>
    public void ClearList()
    {
        base.Visible = false;
        foreach (SecureNoteListItem control in ContainerPanel.Controls)
        {
            control.CategorizeRequest += HandleCategoryRequest;
            control.ContentChanged -= HandleContentChanged;
            control.DeleteRequest -= HandleDeleteRequest;
            control.Dispose();
        }
        ContainerPanel.Controls.Clear();
        GC.Collect();
        base.Visible = true;
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
            int num = 0;
            Control[] array = new Control[_list.Count];
            for (int num2 = _list.Count - 1; num2 >= 0; num2--)
            {
                SecureNote note = _list[num2];
                SecureNoteListItem secureNoteListItem = new SecureNoteListItem();
                secureNoteListItem.Note = note;
                secureNoteListItem.Dock = DockStyle.Top;
                secureNoteListItem.Visible = true;
                secureNoteListItem.Width = base.Width;
                secureNoteListItem.CategorizeRequest += HandleCategoryRequest;
                secureNoteListItem.ContentChanged += HandleContentChanged;
                secureNoteListItem.DeleteRequest += HandleDeleteRequest;
                array[num] = secureNoteListItem;
                num++;
            }
            ContainerPanel.Controls.AddRange(array);
        }
        ResumeLayout();
    }
    #endregion
}
