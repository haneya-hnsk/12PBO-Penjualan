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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        classKoneksi koneksi = new classKoneksi();


        private void Form2_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        public void tampildata() {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_barang", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;
          
        }

  
        private void button1_Click(object sender, EventArgs e)
            {
                MySqlConnection conn = koneksi.mysqlkoneksi();
                MySqlCommand cmd = new MySqlCommand("insert into  tb_barang values (@id, @nb, @hj, @hb, @stok)", conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(tid.Text));
                cmd.Parameters.AddWithValue("@nb", tnb.Text);
                cmd.Parameters.AddWithValue("@hb", thb.Text);
                cmd.Parameters.AddWithValue("@hj", thj.Text);
                cmd.Parameters.AddWithValue("@stok", ts.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil Ditambah");
                tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("update tb_barang set nama_barang=@nb, harga_beli=@hb, harga_jual=@hj, stok=@stok where id_barang=@id", conn);
            cmd.Parameters.AddWithValue("@id", tid.Text);
            cmd.Parameters.AddWithValue("@nb", tnb.Text);
            cmd.Parameters.AddWithValue("@hb", thb.Text);
            cmd.Parameters.AddWithValue("@hj", thj.Text);
            cmd.Parameters.AddWithValue("@stok", ts.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil Diubah");
            tampildata();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_barang Where id_barang=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(tid.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil dihapus");
            tampildata();

        }

        private void barang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = barang.Rows[e.RowIndex];
            tid.Text = row.Cells[0].Value.ToString();
            tnb.Text = row.Cells[1].Value.ToString();
            thb.Text = row.Cells[2].Value.ToString();
            thj.Text = row.Cells[3].Value.ToString();
            ts.Text = row.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_barang where nama_barang like @tc or harga_beli like @tc or id_barang like @tc", conn);
            cmd.Parameters.AddWithValue("@tc", "%"  + tc.Text + "%");

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }


    }
}
