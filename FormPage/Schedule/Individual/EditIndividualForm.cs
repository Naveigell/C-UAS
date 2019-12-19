using System;
using System.Windows.Forms;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Schedule.Individual {
    public partial class EditIndividualForm : Form {

        private String eventID, scheduleID, score, venue, individualScheduleID;
        private QueryBuilder queryBuilder;

        private Database database;

        private void EditIndividualForm_Load(object sender, EventArgs e) {
            if (eventID == null || scheduleID == null || score == null || venue == null || individualScheduleID == null) return;

            textBoxEventVenue.Text = venue;
            textBoxScore.Text = score;
        }

        public EditIndividualForm() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        private void buttonEditSchedule_Click(object sender, EventArgs e) {
            if (textBoxScore.Text.ToString().Equals("")) {
                MessageBox.Show("Skor tidak boleh kosong, jika belum memiliki skor, bisa di ganti dengan - (strip)", "Error");
            } else if (textBoxEventVenue.TextLength < 5) {
                MessageBox.Show("Panjang venue tidak boleh kurang dari 5", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Update("score_by_individual")
                                                   .Set(new string[][]{
                                                        new string[]{ "score_by_individual_score", textBoxScore.Text.ToString() },
                                                        new string[]{ "score_by_individual_venue", textBoxEventVenue.Text.ToString() }
                                                   })
                                                   .Where("id_score_by_individual", "=", individualScheduleID);

                int rowsAffected = database.ExecuteNonQuery(builder.Get());
                if (rowsAffected > 0) {
                    MessageBox.Show("Update berhasil", "Success");
                    Close();
                } else {
                    MessageBox.Show("Update gagal", "Error");
                }

            }
        }

        public void SetIndividualScheduleID(String individualScheduleID) {
            this.individualScheduleID = individualScheduleID;
        }

        public void SetScheduleID(String scheduleID) {
            this.scheduleID = scheduleID;
        }

        public void SetScore(String score) {
            this.score = score;
        }

        public void SetVenue(String venue) {
            this.venue = venue;
        }
    }
}
