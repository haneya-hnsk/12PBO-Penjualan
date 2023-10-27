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


namespace penjualan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        classKoneksi koneksi = new classKoneksi();

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = koneksi.mysqlkoneksi();
            if (conn.State == ConnectionState.Open)
            {
              

           // MessageBox.Show("nyala");
            }
            else
            {
                MessageBox.Show("mati");

            }
            
        }

        private void login_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_user Where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("login berhasil");

                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login gagal");

            }
        }
    }
}
