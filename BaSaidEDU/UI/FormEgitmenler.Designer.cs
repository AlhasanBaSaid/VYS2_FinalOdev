namespace BaSaidEDU.UI
{
    partial class FormEgitmenler
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.Eposta = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.Kimlik = new System.Windows.Forms.Label();
            this.Uzmanlik = new System.Windows.Forms.Label();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.errorProviderEgitmenler = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEgitmenler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::BaSaidEDU.Properties.Resources.button_ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(304, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 35);
            this.btnOk.TabIndex = 5;
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
            this.btnCancel.Location = new System.Drawing.Point(415, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(170, 96);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(300, 22);
            this.txtEposta.TabIndex = 3;
            // 
            // Eposta
            // 
            this.Eposta.AutoSize = true;
            this.Eposta.Location = new System.Drawing.Point(22, 99);
            this.Eposta.Name = "Eposta";
            this.Eposta.Size = new System.Drawing.Size(50, 16);
            this.Eposta.TabIndex = 6;
            this.Eposta.Text = "Eposta";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(170, 68);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(300, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(22, 71);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(47, 16);
            this.Soyad.TabIndex = 7;
            this.Soyad.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(170, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(300, 22);
            this.txtAd.TabIndex = 1;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(22, 43);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(24, 16);
            this.Ad.TabIndex = 8;
            this.Ad.Text = "Ad";
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(170, 12);
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.ReadOnly = true;
            this.txtKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtKimlik.TabIndex = 0;
            // 
            // Kimlik
            // 
            this.Kimlik.AutoSize = true;
            this.Kimlik.Location = new System.Drawing.Point(22, 15);
            this.Kimlik.Name = "Kimlik";
            this.Kimlik.Size = new System.Drawing.Size(42, 16);
            this.Kimlik.TabIndex = 10;
            this.Kimlik.Text = "Kimlik";
            // 
            // Uzmanlik
            // 
            this.Uzmanlik.AutoSize = true;
            this.Uzmanlik.Location = new System.Drawing.Point(22, 127);
            this.Uzmanlik.Name = "Uzmanlik";
            this.Uzmanlik.Size = new System.Drawing.Size(62, 16);
            this.Uzmanlik.TabIndex = 6;
            this.Uzmanlik.Text = "Uzmanlık";
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(170, 124);
            this.txtUzmanlik.Multiline = true;
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUzmanlik.Size = new System.Drawing.Size(300, 66);
            this.txtUzmanlik.TabIndex = 4;
            // 
            // errorProviderEgitmenler
            // 
            this.errorProviderEgitmenler.ContainerControl = this;
            // 
            // FormEgitmenler
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtUzmanlik);
            this.Controls.Add(this.Uzmanlik);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.Eposta);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.Kimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEgitmenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eğitmenler Formu";
            this.Load += new System.EventHandler(this.FormEgitmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEgitmenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label Eposta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label Kimlik;
        private System.Windows.Forms.Label Uzmanlik;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.ErrorProvider errorProviderEgitmenler;
    }
}