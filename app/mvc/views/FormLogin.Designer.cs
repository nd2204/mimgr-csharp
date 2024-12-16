namespace app.mvc.views {
    partial class FormLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.mPanel1 = new components.MPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSignup = new components.MButton();
            this.tbPassword = new components.MTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new components.MTextBox();
            this.mButton1 = new components.MButton();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.btnLogin = new components.MButton();
            this.mPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPanel1
            // 
            this.mPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel1.BackColor = System.Drawing.Color.Transparent;
            this.mPanel1.Background = System.Drawing.Color.Transparent;
            this.mPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.mPanel1.Controls.Add(this.tableLayoutPanel1);
            this.mPanel1.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.mPanel1.HoverBorderColor = System.Drawing.Color.Gainsboro;
            this.mPanel1.Location = new System.Drawing.Point(6, 6);
            this.mPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.mPanel1.Name = "mPanel1";
            this.mPanel1.Size = new System.Drawing.Size(351, 419);
            this.mPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSignup, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUsername, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mButton1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbRemember, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 419);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnSignup
            // 
            this.btnSignup.ClickBackgroundColor = System.Drawing.Color.Black;
            this.btnSignup.ClickForegroundColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSignup, 2);
            this.btnSignup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignup.Font = new System.Drawing.Font("RobotoMono Nerd Font", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignup.Location = new System.Drawing.Point(20, 336);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(311, 39);
            this.btnSignup.TabIndex = 9;
            this.btnSignup.Text = "Go to sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += this.btnSignup_Click;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassword.BorderSize = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tbPassword, 2);
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.tbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbPassword.Location = new System.Drawing.Point(20, 178);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(20, 5, 20, 10);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(7);
            this.tbPassword.PasswordChar = true;
            this.tbPassword.Size = new System.Drawing.Size(311, 31);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseMnemonic = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.tbUsername.BorderSize = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tbUsername, 2);
            this.tbUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.tbUsername.ForeColor = System.Drawing.Color.DimGray;
            this.tbUsername.Location = new System.Drawing.Point(20, 105);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(20, 5, 20, 10);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(7);
            this.tbUsername.Size = new System.Drawing.Size(311, 31);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.UnderlinedStyle = false;
            // 
            // mButton1
            // 
            this.mButton1.ClickBackgroundColor = System.Drawing.Color.Black;
            this.mButton1.ClickForegroundColor = System.Drawing.Color.White;
            this.mButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.mButton1.ForeColor = System.Drawing.Color.Black;
            this.mButton1.Foreground = System.Drawing.Color.Gray;
            this.mButton1.IconPadding = 7;
            this.mButton1.Image = (System.Drawing.Image)resources.GetObject("mButton1.Image");
            this.mButton1.Location = new System.Drawing.Point(292, 229);
            this.mButton1.Margin = new System.Windows.Forms.Padding(5, 10, 20, 10);
            this.mButton1.Name = "mButton1";
            this.mButton1.Size = new System.Drawing.Size(39, 35);
            this.mButton1.TabIndex = 7;
            this.mButton1.UseVisualStyleBackColor = true;
            this.mButton1.Click += this.mButton1_Click;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.cbRemember.ForeColor = System.Drawing.Color.Gray;
            this.cbRemember.Location = new System.Drawing.Point(20, 229);
            this.cbRemember.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(127, 35);
            this.cbRemember.TabIndex = 6;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.ClickBackgroundColor = System.Drawing.Color.Black;
            this.btnLogin.ClickForegroundColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.btnLogin, 2);
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.Font = new System.Drawing.Font("RobotoMono Nerd Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnLogin.Location = new System.Drawing.Point(20, 274);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(311, 42);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += this.btnLogin_Click;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 431);
            this.Controls.Add(this.mPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.mPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private components.MPanel mPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private components.MButton btnSignup;
        private components.MTextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private components.MTextBox tbUsername;
        private components.MButton mButton1;
        private System.Windows.Forms.CheckBox cbRemember;
        private components.MButton btnLogin;
    }
}