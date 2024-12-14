using System;
using System.Collections.Generic;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace app.db {
    public delegate void ConnectionListener(MySqlConnection connection);

    internal class DBConnection {
        private static readonly Lazy<DBConnection> instance = new Lazy<DBConnection>(() => new DBConnection());
        public static DBConnection Instance => instance.Value;

        private MySqlConnection connection;
        private string url = "server=127.0.0.1;port=3306;database=mimgrdb;user=mimgr;password=mimgr-db;SslMode=Preferred;";
        private bool reconnecting;
        private Thread reconnectThread;
        private readonly List<ConnectionListener> listeners = new List<ConnectionListener>();

        private DBConnection() {
            connection = null;
            TryConnect();
            if (connection == null) {
                StartReconnectThread();
            }
        }

        // Get the current connection, with reconnection logic
        public MySqlConnection GetConnection() {
            if (connection == null || !IsConnectionValid()) {
                StartReconnectThread();
            }
            return connection;
        }

        // Add a connection listener
        public void AddConnectionListener(ConnectionListener listener) {
            listeners.Add(listener);
            if (connection != null) {
                listener(connection);
            }
        }

        // Close the current connection
        public void CloseConnection() {
            try {
                if (IsConnectionValid()) {
                    connection.Close();
                    NotifyListenerClosed();
                    connection = null;
                    StopReconnectThread();
                }
            }
            catch (MySqlException ex) {
                Console.Error.WriteLine(ex);
            }
        }

        // Get information about the connection
        public string GetConnectionInfo() {
            if (connection == null) {
                return "No active database connection.";
            }

            try {
                var metaData = connection.GetSchema();
                return $"Connected to {connection.Database}\n" +
                       $"Server Version: {connection.ServerVersion}\n";
            }
            catch (Exception e) {
                return $"Unable to retrieve connection information: {e.Message}";
            }
        }

        // Try to establish a connection
        private void TryConnect() {
            try {
                connection = new MySqlConnection(url);
                connection.Open();
                Console.WriteLine("Connection Info:\n" + GetConnectionInfo() + "\n");
                NotifyListenerConnected();
            }
            catch (MySqlException sqlex) {
                Console.Error.WriteLine(sqlex.Message);
            }
            catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }

        // Start a thread to attempt reconnection
        private void StartReconnectThread() {
            if (reconnectThread != null && reconnectThread.IsAlive) {
                return; // Already running
            }

            reconnectThread = new Thread(() => {
                reconnecting = true;
                while (reconnecting) {
                    MessageBox.Show("Attempting to reconnect...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    try {
                        Thread.Sleep(5000); // Attempt to reconnect every 5 seconds
                        TryConnect();
                        if (connection != null && IsConnectionValid()) {
                            MessageBox.Show("Reconnected successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StopReconnectThread();
                        }
                        else {
                            MessageBox.Show("Connection Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Thread.Sleep(5000);
                    }
                    catch (ThreadInterruptedException) {
                        Thread.CurrentThread.Interrupt();
                    }
                }
            });
            reconnectThread.IsBackground = true;
            reconnectThread.Start();
        }

        // Check if the connection is valid
        private bool IsConnectionValid() {
            try {
                if (connection != null && connection.Ping()) {
                    return true;
                }
            }
            catch (MySqlException ex) {
                Console.Error.WriteLine("Connection validation failed: " + ex.Message);
            }
            return false;
        }

        // Stop the reconnection thread
        private void StopReconnectThread() {
            reconnecting = false;
            if (reconnectThread != null) {
                reconnectThread.Interrupt();
            }
        }

        // Notify listeners when connected
        private void NotifyListenerConnected() {
            foreach (var listener in listeners) {
                listener(connection);
            }
        }

        // Notify listeners when the connection is closed
        private void NotifyListenerClosed() {
            foreach (var listener in listeners) {
                listener(null);
            }
        }
    }
}
