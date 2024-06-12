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
    public partial class EGITMENLER : Form
    {
        public EGITMENLER()
        {
            InitializeComponent();
        }

        private void btnEgitmenEkle_Click(object sender, EventArgs e)
        {
            FormEgitmenler formEgitmenler = new FormEgitmenler()
            {
                Text    = "Eğitmen Ekle",
                Egitmen = new Egitmenler()
                {
                    Kimlik = Guid.NewGuid()
                },
            };

            tekrar:
            var sonuc = formEgitmenler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.EgitmenEkle(formEgitmenler.Egitmen);

                if (b)
                {
                    DataSet ds = BLogic.EgitmenGetir("");
                    if (ds != null)
                        dataGridViewEgitmenler.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnEgitmenDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewEgitmenler.SelectedRows[0];

            FormEgitmenler formEgitmenler = new FormEgitmenler()
            {
                Text     = "Eğitmen Düzenle",
                Updating = true,
                Egitmen  = new Egitmenler()
                {
                    Kimlik   = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad       = row.Cells[1].Value.ToString(),
                    Soyad    = row.Cells[2].Value.ToString(),
                    Eposta   = row.Cells[3].Value.ToString(),
                    Uzmanlik = row.Cells[4].Value.ToString(),
                },
            };

            var sonuc = formEgitmenler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.EgitmenGuncelle(formEgitmenler.Egitmen);

                if (b)
                {
                    row.Cells[1].Value = formEgitmenler.Egitmen.Ad;
                    row.Cells[2].Value = formEgitmenler.Egitmen.Soyad;
                    row.Cells[3].Value = formEgitmenler.Egitmen.Eposta;
                    row.Cells[4].Value = formEgitmenler.Egitmen.Uzmanlik;
                }
            }  
        }

        private void btnEgitmenSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewEgitmenler.SelectedRows[0];

            var Kimlik = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show(
                "Seçili kayıt silinsin mi?",
                "Silmeyi onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
             );

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.EgitmenSil(Kimlik);

                if (b)
                {
                    DataSet ds = BLogic.EgitmenGetir("");
                    if (ds != null)
                        dataGridViewEgitmenler.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnEgitmenBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.EgitmenGetir(toolStripTextBoxEgitmen.Text);
            if (ds != null)
                dataGridViewEgitmenler.DataSource = ds.Tables[0];
        }

        private void EGITMENLER_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.EgitmenGetir("");
            if (ds != null)
                dataGridViewEgitmenler.DataSource = ds.Tables[0];
        }

        public Egitmenler Egitmen { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewEgitmenler.SelectedRows[0];

            Egitmen = new Egitmenler()
            {
                Kimlik   = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad       = row.Cells[1].Value.ToString(),
                Soyad    = row.Cells[2].Value.ToString(),
                Eposta   = row.Cells[3].Value.ToString(),
                Uzmanlik = row.Cells[4].Value.ToString(),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        
    }
}
