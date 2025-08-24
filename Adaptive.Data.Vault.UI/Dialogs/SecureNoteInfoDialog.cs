using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

public partial class SecureNoteInfoDialog : AdaptiveDialogBase
{
    private SecureNote? _note;

    public SecureNoteInfoDialog()
    {
        InitializeComponent();
    }
    protected override void Dispose(bool disposing)
    {
        if (!base.IsDisposed && disposing)
        {
            components?.Dispose();
        }
        _note = null;
        components = null;
        base.Dispose(disposing);
    }



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
            Invalidate();
        }
    }
}
