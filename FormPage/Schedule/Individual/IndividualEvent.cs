using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.FormPage.Schedule.Individual;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Schedule {
    public partial class IndividualEvent : Form {

        private String eventID, scheduleID;
        private String[] individualSchedulesID;
        private QueryBuilder queryBuilder;
        private Database database;
        private ArrayList arrayList;

        public IndividualEvent() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void SetScheduleID(String scheduleID) {
            this.scheduleID = scheduleID;
        }

        private void LoadData() {
            dataGridView.Rows.Clear();
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("score_by_individual")
                                               .InnerJoin("schedules", "schedules.id_schedule", "=", "score_by_individual.id_scedule")
                                               .InnerJoin("peserta", "peserta.id_peserta", "=", "score_by_individual.id_peserta1")
                                               .Where("schedules.id_schedule", "=", scheduleID);

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
            int number = 0;

            try {

                while (dataReader.Read()) {
                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["nama_peserta"].ToString(),
                        dataReader["waktu_pelaksanaan"].ToString(),
                        dataReader["score_by_individual_score"].ToString(),
                        dataReader["score_by_individual_venue"].ToString()
                    );

                    arrayList.Add(dataReader["id_score_by_individual"].ToString());
                }

                individualSchedulesID = new String[arrayList.Count];
                for (int i = 0; i < arrayList.Count; i++) {
                    individualSchedulesID[i] = arrayList[i].ToString();
                }

            } catch(Exception exception) {
                Console.WriteLine(exception);
            }
            dataReader.Close();
            database.CloseConnection();
        }

        private void buttonTambahJadwalPeserta_Click(object sender, EventArgs e) {
            IndividualAddForm individualAddForm = new IndividualAddForm();

            this.Opacity = 0.4;

            individualAddForm.SetEventID(eventID);
            individualAddForm.SetScheduleID(scheduleID);
            individualAddForm.ShowDialog(this);
            LoadData();

            this.Opacity = 1;
        }

        private void IndividualEvent_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void buttonEditJadwalPesertaIndividual_Click(object sender, EventArgs e) {

            try {

                int rowCount = dataGridView.CurrentCell.RowIndex;
                String skor = dataGridView.Rows[rowCount].Cells[3].Value.ToString();
                String venue = dataGridView.Rows[rowCount].Cells[4].Value.ToString();

                EditIndividualForm editIndividualForm = new EditIndividualForm();

                this.Opacity = 0.4;

                editIndividualForm.SetEventID(eventID);
                editIndividualForm.SetScheduleID(scheduleID);
                editIndividualForm.SetScore(skor);
                editIndividualForm.SetVenue(venue);
                editIndividualForm.SetIndividualScheduleID(individualSchedulesID[rowCount]);
                editIndividualForm.ShowDialog(this);
                LoadData();

                this.Opacity = 1;

            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonDeleteSchedule_Click(object sender, EventArgs e) {
            try {

                /*if (dataGridView.SelectedRows.Count > 0) {*/
                //
                // BUG
                //
                String name = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
                String id = individualSchedulesID[dataGridView.CurrentCell.RowIndex];

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

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);

            arrayList = new ArrayList();

            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;
        }
    }
}
