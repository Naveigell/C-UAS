using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UAS.Scripts;
using UAS.Scripts.Model;

namespace UAS.FormPage {
    public partial class AddEventForm : Form {

        private bool isEventNameError = true,
                     isEventIDError = true,
                     isStartDateError = true,
                     isFinishDateError = true,
                     isEventTypeError = true,
                     isGenderError = true,
                     isDescriptionError = true;

        private QueryBuilder queryBuilder;
        private Database database;

        public AddEventForm() {
            InitializeComponent();
            InitializeVariables();
        }

        private void AddEventForm_Load(object sender, EventArgs e) {
            SetLabelError("");
        }

        protected void InitializeVariables() {

            database = new Database(Properties.Settings.Default.dbSources);
            queryBuilder = new QueryBuilder();

            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.CustomFormat = "MM - dd - yyyy             HH:mm";

            dateTimePickerFinishDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFinishDate.CustomFormat = "MM - dd -yyyy             HH:mm";

            comboBoxEventType.Items.AddRange(new string[] { "Perorangan", "Kelompok" });
            if (comboBoxEventType.Items.Count > 0) comboBoxEventType.SelectedIndex = 0;

            comboBoxEventGender.Items.AddRange(new string[] { "Man", "Woman", "Mixed" });
            if (comboBoxEventGender.Items.Count > 0) comboBoxEventGender.SelectedIndex = 2;

        }

        private void buttonAddEvent_Click(object sender, EventArgs e) {

            isEventNameError = textBoxEventName.Text.Equals("") || (int) textBoxEventName.Text.Length < 3;
            isEventIDError = textBoxEventID.Text.Equals("") || (int) textBoxEventID.Text.Length < 2;
            isDescriptionError = textBoxDescription.Text.Equals("") || (int) textBoxDescription.Text.Length < 5;

            isEventTypeError = comboBoxEventType.SelectedIndex < 0;
            isGenderError = comboBoxEventGender.SelectedIndex < 0;

            if (!isEventNameError && !isEventIDError && !isDescriptionError && 
                !isEventTypeError && !isFinishDateError && !isStartDateError && !isGenderError) {

                // ambil event dengan id yang mirip
                QueryBuilder builder = queryBuilder.Select("*")
                                                   .From("event_olahraga")
                                                   .WhereLike("id_event", textBoxEventID.Text.ToString(), QueryBuilder.LIKE_BOTH);
                // ambil event dengan id yang mirip
                SqlDataReader dataReader = database.ExecuteQuery(queryBuilder.Get());

                DateTime startDate = dateTimePickerStartDate.Value;
                DateTime finishDate = dateTimePickerFinishDate.Value;

                try {
                    int count = 0;
                    // cek berapa banyak id event yang mirip
                    while (dataReader.Read()) {
                        // cek banyaknya event
                        ++count;
                    }
                    // increment kan 1
                    ++count;

                    dataReader.Close();

                    // tambahkan 0 di depan event id, misal
                    // AAA001, AAA011, AAA111
                    String eventID = textBoxEventID.Text.ToString().ToUpper();
                    if (count < 10) eventID = eventID + "00" + count;
                    else if (count < 100) eventID = eventID + "0" + count;
                    else eventID = eventID + count;

                    // membuat query untuk insert data
                    builder = queryBuilder.Insert("event_olahraga",
                                                   "id_event, nama_event, tanggal_pelaksanaan_event, tanggal_event_selesai, tipe_event, deskripsi, event_gender, status_event")

                                           .Values(new String[][] {
                                            new String[] { eventID, textBoxEventName.Text.ToString(), startDate.ToString("yyyy-MM-dd HH:mm"), finishDate.ToString("yyyy-MM-dd HH:mm"), comboBoxEventType.SelectedItem.ToString(), textBoxDescription.Text.ToString(), comboBoxEventGender.SelectedItem.ToString(), "1" },
                                           });

                    // execute query dari insert data
                    int rowsAffected = database.ExecuteNonQuery(builder.Get());
                    // jika query berhasil di execute tanpa error,
                    // -1 = error
                    if (rowsAffected > -1) {
                        MessageBox.Show("Tambah event berhasil", "Success");
                        // tutup form jika berhasil
                        this.Close();
                    } else {
                        MessageBox.Show("Tambah event gagal", "Failed");
                    }

                } catch (Exception exception) {
                    Console.WriteLine("Error : " + exception.Message);
                }

            } else {
                MessageBox.Show("Ups check your input again", "Error");

                Console.WriteLine("Name : " + isEventNameError);
                Console.WriteLine("EventID : " + isEventIDError);
                Console.WriteLine("Description : " + isDescriptionError);
                Console.WriteLine("Event Type : " + isEventTypeError);
                Console.WriteLine("FinishDate : " + isFinishDateError);
                Console.WriteLine("StartDate : " + isStartDateError);
                Console.WriteLine("Gender Error : " + isGenderError);
                Console.WriteLine();

                Console.WriteLine("Name Length : " + textBoxEventName.Text.Length);
                Console.WriteLine("Event ID Length : " + textBoxEventID.Text.Length);
                Console.WriteLine("Description Length : " + textBoxDescription.Text.Length);
                Console.WriteLine();

                Console.WriteLine("Name : " + textBoxEventName.Text.ToString());
                Console.WriteLine("Event ID : " + textBoxEventID.Text.ToString());
                Console.WriteLine("Description : " + textBoxDescription.Text.ToString());
                Console.WriteLine("============================");
            }
        }

        private void buttonGenerateID_Click(object sender, EventArgs e) {
            if (textBoxEventName.Text.ToString().Equals("") || textBoxEventName.Text.Length < 3) { // jika event name nilainya kosong
                MessageBox.Show("Event name must have at least 3 characters!", "Error");
            } else {

                String stringToGenerate = textBoxEventName.Text.ToString();
                textBoxEventID.Text = GenerateString(stringToGenerate).ToUpper();

            }
        }

        private String GenerateString(String stringToGenerate) {

            Random random = new Random();

            // menghilangkan whitespace
            stringToGenerate = stringToGenerate.Replace(" ", stringToGenerate);
            // buat string kosong
            String tempString = "";

            while (true) {
                int count = 0;
                // kosongkan string jika seandainya while loop diulang
                tempString = "";
                // loop sebanyak panjang string yang ingin di generate
                for (int i = 0; i < stringToGenerate.Length; i++) {
                    // buat random antara nomor 1 - 10 lalu cek apakah
                    // hasilnya kurang dari sama dengan 5
                    if (random.Next(1, 10) <= 5) {
                        // tambahkan huruf pada stringToGenerate pada index
                        // ke i ke dalam temp string dan increment count
                        tempString += stringToGenerate[i];
                        count++;
                    }
                    // jika count bernilai 3 maka break
                    if (count >= 3) break;
                }
                // jika count bernilai 3 maka break
                if (count >= 3) break;
            }

            return tempString;
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e) {
            ValidateDateTime();
        }

        private void dateTimePickerFinishDate_ValueChanged(object sender, EventArgs e) {
            ValidateDateTime();
        }

        protected void ValidateDateTime() {

            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime finishDate = dateTimePickerFinishDate.Value;

            startDate.ToString("yyyy-MM-dd HH:mm:ss");

            if (startDate.Date > finishDate.Date) {
                labelErrorMessage.Text = "Start date cant be greater than finish date";
            } else if (startDate.Hour > finishDate.Hour && startDate.Date == finishDate.Date) {
                labelErrorMessage.Text = "Start hour cant be greater than finish hour";
            } else if (startDate.Minute > finishDate.Minute && startDate.Hour == finishDate.Hour && startDate.Date == finishDate.Date) {
                labelErrorMessage.Text = "Start minute cant be greater than finish minute";
            } else if (startDate.Minute == finishDate.Minute && startDate.Hour == finishDate.Hour && startDate.Date == finishDate.Date) {
                labelErrorMessage.Text = "Date, Hour, Minute cant be same";
            } else {
                SetLabelError("");
                isFinishDateError = isStartDateError = false;
                return;
            }
            isFinishDateError = isStartDateError = true;
        }

        private void textBoxEventName_Enter(object sender, EventArgs e) {
            
        }

        protected void SetLabelError(String text) {
            labelErrorMessage.Text = text;
        }

        private void textBoxEventName_KeyPress(object sender, KeyPressEventArgs e) {
            /*if (textBoxEventName.Text.ToString().Equals("") || textBoxEventName.Text.Length < 3) {
                SetLabelError("Event name must have at least 3 characters!");
            } else {
                SetLabelError("");
            }*/
        }

        private void textBoxEventID_KeyPress(object sender, KeyPressEventArgs e) {
            //
            // BUG
            //

            /*if (textBoxEventID.Text.ToString().Equals("") || textBoxEventID.Text.Length < 3) {
                SetLabelError("Event ID must have at least 3 characters!");
            } else {
                SetLabelError("");
            }*/
            /*int count = 0;
            if (e.KeyChar >= 48 && e.KeyChar <= 57) {
                textBoxEventID.Text += e.KeyChar.ToString();
                textBoxEventID.SelectionStart = textBoxEventID.Text.Length;
                ++count;
            }
            if (e.KeyChar == 8) {
                textBoxEventID.Text = textBox1.Text;
                sssnumber.Remove(sssnumber.Length - 1);
                textBox1.Text = sssnumber;
            }
            Console.WriteLine(count);*/
        }

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e) {
        }
    }
}
