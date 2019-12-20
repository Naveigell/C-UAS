using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage.Participant.SubParticipant {
    public partial class EditSubParticipantForm : Form {

        private String eventID, participantID;
        private QueryBuilder queryBuilder;
        private Database database;

        public EditSubParticipantForm() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            queryBuilder = new QueryBuilder();
            database = new Database(Properties.Settings.Default.dbSources);
        }
    }
}
