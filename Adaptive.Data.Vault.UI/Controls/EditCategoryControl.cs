using Adaptive.Intelligence.Shared.UI;
using System.ComponentModel;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Provides a control for editing the content of user-defined category.
/// </summary>
/// <seealso cref="AdaptiveControlBase" />
public partial class EditCategoryControl : AdaptiveControlBase
{
    #region Private Member Declarations
    /// <summary>
    /// The secure note instance.
    /// </summary>
    private UserCategory? _category;
    #endregion

    #region Constructor / Dispose Methods    
    /// <summary>
    /// Initializes a new instance of the <see cref="EditCategoryControl"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public EditCategoryControl()
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

        _category = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Gets or sets the reference to the category instance to edit.
    /// </summary>
    /// <value>
    /// The <see cref="UserCategory"/> instance to edit.
    /// </value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public UserCategory? Category
    {
        get
        {
            SaveControlValues();
            return _category;
        }
        set
        {
            _category = value;
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
        if (_category != null)
        {
            _category.Name = NameText.Text;
        }
    }

    /// <summary>
    /// Sets the content of the control from the business object.
    /// </summary>
    private void SetControlValues()
    {
        if (_category != null)
        {
            NameText.Text = _category.Name;
        }
    }
    #endregion
}
