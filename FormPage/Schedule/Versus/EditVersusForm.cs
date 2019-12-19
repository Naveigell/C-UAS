using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Schedule.Versus {
    public partial class EditVersusForm : Form {

        private String eventID, scheduleID, score, venue, individualScheduleID;
        private QueryBuilder queryBuilder;

        private Database database;

        public EditVersusForm() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);
        }

        private void EditVersusForm_Load(object sender, EventArgs e) {
            if (eventID == null || scheduleID == null || score == null || venue == null || individualScheduleID == null) return;

            textBoxEventVenue.Text = venue;
            textBoxScore.Text = score;
        }

        public void SetIndividualScheduleID(String individualScheduleID) {
            this.individualScheduleID = individualScheduleID;
        }

        private void buttonEditSchedule_Click(object sender, EventArgs e) {
            if (textBoxScore.Text.ToString().Equals("")) {
                MessageBox.Show("Skor tidak boleh kosong, jika belum memiliki skor, bisa di ganti dengan - (strip)", "Error");
            } else if (textBoxEventVenue.TextLength < 5) {
                MessageBox.Show("Panjang venue tidak boleh kurang dari 5", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Update("score_by_goal")
                                                   .Set(new string[][]{
                                                        new string[]{ "score_by_goal_score", textBoxScore.Text.ToString() },
                                                        new string[]{ "score_by_goal_venue", textBoxEventVenue.Text.ToString() }
                                                   })
                                                   .Where("id_score_by_goal", "=", individualScheduleID);

                int rowsAffected = database.ExecuteNonQuery(builder.Get());
                if (rowsAffected > 0) {
                    MessageBox.Show("Update berhasil", "Success");
                    Close();
                } else {
                    MessageBox.Show("Update gagal", "Error");
                }

            }
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
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
