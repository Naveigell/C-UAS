using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS.Scripts.Model {
    class QueryBuilder {

        private String query = "";
        private ArrayList arrayList;
        public static int LIKE_LEFT = 60, LIKE_RIGHT = 90, LIKE_BOTH = 14;
        public static String ORDER_ASCENDING = "ASC", ORDER_DESCENDING = "DESC";

        public QueryBuilder() {
            arrayList = new ArrayList();
        }

        public QueryBuilder Select(String something) {
            this.query += "SELECT " + something + " ";

            return this;
        }

        public QueryBuilder From(String table) {
            this.query += "FROM " + table + " ";

            return this;
        }

        public QueryBuilder Insert(String table, String value) {
            this.query += "INSERT INTO " + table + " (" + value + ") VALUES";

            return this;
        }

        public QueryBuilder DeleteFrom(String table) {

            this.query += " DELETE FROM " + table + " ";

            return this;
        }

        public QueryBuilder InnerJoin(String table, String value1, String operatorr, String value2) {

            this.query += " INNER JOIN " + table + " ON " + value1 + " " + operatorr + " " + value2 + " ";

            return this;
        }

        public QueryBuilder Join(String table, String value1, String operatorr, String value2) {

            this.query += " JOIN " + table + " ON " + value1 + " " + operatorr + " " + value2 + " ";

            return this;
        }

        public QueryBuilder Values(String[][] values) {

            for (int i = 0; i < values.Length; i++) {
                for (int j = 0; j < values[i].Length; j++) {
                    if (j == 0) this.query += "(";

                    this.query += "'" + values[i][j] + "'";

                    if (j < values[i].Length - 1) this.query += ",";

                    if (j == values[i].Length - 1) this.query += ")";

                }
                if (i < values.Length - 1) this.query += ",";
            }

            return this;
        }

        public QueryBuilder Where(String key, String operatorr, String value) {
            this.query += " WHERE " + key + " " + operatorr + " '" + value + "'";
            return this;
        }

        public QueryBuilder WhereLike(String column, String value, int like) {

           this.query += " WHERE " + column + " LIKE ";

            if (like == LIKE_BOTH) {
                this.query += "'%" + value + "%' ";
                return this;
            }

            this.query += "'";
            if (like == LIKE_LEFT) this.query += "% ";
            this.query += value + " ";
            if (like == LIKE_RIGHT) this.query += "% ";
            this.query += "'";

            return this;
        }

        public QueryBuilder Raw(String query) {
            this.query = query;

            return this;
        }

        public QueryBuilder Set(String[][] data) {

            for (int i = 0; i < data.Length; i++) {
                this.query += data[i][0] + " = '" + data[i][1] + "'";
                if (i < data.Length - 1) this.query += ", ";
            }

            return this;
        }

        public QueryBuilder Update(String table) {
            this.query += " UPDATE " + table + " SET ";

            return this;
        }

        public QueryBuilder Where(String[][] data) {

            // {"key", "operator", "value", "AND"}
            this.query += " WHERE ";
            for (int i = 0; i < data.Length; i++) {
                string temp = "";
                if (data[i].Length > 3 && i < data.Length - 1) temp = data[i][3];

                arrayList.AddRange(new string[] {"@" + data[i][2], data[i][2] });

                this.query += data[i][0] + " " + data[i][1] + " '" + data[i][2] + "' " + temp + " ";
            }

            return this;
        }

        public QueryBuilder OrderBy(String by, String order) {
            this.query += " ORDER BY " + by + " " + order + " ";

            return this;
        }

        public QueryBuilder Limit(int offset, int limit) {

            this.query += " OFFSET " + offset + " ROWS FETCH NEXT " + limit + " ROWS ONLY";

            return this;
        }

        public ArrayList GetArrayList() {
            return arrayList;
        }

        public String Get() {
            String temp = this.query;
            this.query = "";
            
            return temp;
        }

    }
}
