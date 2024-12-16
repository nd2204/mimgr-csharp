using app.components;
using app.db.records;
using app.globals;
using app.mvc.models;
using app.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.mvc.views;
public partial class ProductTable : UserControl {
    ProductModel productModel = new ProductModel();
    public ProductTable() {
        InitializeComponent();
    }

    public DataGridView DataGridView => this.dataGridView1;

    public void Update() {
        this.dataGridView1.Rows.Clear();
        productModel.LoadProduct();
        foreach (ProductModel.Product p in productModel.Products) {
            AddRows(p);
        }
        // Set the height for all rows
        foreach (DataGridViewRow row in dataGridView1.Rows) {
            row.Height = 100;
        }
    }

    private void AddRows(ProductModel.Product product) {
        this.dataGridView1.Rows.Add(false, ImageUtils.ResizeByAspectRatio(product.image, 80, 80), product.name, product.price, product.stock, product.desc);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        // Ensure the click is on the button column
        if (e.ColumnIndex == dataGridView1.Columns["action"].Index && e.RowIndex >= 0) {
            ProductModel.Product product = productModel.Products[e.RowIndex];
            DialogResult result = MessageBox.Show(
                $"Delete {product.name}?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes) {
                ProductRecord.Delete(product.id);
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                productModel.Products.Remove(product);
            }
        }
    }
}
