using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DbConnection
{
    public partial class Form1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public Form1()
        {
            alamat = "server=localhost; database=db_mahasiswa; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Form1_Load(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_pengguna where id_pengguna ='{0}'", TxtIdPengguna.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        TxtUsername.Text = kolom["username"].ToString();
                        TxtPassword.Text = kolom["password"].ToString();
                        CBLevel.Text = kolom["level"].ToString();
                        CBStatus.Text = kolom["status"].ToString();

                        BtnUpdate.Enabled = true;
                        BtnDelete.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                    Form1_Load(null,null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from tbl_pengguna where id_pengguna ='{0}'", TxtIdPengguna.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                Form1_Load(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("update tbl_pengguna set username = '{0}', password = '{1}', level = '{2}', status = '{3}' where id_pengguna ='{4}'", TxtUsername.Text, TxtPassword.Text, CBLevel.Text, CBStatus.Text, TxtIdPengguna.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                Form1_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                
                query = string.Format("insert into tbl_pengguna (username, password, level, status) values ('{0}', '{1}', '{2}', '{3}')", TxtUsername.Text, TxtPassword.Text, CBLevel.Text, CBStatus.Text);
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if(res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    Form1_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Insert data gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from tbl_pengguna");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "No";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Password";
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[3].HeaderText = "Level";
                dataGridView1.Columns[4].Width = 50;
                dataGridView1.Columns[4].HeaderText = "Status";

                TxtIdPengguna.Clear();
                TxtUsername.Clear();
                TxtPassword.Clear();

                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;

                CBLevel.Text = "-";
                CBStatus.Text = "-";
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
