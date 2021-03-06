﻿using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using UAS.FormPage.Participant;
using UAS.FormPage.Participant.SubParticipant;
using UAS.FormPage.Schedule;
using UAS.Scripts;
using UAS.Scripts.Helper;
using UAS.Scripts.Model;

namespace UAS.FormPage {
    public partial class EventParticipant : Form {

        private String eventID;
        private Database database;
        private QueryBuilder queryBuilder;
        private ArrayList arrayList;

        private String[] tempIDArray;

        public EventParticipant() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;

            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();
            arrayList = new ArrayList();

            buttonDeleteParticipant.Visible = Session.LOGIN_MODE == Auth.TYPE_ADMIN;
            buttonEditParticipant.Visible = Session.LOGIN_MODE == Auth.TYPE_ADMIN;
            buttonTambahPeserta.Visible = Session.LOGIN_MODE == Auth.TYPE_ADMIN;
        }

        public void SetEventID(String id) {
            eventID = id;
        }

        private void LoadData() {
            dataGridView.Rows.Clear();
            arrayList.Clear();
            QueryBuilder builder = queryBuilder.Select("peserta.id_peserta, peserta.id_event, peserta.nama_peserta, peserta.nomor_telepon_peserta, peserta.tipe_peserta, peserta.gender, COUNT(field_peserta.id_peserta) AS jumlah_member")
                                               .From("peserta")
                                               .LeftJoin("field_peserta", "field_peserta.id_peserta", "=", "peserta.id_peserta")
                                               .Where("peserta.id_event", "=", eventID)
                                               .GroupBy("peserta.id_peserta, peserta.id_event, peserta.nama_peserta, peserta.nomor_telepon_peserta, peserta.tipe_peserta, peserta.gender")
                                               .OrderBy("peserta.id_peserta", QueryBuilder.ORDER_ASCENDING);
            String d = builder.Get();
            Console.WriteLine(d);

            try {

                SqlDataReader dataReader = database.ExecuteQuery(d);
                int number = 0;

                while (dataReader.Read()) {

                    arrayList.Add(dataReader["id_peserta"].ToString());

                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["nama_peserta"].ToString(),
                        dataReader["nomor_telepon_peserta"].ToString(),
                        dataReader["tipe_peserta"].ToString(),
                        dataReader["tipe_peserta"].ToString().Equals("Kelompok") ? dataReader["jumlah_member"].ToString() : "-",
                        dataReader["gender"].ToString()
                    );
                }

                tempIDArray = new String[arrayList.Count];

                for (int i = 0; i < arrayList.Count; i++) {
                    tempIDArray[i] = arrayList[i].ToString();
                }

                dataReader.Close();
                database.CloseConnection();

            } catch (Exception exception) {
                Console.WriteLine("Error : " + exception.Message);
            }

        }

        private void EventParticipant_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void buttonTambahPeserta_Click(object sender, EventArgs e) {
            AddEventParticipantForm addParticipant = new AddEventParticipantForm();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // passing id event ke form berikutnya
            addParticipant.SetEventID(eventID);
            addParticipant.ShowDialog(this);
            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonEditParticipant_Click(object sender, EventArgs e) {

            int rowCount = dataGridView.CurrentCell.RowIndex;
            String participantName = dataGridView.Rows[rowCount].Cells[1].Value.ToString();
            String participantCellulerPhone = dataGridView.Rows[rowCount].Cells[2].Value.ToString();

            EditParticipantForm editParticipant = new EditParticipantForm();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // passing value ke form berikutnya
            editParticipant.SetEventID(eventID);
            editParticipant.SetParticipantID(tempIDArray[rowCount]);
            editParticipant.SetParticipantName(participantName);
            editParticipant.SetParticipantCellulerPhone(participantCellulerPhone);
            editParticipant.ShowDialog(this);
            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonLihatJadwal_Click(object sender, EventArgs e) {
            RoundForm scheduleForm = new RoundForm();

            this.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            // passing value ke form berikutnya
            scheduleForm.SetEventID(eventID);
            scheduleForm.ShowDialog(this);
            LoadData();

            this.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonDeleteParticipant_Click(object sender, EventArgs e) {
            try {

                /*if (dataGridView.SelectedRows.Count > 0) {*/
                //
                // BUG
                //
                int row = dataGridView.CurrentCell.RowIndex;
                String name = dataGridView.Rows[row].Cells[1].Value.ToString();
                String id = tempIDArray[row];

                DialogResult dialogResult = MessageBox.Show("Hapus " + name + "- (" + id + ")", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    QueryBuilder builder = queryBuilder.DeleteFrom("peserta")
                                                       .Where("id_peserta", "=", id);

                    int rowsAffected = database.ExecuteNonQuery(builder.Get());
                    if (rowsAffected > 0) {
                        MessageBox.Show("Hapus berhasil", "Success");
                        LoadData();
                    } else {
                        MessageBox.Show("Hapus gagal", "Error");
                    }

                }

                /*} else {
                    Console.WriteLine("No rows selected");
                }*/

            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonLihatAnggota_Click(object sender, EventArgs e) {
            try {

                String tipe = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();

                if (!tipe.ToLower().Equals("kelompok")) return;

                SubParticipantForm subParticipantForm = new SubParticipantForm();

                this.Opacity = 0.4;

                subParticipantForm.SetEventID(eventID);
                subParticipantForm.SetParticipantID(tempIDArray[dataGridView.CurrentCell.RowIndex]);
                subParticipantForm.ShowDialog(this);
                LoadData();

                this.Opacity = 1;

            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e) {
            Converter converter = new Converter();
            converter.SetDataGridView(dataGridView);
            converter.ShowDialog(this);
        }
    }
}
