using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ÇizmeliYazılımKursu
{
    public partial class ÖğrenciKayıtEkrani : Form
    {
        public ÖğrenciKayıtEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmmir\Documents\yazilimkursu.mdf;Integrated Security=True;Connect Timeout=30");

        private void KayıtEkrani_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        private void uyeler()
        {

            baglanti.Open();
            string where = "select * from tblkayit ";
            SqlDataAdapter da = new SqlDataAdapter(where, baglanti);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            kayitdtg.DataSource = ds.Tables[0];
            baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "" || txttelefon.Text == "" || txtadres.Text == "" || cmbcinsiyet.Text == "")
            {
                MessageBox.Show("Lütfen Eksik Kısımları Doldurunuz...");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string where = "insert into tblkayit values ('" + txtadsoyad.Text + "' , '" + txttelefon.Text + "' , '" + dttrh.Text + "' , '" + cmbcinsiyet.Text + "' , '" + txtadres.Text + "')";
                    SqlCommand komut = new SqlCommand(where, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Kaydı Başarılı.");
                    baglanti.Close();

                    uyeler();


                }
                catch (Exception kyt)
                {


                    MessageBox.Show(kyt.Message);
                }
            }

        }

        private void btnyukle_Click(object sender, EventArgs e)
        {
            txtadres.Text = "";
            txtadsoyad.Text = "";
            txttelefon.Text = "";
            cmbcinsiyet.Text = "";
            dttrh.Text = "";


        }
        int kytsil;
        private void btnsil_Click(object sender, EventArgs e)
        {
            {
               
                try
                {
                    kytsil = Convert.ToInt32(kayitdtg.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string where = "delete from tblkayit where OgrenciId =" + kytsil + "";
                    SqlCommand komut = new SqlCommand(where, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Silindi.");
                    baglanti.Close();

                    uyeler();

                }
                catch (Exception Ex)
                {
                    baglanti.Close();
                    MessageBox.Show(Ex.Message);
                }
            }
        }

                







































        private void txtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Kayit_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void kayitdtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dttrh_ValueChanged(object sender, EventArgs e)
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
    
    

