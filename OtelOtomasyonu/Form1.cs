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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            FormMusteri musteriForm = new FormMusteri();
            musteriForm.Show();
        }

        private void btnRezervasyonIslemleri_Click(object sender, EventArgs e)
        {
            FormRezervasyon rezervasyonForm = new FormRezervasyon();
            rezervasyonForm.Show();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            FormPersonel personelForm = new FormPersonel();
            personelForm.Show();
        }

        private void btnUcretHesaplama_Click(object sender, EventArgs e)
        {
            FormUcretHesapla ucretForm = new FormUcretHesapla();
            ucretForm.Show();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {

        }
    }
}
