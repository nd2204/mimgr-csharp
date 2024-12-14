using app.db.records;
using app.utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.globals {
    internal class SessionManager {
        private static readonly Lazy<SessionManager> instance = new Lazy<SessionManager>(() => new SessionManager());
        public static SessionManager Instance => instance.Value;

        private static ResourceManager rm = ResourceManager.Instance;
        private static UserRecord currentUser = null;
        private static readonly string TOKEN_FILE = Path.Combine(ResourceManager.Instance.AppDataPath.ToString(), "TOKEN");
        private static readonly string TOKEN_KEY = "rememberMeToken";

        public static void SaveSession(string token, DateTime expirationTime, int userId) {
            var properties = new NameValueCollection();
            properties[TOKEN_KEY] = token;
            SessionRecord.Insert(Security.GenerateToken(), token, userId, expirationTime);

            try {
                using (var writer = new StreamWriter(TOKEN_FILE)) {
                    writer.WriteLine($"{TOKEN_KEY}={token}");
                }
            }
            catch (IOException e) {
                Console.Error.WriteLine(e.Message);
            }

            Console.WriteLine("SAVED TOKEN TO: " + TOKEN_FILE);
        }

        // Load session if a valid token is present and has not expired
        //
        public static UserRecord LoadSession() {
            string token = GetToken();
            if (token == null || token.Length == 0) {
                Console.WriteLine(TOKEN_FILE + " Not exist, Skipping...");
                return null;
            }

            try {
                MySqlDataReader reader = SessionRecord.SelectByToken(token);
                if (reader == null || !reader.Read()) return null;

                var sr = new SessionRecord(reader);
                if (DateTime.Now < sr.m_expiration_time) {
                    using (MySqlDataReader rs = UserRecord.SelectUserById(sr.m_user_id)) {
                        if (!rs.Read()) return null;
                        UserRecord ur = new UserRecord(rs);
                        SetCurrentUser(ur);
                        return ur;
                    }

                }
                else {
                    Console.Error.WriteLine("NO TOKEN FOUND WITH THIS DEVICE TOKEN");
                    clearSession();
                }
            }
            catch (Exception e) {
                Console.Error.WriteLine(e.Message);
            }

            return null;
        }

        public static string GetToken() {
            if (File.Exists(TOKEN_FILE)) {
                try {
                    var lines = File.ReadAllLines(TOKEN_FILE);
                    foreach (var line in lines) {
                        if (line.StartsWith($"{TOKEN_KEY}=")) {
                            return line.Substring($"{TOKEN_KEY}=".Length);
                        }
                    }
                }
                catch (IOException e) {
                    Console.Error.WriteLine(e.Message);
                }
            }
            return null;
        }

        public static void clearSession() {
            try {
                SessionRecord.DeleteByToken(GetToken());
                if (File.Exists(TOKEN_FILE)) {
                    File.Delete(TOKEN_FILE);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e);
            }
        }

        public static UserRecord GetCurrentUser() {
            return currentUser;
        }

        public static void SetCurrentUser(UserRecord ur) {
            currentUser = ur;
            Console.WriteLine("Logged in as user: " + ur.m_username + " as role: " + ur.m_role);
            //PanelManager.createPopup(new NotificationPopup("Chào mừng trở lại " + ur.m_username, NotificationPopup.NOTIFY_LEVEL_INFO, 5000));
        }
    }
}
