using app.db;
using app.db.records;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using app.globals;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace app.mvc.models;
public class ProductModel {
    public List<Product> Products { get; } = new List<Product>();
    public class Product {
        public int id;
        public string name;
        public string desc;
        public int stock;
        public decimal price;
        public Image image;
    }

    public void LoadProduct() {
        Products.Clear();
        string SELECT_PRODUCT_JOIN_IMAGE = $"SELECT * FROM {ProductRecord.TABLE} p " +
            $"INNER JOIN {ImageRecord.TABLE} i " +
            $"ON p.{ProductRecord.FIELD_IMAGE_ID} = i.{ImageRecord.FIELD_ID}";
        using (MySqlDataReader reader = DBQueries.Select(SELECT_PRODUCT_JOIN_IMAGE)) {
            while (reader.Read()) {
                Product product = new Product();

                DBQueries.LoadValue(reader, ProductRecord.FIELD_ID, out product.id);
                DBQueries.LoadValue(reader, ProductRecord.FIELD_NAME, out product.name);
                DBQueries.LoadValue(reader, ProductRecord.FIELD_DESCRIPTION, out product.desc);
                DBQueries.LoadValue(reader, ProductRecord.FIELD_STOCK_QUANTITY, out product.stock);
                DBQueries.LoadValue(reader, ProductRecord.FIELD_PRICE, out product.price);

                ImageRecord ir = new ImageRecord(reader);
                product.image = ResourceManager.Instance.GetUploadFromDB(ir.m_url);
                Products.Add(product);
            }
        }
    }
}
