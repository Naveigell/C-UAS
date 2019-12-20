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

namespace UAS.FormPage.Participant.SubParticipant {
    public partial class AddSubParticipantForm : Form {

        private String eventID, participantID;
        private QueryBuilder queryBuilder;
        private Database database;

        public AddSubParticipantForm() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void SetParticipantID(String participantID) {
            this.participantID = participantID;
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);

            comboBoxGender.Items.AddRange(new string[] { "Male", "Female" });
            if (comboBoxGender.Items.Count > 0) comboBoxGender.SelectedIndex = 0;
        }

        private void buttonAddSubParticipant_Click(object sender, EventArgs e) {

            if (textBoxParticipantName.TextLength < 5) {
                MessageBox.Show("Panjang nama peserta tidak boleh kurang dari 5", "Error");
            } else if (textBoxParticipantAddress.TextLength < 5) {
                MessageBox.Show("Panjang alamat tidak boleh kurang dari 5", "Error");
            } else if (comboBoxGender.SelectedIndex < 0) {
                MessageBox.Show("Jenis kelamin harus dipilih", "Error");
            } else {

                QueryBuilder builder = queryBuilder.Raw("SELECT TOP 1 *, CONVERT (int, SUBSTRING(id_field_peserta, 7, LEN(id_field_peserta))) AS SortingID FROM (SELECT * FROM field_peserta WHERE id_field_peserta LIKE '%" + participantID.Split(new char[] { '_' })[0] + "%') AS a ORDER BY SortingID DESC ");
                
                SqlDataReader dataReader = database.ExecuteQuery(builder.Get());
                int number = 0;

                try {
                    String id_field_peserta = "";
                    int lastID = 0;

                    while (dataReader.Read()) {
                        ++number;
                        id_field_peserta = dataReader["id_field_peserta"].ToString();
                        lastID = int.Parse(dataReader["SortingID"].ToString());
                    }

                    dataReader.Close();

                    if (number > 0) {

                        String id = participantID.Split(new char[] { '_' })[0] + "F_" + (++lastID);

                        builder = queryBuilder.Insert("field_peserta", "id_field_peserta, id_peserta, nama_peserta, alamat_peserta, tanggal_lahir, field_peserta_gender")
                                              .Values(new string[][] {
                                                  new string[]{ id, participantID, textBoxParticipantName.Text.ToString(), textBoxParticipantAddress.Text.ToString(), dateTimePickerBirthday.Value.ToString("yyyy-MM-dd"), comboBoxGender.SelectedItem.ToString() }
                                              });

                        int rowsAffected = database.ExecuteNonQuery(builder.Get());
                        if (rowsAffected > 0) {
                            MessageBox.Show("Tambah peserta berhasil", "Success");
                            Close();
                        } else {
                            MessageBox.Show("Tambah peserta gagal", "Error");
                        }


                    } else {
                        String id = participantID.Split(new char[] { '_' })[0] + "F_1";

                        builder = queryBuilder.Insert("field_peserta", "id_field_peserta, id_peserta, nama_peserta, alamat_peserta, tanggal_lahir, field_peserta_gender")
                                              .Values(new string[][] {
                                                  new string[]{ id, participantID, textBoxParticipantName.Text.ToString(), textBoxParticipantAddress.Text.ToString(), dateTimePickerBirthday.Value.ToString("yyyy-MM-dd"), comboBoxGender.SelectedItem.ToString() }
                                              });

                        int rowsAffected = database.ExecuteNonQuery(builder.Get());
                        if (rowsAffected > 0) {
                            MessageBox.Show("Tambah peserta berhasil", "Success");
                            Close();
                        } else {
                            MessageBox.Show("Tambah peserta gagal", "Error");
                        }
                    }

                } catch(Exception exception) {
                    Console.WriteLine(exception.Message);
                }

            }

        }

        private void AddSubParticipantForm_Load(object sender, EventArgs e) {

        }
    }
}
