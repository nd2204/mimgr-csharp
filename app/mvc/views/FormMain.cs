using app.components;
using app.db.records;
using app.globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.mvc.views;
public partial class FormMain : Form {
    public static double m_aspect_ratio = 16.0f / 10.0f;
    public static int m_width = 1280;
    public static int m_height = (int)((float)m_width / m_aspect_ratio);

    public FormMain() {
        InitializeComponent();

        SetDarkTitleBar(this.Handle);
        this.MinimumSize = new Size(854, 480);
        this.Text = "Mimgr";
        this.Height = m_height;
        this.Width = m_width;

        FormManager.Instance.AddToParent(this);

    }

    // Import the DwmSetWindowAttribute function
    [DllImport("Dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

    private void SetDarkTitleBar(IntPtr handle) {
        if (IsWindows10OrLater()) {
            int attribute = 19; // DWMWA_USE_IMMERSIVE_DARK_MODE
            int useDarkMode = 1; // Enable dark mode
            DwmSetWindowAttribute(handle, attribute, ref useDarkMode, sizeof(int));
        }
    }

    private bool IsWindows10OrLater() {
        return Environment.OSVersion.Version.Major >= 10;
    }

    private void mButton1_Click(object sender, EventArgs e) {

    }

    private void FormMain_Load(object sender, EventArgs e) {

    }
}
