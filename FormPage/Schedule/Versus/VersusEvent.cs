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
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Schedule.Versus {
    public partial class VersusEvent : Form {

        private String eventID, scheduleID;
        private String[] versusSchedulesID;
        private QueryBuilder queryBuilder;
        private Database database;
        private ArrayList arrayList;

        public VersusEvent() {
            InitializeComponent();
            InitializeVarible();
        }
        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void SetScheduleID(String scheduleID) {
            this.scheduleID = scheduleID;
        }

        private void LoadData() {
            dataGridView.Rows.Clear();
            /*QueryBuilder builder = queryBuilder.Select("*")
                                               .From("score_by_goal")
                                               .Join("peserta AS peserta1", "score_by_goal.id_peserta1", "=", "peserta1.id_peserta")
                                               .Join("peserta AS peserta2", "score_by_goal.id_peserta1", "=", "peserta2.id_peserta")
                                               .Where("score_by_goal.id_scedule", "=", scheduleID);*/

            QueryBuilder builder = queryBuilder.Raw("SELECT score_by_goal.*, peserta1.id_peserta AS id1, peserta2.id_peserta AS id2, peserta1.nama_peserta AS nama1, peserta2.nama_peserta AS nama2 FROM score_by_goal INNER JOIN peserta peserta1 ON score_by_goal.id_peserta1 = peserta1.id_peserta INNER JOIN peserta peserta2 ON score_by_goal.id_peserta2 = peserta2.id_peserta WHERE score_by_goal.id_scedule = '" + scheduleID + "'");

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
            int number = 0;

            try {

                while (dataReader.Read()) {
                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["nama1"].ToString(),
                        "vs",
                        dataReader["nama2"].ToString(),
                        dataReader["waktu_pelaksanaan"].ToString(),
                        dataReader["score_by_goal_score"].ToString(),
                        dataReader["score_by_goal_venue"].ToString()
                    );

                    arrayList.Add(dataReader["id_score_by_goal"].ToString());
                }

                versusSchedulesID = new String[arrayList.Count];
                for (int i = 0; i < arrayList.Count; i++) {
                    versusSchedulesID[i] = arrayList[i].ToString();
                }

            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }

            dataReader.Close();
            database.CloseConnection();
        }

        private void VersusEvent_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void buttonTambahJadwalVersus_Click(object sender, EventArgs e) {
            VersusAddForm versusAddForm = new VersusAddForm();

            this.Opacity = 0.4;

            versusAddForm.SetEventID(eventID);
            versusAddForm.SetScheduleID(scheduleID);
            versusAddForm.ShowDialog(this);
            LoadData();

            this.Opacity = 1;
        }

        private void buttonEditJadwalPesertaVersus_Click(object sender, EventArgs e) {
            try {

                int rowCount = dataGridView.CurrentCell.RowIndex;
                String skor = dataGridView.Rows[rowCount].Cells[5].Value.ToString();
                String venue = dataGridView.Rows[rowCount].Cells[6].Value.ToString();

                EditVersusForm editVersusForm = new EditVersusForm();

                this.Opacity = 0.4;

                editVersusForm.SetEventID(eventID);
                editVersusForm.SetScheduleID(scheduleID);
                editVersusForm.SetScore(skor);
                editVersusForm.SetVenue(venue);
                editVersusForm.SetIndividualScheduleID(versusSchedulesID[rowCount]);
                editVersusForm.ShowDialog(this);
                LoadData();

                this.Opacity = 1;

            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonDeleteVersus_Click(object sender, EventArgs e) {
            try {

                /*if (dataGridView.SelectedRows.Count > 0) {*/
                //
                // BUG
                //
                String name1 = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
                String name2 = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();
                String id = versusSchedulesID[dataGridView.CurrentCell.RowIndex];

                DialogResult dialogResult = MessageBox.Show("Hapus " + name1 + " vs " + name2 + " - (" + id + ")", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    QueryBuilder builder = queryBuilder.DeleteFrom("score_by_goal")
                                                       .Where("id_score_by_goal", "=", id);

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

        private void InitializeVarible() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);

            arrayList = new ArrayList();

            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;
        }
    }
}
