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
    public partial class AddRoundForm : Form {

        private String eventID;

        private QueryBuilder queryBuilder;
        private Database database;

        public AddRoundForm() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void InitializeVariable() {
            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();

            comboBoxRoundType.Items.AddRange(new string[] { "Ronde", "Eliminasi" });
            if (comboBoxRoundType.Items.Count > 0) comboBoxRoundType.SelectedIndex = 0;
        }

        private void buttonAddRound_Click(object sender, EventArgs e) {
            if (textBoxRonde.TextLength < 1 || textBoxRonde.Text.Equals("")) {
                MessageBox.Show("Ronde tidak boleh kosong", "Error");
            } else if (textBoxRoundName.TextLength < 5 || textBoxRoundName.Text.Equals("")) {
                MessageBox.Show("Nama ronde tidak boleh kurang dari 5", "Error");
            } else if (comboBoxRoundType.SelectedIndex < 0) {
                MessageBox.Show("Tipe ronde harus diisi", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Insert("schedules", "id_event, rounds, eliminate, nama_round")
                                                   .Values(new string[][]{
                                                        new string[] {eventID, textBoxRonde.Text.ToString(), comboBoxRoundType.SelectedIndex.ToString(), textBoxRoundName.Text.ToString()}
                                                   });

                int rowsAffected = database.ExecuteNonQuery(builder.Get());
                if (rowsAffected > -1) {
                    MessageBox.Show("Tambah ronde berhasil", "Success");
                    Close();
                } else {
                    MessageBox.Show("Tambah ronde gagal", "Failed");
                }

            }
        }
    }
}
