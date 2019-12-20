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
using UAS.FormPage.Rangking;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage {
    public partial class Ranking : Form {

        private String eventID;
        private Database database;
        private QueryBuilder queryBuilder;
        private ArrayList arrayList;

        private String[] tempIDArray;

        public Ranking() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /*dataGridView.Columns[0].Width = 50;*/

            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();
            arrayList = new ArrayList();
        }

        public void SetEventID(String id) {
            eventID = id;
        }

        private void Ranking_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void LoadData() {
            dataGridView.Rows.Clear();
            arrayList.Clear();
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("ranking")
                                               .InnerJoin("event_olahraga", "ranking.id_event", "=", "event_olahraga.id_event")
                                               .InnerJoin("peserta", "ranking.id_peserta", "=", "peserta.id_peserta")
                                               .Where("event_olahraga.id_event", "=", eventID);

            try {

                SqlDataReader dataReader = database.ExecuteQuery(builder.Get());

                while (dataReader.Read()) {

                    arrayList.Add(dataReader["id_ranking"].ToString());

                    dataGridView.Rows.Add(
                        dataReader["ranking_index"].ToString(),
                        dataReader["nama_event"].ToString(),
                        dataReader["nama_peserta"].ToString(),
                        dataReader["skor"].ToString()
                    );
                }

                tempIDArray = new String[arrayList.Count];

                for (int i = 0; i < arrayList.Count; i++) {
                    tempIDArray[i] = arrayList[i].ToString();
                }

                dataReader.Close();
                database.CloseConnection();

            } catch (Exception exception) {
                Console.WriteLine("Error : " + exception.Message);
            }
        }

        private void buttonTambahRanking_Click(object sender, EventArgs e) {
            try {

                AddRankForm addRankForm = new AddRankForm();
                this.Opacity = 0.4;

                addRankForm.SetEventID(eventID);
                addRankForm.ShowDialog(this);
                LoadData();

                this.Opacity = 1;

            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonEditRangking_Click(object sender, EventArgs e) {
            try {

                int rowCount = dataGridView.CurrentCell.RowIndex;
                String rank = dataGridView.Rows[rowCount].Cells[0].Value.ToString();
                String score = dataGridView.Rows[rowCount].Cells[3].Value.ToString();

                EditRankingForm editRankingForm = new EditRankingForm();
                this.Opacity = 0.4;

                editRankingForm.SetEventID(eventID);
                editRankingForm.SetRank(rank);
                editRankingForm.SetRankID(tempIDArray[rowCount]);
                editRankingForm.SetScore(score);
                editRankingForm.ShowDialog(this);
                LoadData();

                this.Opacity = 1;

            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonDeleteRangking_Click(object sender, EventArgs e) {
            try {

                /*if (dataGridView.SelectedRows.Count > 0) {*/
                //
                // BUG
                //
                String participantName = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString();
                String id = tempIDArray[dataGridView.CurrentCell.RowIndex];

                DialogResult dialogResult = MessageBox.Show("Hapus " + participantName + "- (" + id + ")", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    QueryBuilder builder = queryBuilder.DeleteFrom("ranking")
                                                       .Where("id_ranking", "=", id);

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
