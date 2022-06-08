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
    public partial class ToplamOgrListesi : Form
    {
        public ToplamOgrListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmmir\Documents\yazilimkursu.mdf;Integrated Security=True;Connect Timeout=30");

        private void ToplamOgrListesi_Load(object sender, EventArgs e)
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
            dtglist.DataSource = ds.Tables[0];
            baglanti.Close();


        }

        private void btnara_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblkayit where OgrenciId like '%" + txtfiltre.Text + "%' ", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dtglist.DataSource = ds.Tables[0];
            baglanti.Close();
            uyeler();

        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void GeriTus_Click(object sender, EventArgs e)
        {
            AnaSayfa geri = new AnaSayfa();
            geri.Show();
            this.Hide();

        }

        private void dtglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa geri = new AnaSayfa();
            geri.Show();
            this.Hide();
        }
    }
}
