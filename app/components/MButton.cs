using app.globals;
using app.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.components;
internal class MButton : Button {
    public MButton() { 
        this.Cursor = Cursors.Hand;

        BorderColor      = Color.Gray;
        ClickBorderColor = Color.Black;
        HoverBorderColor = Color.Black;

        Background           = Color.White;
        ClickBackgroundColor = Color.Black;
        HoverBackgroundColor = Color.Black;

        Foreground           = Color.Black;
        ClickForegroundColor = Color.White;
        HoverForegroundColor = Color.White;

        _BorderWidth = 4;

    }

    private bool isHovered = false;
    private bool isClicked = false;

    private Color _BorderColor;
    private Color _HoverBorderColor;
    private Color _ClickBorderColor;

    private Color _Background;
    private Color _ClickBackgroundColor;
    private Color _HoverBackgroundColor;
    
    private Color _Foreground;
    private Color _ClickForegroundColor;
    private Color _HoverForegroundColor;

    private int _BorderWidth;

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Gray")]
    public Color BorderColor      { get { return _BorderColor; } set { _BorderColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Black")]
    public Color HoverBorderColor { get { return _HoverBorderColor; } set { _HoverBorderColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Black")]
    public Color ClickBorderColor { get { return _ClickBorderColor; } set { _ClickBorderColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")] 
    public Color Background           { get { return _Background; } set { _Background = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public Color ClickBackgroundColor { get { return _ClickBackgroundColor; } set { _ClickBackgroundColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Black")]
    public Color HoverBackgroundColor { get { return _HoverBackgroundColor; } set { _HoverBackgroundColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Black")]
    public Color Foreground           { get { return _Foreground; } set { _Foreground = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Black")]
    public Color ClickForegroundColor { get { return _ClickForegroundColor; } set { _ClickForegroundColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public Color HoverForegroundColor { get { return _HoverForegroundColor; } set { _HoverForegroundColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(4)]
    public int BorderWidth { get { return _BorderWidth; } set { _BorderWidth = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(5)]
    public int IconPadding { get; set; } = 5; // Padding between the icon and text

    private Icon prefixIcon = null;
    private Icon postfixIcon = null;


    // Override OnPaint to customize button drawing
    protected override void OnPaint(PaintEventArgs pevent) {

        base.OnPaint(pevent);

        // Get the Graphics object
        Graphics g = pevent.Graphics;

        // Set up the button's visual appearance (e.g., border, background color, etc.)
        Rectangle buttonRect = this.ClientRectangle;

        Pen borderPen;
        Brush backgroundBrush;
        Color textColor;

        if (isClicked) {
            borderPen = new Pen(_ClickBorderColor, _BorderWidth);
            backgroundBrush = new LinearGradientBrush(buttonRect, _ClickBackgroundColor, _ClickBackgroundColor, 45f);
            textColor = _ClickForegroundColor;
        }
        else if (isHovered) {
            borderPen = new Pen(_HoverBorderColor, _BorderWidth);
            backgroundBrush = new LinearGradientBrush(buttonRect, _HoverBackgroundColor, _HoverBackgroundColor, 45f);
            textColor = _HoverForegroundColor;
        }
        else {
            borderPen = new Pen(_BorderColor, _BorderWidth);
            backgroundBrush = new LinearGradientBrush(buttonRect, _Background, _Background, 45f);
            textColor = _Foreground;
        }

        g.FillRectangle(backgroundBrush, buttonRect);

        Image image = this.Image;

        if (image != null) {
            int size = Math.Min(image.Height, this.Height) - IconPadding * 2;
            image = ImageUtils.ChangeImageColor(
                ImageUtils.ResizeByAspectRatio(image, size, size),
                textColor);

            // Calculate the position to draw the icon
            int iconX = IconPadding;
            if (string.IsNullOrEmpty(this.Text)) {
                iconX = (this.Width - image.Width) / 2;
            }
            int iconY = (this.Height - image.Height) / 2;

            // Draw the icon
            g.DrawImageUnscaled(image, new Point(iconX, iconY));
        }

        g.DrawRectangle(borderPen, buttonRect);
        borderPen.Dispose();
        backgroundBrush.Dispose();

        if (image != null) {
            // Draw the button's text
            string buttonText = this.Text;
            using (Brush textBrush = new SolidBrush(textColor)) {
                float textX = image.Width + (2 * IconPadding);
                float textY = MathF.Ceiling((this.Height - MathF.Ceiling(g.MeasureString(buttonText, this.Font).Height)) / 2 + 1);
                g.DrawString(buttonText, this.Font, textBrush, textX, textY);
            }
        }
        else {
            // Draw the button's text
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(g, this.Text, this.Font, buttonRect, textColor, flags);
        }

    }

    // Handle mouse hover events to trigger changes
    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);
        isHovered = true;
        this.Invalidate(); // Redraw the button to apply hover effect
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseEnter(e);
        isHovered = false;
        this.Invalidate(); // Redraw the button to apply hover effect
    }

    // Handle mouse click events to trigger click effect
    protected override void OnMouseDown(MouseEventArgs mevent) {
        base.OnMouseDown(mevent);
        if (mevent.Button == MouseButtons.Left) {
            isClicked = true;
            this.Invalidate(); // Redraw the button to apply click effect
        }
    }

    protected override void OnMouseUp(MouseEventArgs mevent) {
        base.OnMouseUp(mevent);
        if (mevent.Button == MouseButtons.Left) {
            isClicked = false;
            this.Invalidate(); // Redraw the button to reset click effect
        }
    }

    // Optional: If you want to change the button's size based on content or appearance
    protected override Size DefaultSize {
        get { return new Size(100, 50); }
    }
}
