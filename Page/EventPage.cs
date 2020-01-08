using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.Scripts.Model;
using System.Threading;

namespace UAS {
    public partial class EventPage : UserControl {

        private Color linkMainColor, linkBackColor;

        public EventPage() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            linkMainColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (191)))), ((int) (((byte) (61)))));
            linkBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (54)))), ((int) (((byte) (79)))));
        }

        private void EventPage_Load(object sender, EventArgs e) {
            participantPageShowPageDetails1.Hide();
        }

        private void eventPageShowPageDetails1_Load(object sender, EventArgs e) {
        }

        private void buttonParticipantPage_Click(object sender, EventArgs e) {
            eventPageShowPageDetails1.Hide();
            participantPageShowPageDetails1.Show();
            participantPageShowPageDetails1.BringToFront();

            labelTitle.Text = "Participant";
            buttonEventPage.BackColor = linkBackColor;
            buttonParticipantPage.BackColor = linkMainColor;
        }

        private void buttonLogout_Click(object sender, EventArgs e) {
            buttonEventPage.BackColor = linkBackColor;
            buttonParticipantPage.BackColor = linkBackColor;
            buttonLogout.BackColor = linkMainColor;

            // buat session menjadi logout
            Session.LOGIN_MODE = Session.LOGOUT;
            // lalu cek sekali lagi apakah sudah
            // benar" logout
            if (Session.LOGIN_MODE == Session.LOGOUT) {
                OpenForm();
            }
        }
        private void OpenForm() {
            // ambil parent untuk di close
            Form parent = (this.Parent as Form);
            parent.Close();
            Thread thread = new Thread(OpenAnotherForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAnotherForm(object obj) {
            Application.Run(new LoginForm());
        }

        private void buttonEventPage_Click(object sender, EventArgs e) {
            participantPageShowPageDetails1.Hide();
            eventPageShowPageDetails1.Show();
            eventPageShowPageDetails1.BringToFront();

            labelTitle.Text = "Event";
            buttonEventPage.BackColor = linkMainColor;
            buttonParticipantPage.BackColor = linkBackColor;
        }
    }
}
