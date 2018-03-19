namespace PeminjamanBuku
{
    partial class fTambahBuku
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
            this.lTambahBuku = new System.Windows.Forms.Label();
            this.lJudul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDataBuku = new System.Windows.Forms.GroupBox();
            this.tboxTahun_Terbit = new System.Windows.Forms.TextBox();
            this.tboxISBN = new System.Windows.Forms.TextBox();
            this.tboxPenerbit = new System.Windows.Forms.TextBox();
            this.tboxPengarang = new System.Windows.Forms.TextBox();
            this.tboxJudul = new System.Windows.Forms.TextBox();
            this.tboxKode_Buku = new System.Windows.Forms.TextBox();
            this.lnibn = new System.Windows.Forms.Label();
            this.lTahunTerbitBuku = new System.Windows.Forms.Label();
            this.lKlasifikasi = new System.Windows.Forms.Label();
            this.lPenerbitBuku = new System.Windows.Forms.Label();
            this.lPengarang = new System.Windows.Forms.Label();
            this.lJudulBuku = new System.Windows.Forms.Label();
            this.lKodeBuku = new System.Windows.Forms.Label();
            this.gnTampilBuku = new System.Windows.Forms.GroupBox();
            this.dgvTampilBuku = new System.Windows.Forms.DataGridView();
            this.bBatal = new System.Windows.Forms.Button();
            this.bSimpan = new System.Windows.Forms.Button();
            this.tboxKlasifikasi = new System.Windows.Forms.TextBox();
            this.bShowAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbDataBuku.SuspendLayout();
            this.gnTampilBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // lTambahBuku
            // 
            this.lTambahBuku.AutoSize = true;
            this.lTambahBuku.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTambahBuku.Location = new System.Drawing.Point(354, 62);
            this.lTambahBuku.Name = "lTambahBuku";
            this.lTambahBuku.Size = new System.Drawing.Size(107, 22);
            this.lTambahBuku.TabIndex = 3;
            this.lTambahBuku.Text = "Tambah Buku";
            // 
            // lJudul
            // 
            this.lJudul.AutoSize = true;
            this.lJudul.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJudul.Location = new System.Drawing.Point(219, 14);
            this.lJudul.Name = "lJudul";
            this.lJudul.Size = new System.Drawing.Size(377, 36);
            this.lJudul.TabIndex = 2;
            this.lJudul.Text = "P E M I N J A M A N  B U K U";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTambahBuku);
            this.panel1.Controls.Add(this.lJudul);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 96);
            this.panel1.TabIndex = 2;
            // 
            // gbDataBuku
            // 
            this.gbDataBuku.Controls.Add(this.tboxKlasifikasi);
            this.gbDataBuku.Controls.Add(this.tboxTahun_Terbit);
            this.gbDataBuku.Controls.Add(this.tboxISBN);
            this.gbDataBuku.Controls.Add(this.tboxPenerbit);
            this.gbDataBuku.Controls.Add(this.tboxPengarang);
            this.gbDataBuku.Controls.Add(this.tboxJudul);
            this.gbDataBuku.Controls.Add(this.tboxKode_Buku);
            this.gbDataBuku.Controls.Add(this.lnibn);
            this.gbDataBuku.Controls.Add(this.lTahunTerbitBuku);
            this.gbDataBuku.Controls.Add(this.lKlasifikasi);
            this.gbDataBuku.Controls.Add(this.lPenerbitBuku);
            this.gbDataBuku.Controls.Add(this.lPengarang);
            this.gbDataBuku.Controls.Add(this.lJudulBuku);
            this.gbDataBuku.Controls.Add(this.lKodeBuku);
            this.gbDataBuku.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataBuku.Location = new System.Drawing.Point(12, 129);
            this.gbDataBuku.Name = "gbDataBuku";
            this.gbDataBuku.Size = new System.Drawing.Size(340, 240);
            this.gbDataBuku.TabIndex = 3;
            this.gbDataBuku.TabStop = false;
            this.gbDataBuku.Text = "Data Buku";
            // 
            // tboxTahun_Terbit
            // 
            this.tboxTahun_Terbit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTahun_Terbit.Location = new System.Drawing.Point(118, 164);
            this.tboxTahun_Terbit.Name = "tboxTahun_Terbit";
            this.tboxTahun_Terbit.Size = new System.Drawing.Size(196, 23);
            this.tboxTahun_Terbit.TabIndex = 12;
            // 
            // tboxISBN
            // 
            this.tboxISBN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxISBN.Location = new System.Drawing.Point(118, 136);
            this.tboxISBN.Name = "tboxISBN";
            this.tboxISBN.Size = new System.Drawing.Size(196, 23);
            this.tboxISBN.TabIndex = 11;
            // 
            // tboxPenerbit
            // 
            this.tboxPenerbit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPenerbit.Location = new System.Drawing.Point(118, 108);
            this.tboxPenerbit.Name = "tboxPenerbit";
            this.tboxPenerbit.Size = new System.Drawing.Size(196, 23);
            this.tboxPenerbit.TabIndex = 10;
            // 
            // tboxPengarang
            // 
            this.tboxPengarang.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPengarang.Location = new System.Drawing.Point(118, 80);
            this.tboxPengarang.Name = "tboxPengarang";
            this.tboxPengarang.Size = new System.Drawing.Size(196, 23);
            this.tboxPengarang.TabIndex = 9;
            // 
            // tboxJudul
            // 
            this.tboxJudul.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxJudul.Location = new System.Drawing.Point(118, 52);
            this.tboxJudul.Name = "tboxJudul";
            this.tboxJudul.Size = new System.Drawing.Size(196, 23);
            this.tboxJudul.TabIndex = 8;
            // 
            // tboxKode_Buku
            // 
            this.tboxKode_Buku.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxKode_Buku.Location = new System.Drawing.Point(118, 24);
            this.tboxKode_Buku.Name = "tboxKode_Buku";
            this.tboxKode_Buku.Size = new System.Drawing.Size(196, 23);
            this.tboxKode_Buku.TabIndex = 7;
            // 
            // lnibn
            // 
            this.lnibn.AutoSize = true;
            this.lnibn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnibn.Location = new System.Drawing.Point(6, 139);
            this.lnibn.Name = "lnibn";
            this.lnibn.Size = new System.Drawing.Size(39, 16);
            this.lnibn.TabIndex = 6;
            this.lnibn.Text = "NIBN";
            // 
            // lTahunTerbitBuku
            // 
            this.lTahunTerbitBuku.AutoSize = true;
            this.lTahunTerbitBuku.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTahunTerbitBuku.Location = new System.Drawing.Point(6, 167);
            this.lTahunTerbitBuku.Name = "lTahunTerbitBuku";
            this.lTahunTerbitBuku.Size = new System.Drawing.Size(90, 16);
            this.lTahunTerbitBuku.TabIndex = 5;
            this.lTahunTerbitBuku.Text = "Tahun Terbit";
            // 
            // lKlasifikasi
            // 
            this.lKlasifikasi.AutoSize = true;
            this.lKlasifikasi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKlasifikasi.Location = new System.Drawing.Point(6, 196);
            this.lKlasifikasi.Name = "lKlasifikasi";
            this.lKlasifikasi.Size = new System.Drawing.Size(70, 16);
            this.lKlasifikasi.TabIndex = 4;
            this.lKlasifikasi.Text = "Klasifikasi";
            // 
            // lPenerbitBuku
            // 
            this.lPenerbitBuku.AutoSize = true;
            this.lPenerbitBuku.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPenerbitBuku.Location = new System.Drawing.Point(6, 111);
            this.lPenerbitBuku.Name = "lPenerbitBuku";
            this.lPenerbitBuku.Size = new System.Drawing.Size(62, 16);
            this.lPenerbitBuku.TabIndex = 3;
            this.lPenerbitBuku.Text = "Penerbit";
            // 
            // lPengarang
            // 
            this.lPengarang.AutoSize = true;
            this.lPengarang.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPengarang.Location = new System.Drawing.Point(6, 83);
            this.lPengarang.Name = "lPengarang";
            this.lPengarang.Size = new System.Drawing.Size(82, 16);
            this.lPengarang.TabIndex = 2;
            this.lPengarang.Text = "Pengarang ";
            // 
            // lJudulBuku
            // 
            this.lJudulBuku.AutoSize = true;
            this.lJudulBuku.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJudulBuku.Location = new System.Drawing.Point(6, 55);
            this.lJudulBuku.Name = "lJudulBuku";
            this.lJudulBuku.Size = new System.Drawing.Size(46, 16);
            this.lJudulBuku.TabIndex = 1;
            this.lJudulBuku.Text = "Judul ";
            // 
            // lKodeBuku
            // 
            this.lKodeBuku.AutoSize = true;
            this.lKodeBuku.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKodeBuku.Location = new System.Drawing.Point(6, 27);
            this.lKodeBuku.Name = "lKodeBuku";
            this.lKodeBuku.Size = new System.Drawing.Size(76, 16);
            this.lKodeBuku.TabIndex = 0;
            this.lKodeBuku.Text = "Kode Buku";
            // 
            // gnTampilBuku
            // 
            this.gnTampilBuku.Controls.Add(this.dgvTampilBuku);
            this.gnTampilBuku.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnTampilBuku.Location = new System.Drawing.Point(358, 129);
            this.gnTampilBuku.Name = "gnTampilBuku";
            this.gnTampilBuku.Size = new System.Drawing.Size(456, 240);
            this.gnTampilBuku.TabIndex = 4;
            this.gnTampilBuku.TabStop = false;
            this.gnTampilBuku.Text = "Tampil Buku";
            // 
            // dgvTampilBuku
            // 
            this.dgvTampilBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilBuku.Location = new System.Drawing.Point(12, 23);
            this.dgvTampilBuku.Name = "dgvTampilBuku";
            this.dgvTampilBuku.Size = new System.Drawing.Size(438, 199);
            this.dgvTampilBuku.TabIndex = 0;
            // 
            // bBatal
            // 
            this.bBatal.Location = new System.Drawing.Point(606, 407);
            this.bBatal.Name = "bBatal";
            this.bBatal.Size = new System.Drawing.Size(98, 39);
            this.bBatal.TabIndex = 5;
            this.bBatal.Text = "Batal";
            this.bBatal.UseVisualStyleBackColor = true;
            this.bBatal.Click += new System.EventHandler(this.bBatal_Click);
            // 
            // bSimpan
            // 
            this.bSimpan.Location = new System.Drawing.Point(710, 407);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(98, 39);
            this.bSimpan.TabIndex = 6;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // tboxKlasifikasi
            // 
            this.tboxKlasifikasi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxKlasifikasi.Location = new System.Drawing.Point(118, 193);
            this.tboxKlasifikasi.Name = "tboxKlasifikasi";
            this.tboxKlasifikasi.Size = new System.Drawing.Size(196, 23);
            this.tboxKlasifikasi.TabIndex = 13;
            // 
            // bShowAll
            // 
            this.bShowAll.Location = new System.Drawing.Point(748, 375);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(66, 19);
            this.bShowAll.TabIndex = 7;
            this.bShowAll.Text = "Show All";
            this.bShowAll.UseVisualStyleBackColor = true;
            this.bShowAll.Click += new System.EventHandler(this.bShowAll_Click);
            // 
            // fTambahBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 464);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.bBatal);
            this.Controls.Add(this.gnTampilBuku);
            this.Controls.Add(this.gbDataBuku);
            this.Controls.Add(this.panel1);
            this.Name = "fTambahBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penambahan Buku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDataBuku.ResumeLayout(false);
            this.gbDataBuku.PerformLayout();
            this.gnTampilBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTambahBuku;
        private System.Windows.Forms.Label lJudul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDataBuku;
        private System.Windows.Forms.Label lKodeBuku;
        private System.Windows.Forms.Label lnibn;
        private System.Windows.Forms.Label lTahunTerbitBuku;
        private System.Windows.Forms.Label lKlasifikasi;
        private System.Windows.Forms.Label lPenerbitBuku;
        private System.Windows.Forms.Label lPengarang;
        private System.Windows.Forms.Label lJudulBuku;
        private System.Windows.Forms.TextBox tboxTahun_Terbit;
        private System.Windows.Forms.TextBox tboxISBN;
        private System.Windows.Forms.TextBox tboxPenerbit;
        private System.Windows.Forms.TextBox tboxPengarang;
        private System.Windows.Forms.TextBox tboxJudul;
        private System.Windows.Forms.TextBox tboxKode_Buku;
        private System.Windows.Forms.GroupBox gnTampilBuku;
        private System.Windows.Forms.DataGridView dgvTampilBuku;
        private System.Windows.Forms.Button bBatal;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.TextBox tboxKlasifikasi;
        private System.Windows.Forms.Button bShowAll;
    }
}