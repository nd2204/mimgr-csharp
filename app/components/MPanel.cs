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
internal class MPanel : Panel {
    private bool isHovered = false;
    private bool isClicked = false;

    private Color _BorderColor;
    private Color _HoverBorderColor;
    private Color _Background;
    private Color _BackgroundEnd;
    private Color _HoverBackgroundColor;
    private int _BorderWidth;
    private float angle;

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public Color BorderColor { get { return _BorderColor; } set { _BorderColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public Color HoverBorderColor { get { return _HoverBorderColor; } set { _HoverBorderColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public Color Background { get { return _Background; } set { _Background = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public Color BackgroundEnd { get { return _BackgroundEnd; } set { _BackgroundEnd = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public Color HoverBackgroundColor { get { return _HoverBackgroundColor; } set { _HoverBackgroundColor = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(4)]
    public int BorderWith { get { return _BorderWidth; } set { _BorderWidth = value; this.Invalidate(); } }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(45f)]
    public float Angle { get { return angle; } set { angle = value; this.Invalidate(); } }

    public MPanel() {
        angle = 45f;
        _BorderWidth = 4;
        _BorderColor = Color.White;
        _HoverBorderColor = Color.Black;

        _Background = Color.White;
        _BackgroundEnd = Color.White;
        _HoverBackgroundColor = Color.White;

        // Enable double buffering to reduce flicker
        this.DoubleBuffered = true;

        // Set the panel's properties
        this.Size = new Size(200, 100);  // Default size
        this.BackColor = Color.Transparent; // Set default background to transparent to draw custom background
    }

    // Override OnPaint to customize the appearance of the panel
    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        // Get the Graphics object
        Graphics g = e.Graphics;

        Pen borderPen;
        Brush backgroundBrush;

        Rectangle buttonRect = this.ClientRectangle;

        if (isHovered) {
            borderPen = new Pen(_HoverBorderColor, _BorderWidth);
            backgroundBrush = new LinearGradientBrush(buttonRect, _HoverBackgroundColor, _BackgroundEnd, angle);
        }
        else {
            borderPen = new Pen(_BorderColor, _BorderWidth);
            backgroundBrush = new LinearGradientBrush(buttonRect, _Background, _BackgroundEnd, angle);
        }

        g.FillRectangle(backgroundBrush, buttonRect); // Fill the panel's background with the gradient
        g.DrawRectangle(borderPen, buttonRect);

        //// Draw the panel's text (optional)
        //using (Font font = new Font("Arial", 12, FontStyle.Bold)) {
        //    TextRenderer.DrawText(g, "Custom Panel", font, this.ClientRectangle, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        //}
    }

    // Override the mouse events to detect hover state
    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);
        isHovered = true;
        this.Invalidate(); // Redraw the panel to apply hover effect
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e);
        isHovered = false;
        this.Invalidate(); // Redraw the panel to reset hover effect
    }
}
