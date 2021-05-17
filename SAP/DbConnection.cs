using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace SAP {
    class DbConnection {
        private string db_name = "./pizzeria.db";
        private string db_script = "new_pizzeria.sql";
        private static DbConnection db;
        private bool is_nuevo = false; 
        SQLiteConnection connection;
        private DbConnection() {
            if (!File.Exists(db_name)) {
                is_nuevo = true;
            }
            connection = new SQLiteConnection(string.Format("Data Source={0}; Version=3", this.db_name));
            connection.Open();
            if (is_nuevo) {
                string command = File.ReadAllText(db_script);
                using (var obj = connection.CreateCommand()) {
                    obj.CommandText = command;
                    obj.ExecuteNonQuery();
                }
            }
        }
        public static DbConnection getConnection() {
            if (db is null) {
                db = new DbConnection();
            }
            return db;
        }

        public DataTable execute(string query) {
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, this.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public long executeNQ(string query) {
            SQLiteCommand command = new SQLiteCommand(query, this.connection);
            command.ExecuteNonQuery();

            return this.connection.LastInsertRowId;
        }

        public void close() {
            this.connection.Close();
        }

        //Comantario
    }
}
