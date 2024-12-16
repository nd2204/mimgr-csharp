using app.globals;
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
public partial class FormProduct : Form {
    FormManager fm = FormManager.Instance;
    public FormProduct() {
        InitializeComponent();
        this.Name = "Products";
        this.mPanel1.Hide();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void btnHome_Click(object sender, EventArgs e) {
        FormDashboard formDashboard = fm.Dashboard;
        formDashboard.SetButtonSelected(formDashboard.BtnHome);
    }

    private void btnAddProduct_Click(object sender, EventArgs e) {
        if (this.mPanel1.Visible) {
            this.mPanel1.Hide();
            this.panel2.Hide();
        }
        else {
            this.mPanel1.Show();
            this.panel2.Show();
        }
    }

    private void FormProduct_Load(object sender, EventArgs e) {
        productTable2.Update();
    }

    private void productTable2_Load(object sender, EventArgs e) {

    }
}
