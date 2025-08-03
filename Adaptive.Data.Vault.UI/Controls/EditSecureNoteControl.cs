using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a control for editing the content of a Secure Note entry.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class EditSecureNoteControl : AdaptiveControlBase
{
    #region Private Member Declarations
    /// <summary>
    /// The secure note instance.
    /// </summary>
    private SecureNote? _note;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="EditSecureNoteControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public EditSecureNoteControl()
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
    /// Gets or sets the reference to the secure note instance to edit.
    /// </summary>
    /// <value>
    /// The <see cref="SecureNote"/> instance to edit.
    /// </value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public SecureNote? Note
    {
        get
        {
            SaveControlValues();
            return _note;
        }
        set
        {
            _note = value;
            SetControlValues();
            Invalidate();
        }
    }
    #endregion

    #region Private Methods / Functions
    /// <summary>
    /// Saves the control values to the business object.
    /// </summary>
    private void SaveControlValues()
    {
        if (_note != null)
        {
            _note.Name = NameText.Text;
            _note.SecureContent = ContentText.Text;
        }

    }

    /// <summary>
    /// Sets the content of the control from the business object.
    /// </summary>
    private void SetControlValues()
    {
        if (_note != null)
        {
            NameText.Text = _note.Name;
            ContentText.Text = _note.SecureContent;
        }
    }
    #endregion
}
