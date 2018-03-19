using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace PeminjamanBuku
{
    public partial class fTambahBuku : Form
    {
        dbControl database = new dbControl();
        public fTambahBuku()
        {
            InitializeComponent();
        }

        public fTambahBuku(dbControl database)
        {
            InitializeComponent();
            this.database = database;
        }   

        private void bBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            if (tboxISBN.Text != "" && tboxJudul.Text != "" && tboxKode_Buku.Text != "" && tboxPenerbit.Text != "" &&
                tboxPengarang.Text != "" && tboxKlasifikasi.Text != "" && tboxTahun_Terbit.Text != "") 
            {
                try
                {
                    MySqlCommand dbBuku = new MySqlCommand("insert into tbuku values(null,@kode_buku,@judul,@pengarang,@penerbit,@isbn,@tahun_terbit,@klasifikasi)",database.conn);
                    database.conn.Open();
                    dbBuku.Parameters.AddWithValue("@kode_buku", tboxKode_Buku.Text);
                    dbBuku.Parameters.AddWithValue("@judul", tboxJudul.Text);
                    dbBuku.Parameters.AddWithValue("@pengarang", tboxPengarang.Text);
                    dbBuku.Parameters.AddWithValue("@penerbit", tboxPenerbit.Text);
                    dbBuku.Parameters.AddWithValue("@isbn", tboxISBN.Text);
                    dbBuku.Parameters.AddWithValue("@tahun_terbit", tboxTahun_Terbit);
                    dbBuku.Parameters.AddWithValue("@klasifikasi", tboxKlasifikasi.Text);
                    dbBuku.ExecuteNonQuery();
                    database.conn.Close();
                    MessageBox.Show("Data Suskes Tersimpan!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    tboxKode_Buku.Text="";
                    tboxJudul.Text="";
                    tboxPengarang.Text="";
                    tboxPenerbit.Text = "";
                    tboxISBN.Text = "";
                    tboxTahun_Terbit.Text = "";
                    tboxKlasifikasi.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Semua field harus diisi");
            }

            //tampil di grid view
            //dgvTampilBuku.Refresh();
            //OleDbDataAdapter dAdapter = new OleDbDataAdapter("select * from book", );
            //OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);            

        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbuku", database.conn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dta = new DataTable();
                sda.Fill(dta);
                BindingSource bdsour = new BindingSource();

                bdsour.DataSource = dta;
                dgvTampilBuku.DataSource = bdsour;
                sda.Update(dta);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
