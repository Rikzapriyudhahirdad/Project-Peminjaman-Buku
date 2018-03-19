namespace PeminjamanBuku
{
    partial class fUtama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ljudul2 = new System.Windows.Forms.Label();
            this.lJudul = new System.Windows.Forms.Label();
            this.bTambahBuku = new System.Windows.Forms.Button();
            this.bPeminjamanBuku = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ljudul2);
            this.panel1.Controls.Add(this.lJudul);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 96);
            this.panel1.TabIndex = 1;
            // 
            // ljudul2
            // 
            this.ljudul2.AutoSize = true;
            this.ljudul2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ljudul2.Location = new System.Drawing.Point(301, 59);
            this.ljudul2.Name = "ljudul2";
            this.ljudul2.Size = new System.Drawing.Size(202, 22);
            this.ljudul2.TabIndex = 3;
            this.ljudul2.Text = "Dikerjakan oleh kelompok 5";
            this.ljudul2.Click += new System.EventHandler(this.ljudul2_Click);
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
            // bTambahBuku
            // 
            this.bTambahBuku.Location = new System.Drawing.Point(188, 173);
            this.bTambahBuku.Name = "bTambahBuku";
            this.bTambahBuku.Size = new System.Drawing.Size(142, 135);
            this.bTambahBuku.TabIndex = 2;
            this.bTambahBuku.Text = "Tambah Buku";
            this.bTambahBuku.UseVisualStyleBackColor = true;
            this.bTambahBuku.Click += new System.EventHandler(this.bTambahBuku_Click);
            // 
            // bPeminjamanBuku
            // 
            this.bPeminjamanBuku.Location = new System.Drawing.Point(515, 173);
            this.bPeminjamanBuku.Name = "bPeminjamanBuku";
            this.bPeminjamanBuku.Size = new System.Drawing.Size(142, 135);
            this.bPeminjamanBuku.TabIndex = 3;
            this.bPeminjamanBuku.Text = "Peminjaman Buku";
            this.bPeminjamanBuku.UseVisualStyleBackColor = true;
            this.bPeminjamanBuku.Click += new System.EventHandler(this.bPeminjamanBuku_Click);
            // 
            // fUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 464);
            this.Controls.Add(this.bPeminjamanBuku);
            this.Controls.Add(this.bTambahBuku);
            this.Controls.Add(this.panel1);
            this.Name = "fUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peminjaman Buku ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lJudul;
        private System.Windows.Forms.Label ljudul2;
        private System.Windows.Forms.Button bTambahBuku;
        private System.Windows.Forms.Button bPeminjamanBuku;
    }
}

