﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.components;

[DefaultEvent("_TextChanged")]
public partial class MTextBox : UserControl {
    public event EventHandler _TextChanged;

    //Fields
    private Color borderColor      = Color.Gray;
    private Color borderFocusColor = Color.Black;

    private int borderSize = 2;

    private bool underlinedStyle = false;
    private bool isFocused = false;

    public TextBox TextBox { get { return this.textBox1; } }

    //Constructor

    //Events
    public MTextBox() {
        InitializeComponent();
    }

    //Properties
    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Gray")]
    public Color BorderColor {
        get { return borderColor; }
        set {
            borderColor = value;
            this.Invalidate();
        }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Black")]
    public Color BorderFocusColor {
        get { return borderFocusColor; }
        set { borderFocusColor = value; }
    }


    //Properties
    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Gray")]
    public int BorderSize {
        get { return borderSize; }
        set {
            borderSize = value;
            this.Invalidate();
        }
    }

    //Properties
    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "Gray")]
    public bool UnderlinedStyle {
        get { return underlinedStyle; }
        set {
            underlinedStyle = value;
            this.Invalidate();
        }
    }

    //Properties
    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(false)]
    public bool PasswordChar {
        get { return textBox1.UseSystemPasswordChar; }
        set { textBox1.UseSystemPasswordChar = value; }
    }

    //Properties
    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(false)]
    public bool Multiline {
        get { return textBox1.Multiline; }
        set { textBox1.Multiline = value; }
    }

    //Properties
    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public override Color BackColor {
        get { return base.BackColor; }
        set {
            base.BackColor = value;
            textBox1.BackColor = value;
        }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(Color), "White")]
    public override Color ForeColor {
        get { return base.ForeColor; }
        set {
            base.ForeColor = value;
            textBox1.ForeColor = value;
        }
    }

    [Browsable(true)]
    [Category("Appearance")]
    public override Font Font {
        get { return base.Font; }
        set {
            base.Font = value;
            textBox1.Font = value;
            if (this.DesignMode)
                UpdateControlHeight();
        }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue("")]
    public string Texts {
        get { return textBox1.Text; }
        set { textBox1.Text = value; }
    }

    //Overridden methods

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);
        Graphics graph = e.Graphics;

        //Draw border
        using (Pen penBorder = new Pen(borderColor, borderSize)) {
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            if (isFocused) penBorder.Color = borderFocusColor;

            if (underlinedStyle) //Line Style
                graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
            else //Normal Style
                graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        }
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        if (this.DesignMode)
            UpdateControlHeight();
    }

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        UpdateControlHeight();
    }

    //Private methods
    private void UpdateControlHeight() {
        if (textBox1.Multiline == false) {
            int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
            textBox1.Multiline = true;
            textBox1.MinimumSize = new Size(0, txtHeight);
            textBox1.Multiline = false;

            this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
        }
    }

    //TextBox events
    private void textBox1_TextChanged(object sender, EventArgs e) {
        if (_TextChanged != null)
            _TextChanged.Invoke(sender, e);
    }

    private void textBox1_Click(object sender, EventArgs e) {
        this.OnClick(e);
    }

    private void textBox1_MouseEnter(object sender, EventArgs e) {
        this.OnMouseEnter(e);
    }

    private void textBox1_MouseLeave(object sender, EventArgs e) {
        this.OnMouseLeave(e);
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
        this.OnKeyPress(e);
    }

    private void textBox1_Enter(object sender, EventArgs e) {
        isFocused = true;
        this.Invalidate();
    }

    private void textBox1_Leave(object sender, EventArgs e) {
        isFocused = false;
        this.Invalidate();
    }
}
