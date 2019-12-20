using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.Scripts;
using UAS.Scripts.Model;
using System.Data.SqlClient;
using UAS.FormPage;
using System.Collections;
using UAS.Scripts.Helper;

namespace UAS.Page {
    public partial class EventPageShowPageDetails : UserControl {

        private Database database;
        private QueryBuilder queryBuilder;
        private SqlDataReader dataReader;

        private ArrayList IDEventStore;

        private int page = 0;
        private int totalPage = 0;
        private int dataPerPage = 10;

        public EventPageShowPageDetails() {
            InitializeComponent();
            InitializeVariables();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void LoadEventData(int offset, int limit) {

            // clear rows dari data gridview
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
                
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("event_olahraga")
                                               .OrderBy("id_event", QueryBuilder.ORDER_ASCENDING)
                                               // sebelum limit harus menggunakan order by
                                               .Limit(offset, limit);

            try {

                dataReader = database.ExecuteQuery(builder.Get());
                int number = offset;

                while (dataReader.Read()) {

                    string status = "Sedang Berlangsung";

                    // jadikan tanggal mulai dan selesai ke datetime
                    DateTime dateTimeSelesai = Convert.ToDateTime(dataReader["tanggal_event_selesai"].ToString());
                    DateTime dateTimeMulai = Convert.ToDateTime(dataReader["tanggal_pelaksanaan_event"].ToString());

                    // jika waktu sekarang lebih dari waktu tanggal berakhir
                    if (DateTime.Now.Date > dateTimeSelesai.Date) {
                        status = "Sudah Selesai";
                    } else if (DateTime.Now.Date < dateTimeMulai.Date) { // jika waktu sekarang kuran dari waktu tanggal mulai
                        status = "Belum Dimulai";
                    }

                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["id_event"].ToString(),
                        dataReader["nama_event"].ToString(),
                        dateTimeMulai.ToString("dd - MM - yyyy"),
                        dateTimeSelesai.ToString("dd - MM - yyyy"),
                        dataReader["tipe_event"].ToString().First().ToString().ToUpper() + dataReader["tipe_event"].ToString().Substring(1),
                        dataReader["event_gender"].ToString(),
                        dataReader["deskripsi"].ToString(),
                        status
                    );

                }

                dataReader.Close();

                database.CloseConnection();

            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        private void LoadEventPage() {

            QueryBuilder builder = queryBuilder.Raw("SELECT COUNT(*) AS counts FROM event_olahraga");

            dataReader = database.ExecuteQuery(builder.Get());
            int total = 0;

            while (dataReader.Read()) {
                total = int.Parse(dataReader["counts"].ToString());
            }
            dataReader.Close();
            database.CloseConnection();

            // ambil total data event lalu jumlahnya di bagi
            totalPage = total / dataPerPage;
            // cek jika modulus data event lebih dari 0, maka ada page tambahan
            totalPage = total % dataPerPage > 0 ? ++totalPage : totalPage;

            // insert page tambahan ke dalam combo box page
            comboBoxPage.Items.Clear();
            for (int i = 1; i <= totalPage; i++) {
                comboBoxPage.Items.Add("Page " + i);
            }
            // untuk default buat combobox select index ke 0
            comboBoxPage.SelectedIndex = 0;
        }

        private void EventPageShowPageDetails_Load(object sender, EventArgs e) {
            int to = (page + 1) * dataPerPage;
            int from = to - dataPerPage;
            LoadEventData(from, to);
        }

        protected void InitializeVariables() {
            String dbSources = Properties.Settings.Default.dbSources;
            database = new Database(dbSources);
            queryBuilder = new QueryBuilder();

            // membuat cell datagrid menjadi center
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ReadOnly = true;

            // add page ke dalam combobox pagination
            comboBoxPage.Items.AddRange(new String[] { "Page 1", "Page 2" });
            // jika combobox item lebih dari 0, maka set combo box index menjadi yang pertama
            if (comboBoxPage.Items.Count > 0) comboBoxPage.SelectedIndex = 0;
            page = comboBoxPage.SelectedIndex;

            // menambah event baru ke dalam datagridview
            dataGridView.LostFocus += DataGridViewOnLostFocus;
            dataGridView.Columns[0].Width = 50;

            LoadEventPage();
        }

        private void DataGridViewOnLostFocus(object sender, EventArgs e) {
            dataGridView.ClearSelection();
        }

        private void dataGridView_CellLeave(object sender, DataGridViewCellEventArgs e) {

        }

        private void buttonTambahEvent_Click(object sender, EventArgs e) {
            AddEventForm addEventForm = new AddEventForm();

            // mengambil parent form
            Form form = (this.Parent.Parent as Form);
            form.Opacity = 0.4; // membuat parent form opacity menjadi 0.4
            addEventForm.ShowDialog(this);
            LoadEventPage();
            form.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonLihatPeserta_Click(object sender, EventArgs e) {

            try {

                // ambil id event dari datagridview
                int rowCount = dataGridView.CurrentCell.RowIndex;
                String cellValue = dataGridView.Rows[rowCount].Cells[1].Value.ToString();

                EventParticipant eventParticipant = new EventParticipant();

                // mengambil parent form
                Form form = (this.Parent.Parent as Form);
                form.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

                // passing id event ke form berikutnya
                eventParticipant.SetEventID(cellValue);
                eventParticipant.ShowDialog(this);

                form.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose


            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }

        }

        private void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e) {
            page = comboBoxPage.SelectedIndex;

            int to = (page + 1) * dataPerPage;
            int from = to - dataPerPage;
            LoadEventData(from, to);
        }

        public void RefreshEvent() {
            int to = (page + 1) * dataPerPage;
            int from = to - dataPerPage;
            LoadEventData(from, to);
        }

        private void buttonEditEvent_Click(object sender, EventArgs e) {
            int rowCount = dataGridView.CurrentCell.RowIndex;
            String eventID = dataGridView.Rows[rowCount].Cells[1].Value.ToString();
            String eventName = dataGridView.Rows[rowCount].Cells[2].Value.ToString();
            String eventDescription = dataGridView.Rows[rowCount].Cells[7].Value.ToString();

            EditEventForm editEventForm = new EditEventForm();

            // mengambil parent form
            Form form = (this.Parent.Parent as Form);
            form.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            editEventForm.SetEventID(eventID);
            editEventForm.SetEventName(eventName);
            editEventForm.SetEventDescription(eventDescription);
            editEventForm.ShowDialog(this);

            RefreshEvent();

            form.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonDeleteEvent_Click(object sender, EventArgs e) {
            try {

                /*if (dataGridView.SelectedRows.Count > 0) {*/
                //
                // BUG
                //
                    int row = dataGridView.CurrentCell.RowIndex;
                    String eventName = dataGridView.Rows[row].Cells[2].Value.ToString();
                    String id = dataGridView.Rows[row].Cells[1].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("Hapus " + eventName + "- (" + id + ")", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {

                        QueryBuilder builder = queryBuilder.DeleteFrom("event_olahraga")
                                                           .Where("id_event", "=", id);

                        int rowsAffected = database.ExecuteNonQuery(builder.Get());
                        if (rowsAffected > 0) {
                            MessageBox.Show("Hapus berhasil", "Success");
                            RefreshEvent();
                            LoadEventPage();
                        } else {
                            MessageBox.Show("Hapus gagal", "Error");
                        }

                    } 

                /*} else {
                    Console.WriteLine("No rows selected");
                }*/

            } catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonLihatHasil_Click(object sender, EventArgs e) {
            try {

                // ambil id event dari datagridview
                int rowCount = dataGridView.CurrentCell.RowIndex;
                String cellValue = dataGridView.Rows[rowCount].Cells[1].Value.ToString();

                Ranking ranking = new Ranking();

                // mengambil parent form
                Form form = (this.Parent.Parent as Form);
                form.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

                // passing id event ke form berikutnya
                ranking.SetEventID(cellValue);
                ranking.ShowDialog(this);

                form.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose


            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }

        private void linkLabelPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Converter converter = new Converter();
            converter.SetDataGridView(dataGridView);
            converter.ShowDialog(this);
        }
    }
}

