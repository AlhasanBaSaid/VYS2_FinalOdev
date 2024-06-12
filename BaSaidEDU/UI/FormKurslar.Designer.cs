namespace BaSaidEDU.UI
{
    partial class FormKurslar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.Aciklama = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.Kimlik = new System.Windows.Forms.Label();
            this.errorProviderKurslar = new System.Windows.Forms.ErrorProvider(this.components);
            this.EgitmenKimlik = new System.Windows.Forms.Label();
            this.txtEgitmenKimlik = new System.Windows.Forms.TextBox();
            this.numericFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnEgitmenSec = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKurslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(170, 124);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAciklama.Size = new System.Drawing.Size(300, 66);
            this.txtAciklama.TabIndex = 4;
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSize = true;
            this.Aciklama.Location = new System.Drawing.Point(22, 127);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(102, 16);
            this.Aciklama.TabIndex = 18;
            this.Aciklama.Text = "Kurs Açıklaması";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Location = new System.Drawing.Point(22, 99);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(68, 16);
            this.Fiyat.TabIndex = 19;
            this.Fiyat.Text = "Kurs Fıyatı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(170, 68);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(300, 22);
            this.txtAd.TabIndex = 2;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(22, 71);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(56, 16);
            this.Ad.TabIndex = 21;
            this.Ad.Text = "Kurs Adı";
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(170, 12);
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.ReadOnly = true;
            this.txtKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtKimlik.TabIndex = 0;
            this.txtKimlik.TabStop = false;
            // 
            // Kimlik
            // 
            this.Kimlik.AutoSize = true;
            this.Kimlik.Location = new System.Drawing.Point(22, 15);
            this.Kimlik.Name = "Kimlik";
            this.Kimlik.Size = new System.Drawing.Size(75, 16);
            this.Kimlik.TabIndex = 22;
            this.Kimlik.Text = "Kurs Kimliği";
            // 
            // errorProviderKurslar
            // 
            this.errorProviderKurslar.ContainerControl = this;
            // 
            // EgitmenKimlik
            // 
            this.EgitmenKimlik.AutoSize = true;
            this.EgitmenKimlik.Location = new System.Drawing.Point(22, 43);
            this.EgitmenKimlik.Name = "EgitmenKimlik";
            this.EgitmenKimlik.Size = new System.Drawing.Size(98, 16);
            this.EgitmenKimlik.TabIndex = 22;
            this.EgitmenKimlik.Text = "Eğitmen Kimliği";
            // 
            // txtEgitmenKimlik
            // 
            this.txtEgitmenKimlik.Location = new System.Drawing.Point(170, 40);
            this.txtEgitmenKimlik.Name = "txtEgitmenKimlik";
            this.txtEgitmenKimlik.ReadOnly = true;
            this.txtEgitmenKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtEgitmenKimlik.TabIndex = 1;
            this.txtEgitmenKimlik.TabStop = false;
            // 
            // numericFiyat
            // 
            this.numericFiyat.Location = new System.Drawing.Point(170, 96);
            this.numericFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFiyat.Name = "numericFiyat";
            this.numericFiyat.Size = new System.Drawing.Size(300, 22);
            this.numericFiyat.TabIndex = 3;
            // 
            // btnEgitmenSec
            // 
            this.btnEgitmenSec.Image = global::BaSaidEDU.Properties.Resources.database_user;
            this.btnEgitmenSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEgitmenSec.Location = new System.Drawing.Point(495, 36);
            this.btnEgitmenSec.Name = "btnEgitmenSec";
            this.btnEgitmenSec.Size = new System.Drawing.Size(125, 30);
            this.btnEgitmenSec.TabIndex = 24;
            this.btnEgitmenSec.Text = "Eğitmen Seç";
            this.btnEgitmenSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEgitmenSec.UseVisualStyleBackColor = true;
            this.btnEgitmenSec.Click += new System.EventHandler(this.btnEgitmenSec_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::BaSaidEDU.Properties.Resources.button_ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(404, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 35);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Tamam";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::BaSaidEDU.Properties.Resources.button_cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(515, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormKurslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEgitmenSec);
            this.Controls.Add(this.numericFiyat);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.txtEgitmenKimlik);
            this.Controls.Add(this.EgitmenKimlik);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.Kimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormKurslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kurslar Formu";
            this.Load += new System.EventHandler(this.FormKurslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKurslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label Aciklama;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label Kimlik;
        private System.Windows.Forms.ErrorProvider errorProviderKurslar;
        private System.Windows.Forms.TextBox txtEgitmenKimlik;
        private System.Windows.Forms.Label EgitmenKimlik;
        private System.Windows.Forms.NumericUpDown numericFiyat;
        private System.Windows.Forms.Button btnEgitmenSec;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}