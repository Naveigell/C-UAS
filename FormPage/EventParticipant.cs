using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage {
    public partial class EventParticipant : Form {

        private String eventID;
        private Database database;
        private QueryBuilder queryBuilder;

        public EventParticipant() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;

            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();
        }

        public void SetEventID(String id) {
            eventID = id;
        }

        private void EventParticipant_Load(object sender, EventArgs e) {
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("peserta")
                                               .Where("id_event", "=", eventID);

            try {

                SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
                int number = 0;

                while (dataReader.Read()) {

                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["nama_peserta"].ToString(),
                        dataReader["nomor_telepon_peserta"].ToString(),
                        dataReader["tipe_peserta"].ToString(),
                        dataReader["gender"].ToString()
                    );
                }

                dataReader.Close();
                database.CloseConnection();

            } catch (Exception exception) {
                Console.WriteLine("Error : " + exception.Message);
            }

        }
    }
}
