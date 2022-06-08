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
    public partial class kursyenikurskaydı : Form
    {
        public kursyenikurskaydı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmmir\Documents\yazilimkursu.mdf;Integrated Security=True;Connect Timeout=30");
        private void yenikurskaydı_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        private void uyeler()
        {
            baglanti.Open();
            string where = "select * from yenikurstbll";
            SqlDataAdapter da = new SqlDataAdapter(where, baglanti);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dtgyenikurs.DataSource = ds.Tables[0];
            baglanti.Close();
             


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtkursadi.Text == "" | txtsaat.Text == "" | txtaciklama.Text == "")
            {


                MessageBox.Show("Lütfen Eksik Kısımları doldurunuz...");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string where = "insert into yenikurstbll values('" + txtkursadi.Text + "','" + txtsaat.Text + "', '" + txtaciklama.Text + "')";
                    SqlCommand komut = new SqlCommand(where, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni Kurs Eklendi.");
                    baglanti.Close();


                }
                catch (Exception yenikrs)
                {
                    MessageBox.Show(yenikrs.Message);
                    ;
                }
            }
        }
       
        


        private void dtgyenikurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtkursadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            AnaSayfa geri = new AnaSayfa();
            geri.Show();
            this.Hide();
        }

        private void dtgyenikurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
