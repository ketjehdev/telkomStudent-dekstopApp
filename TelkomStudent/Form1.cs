using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace TelkomStudent
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = new MySqlConnection("SERVER=localhost;" + "DATABASE=satriaconnect;" + "UID=root;" + "PASSWORD=;");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            koneksi.Open();

            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM siswa", koneksi);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            koneksi.Close();
        }
          
        private void Form1_Load(object sender, EventArgs e)
        {
            // jurusan
            jurusan.Items.Add("TKJ");
            jurusan.Items.Add("TJA");
            jurusan.Items.Add("MM");
            jurusan.Items.Add("RPL");

            // kelas
            kelas.Items.Add("X");
            kelas.Items.Add("XI");
            kelas.Items.Add("XII");
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (nis.Text != "" && name.Text != "" && jurusan.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO siswa(nis,name,kelas,jurusan) values(@nis,@name,@kelas,@jurusan)", koneksi);
                koneksi.Open();

                cmd.Parameters.AddWithValue("@nis", nis.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@kelas", kelas.Text);
                cmd.Parameters.AddWithValue("@jurusan", jurusan.Text);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                MessageBox.Show("Data Berhasil Ditambah");
            }
            else
            {
                MessageBox.Show("Inputan Tidak Boleh Kosong!");
            }  
        }
    }
}
