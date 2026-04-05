using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Adaptive.Data.Vault.UI.Controls
{
    [DesignerCategory("Code")]
    public partial class VaultDialogHeader : UserControl
    {
        #region Private Member Declarations

        private Color _startColor = Color.FromArgb(255, 0, 0, 192);
        private Color _endColor = Color.FromArgb(255, 0, 255, 0);

        private string _titleText = "ADAPTIVE DATA VAULT";
        #endregion

        #region Constructor / Dispose Methods		
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultDialogHeader"/> class.
        /// </summary>
        /// <remarks>
        /// This is the default constructor.
        /// </remarks>
        public VaultDialogHeader()
        {
            // Set default size.
            Width = 800;
            Height = 300;
            SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
            SetStyle(ControlStyles.DoubleBuffer, value: true);
            SetStyle(ControlStyles.ResizeRedraw, value: true);
            SetStyle(ControlStyles.Selectable, value: false);
            SetStyle(ControlStyles.UserPaint, value: true);
            UpdateStyles();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the title text.
        /// </summary>
        /// <value>
        /// A string containing the title text.
        /// </value>
        [Category("Appearance"),
         Description("The text that will appear in this header."),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TitleText
        {
            get => _titleText;
            set
            {
                _titleText = value;
                Invalidate();
            }
        }
        #endregion

        #region Protected Method Overrides		
        /// <summary>
        /// Paints the background of the control.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            DrawInitialBackground(e.Graphics);
            DrawBottomBar(e.Graphics);
        }
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            WriteTitleText(e.Graphics);
        }
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
        #endregion

        #region Private Methods / Functions		
        /// <summary>
        /// Draws the initial background.
        /// </summary>
        /// <param name="g">The g.</param>
        private void DrawInitialBackground(Graphics g)
        {
            int width = (int)((float)Width / 4f * 3f);
            int height = Height;

            Rectangle mainRectangle = new Rectangle(0, 0, width + 1, height);
            Rectangle lineRect = new Rectangle(width - 1, 0, Width - width + 1, Height);

            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(lineRect, _endColor, _startColor, LinearGradientMode.Horizontal);
            g.FillRectangle(linearGradientBrush, lineRect);
            linearGradientBrush.Dispose();

            linearGradientBrush = new LinearGradientBrush(mainRectangle, _startColor, _endColor, LinearGradientMode.Horizontal);
            g.FillRectangle(linearGradientBrush, mainRectangle);
            linearGradientBrush.Dispose();
        }
        /// <summary>
        /// Draws the bottom bar.
        /// </summary>
        /// <param name="g">The g.</param>
        private void DrawBottomBar(Graphics g)
        {
            Color color = Color.FromArgb(255, 0, 128, 0);
            Color color2 = Color.FromArgb(255, 0, 0, 128);
            int halfWidth = (int)((float)base.Width / 2f);
            int barHeight = 8;
            Rectangle topRectangle = new Rectangle(0, base.Height - barHeight, halfWidth + 1, barHeight);
            Rectangle barRectangle = new Rectangle(halfWidth, base.Height - barHeight, base.Width - halfWidth, barHeight);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(barRectangle, color2, color, LinearGradientMode.Horizontal);
            g.FillRectangle(linearGradientBrush, barRectangle);
            linearGradientBrush.Dispose();
            linearGradientBrush = new LinearGradientBrush(topRectangle, color, color2, LinearGradientMode.Horizontal);
            g.FillRectangle(linearGradientBrush, topRectangle);
            linearGradientBrush.Dispose();
        }
        /// <summary>
        /// Writes the title text.
        /// </summary>
        /// <param name="g">The g.</param>
        private void WriteTitleText(Graphics g)
        {
            SolidBrush solidBrush = new SolidBrush(Color.White);
            Color color = Color.FromArgb(100, 128, 128, 128);
            Color color2 = Color.FromArgb(70, 128, 128, 128);
            SolidBrush brush = new SolidBrush(color);
            SolidBrush brush2 = new SolidBrush(color2);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            Font font = new Font("OCR A Extended", 24f, FontStyle.Bold);
            SizeF sizeF = g.MeasureString(_titleText, font);
            int num = (int)((float)base.Width / 2f - (float)(int)(sizeF.Width / 2f));
            g.DrawString(_titleText, font, brush2, num + 2, 17f);
            g.DrawString(_titleText, font, brush, num + 1, 16f);
            g.DrawString(_titleText, font, solidBrush, num, 15f);
            solidBrush.Dispose();
            font.Dispose();
        }
        #endregion
    }
}