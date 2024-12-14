using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.db.records {
    internal class UserRecord {
        public UserRecord(MySqlDataReader reader) {
            m_id       = reader.GetInt32(FIELD_ID);
            m_hash     = reader.GetString(FIELD_HASH);
            m_salt     = reader.GetString(FIELD_SALT);
            m_username = reader.GetString(FIELD_USERNAME);
            m_role     = reader.GetString(FIELD_ROLE);
            m_email    = reader.GetString(FIELD_EMAIL);
            m_number   = reader.GetString(FIELD_NUMBER);
            m_bio      = reader.GetString(FIELD_BIO);
        }
        public UserRecord
        (   int id, string hash, string salt, string username,
            string role, string email, string number, string bio
        ) {
            m_id       = id;
            m_hash     = hash;
            m_salt     = salt;
            m_username = username;
            m_role     = role;
            m_email    = email;
            m_number   = number;
            m_bio      = bio;
        }

        public static MySqlDataReader SelectUserById(int id) {
            return DBQueries.Select(QUERY_SELECT_BY_ID, id);
        }

        public static MySqlDataReader SelectUserByName(string username) {
            return DBQueries.Select(QUERY_SELECT_BY_NAME, username);
        }

        public static MySqlDataReader SelectUserByRole(int role) {
            return DBQueries.Select(QUERY_SELECT_BY_ROLE, roles[role]);
        }

        public static int Insert(
          string username,
          string hash, string salt, string role
        ) {
            if (role.Length <= 0) {
                role = roles[ROLE_EMPLOYEE];
            }
            int result = DBQueries.Update(QUERY_INSERT, username, hash, salt, role);
            return result;
        }

        public static int Update(int id, string hash, string salt, int role) {
            return DBQueries.Update(QUERY_UPDATE, hash, salt, role, roles[role]);
        }

        public static int Update(string username, string role, string email, string number, string bio, int user_id) {
            return DBQueries.Update(QUERY_UPDATE_PROFILE, username, role, email, number, bio, user_id);
        }

        public static int Update(UserRecord ur) {
            return DBQueries.Update(QUERY_UPDATE_PROFILE, ur.m_username, ur.m_role, ur.m_email, ur.m_number, ur.m_bio, ur.m_id);
        }

        public int    m_id;
        public string m_username;
        public string m_hash;
        public string m_salt;
        public string m_role;
        public string m_email;
        public string m_number;
        public string m_bio;

        public static string TABLE          = "usereader";
        public static string FIELD_ID       = "id";
        public static string FIELD_HASH     = "hash";
        public static string FIELD_SALT     = "salt";
        public static string FIELD_USERNAME = "username";
        public static string FIELD_ROLE     = "role";
        public static string FIELD_EMAIL    = "email";
        public static string FIELD_NUMBER   = "number";
        public static string FIELD_BIO      = "bio";

        public static readonly string QUERY_INSERT =
            $"INSERT INTO {TABLE} ({FIELD_USERNAME}, {FIELD_HASH}, {FIELD_SALT}, {FIELD_ROLE}) " +
            $"VALUES (@value0, @value1, @value2, @value3);";

        public static readonly string QUERY_SELECT_BY_NAME = $"SELECT * FROM {TABLE} WHERE {FIELD_USERNAME}=@value0;";
        public static readonly string QUERY_SELECT_BY_ID = $"SELECT * FROM {TABLE} WHERE {FIELD_ID}=@value0;";
        public static readonly string QUERY_SELECT_BY_ROLE = $"SELECT * FROM {TABLE} WHERE {FIELD_ROLE}=@value0;";

        public static readonly string QUERY_UPDATE =
            $"UPDATE {TABLE} " +
            $"SET {FIELD_HASH} = @value0, {FIELD_SALT} = @value1, {FIELD_ROLE} = @value2 " +
            $"WHERE {FIELD_ID}=@value3;";

        public static readonly string QUERY_UPDATE_PROFILE =
            $"UPDATE {TABLE} " +
            $"SET {FIELD_USERNAME} = @value0, {FIELD_ROLE} = @value1, {FIELD_EMAIL} = @value2, {FIELD_NUMBER} = @value3, {FIELD_BIO} = @value4 " +
            $"WHERE {FIELD_ID}=@value5;";

        public static readonly int ROLE_ADMIN = 0;
        public static readonly int ROLE_EMPLOYEE = 1;
        public static readonly int ROLE_MANAGER = 2;
        public static readonly int ROLE_USER = 3;
        public static readonly int ROLE_MAXSIZE = 4;

        public static readonly string[] roles = { "admin", "employee", "manager", "user" };

    }
}
