using MySql.Data.MySqlClient;
using System;

namespace app.db.records {
    internal class SessionRecord {
        public SessionRecord(MySqlDataReader reader) {
            m_id              = reader.GetString(FIELD_ID);
            m_value           = reader.GetString(FIELD_VALUE);
            m_user_id         = reader.GetInt32(FIELD_USER_ID);
            m_expiration_time = reader.GetDateTime(FIELD_EXPIRATION);
        }

        public static MySqlDataReader SelectByToken(string token) {
            return DBQueries.Select(QUERY_SELECT_BY_TOKEN, token);
        }

        public static int Insert(string id, string token, int userId, DateTime expirationTime) {
            int result = DBQueries.Update(QUERY_INSERT, id, token, userId, expirationTime);
            return result;
        }

        public static int DeleteByToken(string token) {
            int result = DBQueries.Update(QUERY_DELETE_SESSION_BY_TOKEN, token);
            return result;
        }

        public string   m_id;
        public string   m_value;
        public int      m_user_id;
        public DateTime m_expiration_time;

        public static string TABLE            = "remember_me_tokens";
        public static string FIELD_ID         = "token_id";
        public static string FIELD_VALUE      = "token_value";
        public static string FIELD_USER_ID    = "user_id";
        public static string FIELD_EXPIRATION = "expiration_time";

        public static readonly string QUERY_INSERT =
            $"INSERT INTO {TABLE} ({FIELD_ID}, {FIELD_VALUE}, {FIELD_USER_ID}, {FIELD_EXPIRATION}) " +
            $"VALUES (@value0, @value1, @value2, @value3)";

        public static readonly string QUERY_SELECT_BY_TOKEN = $"SELECT * FROM {TABLE} WHERE {FIELD_VALUE} = @value0";

        public static readonly string QUERY_DELETE_SESSION_BY_TOKEN = $"DELETE FROM {TABLE} WHERE {FIELD_VALUE} = @value0";

    }
}
