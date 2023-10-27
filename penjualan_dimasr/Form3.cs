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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        classKoneksi koneksi = new classKoneksi();

        public void tampildata()
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_barang", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;
        }


        private void barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //masukin data dari table ke textbox
            DataGridViewRow row = barang.Rows[e.RowIndex];
            tid.Text = row.Cells[0].Value.ToString();
            tnb.Text = row.Cells[1].Value.ToString();
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cari barang untuk operasi cari data di master penjualan
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_barang where nama_barang like @tc or id_barang like @tc", conn);
            cmd.Parameters.AddWithValue("@tc", "%" + tc.Text + "%");

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //blok tambah data penjualan
            int j = int.Parse(tj.Text);

            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmdCekData = new MySqlCommand("SELECT * FROM tb_barang where id_barang=@cari", conn);
            cmdCekData.Parameters.AddWithValue("@cari", tid.Text);

            MySqlDataAdapter da = new MySqlDataAdapter(cmdCekData);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                
                int hb = Convert.ToInt32(row["harga_beli"]);
                int hj = Convert.ToInt32(row["harga_jual"]);
                int s = Convert.ToInt32(row["stok"]);

                if (j > s)
                {
                    MessageBox.Show("Stok barang tidak cukup");
                }
                else
                {
                    int thb = hb * j;
                    int thj = hj * j;
                    int k = thj - thb;



                    tthj.Text = thj.ToString();
                    tthb.Text = thb.ToString();
                    tk.Text = k.ToString();

                    int stok = s - j;

                    MySqlCommand cmd = new MySqlCommand("update tb_barang set stok=@stok where id_barang=@id_barang", conn);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@id_barang", tid.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Barang Dijual");
                    tampildata();



                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO `tb_penjualan`( `nama_barang`, `jumlah_penjualan`, `total_keuntungan`) VALUES (@nb,@j,@k)", conn);
                    //cmd2.Parameters.AddWithValue("@id", tcid.Text );                    
                    cmd2.Parameters.AddWithValue("@nb", tnb.Text);
                    cmd2.Parameters.AddWithValue("@j", j);
                    cmd2.Parameters.AddWithValue("@k", k);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Data Penjualan berhasil Ditambah");
                    tampildata();
                }    
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void tj_TextChanged(object sender, EventArgs e)
        {

        if (tj.Text=="") {
                tj.Text = "0";
        }

            int j = int.Parse(tj.Text);


            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmdCekData = new MySqlCommand("SELECT * FROM tb_barang where id_barang=@cari", conn);
            cmdCekData.Parameters.AddWithValue("@cari", tid.Text);

            MySqlDataAdapter da = new MySqlDataAdapter(cmdCekData);
            DataTable dt = new DataTable();
            da.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {

                int hb = Convert.ToInt32(row["harga_beli"]);
                int hj = Convert.ToInt32(row["harga_jual"]);

                //operasi matematika buat hitung blok penjualan
                int thb = hb * j;
                int thj = hj * j;
                int k = thj - thb;



                tthj.Text = thj.ToString();
                tthb.Text = thb.ToString();
                tk.Text = k.ToString();


            }
        }
    }
}
