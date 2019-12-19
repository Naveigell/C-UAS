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

namespace UAS.FormPage.Schedule.Individual {
    public partial class IndividualAddForm : Form {

        private String eventID, scheduleID;
        private String[] participansID;

        private QueryBuilder queryBuilder;
        private Database database;

        public IndividualAddForm() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);

            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.CustomFormat = "MM - dd - yyyy             HH:mm";
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        private void IndividualAddForm_Load(object sender, EventArgs e) {
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("peserta")
                                               .Where("id_event", "=", eventID);

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());

            ArrayList arrayList = new ArrayList();

            try {

                while (dataReader.Read()) {
                    comboBoxParticipantName.Items.Add(
                        dataReader["nama_peserta"].ToString()
                    );
                    arrayList.Add(dataReader["id_peserta"].ToString());
                }
                participansID = new String[arrayList.Count];

                for (int i = 0; i < arrayList.Count; i++) {
                    participansID[i] = arrayList[i].ToString();
                }

            } catch (Exception exception) {
                Console.WriteLine(exception);
            }

            dataReader.Close();
            database.CloseConnection();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e) {
            if (comboBoxParticipantName.SelectedIndex < 0) {
                MessageBox.Show("Nama peserta harus dipilih", "Error");
            } else if (textBoxEventVenue.TextLength < 5) {
                MessageBox.Show("Venue tidak boleh kurang dari 5", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Insert("score_by_individual", "id_scedule, id_peserta1, waktu_pelaksanaan, score_by_individual_score, score_by_individual_venue")
                                                   .Values(new String[][] { 
                                                        new String[] { scheduleID, participansID[comboBoxParticipantName.SelectedIndex], dateTimePickerStartDate.Value.ToString("yyyy-MM-dd HH:mm"), textBoxScore.Text.ToString(), textBoxEventVenue.Text.ToString() }
                                                   });

                int rowsAffected = database.ExecuteNonQuery(builder.Get());
                if (rowsAffected > 0) {
                    MessageBox.Show("Tambah berhasil", "Success");
                    Close();
                } else {
                    MessageBox.Show("Tambah gagal", "Success");
                }

            }
        }

        public void SetScheduleID(String scheduleID) {
            this.scheduleID = scheduleID;
        }
    }
}
