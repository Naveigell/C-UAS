using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS.Scripts.Model {
    class Auth {
        public static int TYPE_USER = 1, TYPE_ADMIN = 2;
        private int TYPE;
        private Database database;
        private QueryBuilder queryBuilder;

        public Auth() {
            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();
        }

        public bool SignInWithEmailAndPassword(String email, String password, bool isBool) {
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("[admin]")
                                               .Where(new string[][] {
                                                    new string[] { "email", "=", email, "AND" },
                                                    new string[] { "[password]", "=", password }
                                               });

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
            if (dataReader == null) return false;

            if (dataReader.HasRows) {
                // jika data reader memiliki row, maka jadikan type menjadi admin
                TYPE = TYPE_ADMIN;

                dataReader.Close();
                database.CloseConnection();

                return true;
            }

            dataReader.Close();
            database.CloseConnection();

            return false;
        }

        public Auth SignInWithEmailAndPassword(String email, String password) {
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("[admin]")
                                               .Where(new string[][] {
                                                    new string[] { "email", "=", email, "AND" },
                                                    new string[] { "[password]", "=", password }
                                               });

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
            if (dataReader == null) return null;

            if (dataReader.HasRows) {
                // jika data reader memiliki row, maka jadikan type menjadi admin
                TYPE = TYPE_ADMIN;
            }

            dataReader.Close();
            database.CloseConnection();

            return this;
        }

        public int GetUserType() {
            return TYPE;
        }
    }
}
