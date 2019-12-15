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

        public Database Select(String something) {
            this.query += "SELECT " + something + " ";

            return this;
        }

        public void ExecuteQuery(String query) {


            if (sqlConnection == null) sqlConnection = new SqlConnection(dbSources);
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();

            sqlCommand = new SqlCommand(query, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();


            dataReader.Close();
            sqlConnection.Close();

        }

        public void ExecuteQuery(String query, ArrayList arrayList) {

            if (sqlConnection == null) sqlConnection = new SqlConnection(dbSources);
            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();

            sqlCommand = new SqlCommand(query, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();


            Console.WriteLine(1);

            dataReader.Close();
            sqlConnection.Close();

        }

    }
}
