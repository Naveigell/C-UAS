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
using UAS.Scripts.Helper;

namespace UAS.Page {
    public partial class ParticipantPageShowPageDetails : UserControl {

        private Database database;
        private QueryBuilder queryBuilder;

        private SqlDataReader dataReader;

        private int page = 0;
        private int totalPage = 0;
        private int dataPerPage = 10;

        public ParticipantPageShowPageDetails() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
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

            dataGridView.Columns[0].Width = 50;

            LoadEventPage();
        }
        private void LoadEventPage() {

            QueryBuilder builder = queryBuilder.Raw("SELECT COUNT(*) AS counts FROM peserta");

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

        private void LoadEventData(int offset, int limit) {

            // clear rows dari data gridview
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("peserta")
                                               .OrderBy("id_peserta", QueryBuilder.ORDER_ASCENDING)
                                               // sebelum limit harus menggunakan order by
                                               .Limit(offset, dataPerPage);

            try {

                dataReader = database.ExecuteQuery(builder.Get());
                int number = offset;

                while (dataReader.Read()) {
                    dataGridView.Rows.Add(
                        ++number,
                        dataReader["id_peserta"].ToString(),
                        dataReader["nama_peserta"].ToString(),
                        dataReader["tipe_peserta"].ToString(),
                        dataReader["gender"].ToString()
                    );
                }

                dataReader.Close();

                database.CloseConnection();

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        private void ParticipantPageShowPageDetails_Load(object sender, EventArgs e) {
            int to = (page + 1) * dataPerPage;
            int from = to - dataPerPage;
            LoadEventData(from, to);
        }

        private void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e) {
            page = comboBoxPage.SelectedIndex;

            int to = (page + 1) * dataPerPage;
            int from = to - dataPerPage;
            LoadEventData(from, to);
        }

        private void linkLabelPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Form form = (this.Parent.Parent.Parent as Form);
            form.Opacity = 0.4; // membuat parent form opacity menjadi 0.4

            Converter converter = new Converter();
            converter.SetDataGridView(dataGridView);
            converter.ShowDialog(this);

            form.Opacity = 1;
        }
    }
}
