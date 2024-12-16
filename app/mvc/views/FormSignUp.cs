using app.db.records;
using app.globals;
using app.utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace app.mvc.views {
    public partial class FormSignUp : Form {

        private bool hidden = true;
        public FormSignUp() {
            InitializeComponent();
        }

        private void mPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e) {

        }

        private void mTextBox2__TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void mTextBox1__TextChanged(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel1_Paint_3(object sender, PaintEventArgs e) {

        }

        private void login_Click(object sender, EventArgs e) {
            FormManager fm = FormManager.Instance;
            fm.LoadForm(fm.Login);
        }

        private void mButton1_Click(object sender, EventArgs e) {
            if (hidden) {
                mButton1.Image = Image.FromFile(ResourceManager.GetResource("icons\\eye_opened.png").FullName);
            }
            else {
                mButton1.Image = Image.FromFile(ResourceManager.GetResource("icons\\eye_closed.png").FullName);
            }
            hidden = !hidden;
            tbConfirmPassword.PasswordChar = hidden;
            tbPassword.PasswordChar = hidden;
        }

        private void btnSignup_Click(object sender, EventArgs e) {
            string username = tbUsername.TextBox.Text.Trim();
            string password = tbPassword.TextBox.Text.Trim();
            string confirm = tbConfirmPassword.TextBox.Text.Trim();
            string salt = Security.GenerateSalt(16);

            if (string.IsNullOrEmpty(username)) {
                MessageBox.Show("Enter Username");
                tbUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password)) {
                MessageBox.Show("Enter Password");
                tbPassword.Focus();
                return;
            }
            if (!Helpers.IsValidUsername(username)) {
                tbUsername.Focus();
                return;
            }
            if (!Helpers.IsValidPassword(password)) {
                tbPassword.Focus();
                return;
            }
            if (!string.Equals(password, confirm)) {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }

            UserRecord.Insert(username, Security.HashString(password + salt), salt, UserRecord.roles[UserRecord.ROLE_ADMIN]);
            FormManager.Instance.LoadForm(FormManager.Instance.Dashboard);
            this.Dispose();
        }

        private void tableLayoutPanel1_Paint_4(object sender, PaintEventArgs e) {

        }
    }
}
