namespace BaSaidEDU.UI
{
    partial class EGITMENLER
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
            this.tabControlEGITMEN = new System.Windows.Forms.TabControl();
            this.tabPageEgitmen = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStripEgitmenler = new System.Windows.Forms.ToolStrip();
            this.btnEgitmenEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorEgitmenler = new System.Windows.Forms.ToolStripSeparator();
            this.btnEgitmenDuzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEgitmenSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEgitmenBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxEgitmen = new System.Windows.Forms.ToolStripTextBox();
            this.labelEgitmenAra = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewEgitmenler = new System.Windows.Forms.DataGridView();
            this.tabControlEGITMEN.SuspendLayout();
            this.tabPageEgitmen.SuspendLayout();
            this.toolStripEgitmenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEgitmenler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEGITMEN
            // 
            this.tabControlEGITMEN.Controls.Add(this.tabPageEgitmen);
            this.tabControlEGITMEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEGITMEN.Location = new System.Drawing.Point(0, 0);
            this.tabControlEGITMEN.Name = "tabControlEGITMEN";
            this.tabControlEGITMEN.SelectedIndex = 0;
            this.tabControlEGITMEN.Size = new System.Drawing.Size(832, 473);
            this.tabControlEGITMEN.TabIndex = 5;
            // 
            // tabPageEgitmen
            // 
            this.tabPageEgitmen.Controls.Add(this.dataGridViewEgitmenler);
            this.tabPageEgitmen.Controls.Add(this.btnOk);
            this.tabPageEgitmen.Controls.Add(this.btnCancel);
            this.tabPageEgitmen.Controls.Add(this.toolStripEgitmenler);
            this.tabPageEgitmen.Location = new System.Drawing.Point(4, 25);
            this.tabPageEgitmen.Name = "tabPageEgitmen";
            this.tabPageEgitmen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEgitmen.Size = new System.Drawing.Size(824, 444);
            this.tabPageEgitmen.TabIndex = 1;
            this.tabPageEgitmen.Text = "Eğitmenler";
            this.tabPageEgitmen.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::BaSaidEDU.Properties.Resources.button_ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(610, 406);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 9;
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
            this.btnCancel.Location = new System.Drawing.Point(716, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripEgitmenler
            // 
            this.toolStripEgitmenler.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripEgitmenler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEgitmenEkle,
            this.toolStripSeparatorEgitmenler,
            this.btnEgitmenDuzenle,
            this.toolStripSeparator1,
            this.btnEgitmenSil,
            this.toolStripSeparator2,
            this.btnEgitmenBul,
            this.toolStripTextBoxEgitmen,
            this.labelEgitmenAra});
            this.toolStripEgitmenler.Location = new System.Drawing.Point(3, 3);
            this.toolStripEgitmenler.Name = "toolStripEgitmenler";
            this.toolStripEgitmenler.Size = new System.Drawing.Size(818, 31);
            this.toolStripEgitmenler.TabIndex = 4;
            this.toolStripEgitmenler.Text = "Kurslar Tool Strip";
            // 
            // btnEgitmenEkle
            // 
            this.btnEgitmenEkle.Image = global::BaSaidEDU.Properties.Resources.database_user_add;
            this.btnEgitmenEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEgitmenEkle.Name = "btnEgitmenEkle";
            this.btnEgitmenEkle.Size = new System.Drawing.Size(64, 28);
            this.btnEgitmenEkle.Text = "Ekle";
            this.btnEgitmenEkle.Click += new System.EventHandler(this.btnEgitmenEkle_Click);
            // 
            // toolStripSeparatorEgitmenler
            // 
            this.toolStripSeparatorEgitmenler.Name = "toolStripSeparatorEgitmenler";
            this.toolStripSeparatorEgitmenler.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEgitmenDuzenle
            // 
            this.btnEgitmenDuzenle.Image = global::BaSaidEDU.Properties.Resources.database_user_edit;
            this.btnEgitmenDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEgitmenDuzenle.Name = "btnEgitmenDuzenle";
            this.btnEgitmenDuzenle.Size = new System.Drawing.Size(91, 28);
            this.btnEgitmenDuzenle.Text = "Düzenle";
            this.btnEgitmenDuzenle.Click += new System.EventHandler(this.btnEgitmenDuzenle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEgitmenSil
            // 
            this.btnEgitmenSil.Image = global::BaSaidEDU.Properties.Resources.database_user_remove;
            this.btnEgitmenSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEgitmenSil.Name = "btnEgitmenSil";
            this.btnEgitmenSil.Size = new System.Drawing.Size(53, 28);
            this.btnEgitmenSil.Text = "Sil";
            this.btnEgitmenSil.Click += new System.EventHandler(this.btnEgitmenSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnEgitmenBul
            // 
            this.btnEgitmenBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEgitmenBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEgitmenBul.Image = global::BaSaidEDU.Properties.Resources.database_user_search;
            this.btnEgitmenBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEgitmenBul.Name = "btnEgitmenBul";
            this.btnEgitmenBul.Size = new System.Drawing.Size(29, 28);
            this.btnEgitmenBul.Text = "Bul";
            this.btnEgitmenBul.Click += new System.EventHandler(this.btnEgitmenBul_Click);
            // 
            // toolStripTextBoxEgitmen
            // 
            this.toolStripTextBoxEgitmen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxEgitmen.AutoSize = false;
            this.toolStripTextBoxEgitmen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxEgitmen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxEgitmen.Name = "toolStripTextBoxEgitmen";
            this.toolStripTextBoxEgitmen.Size = new System.Drawing.Size(200, 27);
            // 
            // labelEgitmenAra
            // 
            this.labelEgitmenAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelEgitmenAra.Name = "labelEgitmenAra";
            this.labelEgitmenAra.Size = new System.Drawing.Size(32, 28);
            this.labelEgitmenAra.Text = "Ara";
            // 
            // dataGridViewEgitmenler
            // 
            this.dataGridViewEgitmenler.AllowUserToAddRows = false;
            this.dataGridViewEgitmenler.AllowUserToDeleteRows = false;
            this.dataGridViewEgitmenler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEgitmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEgitmenler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEgitmenler.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewEgitmenler.MultiSelect = false;
            this.dataGridViewEgitmenler.Name = "dataGridViewEgitmenler";
            this.dataGridViewEgitmenler.RowHeadersWidth = 51;
            this.dataGridViewEgitmenler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEgitmenler.RowTemplate.Height = 24;
            this.dataGridViewEgitmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEgitmenler.Size = new System.Drawing.Size(818, 355);
            this.dataGridViewEgitmenler.TabIndex = 13;
            // 
            // EGITMENLER
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.tabControlEGITMEN);
            this.Name = "EGITMENLER";
            this.Text = "Eğitmenler";
            this.Load += new System.EventHandler(this.EGITMENLER_Load);
            this.Click += new System.EventHandler(this.EGITMENLER_Load);
            this.tabControlEGITMEN.ResumeLayout(false);
            this.tabPageEgitmen.ResumeLayout(false);
            this.tabPageEgitmen.PerformLayout();
            this.toolStripEgitmenler.ResumeLayout(false);
            this.toolStripEgitmenler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEgitmenler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEGITMEN;
        private System.Windows.Forms.TabPage tabPageEgitmen;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip toolStripEgitmenler;
        private System.Windows.Forms.ToolStripButton btnEgitmenEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorEgitmenler;
        private System.Windows.Forms.ToolStripButton btnEgitmenDuzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEgitmenSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEgitmenBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxEgitmen;
        private System.Windows.Forms.ToolStripLabel labelEgitmenAra;
        private System.Windows.Forms.DataGridView dataGridViewEgitmenler;
    }
}