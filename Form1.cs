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

namespace PeminjamanBuku
{
    public partial class fUtama : Form
    {
        fTambahBuku ftbuku = new fTambahBuku();
        FormPeminjaman fPinjam = new FormPeminjaman();

        public fUtama()
        {
            
            InitializeComponent();
            
        }

        private void ljudul2_Click(object sender, EventArgs e)
        {

        }

        private void bTambahBuku_Click(object sender, EventArgs e)
        {
            ftbuku.Show();

        }

        private void bPeminjamanBuku_Click(object sender, EventArgs e)
        {
            fPinjam.Show();
            try
            {
                dbControl db = new dbControl();
                db.conn.Open();                
                db.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
