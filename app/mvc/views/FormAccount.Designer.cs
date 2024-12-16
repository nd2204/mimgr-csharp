using System.Drawing;

namespace app.mvc.views;

partial class FormAccount {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
        this.mPanel1 = new components.MPanel();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.tbNumber = new components.MTextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.tbUsername = new components.MTextBox();
        this.tbEmail = new components.MTextBox();
        this.tbBio = new components.MTextBox();
        this.cbRole = new System.Windows.Forms.ComboBox();
        this.btnSubmit = new components.MButton();
        this.label2 = new System.Windows.Forms.Label();
        this.mButton1 = new components.MButton();
        this.mPanel1.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // mPanel1
        // 
        this.mPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.mPanel1.BackColor = Color.Transparent;
        this.mPanel1.BorderColor = Color.Gray;
        this.mPanel1.Controls.Add(this.tableLayoutPanel2);
        this.mPanel1.HoverBorderColor = Color.Black;
        this.mPanel1.Location = new Point(12, 12);
        this.mPanel1.Name = "mPanel1";
        this.mPanel1.Padding = new System.Windows.Forms.Padding(20);
        this.mPanel1.Size = new Size(540, 470);
        this.mPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 2;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
        this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
        this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
        this.tableLayoutPanel2.Controls.Add(this.mButton1, 0, 0);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.Location = new Point(20, 20);
        this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 2;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 365F));
        this.tableLayoutPanel2.Size = new Size(500, 430);
        this.tableLayoutPanel2.TabIndex = 3;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel1, 2);
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.tbNumber, 1, 3);
        this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
        this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
        this.tableLayoutPanel1.Controls.Add(this.tbUsername, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.tbEmail, 0, 3);
        this.tableLayoutPanel1.Controls.Add(this.tbBio, 0, 5);
        this.tableLayoutPanel1.Controls.Add(this.cbRole, 1, 1);
        this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 0, 6);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 57);
        this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 7;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.Size = new Size(500, 363);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // tbNumber
        // 
        this.tbNumber.BackColor = SystemColors.Window;
        this.tbNumber.BorderSize = 2;
        this.tbNumber.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbNumber.Font = new Font("RobotoMono Nerd Font SmBd", 12F, FontStyle.Bold);
        this.tbNumber.ForeColor = Color.DimGray;
        this.tbNumber.Location = new Point(260, 100);
        this.tbNumber.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.tbNumber.Name = "tbNumber";
        this.tbNumber.Padding = new System.Windows.Forms.Padding(4);
        this.tbNumber.Size = new Size(230, 30);
        this.tbNumber.TabIndex = 9;
        this.tbNumber.UnderlinedStyle = false;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = System.Windows.Forms.DockStyle.Top;
        this.label1.Font = new Font("RobotoMono Nerd Font SmBd", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.label1.Location = new Point(10, 8);
        this.label1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.label1.Name = "label1";
        this.label1.Size = new Size(230, 16);
        this.label1.TabIndex = 0;
        this.label1.Text = "Username";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label3.Font = new Font("RobotoMono Nerd Font SmBd", 9F, FontStyle.Bold);
        this.label3.Location = new Point(260, 8);
        this.label3.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.label3.Name = "label3";
        this.label3.Size = new Size(230, 16);
        this.label3.TabIndex = 1;
        this.label3.Text = "Role";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new Font("RobotoMono Nerd Font SmBd", 9F, FontStyle.Bold);
        this.label4.Location = new Point(10, 74);
        this.label4.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.label4.Name = "label4";
        this.label4.Size = new Size(42, 16);
        this.label4.TabIndex = 2;
        this.label4.Text = "Email";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new Font("RobotoMono Nerd Font SmBd", 9F, FontStyle.Bold);
        this.label5.Location = new Point(260, 74);
        this.label5.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.label5.Name = "label5";
        this.label5.Size = new Size(49, 16);
        this.label5.TabIndex = 3;
        this.label5.Text = "Number";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new Font("RobotoMono Nerd Font SmBd", 9F, FontStyle.Bold);
        this.label6.Location = new Point(10, 140);
        this.label6.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.label6.Name = "label6";
        this.label6.Size = new Size(28, 16);
        this.label6.TabIndex = 4;
        this.label6.Text = "Bio";
        // 
        // tbUsername
        // 
        this.tbUsername.BackColor = SystemColors.Window;
        this.tbUsername.BorderSize = 2;
        this.tbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbUsername.Font = new Font("RobotoMono Nerd Font SmBd", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.tbUsername.ForeColor = Color.DimGray;
        this.tbUsername.Location = new Point(10, 34);
        this.tbUsername.Margin = new System.Windows.Forms.Padding(10, 8, 30, 2);
        this.tbUsername.Name = "tbUsername";
        this.tbUsername.Padding = new System.Windows.Forms.Padding(4);
        this.tbUsername.Size = new Size(210, 30);
        this.tbUsername.TabIndex = 5;
        this.tbUsername.UnderlinedStyle = false;
        // 
        // tbEmail
        // 
        this.tbEmail.BackColor = SystemColors.Window;
        this.tbEmail.BorderSize = 2;
        this.tbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbEmail.Font = new Font("RobotoMono Nerd Font SmBd", 12F, FontStyle.Bold);
        this.tbEmail.ForeColor = Color.DimGray;
        this.tbEmail.Location = new Point(10, 100);
        this.tbEmail.Margin = new System.Windows.Forms.Padding(10, 8, 30, 2);
        this.tbEmail.Name = "tbEmail";
        this.tbEmail.Padding = new System.Windows.Forms.Padding(4);
        this.tbEmail.Size = new Size(210, 30);
        this.tbEmail.TabIndex = 6;
        this.tbEmail.UnderlinedStyle = false;
        // 
        // tbBio
        // 
        this.tbBio.BackColor = SystemColors.Window;
        this.tbBio.BorderSize = 2;
        this.tableLayoutPanel1.SetColumnSpan(this.tbBio, 2);
        this.tbBio.Dock = System.Windows.Forms.DockStyle.Top;
        this.tbBio.Font = new Font("RobotoMono Nerd Font SmBd", 12F, FontStyle.Bold);
        this.tbBio.ForeColor = Color.DimGray;
        this.tbBio.Location = new Point(10, 166);
        this.tbBio.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.tbBio.Multiline = true;
        this.tbBio.Name = "tbBio";
        this.tbBio.Padding = new System.Windows.Forms.Padding(4);
        this.tbBio.Size = new Size(480, 120);
        this.tbBio.TabIndex = 7;
        this.tbBio.UnderlinedStyle = false;
        // 
        // cbRole
        // 
        this.cbRole.Dock = System.Windows.Forms.DockStyle.Fill;
        this.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.cbRole.Font = new Font("RobotoMono Nerd Font SmBd", 12F, FontStyle.Bold);
        this.cbRole.ForeColor = Color.Gray;
        this.cbRole.FormattingEnabled = true;
        this.cbRole.Items.AddRange(new object[] { "admin", "user", "manager" });
        this.cbRole.Location = new Point(260, 34);
        this.cbRole.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.cbRole.Name = "cbRole";
        this.cbRole.Size = new Size(230, 29);
        this.cbRole.TabIndex = 8;
        // 
        // btnSubmit
        // 
        this.btnSubmit.Background = Color.Gray;
        this.btnSubmit.ClickBackgroundColor = Color.Black;
        this.btnSubmit.ClickForegroundColor = Color.White;
        this.tableLayoutPanel1.SetColumnSpan(this.btnSubmit, 2);
        this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnSubmit.Font = new Font("RobotoMono Nerd Font", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.btnSubmit.Foreground = Color.White;
        this.btnSubmit.Location = new Point(10, 296);
        this.btnSubmit.Margin = new System.Windows.Forms.Padding(10, 8, 10, 2);
        this.btnSubmit.Name = "btnSubmit";
        this.btnSubmit.Size = new Size(480, 37);
        this.btnSubmit.TabIndex = 10;
        this.btnSubmit.Text = "Update";
        this.btnSubmit.UseVisualStyleBackColor = true;
        this.btnSubmit.Click += this.btnSubmit_Click;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Dock = System.Windows.Forms.DockStyle.Left;
        this.label2.Font = new Font("RobotoMono Nerd Font", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.label2.ForeColor = Color.Gray;
        this.label2.Location = new Point(60, 5);
        this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 2, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(93, 42);
        this.label2.TabIndex = 1;
        this.label2.Text = "Profile";
        this.label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // mButton1
        // 
        this.mButton1.ClickBackgroundColor = Color.Black;
        this.mButton1.ClickForegroundColor = Color.White;
        this.mButton1.IconPadding = 10;
        this.mButton1.Image = (Image)resources.GetObject("mButton1.Image");
        this.mButton1.Location = new Point(10, 3);
        this.mButton1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
        this.mButton1.Name = "mButton1";
        this.mButton1.Size = new Size(37, 41);
        this.mButton1.TabIndex = 3;
        this.mButton1.UseVisualStyleBackColor = true;
        this.mButton1.Click += this.mButton1_Click;
        // 
        // FormAccount
        // 
        this.AutoScaleDimensions = new SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = Color.White;
        this.ClientSize = new Size(564, 494);
        this.Controls.Add(this.mPanel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Margin = new System.Windows.Forms.Padding(2);
        this.Name = "FormAccount";
        this.Text = "FormAccountInfor";
        this.Load += this.FormAccountInfor_Load;
        this.mPanel1.ResumeLayout(false);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private components.MPanel mPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private components.MTextBox tbNumber;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private components.MTextBox tbUsername;
    private components.MTextBox tbEmail;
    private components.MTextBox tbBio;
    private System.Windows.Forms.ComboBox cbRole;
    private components.MButton btnSubmit;
    private System.Windows.Forms.Label label2;
    private components.MButton mButton1;
}