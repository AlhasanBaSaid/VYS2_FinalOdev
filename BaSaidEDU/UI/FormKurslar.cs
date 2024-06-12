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
    public partial class FormKurslar : Form
    {
        public FormKurslar()
        {
            InitializeComponent();
        }

        public Kurslar Kurs { get; set; } 

        public bool Updating { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtEgitmenKimlik)) return;
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(numericFiyat)) return;
            if (!ErrorControl(txtAciklama)) return;

            Kurs.EgitmenKimlik  = Guid.Parse(txtEgitmenKimlik.Text);
            Kurs.Ad             = txtAd.Text;
            Kurs.Aciklama       = txtAciklama.Text;
            Kurs.Fiyat          = (float)numericFiyat.Value;
            
            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control check)
        {
            if (check is TextBox)
            {
                if (check.Text == "")
                {
                    errorProviderKurslar.SetError(check, "Eksik veya hatalı bilgi");
                    check.Focus();
                    return false;
                }   
                errorProviderKurslar.SetError(check, "");
                return true;
            }

            if (check is NumericUpDown)
            {
                if (((NumericUpDown)check).Value == 0)
                {
                    errorProviderKurslar.SetError(check, "Lütfen fiyat giriniz!");
                    check.Focus();
                    return false;
                }
                errorProviderKurslar.SetError(check, "");
            }
            return true;
        }

        private void FormKurslar_Load(object sender, EventArgs e)
        {
            txtKimlik.Text = Kurs.Kimlik.ToString();
            if (Updating)
            {
                txtEgitmenKimlik.Text = Kurs.EgitmenKimlik.ToString();
                txtAd.Text            = Kurs.Ad;
                txtAciklama.Text      = Kurs.Aciklama;
                numericFiyat.Value    = (decimal)Kurs.Fiyat;
            }
        }

        private void btnEgitmenSec_Click(object sender, EventArgs e)
        {
            EGITMENLER EGITMENLER = new EGITMENLER();

            if (EGITMENLER.ShowDialog() == DialogResult.OK)
                txtEgitmenKimlik.Text = EGITMENLER.Egitmen.Kimlik.ToString();
        }
    }
}
