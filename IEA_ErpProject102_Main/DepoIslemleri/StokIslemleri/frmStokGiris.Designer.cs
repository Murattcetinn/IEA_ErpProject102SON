
namespace IEA_ErpProject102_Main.DepoIslemleri.StokIslemleri
{
    partial class frmStokGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.txtUrnCombo = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.txtGirisTarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGirisTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCariGrup = new System.Windows.Forms.ComboBox();
            this.txtGenelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot_SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUst.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1102, 51);
            this.pnlUst.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(883, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(219, 51);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Form Cikis";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stok Giris Karti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAlt.Controls.Add(this.txtUrnCombo);
            this.pnlAlt.Controls.Add(this.btnTemizle);
            this.pnlAlt.Controls.Add(this.btnSil);
            this.pnlAlt.Controls.Add(this.btnGuncelle);
            this.pnlAlt.Controls.Add(this.btnKayit);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 529);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1102, 43);
            this.pnlAlt.TabIndex = 3;
            // 
            // txtUrnCombo
            // 
            this.txtUrnCombo.FormattingEnabled = true;
            this.txtUrnCombo.Location = new System.Drawing.Point(21, 12);
            this.txtUrnCombo.Name = "txtUrnCombo";
            this.txtUrnCombo.Size = new System.Drawing.Size(285, 24);
            this.txtUrnCombo.TabIndex = 4;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(669, 6);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 34);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(750, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 34);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(831, 6);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 34);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.Location = new System.Drawing.Point(927, 6);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(82, 34);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRight.Controls.Add(this.txtGirisTarih);
            this.pnlRight.Controls.Add(this.label8);
            this.pnlRight.Controls.Add(this.txtFaturaNo);
            this.pnlRight.Controls.Add(this.label7);
            this.pnlRight.Controls.Add(this.txtGirisTipi);
            this.pnlRight.Controls.Add(this.label6);
            this.pnlRight.Controls.Add(this.txtAciklama);
            this.pnlRight.Controls.Add(this.label5);
            this.pnlRight.Controls.Add(this.txtCariAdi);
            this.pnlRight.Controls.Add(this.label4);
            this.pnlRight.Controls.Add(this.txtCariGrup);
            this.pnlRight.Controls.Add(this.txtGenelNo);
            this.pnlRight.Controls.Add(this.label3);
            this.pnlRight.Controls.Add(this.label2);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(871, 51);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(231, 478);
            this.pnlRight.TabIndex = 4;
            // 
            // txtGirisTarih
            // 
            this.txtGirisTarih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGirisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtGirisTarih.Location = new System.Drawing.Point(0, 324);
            this.txtGirisTarih.Name = "txtGirisTarih";
            this.txtGirisTarih.Size = new System.Drawing.Size(232, 22);
            this.txtGirisTarih.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(-1, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Giris Tarih";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFaturaNo.Location = new System.Drawing.Point(1, 273);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(231, 22);
            this.txtFaturaNo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(1, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fatura No";
            // 
            // txtGirisTipi
            // 
            this.txtGirisTipi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGirisTipi.FormattingEnabled = true;
            this.txtGirisTipi.Items.AddRange(new object[] {
            "Normal Giris",
            "Muhtelif Giris"});
            this.txtGirisTipi.Location = new System.Drawing.Point(-2, 210);
            this.txtGirisTipi.Name = "txtGirisTipi";
            this.txtGirisTipi.Size = new System.Drawing.Size(234, 24);
            this.txtGirisTipi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(4, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giris Tipi";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(0, 391);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(231, 73);
            this.txtAciklama.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(0, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Aciklama";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariAdi.Location = new System.Drawing.Point(0, 134);
            this.txtCariAdi.Multiline = true;
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(231, 46);
            this.txtCariAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(-3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cari Adi";
            // 
            // txtCariGrup
            // 
            this.txtCariGrup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariGrup.FormattingEnabled = true;
            this.txtCariGrup.Location = new System.Drawing.Point(-3, 76);
            this.txtCariGrup.Name = "txtCariGrup";
            this.txtCariGrup.Size = new System.Drawing.Size(234, 24);
            this.txtCariGrup.TabIndex = 2;
            // 
            // txtGenelNo
            // 
            this.txtGenelNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGenelNo.Location = new System.Drawing.Point(0, 23);
            this.txtGenelNo.Name = "txtGenelNo";
            this.txtGenelNo.Size = new System.Drawing.Size(231, 22);
            this.txtGenelNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cari Grup";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genel No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(861, 51);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 478);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.barcode,
            this.Ukod,
            this.Lot_SeriNo,
            this.GAdet,
            this.Not,
            this.UTarih,
            this.SKTarih,
            this.AlisFiyat,
            this.Id});
            this.Liste.ContextMenuStrip = this.contextMenuStrip1;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 51);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(861, 478);
            this.Liste.TabIndex = 6;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 6;
            this.Sira.Name = "Sira";
            this.Sira.Width = 62;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barkod";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.Visible = false;
            this.barcode.Width = 125;
            // 
            // Ukod
            // 
            this.Ukod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ukod.HeaderText = "Urun Kodu";
            this.Ukod.MinimumWidth = 6;
            this.Ukod.Name = "Ukod";
            // 
            // Lot_SeriNo
            // 
            this.Lot_SeriNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lot_SeriNo.HeaderText = "Lot / Seri No";
            this.Lot_SeriNo.MinimumWidth = 6;
            this.Lot_SeriNo.Name = "Lot_SeriNo";
            this.Lot_SeriNo.Width = 91;
            // 
            // GAdet
            // 
            this.GAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GAdet.HeaderText = "Giris Adet";
            this.GAdet.MinimumWidth = 6;
            this.GAdet.Name = "GAdet";
            this.GAdet.Width = 91;
            // 
            // Not
            // 
            this.Not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Not.HeaderText = "Not";
            this.Not.MinimumWidth = 6;
            this.Not.Name = "Not";
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "-";
            this.UTarih.DefaultCellStyle = dataGridViewCellStyle1;
            this.UTarih.HeaderText = "UT";
            this.UTarih.MinimumWidth = 6;
            this.UTarih.Name = "UTarih";
            this.UTarih.Width = 56;
            // 
            // SKTarih
            // 
            this.SKTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "-";
            this.SKTarih.DefaultCellStyle = dataGridViewCellStyle2;
            this.SKTarih.HeaderText = "SKT";
            this.SKTarih.MinimumWidth = 6;
            this.SKTarih.Name = "SKTarih";
            this.SKTarih.Width = 64;
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AlisFiyat.HeaderText = "Alis Fiyati";
            this.AlisFiyat.MinimumWidth = 6;
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.Width = 89;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.guncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 82);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Image = global::IEA_ErpProject102_Main.Properties.Resources.Save24x24y;
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Image = global::IEA_ErpProject102_Main.Properties.Resources.Update24x24;
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.guncelleToolStripMenuItem.Text = "Guncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::IEA_ErpProject102_Main.Properties.Resources.Sil32x32;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // frmStokGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 572);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmStokGiris";
            this.Text = "frmStokGiris";
            this.Load += new System.EventHandler(this.frmStokGiris_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlAlt.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DateTimePicker txtGirisTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtGirisTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtCariGrup;
        private System.Windows.Forms.TextBox txtGenelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ComboBox txtUrnCombo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot_SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}