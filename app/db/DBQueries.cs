using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace app.db {
    internal class DBQueries {
        private static MySqlConnection dbcon = DBConnection.Instance.GetConnection();

        public static MySqlDataReader Select(string stmt, params object[] args) {
            MySqlDataReader resultSet = null;
            dbcon = DBConnection.Instance.GetConnection();
            if (dbcon == null)
                return null;

            try {
                using (var preparedStatement = new MySqlCommand(stmt, dbcon)) {
                    for (int i = 0; i < args.Length; ++i) {
                        preparedStatement.Parameters.AddWithValue($"@param{i}", args[i]);
                    }
                    resultSet = preparedStatement.ExecuteReader();
                }
            }
            catch (MySqlException e) {
                Console.Error.WriteLine(e.Message);
            }

            return resultSet;
        }

        public static int BatchUpdate(string stmt, List<object[]> batchArgs) {
            int totalAffectedRows = 0;
            dbcon = DBConnection.Instance.GetConnection();
            if (dbcon == null) return 0;

            try {
                using (var preparedStatement = new MySqlCommand(stmt, dbcon)) {
                    foreach (var args in batchArgs) {
                        preparedStatement.Parameters.Clear(); // Clear previous parameters
                        for (int i = 0; i < args.Length; ++i) {
                            preparedStatement.Parameters.AddWithValue($"@param{i}", args[i]);
                        }
                        preparedStatement.ExecuteNonQuery();
                        totalAffectedRows += args.Length;
                    }
                }
            }
            catch (MySqlException e) {
                Console.Error.WriteLine(e.Message);
            }

            return totalAffectedRows;
        }

        public static int Update(string stmt, params object[] args) {
            int totalAffectedRows = 0;
            dbcon = DBConnection.Instance.GetConnection();
            if (dbcon == null)
                return 0;

            try {
                using (var preparedStatement = new MySqlCommand(stmt, dbcon)) {
                    for (int i = 0; i < args.Length; ++i) {
                        preparedStatement.Parameters.AddWithValue($"@param{i}", args[i]);
                    }
                    totalAffectedRows = preparedStatement.ExecuteNonQuery();
                }
            }
            catch (MySqlException e) {
                Console.Error.WriteLine(e.Message);
            }

            return totalAffectedRows;
        }


        public static MySqlDataReader selectAllFromTableByField(string table, string field, string value) {
            return Select(string.Format("SELECT * FROM {0} WHERE {1} = @value", table, field), value);
        }

        public static MySqlDataReader selectAllFromTableLikeField(string table, string field, string value) {
            return Select(string.Format("SELECT * FROM {0} WHERE {1} LIKE @value", table, field), value);
        }

    }
}
