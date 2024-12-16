using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace app.db.records {
    internal class ProductRecord {
        public Int32 m_id;
        public string m_name;
        public double m_price;
        public string m_description;
        public Int32 m_stock_quantity;
        public Int32 m_category_id;
        public Int32 m_image_id;

        public static readonly string TABLE = "products";
        public static readonly string FIELD_ID = "product_id";
        public static readonly string FIELD_NAME = "name";
        public static readonly string FIELD_PRICE = "price";
        public static readonly string FIELD_DESCRIPTION = "description";
        public static readonly string FIELD_STOCK_QUANTITY = "stock_quantity";
        public static readonly string FIELD_CATEGORY_ID = "category_id";
        public static readonly string FIELD_IMAGE_ID = "image_id";

        public static readonly string QUERY_SELECT_ALL = $"SELECT * FROM {TABLE}";
        public static readonly string QUERY_SELECT_BY_KEY = $"SELECT * FROM {TABLE} WHERE {FIELD_ID} = @value0";
        public static readonly string QUERY_SELECT_BY_NAME = $"SELECT * FROM {TABLE} WHERE {FIELD_NAME} = @value0";
        public static readonly string QUERY_SELECT_LIKE_NAME = $"SELECT * FROM {TABLE} WHERE {FIELD_NAME} LIKE @value0";

        public static readonly string QUERY_INSERT =
            $"INSERT INTO {TABLE} " +
            $"({FIELD_NAME}, {FIELD_PRICE}, {FIELD_DESCRIPTION}, {FIELD_STOCK_QUANTITY}, {FIELD_CATEGORY_ID}, {FIELD_IMAGE_ID}) " +
            $"VALUES (@value0, @value1, @value2, @value3, @value4, @value5)";

        public static readonly string QUERY_DELETE_BY_KEY =
          $"DELETE FROM {TABLE} WHERE {FIELD_ID} = @value0";

        public static readonly string QUERY_UPDATE_BY_KEY =
          $"UPDATE {TABLE} " +
          $"SET {FIELD_NAME}=@value0, {FIELD_PRICE}=@value1, {FIELD_DESCRIPTION}=@value2, {FIELD_STOCK_QUANTITY}=@value3, {FIELD_CATEGORY_ID}=@value4, {FIELD_IMAGE_ID}=@value5 " +
          $"WHERE {FIELD_ID}=@value6";

        public ProductRecord(
          int id, string name, String description,
          double price, int stock_quantity, int category_id, int image_id
        ) {
            m_id             = id;
            m_name           = name;
            m_description    = description;
            m_price          = price;
            m_stock_quantity = stock_quantity;
            m_category_id    = category_id;
            m_image_id       = image_id;
        }


        public ProductRecord(MySqlDataReader reader) {
            m_id             = reader.GetInt32(FIELD_ID);
            m_name           = reader.GetString(FIELD_NAME);
            m_description    = reader.GetString(FIELD_DESCRIPTION);
            m_price          = reader.GetDouble(FIELD_PRICE);
            m_stock_quantity = reader.GetInt32(FIELD_STOCK_QUANTITY);
            m_category_id    = reader.GetInt32(FIELD_CATEGORY_ID);
            m_image_id       = reader.GetInt32(FIELD_IMAGE_ID);
        }

        public static MySqlDataReader SelectAll() {
            return DBQueries.Select(QUERY_SELECT_ALL);
        }

        public static MySqlDataReader SelectByKey(int id) {
            return DBQueries.Select(QUERY_SELECT_BY_KEY, id);
        }

        public static MySqlDataReader SelectByKey(ProductRecord pr) {
            return DBQueries.Select(QUERY_SELECT_BY_KEY, pr.m_id);
        }

        public static MySqlDataReader SelectByName(string name) {
            return DBQueries.Select(QUERY_SELECT_BY_NAME, name);
        }

        public static MySqlDataReader SelectByName(ProductRecord pr) {
            return DBQueries.Select(QUERY_SELECT_BY_NAME, pr.m_name);
        }

        public static MySqlDataReader SelectLikeName(string name) {
            return DBQueries.Select(QUERY_SELECT_LIKE_NAME, '%' + name + '%');
        }

        public static MySqlDataReader SelectLikeName(ProductRecord pr) {
            return DBQueries.Select(QUERY_SELECT_LIKE_NAME, '%' + pr.m_name + '%');
        }

        //public static MySqlDataReader SelectTopProductByQuantitySold() {
        //    return DBQueries.Select($@"
        //        SELECT p.*, SUM(oi.quantity) AS total_quantity_sold
        //        FROM {OrderItemRecord.TABLE}
        //            AS oi
        //        INNER JOIN {ProductRecord.TABLE}
        //            AS p
        //        WHERE p.{ProductRecord.FIELD_ID} = oi.{OrderItemRecord.FIELD_PRODUCT_ID}
        //            GROUP BY oi.{ProductRecord.FIELD_ID}, p.{OrderItemRecord.FIELD_PRODUCT_ID}
        //            ORDER BY total_quantity_sold DESC
        //    ");
        //}

        public static int Delete(ProductRecord pr) {
            return DBQueries.Update(QUERY_DELETE_BY_KEY, pr.m_id);
        }

        public static int Delete(int id) {
            return DBQueries.Update(QUERY_DELETE_BY_KEY, id);
        }

        public static int Insert(string name, Double price, String description, int stock_quantity, int category_id, int image_id) {
            int result = DBQueries.Update(
                QUERY_INSERT, name, price,
                description, stock_quantity, category_id,
                image_id < 0 ? (int?)null : image_id);
            return result;
        }

        public static int Insert(ProductRecord pr) {
            int result = DBQueries.Update(
                QUERY_INSERT, pr.m_name, pr.m_price, pr.m_description,
                pr.m_stock_quantity, pr.m_category_id,
                (pr.m_image_id < 0) ? (int?)null : pr.m_image_id
            );
            return result;
        }

        public static int Update(string name, Double price, String description, int stock_quantity, int category_id, int image_id, int product_id) {
            return DBQueries.Update(QUERY_UPDATE_BY_KEY, name, price, description, stock_quantity, category_id, image_id, product_id);
        }

        public static int Update(ProductRecord pr) {
            return DBQueries.Update(QUERY_UPDATE_BY_KEY, pr.m_name, pr.m_price, pr.m_description, pr.m_stock_quantity, pr.m_category_id, pr.m_id);
        }
    }
}
