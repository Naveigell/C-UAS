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

namespace UAS.Page {
    public partial class EventPageShowPageDetails : UserControl {

        private Database database;
        private QueryBuilder queryBuilder;

        public EventPageShowPageDetails() {
            InitializeComponent();
            InitializeVariables();
        }

        public DataGridView GetDataGridView() {
            return dataGridView;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void EventPageShowPageDetails_Load(object sender, EventArgs e) {

        }

        protected void InitializeVariables() {
            String dbSources = Properties.Settings.Default.dbSources;
            database = new Database(dbSources);
            queryBuilder = new QueryBuilder();

            QueryBuilder builder = queryBuilder.Select("*")
                                               .From("event_olahraga");

            database.ExecuteQuery(builder.Get(), builder.GetArrayList());
        }
    }
}

