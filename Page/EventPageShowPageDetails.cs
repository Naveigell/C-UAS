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

namespace UAS.Page {
    public partial class EventPageShowPageDetails : UserControl {

        private Database database;
        private QueryBuilder queryBuilder;

        private SqlDataReader dataReader;
        private ArrayList IDEventStore;

        public EventPageShowPageDetails() {
            InitializeComponent();
            InitializeVariables();

            QueryBuilder builder = queryBuilder.Insert("table",
                                                       "id_event, nama_event")

                                               .Values(new String[][] {
                                                    new String[] { "CTR001", "event name" },
                                                    new String[] { "CTR001", "event name" },
                                                    new String[] { "CTR001", "event name" }
                                               });

            String get = builder.Get();
            Console.WriteLine(get);
        }

        public DataGridView GetDataGridView() {
            return dataGridView;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void EventPageShowPageDetails_Load(object sender, EventArgs e) {
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("event_olahraga")
                                               .OrderBy("id_event")
                                               // sebelum limit harus menggunakan order by
                                               .Limit(0, 10);

            dataReader = database.ExecuteQuery(builder.Get(), builder.GetArrayList());
            int number = 0;

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

            database.CloseConnection();
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

            // menambah event baru ke dalam datagridview
            dataGridView.LostFocus += DataGridViewOnLostFocus;
            dataGridView.Columns[0].Width = 50;
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
            form.Opacity = 1; // kembalikan parent form opacity menjadi normal jika form add Event diclose
        }

        private void buttonLihatPeserta_Click(object sender, EventArgs e) {
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


        }
    }
}

