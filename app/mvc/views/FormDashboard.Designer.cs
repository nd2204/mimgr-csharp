namespace app.mvc.views;

partial class FormDashboard {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
        this.headerPanel = new components.MPanel();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.lblUserRole = new System.Windows.Forms.Label();
        this.mButton7 = new components.MButton();
        this.lblUserName = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.sidePanel = new components.MPanel();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.btnHome = new components.MButton();
        this.btnLogout = new components.MButton();
        this.btnAccount = new components.MButton();
        this.btnAnalytics = new components.MButton();
        this.btnMedia = new components.MButton();
        this.btnOrder = new components.MButton();
        this.btnProduct = new components.MButton();
        this.panel3 = new components.MPanel();
        this.mainPanel = new components.MPanel();
        this.headerPanel.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.sidePanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // headerPanel
        // 
        this.headerPanel.Angle = 60F;
        this.headerPanel.BackColor = System.Drawing.Color.Transparent;
        this.headerPanel.BorderColor = System.Drawing.Color.Transparent;
        this.headerPanel.Controls.Add(this.tableLayoutPanel2);
        this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
        this.headerPanel.HoverBorderColor = System.Drawing.Color.Transparent;
        this.headerPanel.Location = new System.Drawing.Point(0, 0);
        this.headerPanel.Name = "headerPanel";
        this.headerPanel.Size = new System.Drawing.Size(910, 64);
        this.headerPanel.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 4;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.Controls.Add(this.lblUserRole, 3, 1);
        this.tableLayoutPanel2.Controls.Add(this.mButton7, 0, 0);
        this.tableLayoutPanel2.Controls.Add(this.lblUserName, 3, 0);
        this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 2;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.Size = new System.Drawing.Size(910, 64);
        this.tableLayoutPanel2.TabIndex = 0;
        this.tableLayoutPanel2.Paint += this.tableLayoutPanel2_Paint;
        // 
        // lblUserRole
        // 
        this.lblUserRole.AutoSize = true;
        this.lblUserRole.Dock = System.Windows.Forms.DockStyle.Right;
        this.lblUserRole.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.lblUserRole.ForeColor = System.Drawing.Color.Gray;
        this.lblUserRole.Location = new System.Drawing.Point(845, 41);
        this.lblUserRole.Margin = new System.Windows.Forms.Padding(0, 5, 10, 10);
        this.lblUserRole.Name = "lblUserRole";
        this.lblUserRole.Size = new System.Drawing.Size(55, 13);
        this.lblUserRole.TabIndex = 3;
        this.lblUserRole.Text = "label2";
        // 
        // mButton7
        // 
        this.mButton7.ClickBackgroundColor = System.Drawing.Color.Black;
        this.mButton7.ClickForegroundColor = System.Drawing.Color.White;
        this.mButton7.IconPadding = 6;
        this.mButton7.Image = (System.Drawing.Image)resources.GetObject("mButton7.Image");
        this.mButton7.Location = new System.Drawing.Point(10, 10);
        this.mButton7.Margin = new System.Windows.Forms.Padding(10);
        this.mButton7.Name = "mButton7";
        this.tableLayoutPanel2.SetRowSpan(this.mButton7, 2);
        this.mButton7.Size = new System.Drawing.Size(44, 44);
        this.mButton7.TabIndex = 1;
        this.mButton7.UseVisualStyleBackColor = true;
        this.mButton7.Click += this.mButton7_Click;
        // 
        // lblUserName
        // 
        this.lblUserName.AutoSize = true;
        this.lblUserName.Dock = System.Windows.Forms.DockStyle.Right;
        this.lblUserName.Font = new System.Drawing.Font("RobotoMono Nerd Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
        this.lblUserName.Location = new System.Drawing.Point(833, 15);
        this.lblUserName.Margin = new System.Windows.Forms.Padding(0, 15, 10, 5);
        this.lblUserName.Name = "lblUserName";
        this.lblUserName.Size = new System.Drawing.Size(67, 16);
        this.lblUserName.TabIndex = 2;
        this.lblUserName.Text = "label1";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Dock = System.Windows.Forms.DockStyle.Left;
        this.label3.Font = new System.Drawing.Font("RobotoMono Nerd Font", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.label3.ForeColor = System.Drawing.Color.Gray;
        this.label3.Location = new System.Drawing.Point(69, 10);
        this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 20, 10);
        this.label3.Name = "label3";
        this.tableLayoutPanel2.SetRowSpan(this.label3, 2);
        this.label3.Size = new System.Drawing.Size(75, 44);
        this.label3.TabIndex = 4;
        this.label3.Text = "label3";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // sidePanel
        // 
        this.sidePanel.BackColor = System.Drawing.Color.Transparent;
        this.sidePanel.Controls.Add(this.tableLayoutPanel1);
        this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
        this.sidePanel.HoverBorderColor = System.Drawing.Color.Black;
        this.sidePanel.Location = new System.Drawing.Point(0, 64);
        this.sidePanel.Name = "sidePanel";
        this.sidePanel.Size = new System.Drawing.Size(189, 486);
        this.sidePanel.TabIndex = 2;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(this.btnHome, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.btnLogout, 0, 6);
        this.tableLayoutPanel1.Controls.Add(this.btnAccount, 0, 5);
        this.tableLayoutPanel1.Controls.Add(this.btnAnalytics, 0, 4);
        this.tableLayoutPanel1.Controls.Add(this.btnMedia, 0, 3);
        this.tableLayoutPanel1.Controls.Add(this.btnOrder, 0, 2);
        this.tableLayoutPanel1.Controls.Add(this.btnProduct, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 7;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.Size = new System.Drawing.Size(189, 486);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // btnHome
        // 
        this.btnHome.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnHome.ClickForegroundColor = System.Drawing.Color.White;
        this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnHome.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.btnHome.IconPadding = 10;
        this.btnHome.Image = (System.Drawing.Image)resources.GetObject("btnHome.Image");
        this.btnHome.Location = new System.Drawing.Point(10, 10);
        this.btnHome.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
        this.btnHome.Name = "btnHome";
        this.btnHome.Size = new System.Drawing.Size(169, 40);
        this.btnHome.TabIndex = 6;
        this.btnHome.Text = "Home";
        this.btnHome.UseVisualStyleBackColor = true;
        this.btnHome.Click += this.buttonClicked;
        // 
        // btnLogout
        // 
        this.btnLogout.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnLogout.ClickForegroundColor = System.Drawing.Color.White;
        this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnLogout.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold);
        this.btnLogout.Location = new System.Drawing.Point(10, 436);
        this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(169, 40);
        this.btnLogout.TabIndex = 5;
        this.btnLogout.Text = "Log out";
        this.btnLogout.UseVisualStyleBackColor = true;
        this.btnLogout.Click += this.btnLogout_Click;
        // 
        // btnAccount
        // 
        this.btnAccount.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnAccount.ClickForegroundColor = System.Drawing.Color.White;
        this.btnAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnAccount.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold);
        this.btnAccount.IconPadding = 10;
        this.btnAccount.Image = (System.Drawing.Image)resources.GetObject("btnAccount.Image");
        this.btnAccount.Location = new System.Drawing.Point(10, 381);
        this.btnAccount.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
        this.btnAccount.Name = "btnAccount";
        this.btnAccount.Size = new System.Drawing.Size(169, 40);
        this.btnAccount.TabIndex = 4;
        this.btnAccount.Text = "Account";
        this.btnAccount.UseVisualStyleBackColor = true;
        this.btnAccount.Click += this.buttonClicked;
        // 
        // btnAnalytics
        // 
        this.btnAnalytics.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnAnalytics.ClickForegroundColor = System.Drawing.Color.White;
        this.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnAnalytics.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold);
        this.btnAnalytics.IconPadding = 10;
        this.btnAnalytics.Image = (System.Drawing.Image)resources.GetObject("btnAnalytics.Image");
        this.btnAnalytics.Location = new System.Drawing.Point(10, 230);
        this.btnAnalytics.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
        this.btnAnalytics.Name = "btnAnalytics";
        this.btnAnalytics.Size = new System.Drawing.Size(169, 40);
        this.btnAnalytics.TabIndex = 3;
        this.btnAnalytics.Text = "Analytics";
        this.btnAnalytics.UseVisualStyleBackColor = true;
        this.btnAnalytics.Click += this.buttonClicked;
        // 
        // btnMedia
        // 
        this.btnMedia.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnMedia.ClickForegroundColor = System.Drawing.Color.White;
        this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnMedia.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold);
        this.btnMedia.IconPadding = 10;
        this.btnMedia.Image = (System.Drawing.Image)resources.GetObject("btnMedia.Image");
        this.btnMedia.Location = new System.Drawing.Point(10, 175);
        this.btnMedia.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
        this.btnMedia.Name = "btnMedia";
        this.btnMedia.Size = new System.Drawing.Size(169, 40);
        this.btnMedia.TabIndex = 2;
        this.btnMedia.Text = "Media";
        this.btnMedia.UseVisualStyleBackColor = true;
        this.btnMedia.Click += this.buttonClicked;
        // 
        // btnOrder
        // 
        this.btnOrder.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnOrder.ClickForegroundColor = System.Drawing.Color.White;
        this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnOrder.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold);
        this.btnOrder.IconPadding = 10;
        this.btnOrder.Image = (System.Drawing.Image)resources.GetObject("btnOrder.Image");
        this.btnOrder.Location = new System.Drawing.Point(10, 120);
        this.btnOrder.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
        this.btnOrder.Name = "btnOrder";
        this.btnOrder.Size = new System.Drawing.Size(169, 40);
        this.btnOrder.TabIndex = 1;
        this.btnOrder.Text = "Orders";
        this.btnOrder.UseVisualStyleBackColor = true;
        this.btnOrder.Click += this.buttonClicked;
        // 
        // btnProduct
        // 
        this.btnProduct.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnProduct.ClickForegroundColor = System.Drawing.Color.White;
        this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnProduct.Font = new System.Drawing.Font("RobotoMono Nerd Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.btnProduct.IconPadding = 10;
        this.btnProduct.Image = (System.Drawing.Image)resources.GetObject("btnProduct.Image");
        this.btnProduct.Location = new System.Drawing.Point(10, 65);
        this.btnProduct.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
        this.btnProduct.Name = "btnProduct";
        this.btnProduct.Size = new System.Drawing.Size(169, 40);
        this.btnProduct.TabIndex = 0;
        this.btnProduct.Text = "Products";
        this.btnProduct.UseVisualStyleBackColor = true;
        this.btnProduct.Click += this.buttonClicked;
        // 
        // panel3
        // 
        this.panel3.BackColor = System.Drawing.Color.Transparent;
        this.panel3.BorderColor = System.Drawing.Color.Transparent;
        this.panel3.Controls.Add(this.mainPanel);
        this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel3.HoverBorderColor = System.Drawing.Color.Transparent;
        this.panel3.Location = new System.Drawing.Point(189, 64);
        this.panel3.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
        this.panel3.Name = "panel3";
        this.panel3.Padding = new System.Windows.Forms.Padding(10);
        this.panel3.Size = new System.Drawing.Size(721, 486);
        this.panel3.TabIndex = 3;
        // 
        // mainPanel
        // 
        this.mainPanel.BackColor = System.Drawing.Color.Transparent;
        this.mainPanel.BorderColor = System.Drawing.Color.Gray;
        this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mainPanel.HoverBorderColor = System.Drawing.Color.Black;
        this.mainPanel.Location = new System.Drawing.Point(10, 10);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Padding = new System.Windows.Forms.Padding(10);
        this.mainPanel.Size = new System.Drawing.Size(701, 466);
        this.mainPanel.TabIndex = 0;
        // 
        // FormDashboard
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(910, 550);
        this.Controls.Add(this.panel3);
        this.Controls.Add(this.sidePanel);
        this.Controls.Add(this.headerPanel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "FormDashboard";
        this.Text = "FormDashboard";
        this.Load += this.FormDashboard_Load;
        this.headerPanel.ResumeLayout(false);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.sidePanel.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel3.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion
    private components.MPanel headerPanel;
    private components.MPanel sidePanel;
    private components.MPanel panel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private components.MButton btnLogout;
    private components.MButton btnAccount;
    private components.MButton btnAnalytics;
    private components.MButton btnMedia;
    private components.MButton btnOrder;
    private components.MButton btnProduct;
    private components.MPanel mainPanel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label lblUserRole;
    private components.MButton mButton7;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Label label3;
    private components.MButton btnHome;
}