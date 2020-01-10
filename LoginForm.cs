using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAS.Scripts.Helper;
using UAS.Scripts.Model;

namespace UAS {
    public partial class LoginForm : Form {

        private Auth auth;

        public LoginForm() {
            InitializeComponent();

            auth = new Auth();
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonSignIn_Click(object sender, EventArgs e) {
            String email = textBoxEmail.Text;
            String password = textBoxPassword.Text;

            if (email.Trim().Equals("") || textBoxEmail.TextLength < 5) {
                MessageBox.Show("Panjang email tidak boleh kurang dari 5", "Error");
            } else if (password.Trim().Equals("")) {
                MessageBox.Show("Password tidak boleh kosong", "Error");
            } else {

                String ecryptedPassword = Hash.HashMD5(password);
                // dapatkan tipe user dari auth lalu jadikan session login mode menjadi tipe user
                // entah user biasa atau admin
                bool isUserExist = auth.SignInWithEmailAndPassword(email, ecryptedPassword, false);
                if (isUserExist) {
                    Session.LOGIN_MODE = auth.GetUserType();
                } else {
                    MessageBox.Show("Email atau password salah", "Error");
                }
            }

            // cek jika login mode nya adalah admin
            if (Session.LOGIN_MODE == Auth.TYPE_ADMIN) {
                OpenForm();
            }

        }

        private void OpenForm() {
            Close();
            Thread thread = new Thread(OpenAnotherForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAnotherForm(object obj) {
            Application.Run(new MainForm());
        }

        private void linkLoginAsGuest_Click(object sender, EventArgs e) {
            Session.LOGIN_MODE = Auth.TYPE_USER;
            OpenForm();
        }
    }
}
