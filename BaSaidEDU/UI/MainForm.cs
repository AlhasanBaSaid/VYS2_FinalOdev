using BaSaidEDU.BL;
using BaSaidEDU.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace BaSaidEDU
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.KayitDetay();
            if (ds1 != null)
                dataGridViewKayitlar.DataSource = ds1.Tables[0];

            DataSet ds2 = BLogic.OdemeDetay();
            if (ds2 != null)
                dataGridViewOdemeler.DataSource = ds2.Tables[0];
        }

        OGRENCILER OGRENCILER   = new OGRENCILER();
        EGITMENLER EGITMENLER   = new EGITMENLER();
        KURSLAR KURSLAR         = new KURSLAR();
        ILERLEMELER ILERLEMELER = new ILERLEMELER();

        private void btnOGRENCILER_Click(object sender, EventArgs e)
        {
            OGRENCILER.ShowDialog();
        }

        private void btnEGITMENLER_Click(object sender, EventArgs e)
        {
            EGITMENLER.ShowDialog();
        }

        private void btnKURSLAR_Click(object sender, EventArgs e)
        {
            KURSLAR.ShowDialog();
        }        
        
        private void btnILERLEMELER_Click(object sender, EventArgs e)
        {
            ILERLEMELER.ShowDialog();
        }


        /* Odemeler */
        private void btnODEMELER_Click(object sender, EventArgs e)
        {
            FormOdeme formOdemeler = new FormOdeme()
            {
                Text = "Ödeme Yap",
                Odeme = new Odemeler()
                {
                    Kimlik = Guid.NewGuid(),
                }
            };

        tekrar:
            var sonuc = formOdemeler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeEkle(formOdemeler.Odeme);

                if (b)
                {
                    DataSet ds2 = BLogic.OdemeDetay();
                    if (ds2 != null)
                        dataGridViewOdemeler.DataSource = ds2.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnOdemeDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewOdemeler.SelectedRows[0];

            FormOdeme formOdemeler = new FormOdeme()
            {
                Text = "Ödeme Güncelle",
                Updating = true,
                Odeme = new Odemeler()
                {
                    Kimlik        = Guid.Parse(row.Cells[0].Value.ToString()),
                    OgrenciKimlik = Guid.Parse(row.Cells[1].Value.ToString()),
                    KursKimlik    = Guid.Parse(row.Cells[2].Value.ToString()),
                    Tutar         = float.Parse(row.Cells[4].Value.ToString()),
                    Tarih         = DateTime.Parse(row.Cells[5].Value.ToString()),
                },
            };

            var sonuc = formOdemeler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGuncelle(formOdemeler.Odeme);

                if (b)
                {
                    row.Cells[1].Value = formOdemeler.Odeme.OgrenciKimlik;
                    row.Cells[2].Value = formOdemeler.Odeme.KursKimlik;
                    row.Cells[4].Value = formOdemeler.Odeme.Tutar;
                    row.Cells[5].Value = formOdemeler.Odeme.Tarih;
                }
            }
        }

        private void btnOdemeBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KursGetir(toolStripTextBoxOdeme.Text);
            if (ds != null)
                dataGridViewOdemeler.DataSource = ds.Tables[0];
        }        
        
        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewOdemeler.SelectedRows[0];

            var Kimlik = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show(
                "Seçili kayıt silinsin mi?",
                "Silmeyi onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(Kimlik);

                if (b)
                {
                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                        dataGridViewOdemeler.DataSource = ds.Tables[0];
                }
            }
        }




        /* Kayitler */
        private void btnKAYITLAR_Click(object sender, EventArgs e)
        {
            FormKayitlar formKayitler = new FormKayitlar()
            {
                Text = "Kayıt Yap",
                Kayit = new Kayitlar()
                {
                    Kimlik = Guid.NewGuid(),
                }
            };

        tekrar:
            var sonuc = formKayitler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KayitEkle(formKayitler.Kayit);

                if (b)
                {
                    DataSet ds = BLogic.KayitDetay();
                    if (ds != null)
                     dataGridViewKayitlar.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKayitlar.SelectedRows[0];

            FormKayitlar formKayitlar = new FormKayitlar()
            {
                Text = "Kayıt Güncelle",
                Updating = true,
                Kayit = new Kayitlar()
                {
                    Kimlik        = Guid.Parse(row.Cells[0].Value.ToString()),
                    OgrenciKimlik = Guid.Parse(row.Cells[1].Value.ToString()),
                    KursKimlik    = Guid.Parse(row.Cells[2].Value.ToString()),
                    Tarih         = DateTime.Parse(row.Cells[9].Value.ToString()),
                },
            };

            var sonuc = formKayitlar.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KayitGuncelle(formKayitlar.Kayit);

                if (b)
                {
                    row.Cells[1].Value = formKayitlar.Kayit.OgrenciKimlik;
                    row.Cells[2].Value = formKayitlar.Kayit.KursKimlik;
                    row.Cells[9].Value = formKayitlar.Kayit.Tarih;
                }
            }
        }
        
        private void btnKayitBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KursGetir(toolStripTextBoxKayit.Text);
            if (ds != null)
                dataGridViewKayitlar.DataSource = ds.Tables[0];
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKayitlar.SelectedRows[0];

            var Kimlik = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show(
                "Seçili kayıt silinsin mi?",
                "Silmeyi onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KayitSil(Kimlik);

                if (b)
                {
                    DataSet ds = BLogic.KayitDetay();
                    if (ds != null)
                        dataGridViewKayitlar.DataSource = ds.Tables[0];
                }
            }
        }


    }
}
