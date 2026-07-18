using System.Drawing.Drawing2D;

namespace Adaptive.Data.Vault.UI;

/// <summary>
/// Displays a startup splash screen built from the application icon.
/// </summary>
internal sealed class SplashScreenDialog : Form
{
    #region Private Member Declarations
    /// <summary>
    /// The cached icon used for rendering.
    /// </summary>
    private readonly Icon? _appIcon;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="SplashScreenDialog"/> class.
    /// </summary>
    public SplashScreenDialog()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        ShowInTaskbar = false;
        TopMost = true;
        DoubleBuffered = true;
        ClientSize = new Size(640, 360);

        _appIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }

    /// <summary>
    /// Releases managed resources.
    /// </summary>
    /// <param name="disposing">true when managed resources should be released; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _appIcon?.Dispose();
        }

        base.Dispose(disposing);
    }
    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Renders the splash screen content.
    /// </summary>
    /// <param name="e">The paint event arguments.</param>
    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle bounds = ClientRectangle;
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using LinearGradientBrush backgroundBrush = new LinearGradientBrush(
            bounds,
            Color.FromArgb(16, 34, 66),
            Color.FromArgb(38, 92, 161),
            LinearGradientMode.ForwardDiagonal);
        graphics.FillRectangle(backgroundBrush, bounds);

        using Pen borderPen = new Pen(Color.FromArgb(210, 232, 255), 2F);
        graphics.DrawRectangle(borderPen, 1, 1, bounds.Width - 3, bounds.Height - 3);

        const int iconSize = 128;
        int iconX = (bounds.Width - iconSize) / 2;
        int iconY = 55;

        if (_appIcon != null)
        {
            graphics.DrawIcon(_appIcon, new Rectangle(iconX, iconY, iconSize, iconSize));
        }

        using StringFormat centered = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        using Font titleFont = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
        using SolidBrush titleBrush = new SolidBrush(Color.White);
        graphics.DrawString("Adaptive Data Vault", titleFont, titleBrush, new Rectangle(20, 205, bounds.Width - 40, 54), centered);

        using Font subtitleFont = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        using SolidBrush subtitleBrush = new SolidBrush(Color.FromArgb(225, 240, 255));
        graphics.DrawString("Secure Password and Data Protection", subtitleFont, subtitleBrush, new Rectangle(20, 262, bounds.Width - 40, 32), centered);

        using Font loadingFont = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
        using SolidBrush loadingBrush = new SolidBrush(Color.FromArgb(220, 236, 255));
        graphics.DrawString("Loading...", loadingFont, loadingBrush, new Rectangle(20, 305, bounds.Width - 40, 24), centered);
    }
    #endregion
}
