using BaSaidEDU.BL;
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
    public partial class OGRENCILER : Form
    {
        public OGRENCILER()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            FormOgrenciler formOgrenciler = new FormOgrenciler()
            {
                Text    = "Öğrenci Ekle",
                Ogrenci = new Ogrenciler()
                {
                    Kimlik = Guid.NewGuid()
                },
            };

        tekrar:
            var sonuc = formOgrenciler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgrenciEkle(formOgrenciler.Ogrenci);

                if (b)
                {
                    DataSet ds = BLogic.OgrenciGetir("");
                    if (ds != null)
                        dataGridViewOgrenciler.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnOgrenciDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewOgrenciler.SelectedRows[0];

            FormOgrenciler formOgrenciler = new FormOgrenciler()
            {
                Text     = "Öğrenci Güncelle",
                Updating = true,
                Ogrenci  = new Ogrenciler()
                {
                    Kimlik = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad     = row.Cells[1].Value.ToString(),
                    Soyad  = row.Cells[2].Value.ToString(),
                    Eposta = row.Cells[3].Value.ToString(),
                },
            };

            var sonuc = formOgrenciler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgrenciGuncelle(formOgrenciler.Ogrenci);

                if (b)
                {
                    row.Cells[1].Value = formOgrenciler.Ogrenci.Ad;
                    row.Cells[2].Value = formOgrenciler.Ogrenci.Soyad;
                    row.Cells[3].Value = formOgrenciler.Ogrenci.Eposta;
                }
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewOgrenciler.SelectedRows[0];

            var Kimlik = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show(
                "Seçili kayıt silinsin mi?",
                "Silmeyi onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgrenciSil(Kimlik);

                if (b)
                {
                    DataSet ds = BLogic.OgrenciGetir("");
                    if (ds != null)
                        dataGridViewOgrenciler.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnOgrenciBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OgrenciGetir(toolStripTextBoxOgrenci.Text);
            if (ds != null)
                dataGridViewOgrenciler.DataSource = ds.Tables[0];
        }

        private void OGRENCILER_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OgrenciGetir("");
            if (ds != null)
                dataGridViewOgrenciler.DataSource = ds.Tables[0];
        }

        public Ogrenciler Ogrenci { get; set; }
    
        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewOgrenciler.SelectedRows[0];

            Ogrenci = new Ogrenciler()
            {
                Kimlik = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad     = row.Cells[1].Value.ToString(),
                Soyad  = row.Cells[2].Value.ToString(),
                Eposta = row.Cells[3].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
