using app.db.records;
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
public partial class FormAccount : Form {
    FormManager fm = FormManager.Instance;
    public FormAccount() {
        InitializeComponent();
        this.Name = "Account";
    }

    private void mTextBox1__TextChanged(object sender, EventArgs e) {

    }

    private void mButton1_Click(object sender, EventArgs e) {
        FormDashboard formDashboard = fm.Dashboard;
        formDashboard.SetButtonSelected(formDashboard.BtnHome);
    }

    private void FormAccountInfor_Load(object sender, EventArgs e) {
        UserRecord ur = SessionManager.Instance.GetCurrentUser();
        tbUsername.TextBox.Text = ur.m_username;
        tbEmail.TextBox.Text = ur.m_email;
        cbRole.Text = ur.m_role;
        tbNumber.TextBox.Text = ur.m_number;
        tbBio.TextBox.Text = ur.m_bio;
    }

    private void btnSubmit_Click(object sender, EventArgs e) {

        string username = tbUsername.TextBox.Text;
        string email = tbEmail.TextBox.Text;
        string bio = tbBio.TextBox.Text;
        string role = cbRole.Text;
        string number = tbNumber.TextBox.Text;

        if (Array.Exists(UserRecord.roles, r => r == role)) {
            UserRecord.Update(SessionManager.Instance.GetCurrentUser().m_id, username, role, email, number, bio);
            FormDashboard dashboard = FormManager.Instance.Dashboard;
            dashboard.LblUsername.Text = username;
            dashboard.LblUserRole.Text = role;
        }
    }
}
