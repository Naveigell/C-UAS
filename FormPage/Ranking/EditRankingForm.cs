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

namespace UAS.FormPage.Rangking {
    public partial class EditRankingForm : Form {

        private String eventID, rank, score, rank_id;

        private QueryBuilder queryBuilder;
        private Database database;

        public EditRankingForm() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void SetRank(String rank) {
            this.rank = rank;
        }

        public void SetScore(String score) {
            this.score = score;
        }

        private void buttonEditRank_Click(object sender, EventArgs e) {
            if (textBoxRanking.Text.ToString().Equals("")) {
                MessageBox.Show("Ranking tidak boleh kosong", "Error");
            } else if (textBoxTotalScore.Text.ToString().Equals("")) {
                MessageBox.Show("Total skor tidak boleh kosong", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Update("ranking")
                                                   .Set(new string[][]{
                                                        new string[]{ "ranking_index", textBoxRanking.Text.ToString() },
                                                        new string[]{ "skor", textBoxTotalScore.Text.ToString() }
                                                   })
                                                   .Where("id_ranking", "=", rank_id);

                int rowsAffected = database.ExecuteNonQuery(builder.Get());
                if (rowsAffected > 0) {
                    MessageBox.Show("Edit berhasil", "Success");
                    Close();
                } else {
                    MessageBox.Show("edit gagal", "Error");
                }

            }
        }

        public void SetRankID(String id) {
            rank_id = id;
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);
        }

        private void EditRankingForm_Load(object sender, EventArgs e) {
            if (eventID == null || rank == null || score == null) return;

            textBoxRanking.Text = rank;
            textBoxTotalScore.Text = score;
        }
    }
}
