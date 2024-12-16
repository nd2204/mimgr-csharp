namespace app.mvc.views;

partial class ControlProductInfo {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlProductInfo));
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.tbDescription = new components.MTextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.tbPrice = new components.MTextBox();
        this.tbStock = new components.MTextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.lblImg = new System.Windows.Forms.Label();
        this.lblProductName = new System.Windows.Forms.Label();
        this.tbName = new components.MTextBox();
        this.panel1 = new System.Windows.Forms.Panel();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.tbImage = new components.MTextBox();
        this.mButton1 = new components.MButton();
        this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        this.btnSubmit = new components.MButton();
        this.btnCancel = new components.MButton();
        this.tableLayoutPanel2.SuspendLayout();
        this.panel1.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.tableLayoutPanel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 4;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
        this.tableLayoutPanel2.Controls.Add(this.tbDescription, 1, 2);
        this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
        this.tableLayoutPanel2.Controls.Add(this.tbPrice, 3, 1);
        this.tableLayoutPanel2.Controls.Add(this.tbStock, 3, 0);
        this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
        this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
        this.tableLayoutPanel2.Controls.Add(this.lblImg, 0, 1);
        this.tableLayoutPanel2.Controls.Add(this.lblProductName, 0, 0);
        this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 0);
        this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
        this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 2);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 3;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 228);
        this.tableLayoutPanel2.TabIndex = 1;
        // 
        // tbDescription
        // 
        this.tbDescription.BackColor = System.Drawing.SystemColors.Window;
        this.tbDescription.BorderSize = 2;
        this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbDescription.Font = new System.Drawing.Font("RobotoMono Nerd Font SmBd", 9F, System.Drawing.FontStyle.Bold);
        this.tbDescription.ForeColor = System.Drawing.Color.DimGray;
        this.tbDescription.Location = new System.Drawing.Point(106, 112);
        this.tbDescription.Margin = new System.Windows.Forms.Padding(10);
        this.tbDescription.Multiline = true;
        this.tbDescription.Name = "tbDescription";
        this.tbDescription.Padding = new System.Windows.Forms.Padding(7);
        this.tbDescription.Size = new System.Drawing.Size(365, 106);
        this.tbDescription.TabIndex = 9;
        this.tbDescription.UnderlinedStyle = false;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Dock = System.Windows.Forms.DockStyle.Right;
        this.label4.Font = new System.Drawing.Font("RobotoMono Nerd Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.label4.Location = new System.Drawing.Point(5, 102);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(88, 126);
        this.label4.TabIndex = 8;
        this.label4.Text = "description";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tbPrice
        // 
        this.tbPrice.BackColor = System.Drawing.SystemColors.Window;
        this.tbPrice.BorderSize = 2;
        this.tbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbPrice.Font = new System.Drawing.Font("RobotoMono Nerd Font SmBd", 9F, System.Drawing.FontStyle.Bold);
        this.tbPrice.ForeColor = System.Drawing.Color.DimGray;
        this.tbPrice.Location = new System.Drawing.Point(587, 61);
        this.tbPrice.Margin = new System.Windows.Forms.Padding(10);
        this.tbPrice.Name = "tbPrice";
        this.tbPrice.Padding = new System.Windows.Forms.Padding(7);
        this.tbPrice.Size = new System.Drawing.Size(367, 31);
        this.tbPrice.TabIndex = 7;
        this.tbPrice.UnderlinedStyle = false;
        // 
        // tbStock
        // 
        this.tbStock.BackColor = System.Drawing.SystemColors.Window;
        this.tbStock.BorderSize = 2;
        this.tbStock.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbStock.Font = new System.Drawing.Font("RobotoMono Nerd Font SmBd", 9F, System.Drawing.FontStyle.Bold);
        this.tbStock.ForeColor = System.Drawing.Color.DimGray;
        this.tbStock.Location = new System.Drawing.Point(587, 10);
        this.tbStock.Margin = new System.Windows.Forms.Padding(10);
        this.tbStock.Name = "tbStock";
        this.tbStock.Padding = new System.Windows.Forms.Padding(7);
        this.tbStock.Size = new System.Drawing.Size(367, 31);
        this.tbStock.TabIndex = 6;
        this.tbStock.UnderlinedStyle = false;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Dock = System.Windows.Forms.DockStyle.Right;
        this.label3.Font = new System.Drawing.Font("RobotoMono Nerd Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.label3.Location = new System.Drawing.Point(522, 51);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(52, 51);
        this.label3.TabIndex = 5;
        this.label3.Text = "price";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Dock = System.Windows.Forms.DockStyle.Right;
        this.label2.Font = new System.Drawing.Font("RobotoMono Nerd Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.label2.Location = new System.Drawing.Point(522, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(52, 51);
        this.label2.TabIndex = 4;
        this.label2.Text = "stock";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblImg
        // 
        this.lblImg.AutoSize = true;
        this.lblImg.Dock = System.Windows.Forms.DockStyle.Right;
        this.lblImg.Font = new System.Drawing.Font("RobotoMono Nerd Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.lblImg.Location = new System.Drawing.Point(41, 51);
        this.lblImg.Name = "lblImg";
        this.lblImg.Size = new System.Drawing.Size(52, 51);
        this.lblImg.TabIndex = 1;
        this.lblImg.Text = "image";
        this.lblImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblProductName
        // 
        this.lblProductName.AutoSize = true;
        this.lblProductName.Dock = System.Windows.Forms.DockStyle.Right;
        this.lblProductName.Font = new System.Drawing.Font("RobotoMono Nerd Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.lblProductName.Location = new System.Drawing.Point(50, 0);
        this.lblProductName.Name = "lblProductName";
        this.lblProductName.Size = new System.Drawing.Size(43, 51);
        this.lblProductName.TabIndex = 0;
        this.lblProductName.Text = "name";
        this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tbName
        // 
        this.tbName.BackColor = System.Drawing.SystemColors.Window;
        this.tbName.BorderSize = 2;
        this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbName.Font = new System.Drawing.Font("RobotoMono Nerd Font SmBd", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.tbName.ForeColor = System.Drawing.Color.DimGray;
        this.tbName.Location = new System.Drawing.Point(106, 10);
        this.tbName.Margin = new System.Windows.Forms.Padding(10);
        this.tbName.Name = "tbName";
        this.tbName.Padding = new System.Windows.Forms.Padding(7);
        this.tbName.Size = new System.Drawing.Size(365, 31);
        this.tbName.TabIndex = 2;
        this.tbName.UnderlinedStyle = false;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.tableLayoutPanel1);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(106, 61);
        this.panel1.Margin = new System.Windows.Forms.Padding(10);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(365, 31);
        this.panel1.TabIndex = 10;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 2;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel1.Controls.Add(this.tbImage, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.mButton1, 1, 0);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 31);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // tbImage
        // 
        this.tbImage.BackColor = System.Drawing.SystemColors.Window;
        this.tbImage.BorderSize = 2;
        this.tbImage.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tbImage.Font = new System.Drawing.Font("RobotoMono Nerd Font SmBd", 9F, System.Drawing.FontStyle.Bold);
        this.tbImage.ForeColor = System.Drawing.Color.DimGray;
        this.tbImage.Location = new System.Drawing.Point(0, 0);
        this.tbImage.Margin = new System.Windows.Forms.Padding(0);
        this.tbImage.Name = "tbImage";
        this.tbImage.Padding = new System.Windows.Forms.Padding(7);
        this.tbImage.Size = new System.Drawing.Size(327, 31);
        this.tbImage.TabIndex = 0;
        this.tbImage.UnderlinedStyle = false;
        // 
        // mButton1
        // 
        this.mButton1.ClickBackgroundColor = System.Drawing.Color.Black;
        this.mButton1.ClickForegroundColor = System.Drawing.Color.White;
        this.mButton1.Dock = System.Windows.Forms.DockStyle.Right;
        this.mButton1.Image = (System.Drawing.Image)resources.GetObject("mButton1.Image");
        this.mButton1.Location = new System.Drawing.Point(332, 0);
        this.mButton1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
        this.mButton1.Name = "mButton1";
        this.mButton1.Size = new System.Drawing.Size(33, 31);
        this.mButton1.TabIndex = 1;
        this.mButton1.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel3
        // 
        this.tableLayoutPanel3.ColumnCount = 2;
        this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.8784065F));
        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.1215935F));
        this.tableLayoutPanel3.Controls.Add(this.btnSubmit, 0, 0);
        this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
        this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel3.Location = new System.Drawing.Point(484, 105);
        this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        this.tableLayoutPanel3.RowCount = 1;
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 120);
        this.tableLayoutPanel3.TabIndex = 11;
        // 
        // btnSubmit
        // 
        this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
        this.btnSubmit.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnSubmit.ClickForegroundColor = System.Drawing.Color.White;
        this.btnSubmit.Font = new System.Drawing.Font("RobotoMono Nerd Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.btnSubmit.Location = new System.Drawing.Point(103, 35);
        this.btnSubmit.Margin = new System.Windows.Forms.Padding(10);
        this.btnSubmit.Name = "btnSubmit";
        this.btnSubmit.Size = new System.Drawing.Size(144, 50);
        this.btnSubmit.TabIndex = 0;
        this.btnSubmit.Text = "Submit";
        this.btnSubmit.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
        this.btnCancel.ClickBackgroundColor = System.Drawing.Color.Black;
        this.btnCancel.ClickForegroundColor = System.Drawing.Color.White;
        this.btnCancel.Font = new System.Drawing.Font("RobotoMono Nerd Font", 11.25F, System.Drawing.FontStyle.Bold);
        this.btnCancel.Location = new System.Drawing.Point(267, 35);
        this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(141, 50);
        this.btnCancel.TabIndex = 1;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // ControlProductInfo
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.tableLayoutPanel2);
        this.Name = "ControlProductInfo";
        this.Size = new System.Drawing.Size(964, 228);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel3.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private components.MTextBox tbDescription;
    private System.Windows.Forms.Label label4;
    private components.MTextBox tbPrice;
    private components.MTextBox tbStock;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblImg;
    private System.Windows.Forms.Label lblProductName;
    private components.MTextBox tbName;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private components.MTextBox tbImage;
    private components.MButton mButton1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private components.MButton btnSubmit;
    private components.MButton btnCancel;
}
