using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using UAS.Scripts.Model;

namespace UAS.Scripts {
    public class Database {

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        private String dbSources;
        private String query = "";

        private ArrayList arrayList;
        private SqlDataReader dataReader;

        public Database(String sources, String catalog, bool isSecurity) {
            dbSources = @"Data Source = " + sources + "; Initial Catalog = " + catalog + "; Integrated Security = " + isSecurity + ";";
        }

        public Database(String source) {
            dbSources = source;
        }

        public int ExecuteNonQuery(String query) {

            if (sqlConnection == null) sqlConnection = new SqlConnection(dbSources);
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();

            int affectedRows = -1;

            try {

                sqlCommand = new SqlCommand(query, sqlConnection);
                affectedRows = sqlCommand.ExecuteNonQuery();

            } catch (Exception e) {

                Console.WriteLine("Error : " + e.Message);

            }

            return affectedRows;
        }

        public SqlDataReader ExecuteQuery(String query) {

            if (sqlConnection == null) sqlConnection = new SqlConnection(dbSources);
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();

            SqlDataReader reader = null;

            try {

                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                reader = dataReader;

            } catch (Exception e) {

                Console.WriteLine("Error : " + e.Message);

            }

            return reader;
        }

        public SqlDataReader ExecuteQuery(String query, ArrayList arrayList) {

            if (sqlConnection == null) sqlConnection = new SqlConnection(dbSources);
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();

            SqlDataReader reader = null;

            try {

                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                reader = dataReader;

            } catch(Exception e) {

                Console.WriteLine("Error : " + e.Message);

            }

            return reader;
        }

        public void CloseConnection() {
            dataReader.Close();
            sqlConnection.Close();
        }

    }
}
