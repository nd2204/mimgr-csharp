using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace app.mvc.views;
public partial class FormOrder : Form {
    public FormOrder() {
        InitializeComponent();
        LoadDataFromDatabase();
    }

    private void LoadDataFromDatabase() {
        try {
            string url = "server=127.0.0.1;port=3306;database=mimgrdb;user=mimgr;password=mimgr-db;SslMode=Preferred;";

            using (MySqlConnection connection = new MySqlConnection(url)) {
                connection.Open();
                string query = "SELECT * FROM orders";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    dataGridView1.Rows.Add(
                        reader["order_id"],               // Cột OrderID
                        Convert.ToDateTime(reader["order_date"]).ToString("yyyy-MM-dd HH:mm:ss"), // Cột OrderDate
                        reader["order_total"],                 // Cột Total
                        reader["order_status"],           // Cột OrderStatus
                        reader["payment_status"],         // Cột PaymentStatus
                        0
                    );
                }
            }
        }
        catch (Exception ex) {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

}
