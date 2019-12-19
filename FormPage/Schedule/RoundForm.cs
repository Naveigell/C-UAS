using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using UAS.FormPage.Schedule.Versus;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Schedule {
    public partial class RoundForm : Form {

        private String eventID;
        private QueryBuilder queryBuilder;
        private Database database;

        private ArrayList arrayList;
        private String[] schedulesID;

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

            arrayList = new ArrayList();
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

                    arrayList.Add(dataReader["id_schedule"].ToString());

                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["rounds"].ToString(),
                        // jika di database = 1, maka eliminasi, jika 0 maka ronde
                        int.Parse(dataReader["eliminate"].ToString()) == 1 ? "Eliminasi" : "Ronde",
                        dataReader["nama_round"].ToString()
                    );

                    schedulesID = new string[arrayList.Count];
                    for (int i = 0; i < arrayList.Count; i++) {
                        schedulesID[i] = arrayList[i].ToString();
                    }
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

        private void buttonLihatRonde_Click(object sender, EventArgs e) {

            if (dataGridView.Rows.Count < 1) return;

            int rowCount = dataGridView.CurrentCell.RowIndex;
            String eventType = dataGridView.Rows[rowCount].Cells[2].Value.ToString();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // cek jika event ini bertipe ronde
            if (eventType.ToLower().Equals("ronde")) {

                IndividualEvent individualEvent = new IndividualEvent();

                individualEvent.SetEventID(eventID);
                individualEvent.SetScheduleID(schedulesID[rowCount]);
                individualEvent.ShowDialog(this);
            } else {

                VersusEvent versusEvent = new VersusEvent();

                versusEvent.SetEventID(eventID);
                versusEvent.SetScheduleID(schedulesID[rowCount]);
                versusEvent.ShowDialog(this);
            }

            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonEditRonde_Click(object sender, EventArgs e) {
            if (dataGridView.Rows.Count < 1) return;

            int rowCount = dataGridView.CurrentCell.RowIndex;
            String round = dataGridView.Rows[rowCount].Cells[1].Value.ToString();
            String roundName = dataGridView.Rows[rowCount].Cells[3].Value.ToString();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            EditRoundForm editRoundForm = new EditRoundForm();
            editRoundForm.SetEventID(eventID);
            editRoundForm.SetRound(round);
            editRoundForm.SetRoundName(roundName);
            editRoundForm.SetSceduleID(schedulesID[rowCount]);

            editRoundForm.ShowDialog(this);

            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonDeleteRound_Click(object sender, EventArgs e) {
            try {

                /*if (dataGridView.SelectedRows.Count > 0) {*/
                //
                // BUG
                //
                String name = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
                String id = schedulesID[dataGridView.CurrentCell.RowIndex];

                DialogResult dialogResult = MessageBox.Show("Hapus " + name + "- (" + id + ")", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    QueryBuilder builder = queryBuilder.DeleteFrom("schedules")
                                                       .Where("id_schedule", "=", id);

                    int rowsAffected = database.ExecuteNonQuery(builder.Get());
                    if (rowsAffected > 0) {
                        MessageBox.Show("Hapus berhasil", "Success");
                        LoadData();
                    } else {
                        MessageBox.Show("Hapus gagal", "Error");
                    }

                }

                /*} else {
                    Console.WriteLine("No rows selected");
                }*/

            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
