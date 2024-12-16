using System.Drawing;

namespace app.mvc.views;

partial class FormAccountInfor {
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
        this.panel1 = new System.Windows.Forms.Panel();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.button1 = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.panel2 = new System.Windows.Forms.Panel();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.mTextBox1 = new components.MTextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.mTextBox2 = new components.MTextBox();
        this.mTextBox3 = new components.MTextBox();
        this.mTextBox4 = new components.MTextBox();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.button2 = new System.Windows.Forms.Button();
        this.panel1.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.panel2.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.panel1.Controls.Add(this.tableLayoutPanel2);
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Location = new Point(11, 10);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(1096, 814);
        this.panel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 2;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.3284674F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.67153F));
        this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
        this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
        this.tableLayoutPanel2.Location = new Point(0, 0);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 2;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel2.Size = new Size(1096, 157);
        this.tableLayoutPanel2.TabIndex = 1;
        // 
        // button1
        // 
        this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button1.Location = new Point(40, 83);
        this.button1.Margin = new System.Windows.Forms.Padding(40, 5, 50, 5);
        this.button1.Name = "button1";
        this.button1.Size = new Size(78, 69);
        this.button1.TabIndex = 0;
        this.button1.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Dock = System.Windows.Forms.DockStyle.Left;
        this.label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.label2.Location = new Point(171, 78);
        this.label2.Name = "label2";
        this.label2.Size = new Size(113, 79);
        this.label2.TabIndex = 1;
        this.label2.Text = "Profile";
        this.label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel2.Controls.Add(this.tableLayoutPanel1);
        this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panel2.Location = new Point(0, 181);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(1096, 633);
        this.panel2.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.mTextBox1, 1, 3);
        this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
        this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
        this.tableLayoutPanel1.Controls.Add(this.mTextBox2, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.mTextBox3, 0, 3);
        this.tableLayoutPanel1.Controls.Add(this.mTextBox4, 0, 5);
        this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
        this.tableLayoutPanel1.Controls.Add(this.button2, 0, 6);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 0);
        this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 7;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel1.Size = new Size(1094, 631);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // mTextBox1
        // 
        this.mTextBox1.BackColor = SystemColors.Window;
        this.mTextBox1.BorderSize = 2;
        this.mTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.mTextBox1.ForeColor = Color.DimGray;
        this.mTextBox1.Location = new Point(597, 169);
        this.mTextBox1.Margin = new System.Windows.Forms.Padding(50, 15, 30, 4);
        this.mTextBox1.Name = "mTextBox1";
        this.mTextBox1.Padding = new System.Windows.Forms.Padding(7);
        this.mTextBox1.Size = new Size(467, 45);
        this.mTextBox1.TabIndex = 9;
        this.mTextBox1.UnderlinedStyle = false;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = System.Windows.Forms.DockStyle.Top;
        this.label1.Location = new Point(30, 10);
        this.label1.Margin = new System.Windows.Forms.Padding(30, 10, 3, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(514, 32);
        this.label1.TabIndex = 0;
        this.label1.Text = "Username";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label3.Location = new Point(597, 10);
        this.label3.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
        this.label3.Name = "label3";
        this.label3.Size = new Size(494, 34);
        this.label3.TabIndex = 1;
        this.label3.Text = "Role";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(30, 118);
        this.label4.Margin = new System.Windows.Forms.Padding(30, 10, 3, 0);
        this.label4.Name = "label4";
        this.label4.Size = new Size(71, 32);
        this.label4.TabIndex = 2;
        this.label4.Text = "Email";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(597, 118);
        this.label5.Margin = new System.Windows.Forms.Padding(50, 10, 3, 0);
        this.label5.Name = "label5";
        this.label5.Size = new Size(102, 32);
        this.label5.TabIndex = 3;
        this.label5.Text = "Number";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(30, 226);
        this.label6.Margin = new System.Windows.Forms.Padding(30, 10, 3, 0);
        this.label6.Name = "label6";
        this.label6.Size = new Size(48, 32);
        this.label6.TabIndex = 4;
        this.label6.Text = "Bio";
        // 
        // mTextBox2
        // 
        this.mTextBox2.BackColor = SystemColors.Window;
        this.mTextBox2.BorderSize = 2;
        this.mTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.mTextBox2.ForeColor = Color.DimGray;
        this.mTextBox2.Location = new Point(30, 59);
        this.mTextBox2.Margin = new System.Windows.Forms.Padding(30, 15, 70, 4);
        this.mTextBox2.Name = "mTextBox2";
        this.mTextBox2.Padding = new System.Windows.Forms.Padding(7);
        this.mTextBox2.Size = new Size(447, 45);
        this.mTextBox2.TabIndex = 5;
        this.mTextBox2.UnderlinedStyle = false;
        // 
        // mTextBox3
        // 
        this.mTextBox3.BackColor = SystemColors.Window;
        this.mTextBox3.BorderSize = 2;
        this.mTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mTextBox3.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.mTextBox3.ForeColor = Color.DimGray;
        this.mTextBox3.Location = new Point(30, 169);
        this.mTextBox3.Margin = new System.Windows.Forms.Padding(30, 15, 70, 4);
        this.mTextBox3.Name = "mTextBox3";
        this.mTextBox3.Padding = new System.Windows.Forms.Padding(7);
        this.mTextBox3.Size = new Size(447, 45);
        this.mTextBox3.TabIndex = 6;
        this.mTextBox3.UnderlinedStyle = false;
        // 
        // mTextBox4
        // 
        this.mTextBox4.BackColor = SystemColors.Window;
        this.mTextBox4.BorderSize = 2;
        this.tableLayoutPanel1.SetColumnSpan(this.mTextBox4, 2);
        this.mTextBox4.Dock = System.Windows.Forms.DockStyle.Top;
        this.mTextBox4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.mTextBox4.ForeColor = Color.DimGray;
        this.mTextBox4.Location = new Point(30, 275);
        this.mTextBox4.Margin = new System.Windows.Forms.Padding(30, 15, 30, 4);
        this.mTextBox4.Multiline = true;
        this.mTextBox4.Name = "mTextBox4";
        this.mTextBox4.Padding = new System.Windows.Forms.Padding(7);
        this.mTextBox4.Size = new Size(1034, 241);
        this.mTextBox4.TabIndex = 7;
        this.mTextBox4.UnderlinedStyle = false;
        // 
        // comboBox1
        // 
        this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Items.AddRange(new object[] { "admin", "user", "manager" });
        this.comboBox1.Location = new Point(597, 59);
        this.comboBox1.Margin = new System.Windows.Forms.Padding(50, 15, 30, 3);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new Size(467, 40);
        this.comboBox1.TabIndex = 8;
        // 
        // button2
        // 
        this.button2.BackColor = SystemColors.Highlight;
        this.tableLayoutPanel1.SetColumnSpan(this.button2, 2);
        this.button2.Dock = System.Windows.Forms.DockStyle.Top;
        this.button2.ForeColor = Color.FloralWhite;
        this.button2.Location = new Point(30, 538);
        this.button2.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
        this.button2.Name = "button2";
        this.button2.Size = new Size(1034, 65);
        this.button2.TabIndex = 10;
        this.button2.Text = "Update Profile";
        this.button2.UseVisualStyleBackColor = false;
        // 
        // FormAccountInfor
        // 
        this.AutoScaleDimensions = new SizeF(13F, 32F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new Size(1119, 835);
        this.Controls.Add(this.panel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "FormAccountInfor";
        this.Text = "FormAccountInfor";
        this.Load += this.FormAccountInfor_Load;
        this.panel1.ResumeLayout(false);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private components.MTextBox mTextBox2;
    private components.MTextBox mTextBox3;
    private components.MTextBox mTextBox4;
    private components.MTextBox mTextBox1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button2;
}