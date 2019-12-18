using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Schedule {
    public partial class RoundForm : Form {

        private String eventID;
        private QueryBuilder queryBuilder;
        private Database database;

        public RoundForm() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);

            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;
        }

        private void RoundForm_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void LoadData() {
            dataGridView.Rows.Clear();
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("schedules")
                                               .Where("id_event", "=", eventID);

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
            int number = 0;

            try {

                while (dataReader.Read()) {

                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["rounds"].ToString(),
                        // jika di database = 1, maka eliminasi, jika 0 maka ronde
                        int.Parse(dataReader["eliminate"].ToString()) == 1 ? "Eliminasi" : "Ronde",
                        dataReader["nama_round"].ToString()
                    );
                }

            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            dataReader.Close();
            database.CloseConnection();
        }

        private void buttonTambahRonde_Click(object sender, EventArgs e) {
            AddRoundForm addRoundForm = new AddRoundForm();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // passing id event ke form berikutnya
            addRoundForm.SetEventID(eventID);
            addRoundForm.ShowDialog(this);
            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }
    }
}
