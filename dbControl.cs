using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PeminjamanBuku
{
    public class dbControl
    {
        public MySqlConnection conn;
        public dbControl()
        {
            String koneksi = "datasource = localhost; port=3306; username=root; database=tbuku;";
            conn = new MySqlConnection(koneksi);    
        }
    }
}
