namespace BaSaidEDU.UI
{
    partial class FormIlerlemeTakipcesi
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
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.Kimlik = new System.Windows.Forms.Label();
            this.errorProviderIlerleme = new System.Windows.Forms.ErrorProvider(this.components);
            this.TamamlanmaYuzdesi = new System.Windows.Forms.Label();
            this.txtKursKimlik = new System.Windows.Forms.TextBox();
            this.KursKimlik = new System.Windows.Forms.Label();
            this.txtOgrenciKimlik = new System.Windows.Forms.TextBox();
            this.OgrenciKimlik = new System.Windows.Forms.Label();
            this.numericTamamlanmaYuzdesi = new System.Windows.Forms.NumericUpDown();
            this.btnOgrenciSec = new System.Windows.Forms.Button();
            this.btnKursSec = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIlerleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTamamlanmaYuzdesi)).BeginInit();
            this.SuspendLayout();
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
            this.Kimlik.Size = new System.Drawing.Size(97, 16);
            this.Kimlik.TabIndex = 42;
            this.Kimlik.Text = "İlerleme Kimliği";
            // 
            // errorProviderIlerleme
            // 
            this.errorProviderIlerleme.ContainerControl = this;
            // 
            // TamamlanmaYuzdesi
            // 
            this.TamamlanmaYuzdesi.AutoSize = true;
            this.TamamlanmaYuzdesi.Location = new System.Drawing.Point(22, 99);
            this.TamamlanmaYuzdesi.Name = "TamamlanmaYuzdesi";
            this.TamamlanmaYuzdesi.Size = new System.Drawing.Size(142, 16);
            this.TamamlanmaYuzdesi.TabIndex = 41;
            this.TamamlanmaYuzdesi.Text = "Tamamlanma Yüzdesi";
            // 
            // txtKursKimlik
            // 
            this.txtKursKimlik.Location = new System.Drawing.Point(170, 68);
            this.txtKursKimlik.Name = "txtKursKimlik";
            this.txtKursKimlik.ReadOnly = true;
            this.txtKursKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtKursKimlik.TabIndex = 2;
            this.txtKursKimlik.TabStop = false;
            // 
            // KursKimlik
            // 
            this.KursKimlik.AutoSize = true;
            this.KursKimlik.Location = new System.Drawing.Point(22, 71);
            this.KursKimlik.Name = "KursKimlik";
            this.KursKimlik.Size = new System.Drawing.Size(75, 16);
            this.KursKimlik.TabIndex = 43;
            this.KursKimlik.Text = "Kurs Kimliği";
            // 
            // txtOgrenciKimlik
            // 
            this.txtOgrenciKimlik.Location = new System.Drawing.Point(170, 40);
            this.txtOgrenciKimlik.Name = "txtOgrenciKimlik";
            this.txtOgrenciKimlik.ReadOnly = true;
            this.txtOgrenciKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtOgrenciKimlik.TabIndex = 1;
            this.txtOgrenciKimlik.TabStop = false;
            // 
            // OgrenciKimlik
            // 
            this.OgrenciKimlik.AutoSize = true;
            this.OgrenciKimlik.Location = new System.Drawing.Point(22, 43);
            this.OgrenciKimlik.Name = "OgrenciKimlik";
            this.OgrenciKimlik.Size = new System.Drawing.Size(96, 16);
            this.OgrenciKimlik.TabIndex = 44;
            this.OgrenciKimlik.Text = "Öğrenci Kimliği";
            // 
            // numericTamamlanmaYuzdesi
            // 
            this.numericTamamlanmaYuzdesi.DecimalPlaces = 2;
            this.numericTamamlanmaYuzdesi.Location = new System.Drawing.Point(170, 97);
            this.numericTamamlanmaYuzdesi.Name = "numericTamamlanmaYuzdesi";
            this.numericTamamlanmaYuzdesi.Size = new System.Drawing.Size(300, 22);
            this.numericTamamlanmaYuzdesi.TabIndex = 3;
            // 
            // btnOgrenciSec
            // 
            this.btnOgrenciSec.Image = global::BaSaidEDU.Properties.Resources.database_user;
            this.btnOgrenciSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOgrenciSec.Location = new System.Drawing.Point(495, 36);
            this.btnOgrenciSec.Name = "btnOgrenciSec";
            this.btnOgrenciSec.Size = new System.Drawing.Size(125, 30);
            this.btnOgrenciSec.TabIndex = 46;
            this.btnOgrenciSec.Text = "Oğrenci Seç";
            this.btnOgrenciSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciSec.UseVisualStyleBackColor = true;
            this.btnOgrenciSec.Click += new System.EventHandler(this.btnOgrenciSec_Click);
            // 
            // btnKursSec
            // 
            this.btnKursSec.Image = global::BaSaidEDU.Properties.Resources.book;
            this.btnKursSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKursSec.Location = new System.Drawing.Point(495, 64);
            this.btnKursSec.Name = "btnKursSec";
            this.btnKursSec.Size = new System.Drawing.Size(125, 30);
            this.btnKursSec.TabIndex = 47;
            this.btnKursSec.Text = "Kurs Seç";
            this.btnKursSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKursSec.UseVisualStyleBackColor = true;
            this.btnKursSec.Click += new System.EventHandler(this.btnKursSec_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::BaSaidEDU.Properties.Resources.button_ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(404, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 35);
            this.btnOk.TabIndex = 48;
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
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormIlerlemeTakipcesi
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnKursSec);
            this.Controls.Add(this.btnOgrenciSec);
            this.Controls.Add(this.numericTamamlanmaYuzdesi);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.Kimlik);
            this.Controls.Add(this.TamamlanmaYuzdesi);
            this.Controls.Add(this.txtKursKimlik);
            this.Controls.Add(this.KursKimlik);
            this.Controls.Add(this.txtOgrenciKimlik);
            this.Controls.Add(this.OgrenciKimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormIlerlemeTakipcesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İlerleme Takipçesi Formu";
            this.Load += new System.EventHandler(this.FormIlerlemeTakipcesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIlerleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTamamlanmaYuzdesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label Kimlik;
        private System.Windows.Forms.ErrorProvider errorProviderIlerleme;
        private System.Windows.Forms.Label TamamlanmaYuzdesi;
        private System.Windows.Forms.TextBox txtKursKimlik;
        private System.Windows.Forms.Label KursKimlik;
        private System.Windows.Forms.TextBox txtOgrenciKimlik;
        private System.Windows.Forms.Label OgrenciKimlik;
        private System.Windows.Forms.NumericUpDown numericTamamlanmaYuzdesi;
        private System.Windows.Forms.Button btnKursSec;
        private System.Windows.Forms.Button btnOgrenciSec;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}