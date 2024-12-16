namespace app.mvc.views;

partial class FormProduct {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.btnHome = new components.MButton();
        this.lblProduct = new System.Windows.Forms.Label();
        this.btnAddProduct = new components.MButton();
        this.panel1 = new System.Windows.Forms.Panel();
        this.mPanel2 = new components.MPanel();
        this.productTable2 = new ProductTable();
        this.panel2 = new System.Windows.Forms.Panel();
        this.mPanel1 = new components.MPanel();
        this.mPanel3 = new components.MPanel();
        this.controlProductInfo1 = new ControlProductInfo();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel1.SuspendLayout();
        this.mPanel2.SuspendLayout();
        this.mPanel1.SuspendLayout();
        this.mPanel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.Controls.Add(this.btnHome, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.lblProduct, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.btnAddProduct, 2, 0);
        this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 2;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.97826F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 560);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // btnHome
        // 
        this.btnHome.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnHome.ClickForegroundColor = System.Drawing.Color.White;
        this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
        this.btnHome.Font = new System.Drawing.Font("RobotoMono Nerd Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.btnHome.IconPadding = 10;
        this.btnHome.Image = (System.Drawing.Image)resources.GetObject("btnHome.Image");
        this.btnHome.Location = new System.Drawing.Point(10, 3);
        this.btnHome.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
        this.btnHome.Name = "btnHome";
        this.btnHome.Size = new System.Drawing.Size(37, 36);
        this.btnHome.TabIndex = 1;
        this.btnHome.UseVisualStyleBackColor = true;
        this.btnHome.Click += this.btnHome_Click;
        // 
        // lblProduct
        // 
        this.lblProduct.AutoSize = true;
        this.lblProduct.Dock = System.Windows.Forms.DockStyle.Left;
        this.lblProduct.Font = new System.Drawing.Font("RobotoMono Nerd Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.lblProduct.ForeColor = System.Drawing.Color.Gray;
        this.lblProduct.Location = new System.Drawing.Point(53, 8);
        this.lblProduct.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
        this.lblProduct.Name = "lblProduct";
        this.lblProduct.Size = new System.Drawing.Size(108, 31);
        this.lblProduct.TabIndex = 2;
        this.lblProduct.Text = "Product";
        this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnAddProduct
        // 
        this.btnAddProduct.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnAddProduct.ClickForegroundColor = System.Drawing.Color.White;
        this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Right;
        this.btnAddProduct.Font = new System.Drawing.Font("RobotoMono Nerd Font Propo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.btnAddProduct.Location = new System.Drawing.Point(642, 3);
        this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
        this.btnAddProduct.Name = "btnAddProduct";
        this.btnAddProduct.Size = new System.Drawing.Size(108, 36);
        this.btnAddProduct.TabIndex = 3;
        this.btnAddProduct.Text = "Add Product";
        this.btnAddProduct.UseVisualStyleBackColor = true;
        this.btnAddProduct.Click += this.btnAddProduct_Click;
        // 
        // panel1
        // 
        this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
        this.panel1.Controls.Add(this.mPanel2);
        this.panel1.Controls.Add(this.panel2);
        this.panel1.Controls.Add(this.mPanel1);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(0, 42);
        this.panel1.Margin = new System.Windows.Forms.Padding(0);
        this.panel1.Name = "panel1";
        this.panel1.Padding = new System.Windows.Forms.Padding(10);
        this.panel1.Size = new System.Drawing.Size(760, 518);
        this.panel1.TabIndex = 4;
        // 
        // mPanel2
        // 
        this.mPanel2.BackColor = System.Drawing.Color.Transparent;
        this.mPanel2.BorderColor = System.Drawing.Color.Gray;
        this.mPanel2.Controls.Add(this.productTable2);
        this.mPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mPanel2.HoverBorderColor = System.Drawing.Color.Black;
        this.mPanel2.Location = new System.Drawing.Point(10, 263);
        this.mPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        this.mPanel2.Name = "mPanel2";
        this.mPanel2.Padding = new System.Windows.Forms.Padding(3);
        this.mPanel2.Size = new System.Drawing.Size(740, 245);
        this.mPanel2.TabIndex = 3;
        // 
        // productTable2
        // 
        this.productTable2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.productTable2.Location = new System.Drawing.Point(3, 3);
        this.productTable2.Name = "productTable2";
        this.productTable2.Size = new System.Drawing.Size(734, 239);
        this.productTable2.TabIndex = 0;
        this.productTable2.Load += this.productTable2_Load;
        // 
        // panel2
        // 
        this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel2.Location = new System.Drawing.Point(10, 253);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(740, 10);
        this.panel2.TabIndex = 2;
        // 
        // mPanel1
        // 
        this.mPanel1.BackColor = System.Drawing.Color.Transparent;
        this.mPanel1.BorderColor = System.Drawing.Color.Gray;
        this.mPanel1.Controls.Add(this.mPanel3);
        this.mPanel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.mPanel1.HoverBorderColor = System.Drawing.Color.Black;
        this.mPanel1.Location = new System.Drawing.Point(10, 10);
        this.mPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        this.mPanel1.Name = "mPanel1";
        this.mPanel1.Size = new System.Drawing.Size(740, 243);
        this.mPanel1.TabIndex = 0;
        // 
        // mPanel3
        // 
        this.mPanel3.BackColor = System.Drawing.Color.Transparent;
        this.mPanel3.BorderColor = System.Drawing.Color.Gray;
        this.mPanel3.Controls.Add(this.controlProductInfo1);
        this.mPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mPanel3.HoverBorderColor = System.Drawing.Color.Black;
        this.mPanel3.Location = new System.Drawing.Point(0, 0);
        this.mPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
        this.mPanel3.Name = "mPanel3";
        this.mPanel3.Padding = new System.Windows.Forms.Padding(3);
        this.mPanel3.Size = new System.Drawing.Size(740, 243);
        this.mPanel3.TabIndex = 4;
        // 
        // controlProductInfo1
        // 
        this.controlProductInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.controlProductInfo1.Location = new System.Drawing.Point(3, 3);
        this.controlProductInfo1.Name = "controlProductInfo1";
        this.controlProductInfo1.Size = new System.Drawing.Size(734, 237);
        this.controlProductInfo1.TabIndex = 0;
        // 
        // FormProduct
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.Controls.Add(this.tableLayoutPanel1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "FormProduct";
        this.Padding = new System.Windows.Forms.Padding(20);
        this.Text = "FormProduct";
        this.Load += this.FormProduct_Load;
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.mPanel2.ResumeLayout(false);
        this.mPanel1.ResumeLayout(false);
        this.mPanel3.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion
    private ProductTable productTable1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private components.MButton btnHome;
    private System.Windows.Forms.Label lblProduct;
    private components.MButton btnAddProduct;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private components.MPanel mPanel2;
    private ProductTable productTable2;
    private components.MPanel mPanel1;
    private components.MPanel mPanel3;
    private ControlProductInfo controlProductInfo1;
}