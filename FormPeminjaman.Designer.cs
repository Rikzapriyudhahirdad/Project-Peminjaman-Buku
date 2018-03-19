namespace PeminjamanBuku
{
    partial class FormPeminjaman
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cek = new System.Windows.Forms.Button();
            this.label_id_buku_pinjam = new System.Windows.Forms.Label();
            this.tb_id_buku = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_pinjam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_judul = new System.Windows.Forms.TextBox();
            this.tb_telp = new System.Windows.Forms.TextBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.button_keluar = new System.Windows.Forms.Button();
            this.groupBox_data_pinjam = new System.Windows.Forms.GroupBox();
            this.dgvTampilBukuPinjam = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label_stok = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_data_pinjam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilBukuPinjam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_cek);
            this.groupBox1.Controls.Add(this.label_id_buku_pinjam);
            this.groupBox1.Controls.Add(this.tb_id_buku);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID Buku";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_cek
            // 
            this.button_cek.Location = new System.Drawing.Point(315, 11);
            this.button_cek.Name = "button_cek";
            this.button_cek.Size = new System.Drawing.Size(49, 23);
            this.button_cek.TabIndex = 2;
            this.button_cek.Text = "Cari";
            this.button_cek.UseVisualStyleBackColor = true;
            this.button_cek.Click += new System.EventHandler(this.button_cek_Click);
            // 
            // label_id_buku_pinjam
            // 
            this.label_id_buku_pinjam.AutoSize = true;
            this.label_id_buku_pinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_buku_pinjam.Location = new System.Drawing.Point(6, 16);
            this.label_id_buku_pinjam.Name = "label_id_buku_pinjam";
            this.label_id_buku_pinjam.Size = new System.Drawing.Size(113, 13);
            this.label_id_buku_pinjam.TabIndex = 1;
            this.label_id_buku_pinjam.Text = "Masukkan Kode Buku";
            // 
            // tb_id_buku
            // 
            this.tb_id_buku.Location = new System.Drawing.Point(135, 13);
            this.tb_id_buku.Name = "tb_id_buku";
            this.tb_id_buku.Size = new System.Drawing.Size(174, 20);
            this.tb_id_buku.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_pinjam);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_judul);
            this.groupBox2.Controls.Add(this.tb_telp);
            this.groupBox2.Controls.Add(this.tb_alamat);
            this.groupBox2.Controls.Add(this.tb_nama);
            this.groupBox2.Location = new System.Drawing.Point(25, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 234);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button_pinjam
            // 
            this.button_pinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pinjam.Location = new System.Drawing.Point(216, 182);
            this.button_pinjam.Name = "button_pinjam";
            this.button_pinjam.Size = new System.Drawing.Size(136, 38);
            this.button_pinjam.TabIndex = 2;
            this.button_pinjam.Text = "Pinjam";
            this.button_pinjam.UseVisualStyleBackColor = true;
            this.button_pinjam.Click += new System.EventHandler(this.button_pinjam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Judul Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "No Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            // 
            // tb_judul
            // 
            this.tb_judul.Location = new System.Drawing.Point(135, 147);
            this.tb_judul.Name = "tb_judul";
            this.tb_judul.Size = new System.Drawing.Size(219, 20);
            this.tb_judul.TabIndex = 3;
            // 
            // tb_telp
            // 
            this.tb_telp.Location = new System.Drawing.Point(135, 104);
            this.tb_telp.Name = "tb_telp";
            this.tb_telp.Size = new System.Drawing.Size(219, 20);
            this.tb_telp.TabIndex = 2;
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(135, 66);
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(219, 20);
            this.tb_alamat.TabIndex = 1;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(135, 20);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(219, 20);
            this.tb_nama.TabIndex = 0;
            // 
            // button_keluar
            // 
            this.button_keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_keluar.Location = new System.Drawing.Point(666, 414);
            this.button_keluar.Name = "button_keluar";
            this.button_keluar.Size = new System.Drawing.Size(136, 38);
            this.button_keluar.TabIndex = 1;
            this.button_keluar.Text = "Keluar";
            this.button_keluar.UseVisualStyleBackColor = true;
            this.button_keluar.Click += new System.EventHandler(this.button_keluar_Click);
            // 
            // groupBox_data_pinjam
            // 
            this.groupBox_data_pinjam.Controls.Add(this.dgvTampilBukuPinjam);
            this.groupBox_data_pinjam.Location = new System.Drawing.Point(424, 89);
            this.groupBox_data_pinjam.Name = "groupBox_data_pinjam";
            this.groupBox_data_pinjam.Size = new System.Drawing.Size(378, 234);
            this.groupBox_data_pinjam.TabIndex = 7;
            this.groupBox_data_pinjam.TabStop = false;
            this.groupBox_data_pinjam.Text = "Daftar Buku Dipinjam";
            // 
            // dgvTampilBukuPinjam
            // 
            this.dgvTampilBukuPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilBukuPinjam.Location = new System.Drawing.Point(3, 28);
            this.dgvTampilBukuPinjam.Name = "dgvTampilBukuPinjam";
            this.dgvTampilBukuPinjam.Size = new System.Drawing.Size(438, 199);
            this.dgvTampilBukuPinjam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(424, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tampilkan Data Buku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_stok
            // 
            this.label_stok.AutoSize = true;
            this.label_stok.Location = new System.Drawing.Point(34, 352);
            this.label_stok.Name = "label_stok";
            this.label_stok.Size = new System.Drawing.Size(102, 13);
            this.label_stok.TabIndex = 8;
            this.label_stok.Text = "Stock Buku tersisa :";
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 464);
            this.Controls.Add(this.label_stok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_data_pinjam);
            this.Controls.Add(this.button_keluar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPeminjaman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_data_pinjam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilBukuPinjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_id_buku_pinjam;
        private System.Windows.Forms.TextBox tb_id_buku;
        private System.Windows.Forms.TextBox tb_judul;
        private System.Windows.Forms.TextBox tb_telp;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Button button_pinjam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_keluar;
        private System.Windows.Forms.GroupBox groupBox_data_pinjam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_stok;
        private System.Windows.Forms.DataGridView dgvTampilBukuPinjam;
        private System.Windows.Forms.Button button_cek;
    }
}