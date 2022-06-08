using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇizmeliYazılımKursu
{
    public partial class notlistesi : Form
    {
        public notlistesi()
        {
            InitializeComponent();
        }

        private void GeriTus_Click(object sender, EventArgs e)
        {
            
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmmir\Documents\yazilimkursu.mdf;Integrated Security=True;Connect Timeout=30");

        private void notlistesi_Load(object sender, EventArgs e)
        {
            uyeler();
            puanlar();
        }
        private void uyeler()
        {

            baglanti.Open();
            string where = "select * from tblkayit ";
            SqlDataAdapter da = new SqlDataAdapter(where, baglanti);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dtgogr.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void puanlar()
        {

            baglanti.Open();
            string where = "select * from Puantbl ";
            SqlDataAdapter da = new SqlDataAdapter(where, baglanti);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dtgpuan.DataSource = ds.Tables[0];
            baglanti.Close();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
           
            try
            {
                baglanti.Open();
                string where = "insert into Puantbl values ('" + txtId.Text + "','" + txtpuan.Text + "','" + cmbkurs.Text + "','" + txtaciklama.Text + "')";
                SqlCommand komut = new SqlCommand(where, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Puan Eklendi");
                baglanti.Close();
                puanlar();

            }
            catch (Exception Ex)
            {
                baglanti.Close();
                MessageBox.Show(Ex.Message);
            }
        }

        private void NewMethod()
        {
            baglanti.Open();
        }

       
        int pid;
        private void btnsil_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    pid = Convert.ToInt32(dtgpuan.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string where = "delete from Puantbl where PuanId=" + pid + "" ;
                    SqlCommand komut = new SqlCommand(where, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Silindi.");
                    baglanti.Close();
                    puanlar();

                }
                catch (Exception Ex)
                {
                    baglanti.Close();
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dtgpuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void txtpuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            AnaSayfa geri = new AnaSayfa();
            geri.Show();
            this.Hide();
        }
    }
  }
   
