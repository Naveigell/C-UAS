using System;
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

namespace UAS.FormPage.Participant {
    public partial class AddEventParticipantForm : Form {

        private Database database;
        private QueryBuilder queryBuilder;

        private String eventID;

        public AddEventParticipantForm() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        private void InitializeVariable() {
            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();

            comboBoxParticipantType.Items.AddRange(new string[] { "Perorangan", "Kelompok" });
            if (comboBoxParticipantType.Items.Count > 0) comboBoxParticipantType.SelectedIndex = 0;

            comboBoxParticipantGender.Items.AddRange(new string[] { "Man", "Woman" });
            if (comboBoxParticipantGender.Items.Count > 0) comboBoxParticipantGender.SelectedIndex = 0;
        }

        private void buttonAddParticipant_Click(object sender, EventArgs e) {

            if (textBoxParticipantName.TextLength < 3) {
                MessageBox.Show("Nama peserta tidak boleh kurang dari 3", "Error");
            } else if (textBoxNoTelp.TextLength < 9) {
                MessageBox.Show("No telp tidak boleh kurang dari 9", "Error");
            } else if (comboBoxParticipantType.SelectedIndex < 0) {
                MessageBox.Show("Tipe peserta harus dipilih", "Error");
            } else if (comboBoxParticipantGender.SelectedIndex < 0) {
                MessageBox.Show("Jenis kelamin peserta harus dipilih", "Error");
            } else {

                // ambil yang pertama  // pisahkan antara angka dan huruf (substring)                       // lalu ambil semua data dengan id event = ''                   // lalu order by angka yang di substring
                QueryBuilder builder = queryBuilder.Raw("SELECT TOP 1 *, CONVERT (int, SUBSTRING(id_peserta, 6, LEN(id_peserta))) AS SortingID FROM (SELECT * FROM peserta WHERE id_event = '" + eventID + "') AS a ORDER BY SortingID DESC");

                SqlDataReader dataReader = database.ExecuteQuery(builder.Get());

                try {
                    String lastParticipantID = "";
                    String[] strArr;
                    int index = 0;
                    String participantID = eventID.Replace("0", "") + "_1";

                    while (dataReader.Read()) {
                        index++;
                        lastParticipantID = dataReader["id_peserta"].ToString();
                    }

                    dataReader.Close();

                    // cek apakah ada peserta
                    if (index > 0) {

                        // split underscore
                        strArr = lastParticipantID.Split(new char[] { '_' });
                        int tempID = int.Parse(strArr[1]);

                        participantID = strArr[0] + "_" + ++tempID;
                    }

                    builder = queryBuilder.Insert("peserta", "id_peserta, id_event, nama_peserta, nomor_telepon_peserta, tipe_peserta, gender")
                                          .Values(new string[][] { 
                                                new string[] {participantID, eventID, textBoxParticipantName.Text.ToString(), textBoxNoTelp.Text.ToString(), comboBoxParticipantType.SelectedItem.ToString(), comboBoxParticipantGender.SelectedItem.ToString() }
                                          });

                    int rowsAffected = database.ExecuteNonQuery(builder.Get());

                    if (rowsAffected > -1) {
                        MessageBox.Show("Tambah peserta berhasil", "Success");
                        Close();
                    } else {
                        MessageBox.Show("Tambah peserta gagal", "Error");
                    }

                } catch (Exception exception) {
                    Console.WriteLine(exception.Message);
                }

                database.CloseConnection();
            }
        }
    }
}
