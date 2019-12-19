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

namespace UAS.FormPage.Schedule {
    public partial class EditRoundForm : Form {

        private String eventID, scheduleID, round, roundName;
        private QueryBuilder queryBuilder;
        private Database database;

        public EditRoundForm() {
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

        private void buttonEditRound_Click(object sender, EventArgs e) {
            if (textBoxRound.Text.ToString().Equals("")) {
                MessageBox.Show("Ronde tidak boleh kosong", "Error");
            } else if (textBoxRoundName.TextLength < 5) {
                MessageBox.Show("Nama ronde tidak boleh kurang dari 3", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Update("schedules")
                                                   .Set(new string[][] {
                                                       new string[]{"rounds", textBoxRound.Text.ToString() },
                                                       new string[]{"nama_round", textBoxRoundName.Text.ToString() }
                                                   })
                                                   .Where("id_schedule", "=", scheduleID);

                int rowsAffected = database.ExecuteNonQuery(builder.Get());
                if (rowsAffected > 0) {
                    MessageBox.Show("Ronde berhasil di edit", "Success");
                    Close();
                } else {
                    MessageBox.Show("Ronde gagal di edit", "Error");
                }
            }
        }

        private void EditRoundForm_Load(object sender, EventArgs e) {
            if (eventID == null || scheduleID == null || round == null || roundName == null) return;

            textBoxRound.Text = round;
            textBoxRoundName.Text = roundName;
        }

        public void SetSceduleID(String scheduleID) {
            this.scheduleID = scheduleID;
        }

        public void SetRound(String round) {
            this.round = round;
        }

        public void SetRoundName(String roundName) {
            this.roundName = roundName;
        }
    }
}
