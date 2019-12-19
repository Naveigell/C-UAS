using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using UAS.FormPage.Participant;
using UAS.FormPage.Schedule;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage {
    public partial class EventParticipant : Form {

        private String eventID;
        private Database database;
        private QueryBuilder queryBuilder;
        private ArrayList arrayList;

        private String[] tempIDArray;

        public EventParticipant() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;

            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();
            arrayList = new ArrayList();
        }

        public void SetEventID(String id) {
            eventID = id;
        }

        private void LoadData() {
            dataGridView.Rows.Clear();
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("peserta")
                                               .Where("id_event", "=", eventID);

            try {

                SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
                int number = 0;

                while (dataReader.Read()) {

                    arrayList.Add(dataReader["id_peserta"].ToString());

                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["nama_peserta"].ToString(),
                        dataReader["nomor_telepon_peserta"].ToString(),
                        dataReader["tipe_peserta"].ToString(),
                        dataReader["gender"].ToString()
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

        private void EventParticipant_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void buttonTambahPeserta_Click(object sender, EventArgs e) {
            AddEventParticipantForm addParticipant = new AddEventParticipantForm();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // passing id event ke form berikutnya
            addParticipant.SetEventID(eventID);
            addParticipant.ShowDialog(this);
            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonEditParticipant_Click(object sender, EventArgs e) {

            int rowCount = dataGridView.CurrentCell.RowIndex;
            String participantName = dataGridView.Rows[rowCount].Cells[1].Value.ToString();
            String participantCellulerPhone = dataGridView.Rows[rowCount].Cells[2].Value.ToString();

            EditParticipantForm editParticipant = new EditParticipantForm();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // passing value ke form berikutnya
            editParticipant.SetEventID(eventID);
            editParticipant.SetParticipantID(tempIDArray[rowCount]);
            editParticipant.SetParticipantName(participantName);
            editParticipant.SetParticipantCellulerPhone(participantCellulerPhone);
            editParticipant.ShowDialog(this);
            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonLihatJadwal_Click(object sender, EventArgs e) {
            RoundForm scheduleForm = new RoundForm();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // passing value ke form berikutnya
            scheduleForm.SetEventID(eventID);
            scheduleForm.ShowDialog(this);
            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonDeleteParticipant_Click(object sender, EventArgs e) {
            try {

                /*if (dataGridView.SelectedRows.Count > 0) {*/
                //
                // BUG
                //
                String name = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
                String id = tempIDArray[dataGridView.CurrentCell.RowIndex];

                DialogResult dialogResult = MessageBox.Show("Hapus " + name + "- (" + id + ")", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    QueryBuilder builder = queryBuilder.DeleteFrom("peserta")
                                                       .Where("id_peserta", "=", id);

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
