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
    public partial class ILERLEMELER : Form
    {
        public ILERLEMELER()
        {
            InitializeComponent();
        }

        private void btnILERLEMEekle_Click(object sender, EventArgs e)
        {
            FormIlerlemeTakipcesi formIlerlemeler = new FormIlerlemeTakipcesi()
            {
                Text = "İlerleme Takipi Ekle",
                Ilerleme = new IlerlemeTakipcisi()
                {
                    Kimlik = Guid.NewGuid()
                },
            };

        tekrar:
            var sonuc = formIlerlemeler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.IlerlemeEkle(formIlerlemeler.Ilerleme);

                if (b)
                {
                    DataSet ds = BLogic.IlerlemeGetir("");
                    if (ds != null)
                        dataGridViewILERLEME.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnILERLEMEduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewILERLEME.SelectedRows[0];

            FormIlerlemeTakipcesi formIlerlemeler = new FormIlerlemeTakipcesi()
            {
                Text = "Ilerleme Düzenle",
                Updating = true,
                Ilerleme = new IlerlemeTakipcisi()
                {
                    Kimlik            = Guid.Parse(row.Cells[0].Value.ToString()),
                    OgrenciKimlik     = Guid.Parse(row.Cells[1].Value.ToString()),
                    KursKimlik        = Guid.Parse(row.Cells[2].Value.ToString()),
                    TamamlanmaYuzdesi = float.Parse(row.Cells[3].Value.ToString()),
                },
            };

            var sonuc = formIlerlemeler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.IlerlemeGuncelle(formIlerlemeler.Ilerleme);

                if (b)
                {
                    row.Cells[1].Value = formIlerlemeler.Ilerleme.OgrenciKimlik;
                    row.Cells[2].Value = formIlerlemeler.Ilerleme.KursKimlik;
                    row.Cells[3].Value = formIlerlemeler.Ilerleme.TamamlanmaYuzdesi;
                }
            }
        }

        private void btnILERLEMEsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewILERLEME.SelectedRows[0];

            var Kimlik = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show(
                "Seçili kayıt silinsin mi?",
                "Silmeyi onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
             );

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.IlerlemeSil(Kimlik);

                if (b)
                {
                    DataSet ds = BLogic.IlerlemeGetir("");
                    if (ds != null)
                        dataGridViewILERLEME.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnILERLEMEbul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.IlerlemeGetir(toolStripTextBoxILERLEME.Text);
            if (ds != null)
                dataGridViewILERLEME.DataSource = ds.Tables[0];
        }

        private void ILERLEMELER_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.IlerlemeGetir("");
            if (ds != null)
                dataGridViewILERLEME.DataSource = ds.Tables[0];
        }

        public IlerlemeTakipcisi Ilerleme { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewILERLEME.SelectedRows[0];

            Ilerleme = new IlerlemeTakipcisi()
            {
                Kimlik            = Guid.Parse(row.Cells[0].Value.ToString()),
                OgrenciKimlik     = Guid.Parse(row.Cells[1].Value.ToString()),
                KursKimlik        = Guid.Parse(row.Cells[2].Value.ToString()),
                TamamlanmaYuzdesi = float.Parse(row.Cells[3].Value.ToString()),
            };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
