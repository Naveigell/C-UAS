using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.FormPage.Schedule.Individual;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Schedule {
    public partial class IndividualEvent : Form {

        private String eventID, scheduleID;
        private QueryBuilder queryBuilder;
        private Database database;

        public IndividualEvent() {
            InitializeComponent();
            InitializeVariable();
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        public void SetScheduleID(String scheduleID) {
            this.scheduleID = scheduleID;
        }

        private void LoadData() {
            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("score_by_individual")
                                               .InnerJoin("schedules", "schedules.id_schedule", "=", "score_by_individual.id_scedule")
                                               .Where("schedules.id_schedule", "=", scheduleID);

            Console.WriteLine(builder.Get());
        }

        private void buttonTambahJadwalPeserta_Click(object sender, EventArgs e) {
            IndividualAddForm individualAddForm = new IndividualAddForm();
        }

        private void IndividualEvent_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);

            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Width = 50;
        }
    }
}
