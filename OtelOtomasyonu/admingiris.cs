using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        private void admingiris_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Önceden tanımlı kullanıcı adı ve şifre
            string correctUsername = "admin";
            string correctPassword = "1234";

            // Kullanıcıdan alınan girişler
            string username = txtKullaniciAdi.Text;
            string password = textBox2.Text;

            // Giriş kontrolü
            if (username == correctUsername && password == correctPassword)
            {
                lblSonuc.Text = "Giriş başarılı! Hoş geldiniz.";
                lblSonuc.ForeColor = System.Drawing.Color.Green;
                FormAna FormAna = new FormAna();
                FormAna.Show();
                this.Hide();


            }
            else if (username != correctUsername && password == correctPassword)
            {
                lblSonuc.Text = "Kullanıcı adı yanlış!";
                lblSonuc.ForeColor = System.Drawing.Color.Red;
            }
            else if (username == correctUsername && password != correctPassword)
            {
                lblSonuc.Text = "Şifre yanlış!";
                lblSonuc.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblSonuc.Text = "Kullanıcı adı ve şifre yanlış!";
                lblSonuc.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
