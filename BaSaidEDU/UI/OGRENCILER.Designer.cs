namespace BaSaidEDU.UI
{
    partial class OGRENCILER
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
            this.tabPageOgrenciler = new System.Windows.Forms.TabPage();
            this.toolStripOgrenciler = new System.Windows.Forms.ToolStrip();
            this.btnOgrenciEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorOgrenciler = new System.Windows.Forms.ToolStripSeparator();
            this.btnOgrenciDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOgrenciSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOgrenciBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxOgrenci = new System.Windows.Forms.ToolStripTextBox();
            this.labelOgrenciAra = new System.Windows.Forms.ToolStripLabel();
            this.tabControlOgrenciler = new System.Windows.Forms.TabControl();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewOgrenciler = new System.Windows.Forms.DataGridView();
            this.tabPageOgrenciler.SuspendLayout();
            this.toolStripOgrenciler.SuspendLayout();
            this.tabControlOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageOgrenciler
            // 
            this.tabPageOgrenciler.Controls.Add(this.dataGridViewOgrenciler);
            this.tabPageOgrenciler.Controls.Add(this.toolStripOgrenciler);
            this.tabPageOgrenciler.Location = new System.Drawing.Point(4, 25);
            this.tabPageOgrenciler.Name = "tabPageOgrenciler";
            this.tabPageOgrenciler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgrenciler.Size = new System.Drawing.Size(824, 444);
            this.tabPageOgrenciler.TabIndex = 0;
            this.tabPageOgrenciler.Text = "Öğrenciler";
            this.tabPageOgrenciler.UseVisualStyleBackColor = true;
            // 
            // toolStripOgrenciler
            // 
            this.toolStripOgrenciler.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripOgrenciler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOgrenciEkle,
            this.toolStripSeparatorOgrenciler,
            this.btnOgrenciDuzenle,
            this.toolStripSeparator1,
            this.btnOgrenciSil,
            this.toolStripSeparator2,
            this.btnOgrenciBul,
            this.toolStripTextBoxOgrenci,
            this.labelOgrenciAra});
            this.toolStripOgrenciler.Location = new System.Drawing.Point(3, 3);
            this.toolStripOgrenciler.Name = "toolStripOgrenciler";
            this.toolStripOgrenciler.Size = new System.Drawing.Size(818, 31);
            this.toolStripOgrenciler.TabIndex = 1;
            this.toolStripOgrenciler.Text = "Öğrenciler Tool Strip";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Image = global::BaSaidEDU.Properties.Resources.database_user_add;
            this.btnOgrenciEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(64, 28);
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // toolStripSeparatorOgrenciler
            // 
            this.toolStripSeparatorOgrenciler.Name = "toolStripSeparatorOgrenciler";
            this.toolStripSeparatorOgrenciler.Size = new System.Drawing.Size(6, 31);
            // 
            // btnOgrenciDuzenle
            // 
            this.btnOgrenciDuzenle.Image = global::BaSaidEDU.Properties.Resources.database_user_edit;
            this.btnOgrenciDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOgrenciDuzenle.Name = "btnOgrenciDuzenle";
            this.btnOgrenciDuzenle.Size = new System.Drawing.Size(91, 28);
            this.btnOgrenciDuzenle.Text = "Düzenle";
            this.btnOgrenciDuzenle.Click += new System.EventHandler(this.btnOgrenciDuzenle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Image = global::BaSaidEDU.Properties.Resources.database_user_remove;
            this.btnOgrenciSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(53, 28);
            this.btnOgrenciSil.Text = "Sil";
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnOgrenciBul
            // 
            this.btnOgrenciBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOgrenciBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOgrenciBul.Image = global::BaSaidEDU.Properties.Resources.database_user_search;
            this.btnOgrenciBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOgrenciBul.Name = "btnOgrenciBul";
            this.btnOgrenciBul.Size = new System.Drawing.Size(29, 28);
            this.btnOgrenciBul.Text = "Bul";
            this.btnOgrenciBul.Click += new System.EventHandler(this.btnOgrenciBul_Click);
            // 
            // toolStripTextBoxOgrenci
            // 
            this.toolStripTextBoxOgrenci.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxOgrenci.AutoSize = false;
            this.toolStripTextBoxOgrenci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxOgrenci.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxOgrenci.Name = "toolStripTextBoxOgrenci";
            this.toolStripTextBoxOgrenci.Size = new System.Drawing.Size(200, 27);
            // 
            // labelOgrenciAra
            // 
            this.labelOgrenciAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelOgrenciAra.Name = "labelOgrenciAra";
            this.labelOgrenciAra.Size = new System.Drawing.Size(32, 28);
            this.labelOgrenciAra.Text = "Ara";
            // 
            // tabControlOgrenciler
            // 
            this.tabControlOgrenciler.Controls.Add(this.tabPageOgrenciler);
            this.tabControlOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOgrenciler.Location = new System.Drawing.Point(0, 0);
            this.tabControlOgrenciler.Name = "tabControlOgrenciler";
            this.tabControlOgrenciler.SelectedIndex = 0;
            this.tabControlOgrenciler.Size = new System.Drawing.Size(832, 473);
            this.tabControlOgrenciler.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::BaSaidEDU.Properties.Resources.button_ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(614, 431);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Tamam";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::BaSaidEDU.Properties.Resources.button_cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(720, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridViewOgrenciler
            // 
            this.dataGridViewOgrenciler.AllowUserToAddRows = false;
            this.dataGridViewOgrenciler.AllowUserToDeleteRows = false;
            this.dataGridViewOgrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenciler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOgrenciler.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewOgrenciler.MultiSelect = false;
            this.dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            this.dataGridViewOgrenciler.RowHeadersWidth = 51;
            this.dataGridViewOgrenciler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOgrenciler.RowTemplate.Height = 24;
            this.dataGridViewOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgrenciler.Size = new System.Drawing.Size(818, 355);
            this.dataGridViewOgrenciler.TabIndex = 12;
            // 
            // OGRENCILER
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControlOgrenciler);
            this.Name = "OGRENCILER";
            this.Text = "Öğrenciler";
            this.Load += new System.EventHandler(this.OGRENCILER_Load);
            this.tabPageOgrenciler.ResumeLayout(false);
            this.tabPageOgrenciler.PerformLayout();
            this.toolStripOgrenciler.ResumeLayout(false);
            this.toolStripOgrenciler.PerformLayout();
            this.tabControlOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageOgrenciler;
        private System.Windows.Forms.TabControl tabControlOgrenciler;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip toolStripOgrenciler;
        private System.Windows.Forms.ToolStripButton btnOgrenciEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOgrenciler;
        private System.Windows.Forms.ToolStripButton btnOgrenciDuzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOgrenciSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnOgrenciBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxOgrenci;
        private System.Windows.Forms.ToolStripLabel labelOgrenciAra;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciler;
    }
}