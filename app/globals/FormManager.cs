using app.mvc.views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.globals;
internal class FormManager {
    private static Lazy<FormManager> _instance = new Lazy<FormManager>(() => new FormManager());
    public static FormManager Instance = _instance.Value;

    // Main panel serving as the layered pane
    private Panel mainPanel = new Panel { Dock = DockStyle.Fill, AutoScroll = true };

    public FormMain _MainForm = null;
    public FormLogin _Login = null;
    public FormSignUp _SignUp = null;
    public FormDashboard _Dashboard = null;

    public Panel MainPanel { get { return mainPanel; } }
    public FormMain MainForm { get { return (_MainForm != null) ? _MainForm : _MainForm = new FormMain(); } }
    public FormSignUp SignUp { get { return (_SignUp != null) ? _SignUp : _SignUp = new FormSignUp(); } }
    public FormLogin Login { get { return (_Login != null) ? _Login : _Login = new FormLogin(); } }
    public FormDashboard Dashboard { get { return (_Dashboard != null) ? _Dashboard : _Dashboard = new FormDashboard(); } }

    public void LoadDashboardForm(Form form) {
        if (mainPanel.Controls.Count > 0) {
            mainPanel.Controls.Clear();
        }
        form.TopLevel = false;
        form.Dock = DockStyle.Fill;
        mainPanel.Controls.Add(form);
        mainPanel.Tag = form;
        form.Show();
    }

    public void LoadForm(Form form) {
        if (mainPanel.Controls.Count > 0) {
            mainPanel.Controls.Clear();
        }
        form.TopLevel = false;
        form.Dock = DockStyle.Fill;
        mainPanel.Controls.Add(form);
        mainPanel.Tag = form;
        form.Show();
    }

    // Adds the main panel to a parent control (e.g., a Form)
    public void AddToParent(Control parent) {
        parent.Controls.Add(mainPanel);
    }
}
