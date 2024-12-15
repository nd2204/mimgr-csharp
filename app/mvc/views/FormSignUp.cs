using app.globals;
using System;
using System.Windows.Forms;

namespace app.mvc.views {
    public partial class FormSignUp : Form {
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
    }
}
