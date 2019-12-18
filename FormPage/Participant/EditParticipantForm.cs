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

namespace UAS.FormPage.Participant {
    public partial class EditParticipantForm : Form {

        private String eventID, participantName, participantCellulerPhone, participantID;
        private QueryBuilder queryBuilder;
        private Database database;

        public EditParticipantForm() {
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

        public void SetParticipantName(String participantName) {
            this.participantName = participantName;
        }

        public void SetParticipantID(String participantID) {
            this.participantID = participantID;
        }

        private void EditParticipantForm_Load(object sender, EventArgs e) {
            if (eventID != null && participantName != null && participantCellulerPhone != null) {
                textBoxParticipantName.Text = participantName;
                textBoxNoTelp.Text = participantCellulerPhone;
            }
        }

        public void SetParticipantCellulerPhone(String participantCellulerPhone) {
            this.participantCellulerPhone = participantCellulerPhone;
        }

        private void buttonEditParticipant_Click(object sender, EventArgs e) {
            if (textBoxParticipantName.TextLength < 3) {
                MessageBox.Show("Nama tidak boleh kurang dari 3", "Error");
            } else if (textBoxNoTelp.TextLength < 9) {
                MessageBox.Show("No telp tidak boleh kurang dari 9", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Update("peserta")
                                                   .Set(new string[][] {
                                                       new string[] {"nama_peserta", textBoxParticipantName.Text.ToString()},
                                                       new string[] {"nomor_telepon_peserta", textBoxNoTelp.Text.ToString()}
                                                   })
                                                   .Where("id_peserta", "=", participantID);

                int rowsAffected = database.ExecuteNonQuery(builder.Get());

                if (rowsAffected > 0) {
                    MessageBox.Show("Edit berhasil", "Success");
                    Close();
                } else {
                    MessageBox.Show("Edit gagal", "Error");
                }

            }
        }
    }
}
