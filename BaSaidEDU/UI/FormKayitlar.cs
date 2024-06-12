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
    public partial class FormKayitlar : Form
    {
        public FormKayitlar()
        {
            InitializeComponent();
        }

        public Kayitlar Kayit { get; set; }

        public bool Updating { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtOgrenciKimlik)) return;
            if (!ErrorControl(txtKursKimlik)) return;

            Kayit.OgrenciKimlik = Guid.Parse(txtOgrenciKimlik.Text);
            Kayit.KursKimlik    = Guid.Parse(txtKursKimlik.Text);
            Kayit.Tarih         = dateKayitTarihi.Value;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control check)
        {
            if (check.Text == "")
            {
                errorProviderKayitler.SetError(check, "Eksik veya hatalı bilgi");
                check.Focus();
                return false;
            }
            errorProviderKayitler.SetError(check, "");
            return true;
        }

        private void FormKayitlar_Load(object sender, EventArgs e)
        {
            txtKimlik.Text = Kayit.Kimlik.ToString();
            if (Updating)
            {
                txtOgrenciKimlik.Text = Kayit.OgrenciKimlik.ToString();
                txtKursKimlik.Text    = Kayit.KursKimlik.ToString();
                dateKayitTarihi.Value = Kayit.Tarih;
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
