using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaSaidEDU.UI
{
    public partial class FormOgrenciler : Form
    {
        public FormOgrenciler()
        {
            InitializeComponent();
        }

        public Ogrenciler Ogrenci { get; set; }

        public bool Updating { get; set; } = false;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtEposta)) return;

            Ogrenci.Ad      = txtAd.Text;
            Ogrenci.Soyad   = txtSoyad.Text;
            Ogrenci.Eposta  = txtEposta.Text;
            

            DialogResult    = DialogResult.OK;
        }

        private bool ErrorControl(Control check)
        {
            if (check.Text == "")
            {
                errorProviderOgrenciler.SetError(check, "Eksik veya hatalı bilgi");
                check.Focus();
                return false;
            }
            errorProviderOgrenciler.SetError(check, "");
            return true;
        }

        private void FormOgrenciler_Load(object sender, EventArgs e)
        {
            txtKimlik.Text = Ogrenci.Kimlik.ToString();
            if (Updating)
            {
                txtAd.Text      = Ogrenci.Ad;
                txtSoyad.Text   = Ogrenci.Soyad;
                txtEposta.Text  = Ogrenci.Eposta;
            }
        }
    }
}
