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

namespace UAS.FormPage.Rangking {
    public partial class AddRankForm : Form {

        private String eventID;
        private String[] participantsID;

        private QueryBuilder queryBuilder;
        private SqlDataReader dataReader;
        private Database database;

        public AddRankForm() {
            InitializeComponent();
            InitializeVariables();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        private void InitializeVariables() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);
            
        }

        private void AddRankForm_Load(object sender, EventArgs e) {

            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("peserta")
                                               .InnerJoin("event_olahraga", "peserta.id_event", "=", "event_olahraga.id_event")
                                               .Where("peserta.id_event", "=", eventID);

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());

            ArrayList arrayList = new ArrayList();

            try {

                while (dataReader.Read()) {
                    comboBoxParticipantName.Items.Add(
                        dataReader["nama_peserta"].ToString()
                    );
                    arrayList.Add(dataReader["id_peserta"].ToString());
                }
                participantsID = new String[arrayList.Count];

                for (int i = 0; i < arrayList.Count; i++) {
                    participantsID[i] = arrayList[i].ToString();
                }

            } catch (Exception exception) {
                Console.WriteLine(exception);
            }

            dataReader.Close();
            database.CloseConnection();
        }

        private void buttonAddRank_Click(object sender, EventArgs e) {
            if (textBoxRanking.Text.ToString().Equals("")) {
                MessageBox.Show("Ranking tidak boleh kosong", "Error");
            } else if (comboBoxParticipantName.SelectedIndex < 0) {
                MessageBox.Show("Nama peserta harus dipilih", "Error");
            } else if (textBoxTotalScore.Text.ToString().Equals("")) {
                MessageBox.Show("Total skor tidak boleh kosong", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Insert("ranking", "ranking_index, id_event, id_peserta, skor")
                                                   .Values(new String[][] {
                                                        new String[] { textBoxRanking.Text.ToString(), eventID, participantsID[comboBoxParticipantName.SelectedIndex].ToString(), textBoxTotalScore.Text.ToString() }
                                                   });

                int rowsAffected = database.ExecuteNonQuery(builder.Get());
                if (rowsAffected > 0) {
                    MessageBox.Show("Tambah berhasil", "Success");
                    Close();
                } else {
                    MessageBox.Show("Tambah gagal", "Error");
                }

            }
        }
    }
}
