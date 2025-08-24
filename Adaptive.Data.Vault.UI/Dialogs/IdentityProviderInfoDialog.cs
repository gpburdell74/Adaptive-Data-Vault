using Adaptive.Data.Vault.OS;
using Adaptive.Intelligence.Shared.Logging;
using Adaptive.Intelligence.Shared.UI;
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

public partial class IdentityProviderInfoDialog : AdaptiveDialogBase
{
    private IdentityProvider? _provider;

    private bool _userIdChecked;

    public IdentityProviderInfoDialog()
    {
        InitializeComponent();
    }


    protected override void Dispose(bool disposing)
    {
        if (!base.IsDisposed && disposing)
        {
            components?.Dispose();
        }
        _provider = null;
        components = null;
        base.Dispose(disposing);
    }


    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IdentityProvider? IdProvider
    {
        get
        {
            return _provider;
        }
        set
        {
            _provider = value;
            Invalidate();
        }
    }


    protected override void InitializeDataContent()
    {
        Header.Text = _provider?.Name;
        AddressLabel.Text = _provider?.Url;
        if (_provider != null)
        {
            if (_provider.UserId != null)
            {
                UserIdLabel.Text = new string('*', _provider.UserId.Length);
            }
            if (_provider.Password != null)
            {
                PasswordLabel.Text = new string('*', _provider.Password.Length);
            }
        }
    }

    protected override void AssignEventHandlers()
    {
        AddressLabel.Click += HandleAddressClicked;
        ShowUserIdButton.Click += HandleShowUserIdClicked;
        ShowPasswordButton.Click += HandleShowPasswordClicked;
        CopyPasswordButton.Click += HandleCopyPasswordClicked;
        CopyUrlButton.Click += HandleCopyUrlClicked;
        CopyUserIdButton.Click += HandleCopyUserIdClicked;
        CloseButton.Click += HandleCloseClicked;
    }

    protected override void RemoveEventHandlers()
    {
        AddressLabel.Click -= HandleAddressClicked;
        ShowUserIdButton.Click -= HandleShowUserIdClicked;
        ShowPasswordButton.Click -= HandleShowPasswordClicked;
        CopyPasswordButton.Click -= HandleCopyPasswordClicked;
        CopyUrlButton.Click -= HandleCopyUrlClicked;
        CopyUserIdButton.Click -= HandleCopyUserIdClicked;
        CloseButton.Click -= HandleCloseClicked;
    }

    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        ShowUserIdButton.Enabled = false;
        ShowPasswordButton.Enabled = false;
        CopyPasswordButton.Enabled = false;
        CopyUrlButton.Enabled = false;
        CopyUserIdButton.Enabled = false;
        CloseButton.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        ShowUserIdButton.Enabled = true;
        ShowPasswordButton.Enabled = true;
        CopyPasswordButton.Enabled = true;
        CopyUrlButton.Enabled = true;
        CopyUserIdButton.Enabled = true;
        CloseButton.Enabled = true;
        ResumeLayout();
        Invalidate();
        Application.DoEvents();
    }


    private void HandleAddressClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.Url != null)
        {
            OSUtilities.StartBrowser(_provider.Url);
        }
        SetPostLoadState();
    }

    private void HandleShowUserIdClicked(object? sender, EventArgs e)
    {
        ShowUserIdButton.Checked = !ShowUserIdButton.Checked;
        if (_provider != null && _provider.UserId != null)
        {
            if (ShowUserIdButton.Checked)
            {
                UserIdLabel.Text = _provider.UserId;
            }
            else
            {
                UserIdLabel.Text = new string('*', _provider.UserId.Length);
            }
        }
    }

    private void HandleShowPasswordClicked(object? sender, EventArgs e)
    {
        ShowPasswordButton.Checked = !ShowPasswordButton.Checked;
        if (_provider != null && _provider.Password != null)
        {
            if (ShowPasswordButton.Checked)
            {
                PasswordLabel.Text = _provider.Password;
            }
            else
            {
                PasswordLabel.Text = new string('*', _provider.Password.Length);
            }
        }
        Invalidate();
    }

    private void HandleCopyPasswordClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.Password != null)
        {
            try
            {
                Clipboard.SetText(_provider.Password);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        SetPostLoadState();
    }

    private void HandleCopyUrlClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.Url != null)
        {
            try
            {
                Clipboard.SetText(_provider.Url);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        SetPostLoadState();
    }

    private void HandleCopyUserIdClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_provider != null && _provider.UserId != null)
        {
            try
            {
                Clipboard.SetText(_provider.UserId);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }
        SetPostLoadState();
    }

    private void HandleCloseClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        Application.DoEvents();
        base.DialogResult = DialogResult.OK;
        Close();
    }
}
