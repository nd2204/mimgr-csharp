using app.globals;
using System;
using System.Drawing;
using System.Windows.Forms;
using app.db;
using app.db.records;
using app.utils;
using MySql.Data.MySqlClient;
using System.Diagnostics.CodeAnalysis;

namespace app.mvc.views {
    public partial class FormLogin : Form {

        private bool hidden = true;
        public Button BtnLogin { get { return this.btnLogin; } }
        public TextBox TbUsername { get { return this.tbUsername.TextBox; } }
        public TextBox TbPassword { get { return this.tbPassword.TextBox; } }
        public CheckBox CbRemember { get { return this.cbRemember; } }

        public FormLogin() {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e) {
            FormManager fm = FormManager.Instance;
            fm.LoadForm(fm.SignUp);
        }

        private void mButton1_Click(object sender, EventArgs e) {
            if (hidden) {
                mButton1.Image = Image.FromFile(ResourceManager.GetResource("icons\\eye_opened.png").FullName);
            } else {
                mButton1.Image = Image.FromFile(ResourceManager.GetResource("icons\\eye_closed.png").FullName);
            }
            hidden = !hidden;
            tbPassword.PasswordChar = hidden;
        }

        // Login function
        public bool LoginUser(string username, string password, bool rememberMe) {
            UserRecord userRecord = Authenticate(username, password);
            if (userRecord == null) return false;

            if (rememberMe) {
                string token = Security.GenerateToken();
                DateTime expirationTime = DateTime.Now.AddDays(1);
                SessionManager.Instance.SaveSession(token, expirationTime, userRecord.m_id);
            }
            else {
                SessionManager.Instance.ClearSession();
            }

            SessionManager.Instance.SetCurrentUser(userRecord);
            return true;
        }

        // Authentication function
        private static UserRecord Authenticate(string username, string password) {
            using (MySqlDataReader reader = UserRecord.SelectUserByName(username)) {
                while (reader.Read()) {
                    UserRecord userRecord = new UserRecord(reader);
                    string hashInput = Security.HashString(password + userRecord.m_salt);

                    if (hashInput == userRecord.m_hash) {
                        return userRecord;
                    }
                }
            }
            return null;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(TbUsername.Text)) {
                MessageBox.Show("Enter Username");
                TbUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TbPassword.Text)) {
                MessageBox.Show("Enter Password");
                TbPassword.Focus();
                return;
            }
            if (LoginUser(TbUsername.Text.Trim(), TbPassword.Text.Trim(), CbRemember.Checked)) {
                FormManager fm = FormManager.Instance;
                fm.LoadForm(fm.Dashboard);
                this.Dispose();
            } else {
                MessageBox.Show("Invalid Credential");
            }
        }
    }
}
