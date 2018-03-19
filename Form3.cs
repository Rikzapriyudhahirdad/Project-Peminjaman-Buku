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
    public partial class Form3 : Form
    {
        dbControl database = new dbControl();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void showAll_Click(object sender, EventArgs e)
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

        private void Kembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
