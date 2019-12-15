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

        public QueryBuilder Where(String key, String value) {
            this.query += "WHERE " + key + " = '" + value + "'";
            return this;
        }

        public QueryBuilder Where(String[][] data) {

            // {"key", "operator", "value", ""}
            this.query += "WHERE ";
            for (int i = 0; i < data.Length; i++) {
                string temp = "";
                if (data[i].Length > 3 && i < data.Length - 1) temp = data[i][3];

                arrayList.AddRange(new string[] {"@" + data[i][2], data[i][2] });

                this.query += data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + temp + " ";
            }

            return this;
        }

        public ArrayList GetArrayList() {
            return arrayList;
        }

        public String Get() {
            return this.query;
        }

    }
}
