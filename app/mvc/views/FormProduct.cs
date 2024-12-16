using app.db.records;
using app.globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        this.controlProductInfo1.BtnSubmit.Click += (sender, e) => {
            string name = this.controlProductInfo1.TbName.Text;
            string desc = this.controlProductInfo1.TbDescription.Text;
            double price;
            if (!Double.TryParse(this.controlProductInfo1.TbPrice.Text, out price)) {
                price = 0;
            }
            int stock;
            if (!Int32.TryParse(this.controlProductInfo1.TbName.Text, out stock)) {
                stock = 0;
            }
            string image_url = this.controlProductInfo1.TbImage.Text;
            if (string.IsNullOrEmpty(name)) {
                return;
            }

            int image_id = 0;
            if (!string.IsNullOrEmpty(image_url)) {
                FileInfo new_url = ResourceManager.Instance.MoveStagedFileToUploadDir(new FileInfo(image_url));
                string store_path = ResourceManager.Instance.GetRelativePathFromProjectToPath(new_url).Replace("\\", "/");
                store_path = store_path.Substring(store_path.IndexOf("/") + 1);
                ImageRecord.Insert(
                    store_path,
                    new_url.Name,
                    "",
                    SessionManager.Instance.GetCurrentUser().m_id);
                ImageRecord ir = ImageRecord.SelectByName(new_url.Name);
                image_id = (ir == null) ? 0 : ir.m_id;
            }

            ProductRecord.Insert(name, price, desc, stock, 1, image_id);
            this.productTable2.Update();

            MessageBox.Show($"Added {name}");
        };
    }

    private void FormProduct_Load(object sender, EventArgs e) {
    }

    private void productTable2_Load(object sender, EventArgs e) {
        productTable2.Update();
    }
}
