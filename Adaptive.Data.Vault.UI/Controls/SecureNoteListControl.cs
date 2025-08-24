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

public partial class SecureNoteListControl : UserControl
{
    public event EventHandler? ContentChanged;

    public event Adaptive.Intelligence.Shared.EventHandler<SecureNote>? ItemAdded;

    public event Adaptive.Intelligence.Shared.EventHandler<SecureNote>? ItemDeleted;


    private SecureNoteCollection? _list;
    private VaultManager? _manager;
    private UserCategory? _category;

    public SecureNoteListControl()
    {
        InitializeComponent();
    }

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

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        AssignEventHandlers();
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
        RemoveEventHandlers();
        base.OnHandleDestroyed(e);
    }

    private void OnItemAdded(EventArgs<SecureNote> e)
    {
        this.ItemAdded?.Invoke(this, e);
    }

    private void OnItemDeleted(EventArgs<SecureNote> e)
    {
        this.ItemDeleted?.Invoke(this, e);
    }

    private void OnContentChanged(EventArgs e)
    {
        this.ContentChanged?.Invoke(this, e);
    }

    private void HandleNewAccountButtonClicked(object? sender, EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        ContainerPanel.Enabled = false;
        AddEditSecureNoteDialog addEditSecureNoteDialog = new AddEditSecureNoteDialog();
        DialogResult dialogResult = addEditSecureNoteDialog.ShowDialog();
        if (dialogResult == DialogResult.OK)
        {
            SecureNote note = addEditSecureNoteDialog.Note;
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

    private void HandleDeleteRequest(object? sender, EventArgs<SecureNote> e)
    {
        if (_list != null && e.Data != null)
        {
            _list.Remove(e.Data);
            SecureNoteListItem secureNoteListItem = (SecureNoteListItem)sender;
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
        UserCategory selectedCategory = selectCategoryDialog.SelectedCategory;
        foreach (SecureNoteListItem control in ContainerPanel.Controls)
        {
            if (control.Selected && control.Note != null && selectedCategory != null)
            {
                control.Note.CategoryId = selectedCategory.Id;
            }
        }
    }

    private void HandleContentChanged(object? sender, EventArgs e)
    {
        OnContentChanged(e);
    }


    public void AddNewItem()
    {
        HandleNewAccountButtonClicked(this, EventArgs.Empty);
    }

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

    private void AssignEventHandlers()
    {
        NewAccountButton.Click += HandleNewAccountButtonClicked;
    }

    private void RemoveEventHandlers()
    {
        NewAccountButton.Click -= HandleNewAccountButtonClicked;
    }

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
}
