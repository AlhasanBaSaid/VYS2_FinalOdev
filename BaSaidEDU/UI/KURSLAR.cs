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
    public partial class KURSLAR : Form
    {
        public KURSLAR()
        {
            InitializeComponent();
        }

        private void btnKURSLARekle_Click(object sender, EventArgs e)
        {
            FormKurslar formKurslar = new FormKurslar()
            {
                Text = "Kurs Ekle",
                Kurs = new Kurslar()
                {
                    Kimlik = Guid.NewGuid()
                },
            };

        tekrar:
            var sonuc = formKurslar.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KursEkle(formKurslar.Kurs);

                if (b)
                {
                    DataSet ds = BLogic.KursGetir("");
                    if (ds != null)
                        dataGridViewKURSLAR.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnKURSLARduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKURSLAR.SelectedRows[0];

            FormKurslar formKurslar = new FormKurslar()
            {
                Text = "Kurs Düzenle",
                Updating = true,
                Kurs = new Kurslar()
                {
                    Kimlik         = Guid.Parse(row.Cells[0].Value.ToString()),
                    EgitmenKimlik  = Guid.Parse(row.Cells[1].Value.ToString()),
                    Ad             = row.Cells[2].Value.ToString(),
                    Aciklama       = row.Cells[3].Value.ToString(),
                    Fiyat          = float.Parse(row.Cells[4].Value.ToString()),
                },
            };

            var sonuc = formKurslar.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KursGuncelle(formKurslar.Kurs);

                if (b)
                {
                    row.Cells[1].Value = formKurslar.Kurs.EgitmenKimlik;
                    row.Cells[2].Value = formKurslar.Kurs.Ad;
                    row.Cells[3].Value = formKurslar.Kurs.Aciklama;
                    row.Cells[4].Value = formKurslar.Kurs.Fiyat;  
                }
            }
        }

        private void btnKURSLARsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKURSLAR.SelectedRows[0];

            var Kimlik = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show(
                "Seçili kayıt silinsin mi?",
                "Silmeyi onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
             );

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KursSil(Kimlik);

                if (b)
                {
                    DataSet ds = BLogic.KursGetir("");
                    if (ds != null)
                        dataGridViewKURSLAR.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnKURSLARbul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KursGetir(toolStripTextBoxKURSLAR.Text);
            if (ds != null)
                dataGridViewKURSLAR.DataSource = ds.Tables[0];
        }

        private void KURSLAR_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KursGetir("");
            if (ds != null)
                dataGridViewKURSLAR.DataSource = ds.Tables[0];
        }

        public Kurslar Kurs { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewKURSLAR.SelectedRows[0];

            Kurs = new Kurslar()
            {
                Kimlik        = Guid.Parse(row.Cells[0].Value.ToString()),
                EgitmenKimlik = Guid.Parse(row.Cells[1].Value.ToString()),
                Ad            = row.Cells[2].Value.ToString(),
                Aciklama      = row.Cells[3].Value.ToString(),
                Fiyat         = float.Parse(row.Cells[4].Value.ToString()),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
