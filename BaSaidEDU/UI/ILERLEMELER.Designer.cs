namespace BaSaidEDU.UI
{
    partial class ILERLEMELER
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
            this.tabControlILERLEME = new System.Windows.Forms.TabControl();
            this.tabPageILERLEME = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStripKURSLAR = new System.Windows.Forms.ToolStrip();
            this.btnILERLEMEekle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorEgitmenler = new System.Windows.Forms.ToolStripSeparator();
            this.btnILERLEMEduzenle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnILERLEMEsil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnILERLEMEbul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxILERLEME = new System.Windows.Forms.ToolStripTextBox();
            this.labelILERLEMEara = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewILERLEME = new System.Windows.Forms.DataGridView();
            this.tabControlILERLEME.SuspendLayout();
            this.tabPageILERLEME.SuspendLayout();
            this.toolStripKURSLAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewILERLEME)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlILERLEME
            // 
            this.tabControlILERLEME.Controls.Add(this.tabPageILERLEME);
            this.tabControlILERLEME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlILERLEME.Location = new System.Drawing.Point(0, 0);
            this.tabControlILERLEME.Name = "tabControlILERLEME";
            this.tabControlILERLEME.SelectedIndex = 0;
            this.tabControlILERLEME.Size = new System.Drawing.Size(832, 473);
            this.tabControlILERLEME.TabIndex = 4;
            // 
            // tabPageILERLEME
            // 
            this.tabPageILERLEME.Controls.Add(this.dataGridViewILERLEME);
            this.tabPageILERLEME.Controls.Add(this.btnOk);
            this.tabPageILERLEME.Controls.Add(this.btnCancel);
            this.tabPageILERLEME.Controls.Add(this.toolStripKURSLAR);
            this.tabPageILERLEME.Location = new System.Drawing.Point(4, 25);
            this.tabPageILERLEME.Name = "tabPageILERLEME";
            this.tabPageILERLEME.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageILERLEME.Size = new System.Drawing.Size(824, 444);
            this.tabPageILERLEME.TabIndex = 1;
            this.tabPageILERLEME.Text = "İlerleme Takipçesi";
            this.tabPageILERLEME.UseVisualStyleBackColor = true;
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
            // toolStripKURSLAR
            // 
            this.toolStripKURSLAR.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripKURSLAR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnILERLEMEekle,
            this.toolStripSeparatorEgitmenler,
            this.btnILERLEMEduzenle,
            this.toolStripSeparator1,
            this.btnILERLEMEsil,
            this.toolStripSeparator2,
            this.btnILERLEMEbul,
            this.toolStripTextBoxILERLEME,
            this.labelILERLEMEara});
            this.toolStripKURSLAR.Location = new System.Drawing.Point(3, 3);
            this.toolStripKURSLAR.Name = "toolStripKURSLAR";
            this.toolStripKURSLAR.Size = new System.Drawing.Size(818, 31);
            this.toolStripKURSLAR.TabIndex = 4;
            this.toolStripKURSLAR.Text = "Kurslar Tool Strip";
            // 
            // btnILERLEMEekle
            // 
            this.btnILERLEMEekle.Image = global::BaSaidEDU.Properties.Resources.dashboard_add;
            this.btnILERLEMEekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnILERLEMEekle.Name = "btnILERLEMEekle";
            this.btnILERLEMEekle.Size = new System.Drawing.Size(64, 28);
            this.btnILERLEMEekle.Text = "Ekle";
            this.btnILERLEMEekle.Click += new System.EventHandler(this.btnILERLEMEekle_Click);
            // 
            // toolStripSeparatorEgitmenler
            // 
            this.toolStripSeparatorEgitmenler.Name = "toolStripSeparatorEgitmenler";
            this.toolStripSeparatorEgitmenler.Size = new System.Drawing.Size(6, 31);
            // 
            // btnILERLEMEduzenle
            // 
            this.btnILERLEMEduzenle.Image = global::BaSaidEDU.Properties.Resources.dashboard_edit;
            this.btnILERLEMEduzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnILERLEMEduzenle.Name = "btnILERLEMEduzenle";
            this.btnILERLEMEduzenle.Size = new System.Drawing.Size(91, 28);
            this.btnILERLEMEduzenle.Text = "Düzenle";
            this.btnILERLEMEduzenle.Click += new System.EventHandler(this.btnILERLEMEduzenle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnILERLEMEsil
            // 
            this.btnILERLEMEsil.Image = global::BaSaidEDU.Properties.Resources.dashboard_remove;
            this.btnILERLEMEsil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnILERLEMEsil.Name = "btnILERLEMEsil";
            this.btnILERLEMEsil.Size = new System.Drawing.Size(53, 28);
            this.btnILERLEMEsil.Text = "Sil";
            this.btnILERLEMEsil.Click += new System.EventHandler(this.btnILERLEMEsil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnILERLEMEbul
            // 
            this.btnILERLEMEbul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnILERLEMEbul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnILERLEMEbul.Image = global::BaSaidEDU.Properties.Resources.dashboard_search;
            this.btnILERLEMEbul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnILERLEMEbul.Name = "btnILERLEMEbul";
            this.btnILERLEMEbul.Size = new System.Drawing.Size(29, 28);
            this.btnILERLEMEbul.Text = "Bul";
            this.btnILERLEMEbul.Click += new System.EventHandler(this.btnILERLEMEbul_Click);
            // 
            // toolStripTextBoxILERLEME
            // 
            this.toolStripTextBoxILERLEME.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxILERLEME.AutoSize = false;
            this.toolStripTextBoxILERLEME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxILERLEME.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxILERLEME.Name = "toolStripTextBoxILERLEME";
            this.toolStripTextBoxILERLEME.Size = new System.Drawing.Size(200, 27);
            // 
            // labelILERLEMEara
            // 
            this.labelILERLEMEara.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelILERLEMEara.Name = "labelILERLEMEara";
            this.labelILERLEMEara.Size = new System.Drawing.Size(32, 28);
            this.labelILERLEMEara.Text = "Ara";
            // 
            // dataGridViewILERLEME
            // 
            this.dataGridViewILERLEME.AllowUserToAddRows = false;
            this.dataGridViewILERLEME.AllowUserToDeleteRows = false;
            this.dataGridViewILERLEME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewILERLEME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewILERLEME.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewILERLEME.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewILERLEME.MultiSelect = false;
            this.dataGridViewILERLEME.Name = "dataGridViewILERLEME";
            this.dataGridViewILERLEME.RowHeadersWidth = 51;
            this.dataGridViewILERLEME.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewILERLEME.RowTemplate.Height = 24;
            this.dataGridViewILERLEME.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewILERLEME.Size = new System.Drawing.Size(818, 355);
            this.dataGridViewILERLEME.TabIndex = 14;
            // 
            // ILERLEMELER
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.tabControlILERLEME);
            this.Name = "ILERLEMELER";
            this.Text = "ILERLEMELER";
            this.Load += new System.EventHandler(this.ILERLEMELER_Load);
            this.tabControlILERLEME.ResumeLayout(false);
            this.tabPageILERLEME.ResumeLayout(false);
            this.tabPageILERLEME.PerformLayout();
            this.toolStripKURSLAR.ResumeLayout(false);
            this.toolStripKURSLAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewILERLEME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlILERLEME;
        private System.Windows.Forms.TabPage tabPageILERLEME;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip toolStripKURSLAR;
        private System.Windows.Forms.ToolStripButton btnILERLEMEekle;
        private System.Windows.Forms.ToolStripButton btnILERLEMEduzenle;
        private System.Windows.Forms.ToolStripButton btnILERLEMEsil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorEgitmenler;
        private System.Windows.Forms.ToolStripButton btnILERLEMEbul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxILERLEME;
        private System.Windows.Forms.ToolStripLabel labelILERLEMEara;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridViewILERLEME;
    }
}