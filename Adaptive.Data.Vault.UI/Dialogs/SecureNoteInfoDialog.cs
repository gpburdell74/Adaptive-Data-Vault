using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides the dialog to show the detail information and content for a secure note.
/// </summary>
/// <seealso cref="AdaptiveDialogBase" />
public partial class SecureNoteInfoDialog : AdaptiveDialogBase
{
    #region Private Member Declarations    
    /// <summary>
    /// The note being displayed.
    /// </summary>
    private SecureNote? _note;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureNoteInfoDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public SecureNoteInfoDialog()
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
    /// Gets or sets the reference to the secure note being viewed.
    /// </summary>
    /// <value>
    /// A <see cref="SecureNote"/> instance to display.
    /// </value>
    [Browsable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public SecureNote? Note
    {
        get => _note;
        set
        {
            _note = value;
            Invalidate();
        }
    }
    #endregion

    #region Protected Method Overrides
    #endregion

    #region Private Event Handlers
    #endregion

    #region
    #endregion

    #region Private Methods / Functions
    #endregion

    #region
    #endregion
}
