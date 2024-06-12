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
    public partial class FormEgitmenler : Form
    {
        public FormEgitmenler()
        {
            InitializeComponent();
        }

        public Egitmenler Egitmen { get; set; }

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
            if (!ErrorControl(txtUzmanlik)) return;

            Egitmen.Ad = txtAd.Text;
            Egitmen.Soyad = txtSoyad.Text;
            Egitmen.Eposta = txtEposta.Text;
            Egitmen.Uzmanlik = txtUzmanlik.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control check)
        {
            if (check.Text == "")
            {
                errorProviderEgitmenler.SetError(check, "Eksik veya hatalı bilgi");
                check.Focus();
                return false;
            }
            errorProviderEgitmenler.SetError(check, "");
            return true;
        }

        private void FormEgitmenler_Load(object sender, EventArgs e)
        {
            txtKimlik.Text = Egitmen.Kimlik.ToString();
            if (Updating)
            {
                txtAd.Text = Egitmen.Ad;
                txtSoyad.Text = Egitmen.Soyad;
                txtEposta.Text = Egitmen.Eposta;
                txtUzmanlik.Text = Egitmen.Uzmanlik;
            }
        }
    }
}
