namespace app.mvc.views;

partial class ProductTable {
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
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.cbColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.image = new System.Windows.Forms.DataGridViewImageColumn();
        this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.action = new System.Windows.Forms.DataGridViewButtonColumn();
        this.edit_action = new System.Windows.Forms.DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.cbColumn, this.image, this.Name, this.price, this.stock, this.description, this.action, this.edit_action });
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.Location = new System.Drawing.Point(0, 0);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.Size = new System.Drawing.Size(691, 383);
        this.dataGridView1.TabIndex = 1;
        this.dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
        // 
        // cbColumn
        // 
        this.cbColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        this.cbColumn.HeaderText = "";
        this.cbColumn.MinimumWidth = 48;
        this.cbColumn.Name = "cbColumn";
        this.cbColumn.Width = 48;
        // 
        // image
        // 
        this.image.HeaderText = "";
        this.image.Name = "image";
        // 
        // Name
        // 
        this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.Name.HeaderText = "Name";
        this.Name.Name = "Name";
        this.Name.ReadOnly = true;
        // 
        // price
        // 
        this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
        this.price.HeaderText = "Price";
        this.price.Name = "price";
        this.price.ReadOnly = true;
        this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        this.price.Width = 58;
        // 
        // stock
        // 
        this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
        this.stock.HeaderText = "Stock";
        this.stock.Name = "stock";
        this.stock.ReadOnly = true;
        this.stock.Width = 61;
        // 
        // description
        // 
        this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.description.HeaderText = "Description";
        this.description.Name = "description";
        this.description.ReadOnly = true;
        // 
        // action
        // 
        this.action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
        this.action.HeaderText = "Delete";
        this.action.Name = "action";
        this.action.Width = 46;
        // 
        // edit_action
        // 
        this.edit_action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
        this.edit_action.HeaderText = "Edit";
        this.edit_action.Name = "edit_action";
        this.edit_action.Width = 33;
        // 
        // ProductTable
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.dataGridView1);
        this.Size = new System.Drawing.Size(691, 383);
        ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn cbColumn;
    private System.Windows.Forms.DataGridViewImageColumn image;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    private System.Windows.Forms.DataGridViewTextBoxColumn price;
    private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    private System.Windows.Forms.DataGridViewTextBoxColumn description;
    private System.Windows.Forms.DataGridViewButtonColumn action;
    private System.Windows.Forms.DataGridViewButtonColumn edit_action;
}
