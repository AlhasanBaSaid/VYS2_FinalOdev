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
    public partial class FormOdeme : Form
    {
        public FormOdeme()
        {
            InitializeComponent();
        }

        public Odemeler Odeme { get; set; }
        
        public bool Updating { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtOgrenciKimlik)) return;
            if (!ErrorControl(txtKursKimlik)) return;
            if (!ErrorControl(numericOdemeTutari)) return;

            Odeme.OgrenciKimlik = Guid.Parse(txtOgrenciKimlik.Text);
            Odeme.KursKimlik    = Guid.Parse(txtKursKimlik.Text);
            Odeme.Tutar         = (double)numericOdemeTutari.Value;
            Odeme.Tarih         = dateTarihi.Value;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control check)
        {
            if (check is TextBox)
            {
                if (check.Text == "")
                {
                    errorProviderOdeme.SetError(check, "Eksik veya hatalı bilgi");
                    check.Focus();
                    return false;
                }
                errorProviderOdeme.SetError(check, "");
                return true;
            }

            if (check is NumericUpDown)
            {
                if (((NumericUpDown)check).Value == 0)
                {
                    errorProviderOdeme.SetError(check, "Lütfen fiyat giriniz!");
                    check.Focus();
                    return false;
                }
                errorProviderOdeme.SetError(check, "");
            }
            return true;
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            
            txtKimlik.Text = Odeme.Kimlik.ToString();
            if (Updating)
            {
                txtOgrenciKimlik.Text    = Odeme.OgrenciKimlik.ToString();
                txtKursKimlik.Text       = Odeme.KursKimlik.ToString();
                numericOdemeTutari.Value = (decimal)Odeme.Tutar;
                dateTarihi.Value         = Odeme.Tarih;
            }
        }

        private void btnOgrenciSec_Click(object sender, EventArgs e)
        {
            OGRENCILER OGRENCILER = new OGRENCILER();

            if (OGRENCILER.ShowDialog() == DialogResult.OK)
                txtOgrenciKimlik.Text = OGRENCILER.Ogrenci.Kimlik.ToString();
        }

        private void btnKursSec_Click(object sender, EventArgs e)
        {
            KURSLAR KURSLAR = new KURSLAR();

            if (KURSLAR.ShowDialog() == DialogResult.OK)
                txtKursKimlik.Text = KURSLAR.Kurs.Kimlik.ToString();
        }
    }
}
