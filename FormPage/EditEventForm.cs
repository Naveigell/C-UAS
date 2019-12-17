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

namespace UAS.FormPage {
    public partial class EditEventForm : Form {

        private String eventID, eventName, eventDescription;
        private Database database;
        private QueryBuilder queryBuilder;
        private bool isEventNameError = false, isEventDescriptionError = false;

        public EditEventForm() {
            InitializeComponent();
            InitializeVariable();
        }

        protected void InitializeVariable() {
            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();

            labelErrorMessage.Text = "";
        }

        public void SetEventID(String eventID) {
            this.eventID = eventID;
        }

        private void buttonEditEvent_Click(object sender, EventArgs e) {

            isEventNameError = textBoxEventName.TextLength < 3;
            isEventDescriptionError = textBoxDescription.TextLength < 5;

            if (!isEventNameError && !isEventDescriptionError && eventID != null) {

                QueryBuilder builder = queryBuilder.Update("event_olahraga")
                                                   .Set(new string[][]{
                                                        new string[]{ "nama_event", textBoxEventName.Text },
                                                        new string[]{ "deskripsi", textBoxDescription.Text }
                                                   })
                                                   .Where("id_event", "=", eventID);

                try {

                    int rowsAffected = database.ExecuteNonQuery(builder.Get());

                    if (rowsAffected > -1) {
                        MessageBox.Show("Update event success", "Success");
                        Close();
                    } else {
                        MessageBox.Show("Update event failed", "Failed");
                    }
                } catch (Exception exception) {
                    Console.WriteLine(exception.Message);
                }
            }

        }

        private void EditEventForm_Load(object sender, EventArgs e) {
            if (eventID != null && eventName != null && eventDescription != null) {
                textBoxEventName.Text = eventName;
                textBoxDescription.Text = eventDescription;
            }
        }

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e) {
            if (textBoxDescription.TextLength < 5) labelErrorMessage.Text = "Deskripsi event tidak boleh kurang dari 5";
            else labelErrorMessage.Text = "";
        }

        private void textBoxEventName_KeyPress(object sender, KeyPressEventArgs e) {
            if (textBoxEventName.TextLength < 3) labelErrorMessage.Text = "Nama event tidak boleh kurang dari 3";
            else labelErrorMessage.Text = "";
        }

        public void SetEventName(String eventName) {
            this.eventName = eventName;
        }

        public void SetEventDescription(String eventDescription) {
            this.eventDescription = eventDescription;
        }


    }
}
