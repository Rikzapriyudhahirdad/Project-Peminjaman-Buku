namespace PeminjamanBuku
{
    partial class Form3
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
            this.dgvTampilBuku = new System.Windows.Forms.DataGridView();
            this.showAll = new System.Windows.Forms.Button();
            this.Kembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTampilBuku
            // 
            this.dgvTampilBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilBuku.Location = new System.Drawing.Point(12, 95);
            this.dgvTampilBuku.Name = "dgvTampilBuku";
            this.dgvTampilBuku.Size = new System.Drawing.Size(808, 357);
            this.dgvTampilBuku.TabIndex = 1;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(12, 60);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(75, 23);
            this.showAll.TabIndex = 2;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // Kembali
            // 
            this.Kembali.Location = new System.Drawing.Point(745, 60);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(75, 23);
            this.Kembali.TabIndex = 3;
            this.Kembali.Text = "Kembali";
            this.Kembali.UseVisualStyleBackColor = true;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 464);
            this.Controls.Add(this.Kembali);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.dgvTampilBuku);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTampilBuku;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Button Kembali;
    }
}