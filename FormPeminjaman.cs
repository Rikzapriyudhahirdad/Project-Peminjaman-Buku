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
    public partial class FormPeminjaman : Form
    {
        Form3 frm3 = new Form3();
        dbControl database = new dbControl();
        public FormPeminjaman()
        {
            InitializeComponent();
            this.setData();
        }

         public void setData()
        {
            MySqlCommand dbBuku = new MySqlCommand("select count(ID) as stockSisa from tbuku", database.conn);
            database.conn.Open();
            label_stok.Text = "Stock buku tersisa : " + dbBuku.ExecuteScalar().ToString();            
            database.conn.Close();

        }

        public FormPeminjaman(dbControl database)
        {
            InitializeComponent();
            this.database = database;
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_stok_Click(object sender, EventArgs e)
        {
            MySqlCommand dbBuku = new MySqlCommand("select count(ID) as stockSisa from tbuku", database.conn);
            database.conn.Open();
            label_stok.Text = "Stock buku tersisa : " + dbBuku.ExecuteScalar().ToString();
            database.conn.Close();
        }

        private void button_pinjam_Click(object sender, EventArgs e)
        {

            //String str = "call sp_pinjam('"+tb_judul.Text+"')";
            
            String data_pinjam = "select * from peminjam";
            string hapus = "delete from tbuku where ID=4";
            try
            {
                MySqlCommand cmd = new MySqlCommand(hapus,database.conn);
                MySqlCommand pinjam = new MySqlCommand(data_pinjam, database.conn);
                MySqlCommand dbBuku = new MySqlCommand("insert into peminjam values(@idbuku,@nama_peminjam,@alamat_peminjam,@no_telp,@judul)", database.conn);
                MySqlCommand sisaBuku = new MySqlCommand("select count(ID) as stockSisa from tbuku", database.conn);
                database.conn.Open();
                dbBuku.Parameters.AddWithValue("@idbuku", tb_id_buku.Text);
                dbBuku.Parameters.AddWithValue("@judul", tb_judul.Text);
                dbBuku.Parameters.AddWithValue("@nama_peminjam", tb_nama.Text);
                dbBuku.Parameters.AddWithValue("@alamat_peminjam", tb_alamat.Text);
                dbBuku.Parameters.AddWithValue("@no_telp", tb_telp.Text);            
                dbBuku.ExecuteNonQuery();                
                

                //untuk menampilkan 
                label_stok.Text = "Stock buku tersisa : " + sisaBuku.ExecuteScalar().ToString();
                //untuk menampilkan data ke dalam tabel                
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = pinjam;
                DataTable dta = new DataTable();
                sda.Fill(dta);
                BindingSource bdsour = new BindingSource();

                bdsour.DataSource = dta;
                dgvTampilBukuPinjam.DataSource = bdsour;
                sda.Update(dta);
                database.conn.Close();

                tb_alamat.Text = "";
                tb_id_buku.Text = "";
                tb_judul.Text = "";
                tb_telp.Text = "";
                tb_nama.Text = "";
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button_keluar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_cek_Click(object sender, EventArgs e)
        {
            String cek = tb_id_buku.Text;
            String command = "Select kode_buku from tbuku where kode_buku like "+"'"+cek+"%"+"'";
            String jdl_buku = "Select judul from tbuku where kode_buku = " + "'" + cek + "'";
            String id_buku = "Select kode_buku from tbuku where kode_buku = " + "'" + cek + "'";
            MySqlCommand dbBuku = new MySqlCommand(command, database.conn);
            database.conn.Open();
            if(cek !=(String)dbBuku.ExecuteScalar())
            {
                MessageBox.Show("Buku Tidak Tersedia");
            }
            else { 
                MySqlCommand judul = new MySqlCommand(jdl_buku, database.conn);
                MySqlCommand idbuku = new MySqlCommand(id_buku, database.conn);

                tb_id_buku.Text = idbuku.ExecuteScalar().ToString();
                tb_judul.Text = judul.ExecuteScalar().ToString();
            }
            database.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }
    }
}
