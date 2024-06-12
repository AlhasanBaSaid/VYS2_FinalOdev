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
    public partial class FormIlerlemeTakipcesi : Form
    {
        public FormIlerlemeTakipcesi()
        {
            InitializeComponent();
        }
        
        public IlerlemeTakipcisi Ilerleme { get; set; }

        public bool Updating { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtOgrenciKimlik)) return;
            if (!ErrorControl(txtKursKimlik)) return;
            if (!ErrorControl(numericTamamlanmaYuzdesi)) return;

            Ilerleme.OgrenciKimlik     = Guid.Parse(txtOgrenciKimlik.Text);
            Ilerleme.KursKimlik        = Guid.Parse (txtKursKimlik.Text) ;
            Ilerleme.TamamlanmaYuzdesi = (float)numericTamamlanmaYuzdesi.Value;

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control check)
        {
            if (check is TextBox)
            {
                if (check.Text == "")
                {
                    errorProviderIlerleme.SetError(check, "Eksik veya hatalı bilgi");
                    check.Focus();
                    return false;
                }
                errorProviderIlerleme.SetError(check, "");
                return true;
            }

            if (check is NumericUpDown)
            {
                if (((NumericUpDown)check).Value == 0)
                {
                    errorProviderIlerleme.SetError(check, "Lütfen fiyat giriniz!");
                    check.Focus();
                    return false;
                }
                errorProviderIlerleme.SetError(check, "");
            }
            return true;
        }

        private void FormIlerlemeTakipcesi_Load(object sender, EventArgs e)
        {
            txtKimlik.Text = Ilerleme.Kimlik.ToString();
            if (Updating)
            {
                txtOgrenciKimlik.Text          = Ilerleme.OgrenciKimlik.ToString();
                txtKursKimlik.Text             = Ilerleme.KursKimlik.ToString();
                numericTamamlanmaYuzdesi.Value = (decimal)Ilerleme.TamamlanmaYuzdesi;
            }
        }

        private void btnOgrenciSec_Click(object sender, EventArgs e)
        {
            OGRENCILER OGRENCILER = new OGRENCILER();

            if (OGRENCILER.ShowDialog() == DialogResult.OK)
                txtOgrenciKimlik.Text = OGRENCILER.Ogrenci.Kimlik.ToString() ;
        }

        private void btnKursSec_Click(object sender, EventArgs e)
        {
            KURSLAR KURSLAR = new KURSLAR();

            if (KURSLAR.ShowDialog() == DialogResult.OK)
                txtKursKimlik.Text = KURSLAR.Kurs.Kimlik.ToString();
        }
    }
}
