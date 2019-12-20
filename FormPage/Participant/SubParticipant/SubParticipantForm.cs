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
using UAS.Scripts.Helper;
using UAS.Scripts.Model;

namespace UAS.FormPage.Participant.SubParticipant {
    public partial class SubParticipantForm : Form {

        private String eventID, participantID;
        private QueryBuilder queryBuilder;
        private String[] fieldsID;
        private ArrayList arrayList;
        private Database database;

        public SubParticipantForm() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void SetParticipantID(String participantID) {
            this.participantID = participantID;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void SubParticipantForm_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void LoadData() {
            dataGridView.Rows.Clear();
            arrayList.Clear();
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("field_peserta")
                                               .Where("id_peserta", "=", participantID);

            SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
            int number = 0;

            try {

                while (dataReader.Read()) {
                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["nama_peserta"].ToString(),
                        dataReader["alamat_peserta"].ToString(),
                        Convert.ToDateTime(dataReader["tanggal_lahir"].ToString()).ToString("dd - MM - yyyy"),
                        dataReader["field_peserta_gender"].ToString()
                    );

                    arrayList.Add(dataReader["id_field_peserta"].ToString());
                }

                fieldsID = new string[arrayList.Count];
                for (int i = 0; i < fieldsID.Length; i++) {
                    fieldsID[i] = arrayList[i].ToString();
                }

            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }

            dataReader.Close();
            database.CloseConnection();
        }

        private void buttonTambahPeserta_Click(object sender, EventArgs e) {
            AddSubParticipantForm addSubParticipantForm = new AddSubParticipantForm();

            this.Opacity = 0.4;

            addSubParticipantForm.SetEventID(eventID);
            addSubParticipantForm.SetParticipantID(participantID);
            addSubParticipantForm.ShowDialog(this);
            LoadData();

            this.Opacity = 1;
        }

        private void buttonEditParticipant_Click(object sender, EventArgs e) {
            try {

                int row = dataGridView.CurrentCell.RowIndex;


            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonDeleteParticipant_Click(object sender, EventArgs e) {
            try {

                int row = dataGridView.CurrentCell.RowIndex;
                String name = dataGridView.Rows[row].Cells[1].Value.ToString();
                String id = fieldsID[row];

                DialogResult dialogResult = MessageBox.Show("Hapus " + name + "- (" + id + ")", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    QueryBuilder builder = queryBuilder.DeleteFrom("field_peserta")
                                                       .Where("id_field_peserta", "=", id);

                    int rowsAffected = database.ExecuteNonQuery(builder.Get());
                    if (rowsAffected > 0) {
                        MessageBox.Show("Hapus berhasil", "Success");
                        LoadData();
                    } else {
                        MessageBox.Show("Hapus gagal", "Error");
                    }

                }

            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e) {
            Converter converter = new Converter();
            converter.SetDataGridView(dataGridView);
            converter.ShowDialog(this);
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);

            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;

            arrayList = new ArrayList();
        }
    }
}
