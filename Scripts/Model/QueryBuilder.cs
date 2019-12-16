﻿using System;
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

        public QueryBuilder Insert(String table, String value) {
            this.query += "INSERT INTO " + table + " (" + value + ") VALUES";

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
            this.query += "WHERE " + key + " " + operatorr + " '" + value + "'";
            return this;
        }

        public QueryBuilder Where(String[][] data) {

            // {"key", "operator", "value", "AND"}
            this.query += "WHERE ";
            for (int i = 0; i < data.Length; i++) {
                string temp = "";
                if (data[i].Length > 3 && i < data.Length - 1) temp = data[i][3];

                arrayList.AddRange(new string[] {"@" + data[i][2], data[i][2] });

                this.query += data[i][0] + " " + data[i][1] + " " + data[i][2] + " " + temp + " ";
            }

            return this;
        }

        public QueryBuilder OrderBy(String order) {
            this.query += "ORDER BY " + order + " ";

            return this;
        }

        public QueryBuilder Limit(int offset, int limit) {

            this.query += "OFFSET " + offset + " ROWS FETCH NEXT " + limit + " ROWS ONLY";

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
