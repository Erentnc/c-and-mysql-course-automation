using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇizmeliYazılımKursu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ÖğrenciKayıtEkrani kayıt = new ÖğrenciKayıtEkrani();
            kayıt.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnyonetim_Click(object sender, EventArgs e)
        {
            
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            kursyenikurskaydı yenikayıt = new kursyenikurskaydı();
            yenikayıt.ShowDialog();
        }

        private void btnpuan_Click(object sender, EventArgs e)
        {
            this.Hide();
            notlistesi puan = new notlistesi();
            puan.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            ToplamOgrListesi puan = new ToplamOgrListesi();
            puan.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
