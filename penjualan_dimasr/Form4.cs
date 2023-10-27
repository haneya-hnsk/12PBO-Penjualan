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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        classKoneksi koneksi = new classKoneksi();
        public void tampildata(){
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_penjualan", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_penjualan where nama_barang like @tc or id_penjualan like @tc", conn);
            cmd.Parameters.AddWithValue("@tc", "%" + tc.Text + "%");

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tampildata();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();

        }
    }
}
