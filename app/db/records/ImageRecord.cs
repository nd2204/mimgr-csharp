using app.globals;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.db.records {
    internal class ImageRecord {
        public int    m_id;
        public string m_name;
        public string m_caption;
        public string m_url;
        public string m_created_at;
        public int    m_author;

        public static readonly string TABLE            = "images";
        public static readonly string FIELD_ID         = "image_id";
        public static readonly string FIELD_NAME       = "image_name";
        public static readonly string FIELD_CAPTION    = "image_caption";
        public static readonly string FIELD_URL        = "image_url";
        public static readonly string FIELD_CREATED_AT = "image_created_at";
        public static readonly string FIELD_AUTHOR     = "image_author";

        public static readonly string QUERY_SELECT_ALL       = $"SELECT * FROM {TABLE}";
        public static readonly string QUERY_SELECT_BY_ID     = $"SELECT * FROM {TABLE} WHERE {FIELD_ID} = @value0";
        public static readonly string QUERY_SELECT_LIKE_NAME = $"SELECT * FROM {TABLE} WHERE {FIELD_NAME} LIKE @value0";
        public static readonly string QUERY_INSERT           =
            $"INSERT INTO {TABLE} ({FIELD_NAME}, {FIELD_URL}, {FIELD_CAPTION}, {FIELD_AUTHOR}) " +
            $"VALUES (@value0, @value1, @value2, @value3)";
        public static readonly string QUERY_DELETE_BY_ID     = $"DELETE FROM {TABLE} WHERE {FIELD_ID} = @value0";
        public static readonly string QUERY_UPDATE_BY_KEY    =
            $"UPDATE {TABLE}" +
            $"SET {FIELD_NAME}=@value0, {FIELD_CAPTION}=@value1, {FIELD_URL}=@value2, {FIELD_AUTHOR}=@value3" +
            $"WHERE {FIELD_ID}=@value4";
        public static readonly string QUERY_SELECT_ALL_NEWEST = 
            $"SELECT * FROM {TABLE} ORDER BY {FIELD_CREATED_AT} DESC";
        public static readonly string QUERY_SELECT_ALL_OLDEST =
            $"SELECT * FROM {TABLE} ORDER BY {FIELD_CREATED_AT} ASC";

        public ImageRecord(MySqlDataReader reader) {
            m_id         = reader.GetInt32(FIELD_ID);
            m_name       = reader.GetString(FIELD_NAME);
            m_caption    = reader.GetString(FIELD_CAPTION);
            m_url        = reader.GetString(FIELD_URL);
            m_created_at = reader.GetString(FIELD_CREATED_AT);
            m_author     = reader.GetInt32(FIELD_AUTHOR);
        }

        public ImageRecord(
          int id, string name, string caption, string url,
          string created_at, int author
        ) {
            m_id             = id;
            m_name           = name;
            m_caption        = caption;
            m_url            = url;
            m_created_at     = created_at;
            m_author         = author;
        }

        public static MySqlDataReader SelectAll() {
            return DBQueries.Select(QUERY_SELECT_ALL);
        }

        public static ImageRecord SelectByName(string name) {
            name = name.Substring(0, name.IndexOf("."));
            try {
                MySqlDataReader reader = SelectByField(FIELD_NAME, name);
                if (reader == null || !reader.Read()) return null;
                return new ImageRecord(reader);
            }
            catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }

        public static ImageRecord SelectByURL(string url) {
            try {
                MySqlDataReader reader = SelectByField(FIELD_URL, url);
                if (reader == null || !reader.Read()) return null;
                return new ImageRecord(reader);
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }

        public static MySqlDataReader SelectByField(string field, string value) {
            return DBQueries.SelectAllFromTableByField(TABLE, field, value);
        }

        public static ImageRecord SelectById(int id) {
            try {
                MySqlDataReader reader = DBQueries.Select(QUERY_SELECT_BY_ID, id);
                if (reader == null || !reader.Read()) return null;
                return new ImageRecord(reader);
            }
            catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }

        public static MySqlDataReader SelectLikeName(string name) {
            return DBQueries.Select(QUERY_SELECT_LIKE_NAME, '%' + name + '%');
        }

        public static int Delete(ImageRecord ir) {
            return DBQueries.Update(QUERY_DELETE_BY_ID, ir.m_id);
        }

        public static int Delete(int id) {
            return DBQueries.Update(QUERY_DELETE_BY_ID, id);
        }

        public static int Insert(string image_url, string image_name, string image_caption, int image_author) {
            image_name = image_name.Substring(0, image_name.IndexOf("."));
            int result = DBQueries.Update(QUERY_INSERT, image_name, image_url, image_caption, image_author);
            return result;
        }

        public static int Insert(ImageRecord ir) {
            ir.m_name = ir.m_name.Substring(0, ir.m_name.IndexOf("."));
            int result = DBQueries.Update(
              QUERY_INSERT,
              ir.m_name,
              ir.m_url,
              ir.m_caption,
              SessionManager.GetCurrentUser().m_id,
              ir.m_id
            );
            return result;
        }

        public static int Update(string image_name, string image_caption, string image_url, int image_author, int image_id) {
            image_name = image_name.Substring(0, image_name.IndexOf("."));
            int result = DBQueries.Update(QUERY_UPDATE_BY_KEY, image_name, image_caption, image_url, image_author, image_id);
            return result;
        }

        public static int Update(ImageRecord ir) {
            ir.m_name = ir.m_name.Substring(0, ir.m_name.IndexOf("."));
            int result = DBQueries.Update(
              QUERY_UPDATE_BY_KEY,
              ir.m_name,
              ir.m_caption,
              ir.m_url,
              SessionManager.GetCurrentUser().m_id,
              ir.m_id
            );
            return result;
        }

        public static string GetImageAuthor(ImageRecord ir) {
            try {
                MySqlDataReader reader = UserRecord.SelectUserById(ir.m_author);
                if (reader.Read()) {
                    UserRecord ur = new UserRecord(reader);
                    return ur.m_username;
                }
            }
            catch (Exception) {
                return "N/A";
            }
            return "N/A";
        }

        public static MySqlDataReader SelectAllNewest() {
            return DBQueries.Select(QUERY_SELECT_ALL_NEWEST);
        }

        public static MySqlDataReader SelectAllOldest() {
            return DBQueries.Select(QUERY_SELECT_ALL_OLDEST);
        }

    }
}
