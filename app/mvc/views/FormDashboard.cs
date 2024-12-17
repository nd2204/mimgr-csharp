using app.components;
using app.globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.mvc.views;
public partial class FormDashboard : Form {
    Dictionary<MButton, Form> ButtonToForm = new Dictionary<MButton, Form>();

    public Label LblUsername => lblUserName;
    public Label LblUserRole => lblUserRole;
    public MButton CurrentButton { get; private set; } = null;
    public MButton BtnHome => btnHome;
    public MButton BtnProduct => btnProduct;
    public MButton BtnAccount => btnAccount;
    public MButton BtnMedia => btnMedia;
    public MButton BtnAnalytics => btnAnalytics;
    public MButton BtnOrder => btnOrder;

    public FormDashboard() {
        InitializeComponent();

        ButtonToForm[btnHome] = new FormHome();
        ButtonToForm[btnProduct] = new FormProduct();
        ButtonToForm[btnAccount] = new FormAccount();
        ButtonToForm[btnMedia] = new FormMedia();
        ButtonToForm[btnOrder] = new FormOrder();
    }

    private void btnLogout_Click(object sender, EventArgs e) {
        SessionManager.Instance.ClearSession();
        Console.WriteLine("User logged out, session cleared.");
        FormManager.Instance.LoadForm(FormManager.Instance.Login);
    }

    private void mButton7_Click(object sender, EventArgs e) {
        if (sidePanel.Visible) {
            sidePanel.Hide();
        }
        else {
            sidePanel.Show();
        }
    }

    private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) {

    }

    private void btnProduct_Click(object sender, EventArgs e) {
    }

    public void SetButtonSelected(MButton button) {
        if (button == null || !ButtonToForm.ContainsKey(button)) return;
        if (CurrentButton != button) {
            if (CurrentButton != null) {
                CurrentButton.Background = Color.White;
                CurrentButton.BorderColor = Color.Gray;
                CurrentButton.Foreground = Color.Gray;
            }
            button.Foreground = Color.White;
            button.Background = Color.Black;
            button.BorderColor = Color.Black;
            CurrentButton = button;
        }
        Form form = ButtonToForm[button];
        LoadForm(form);
        label3.Text = form.Name;
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

    private void buttonClicked(object sender, EventArgs e) {
        if (sender is MButton button) SetButtonSelected(button);
    }

    private void btnAccount_Click(object sender, EventArgs e) {
    }

    private void FormDashboard_Load(object sender, EventArgs e) {
        this.lblUserName.Text = SessionManager.Instance.GetCurrentUser().m_username; 
        this.lblUserRole.Text = SessionManager.Instance.GetCurrentUser().m_role; 
        SetButtonSelected(BtnHome);
    }
}
