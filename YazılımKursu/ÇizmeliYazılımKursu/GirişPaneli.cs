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
    public partial class GirişPaneli : Form
    {
        public GirişPaneli()
        {
            InitializeComponent();
        }

        private void GirişPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {

            if (txtkad.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı adı ve Şifre Giriniz.");
            }
            else
            {
                if (txtkad.Text == "iste" && txtsifre.Text == "ybs")
                {
                    AnaSayfa ogrkayit = new AnaSayfa();
                    ogrkayit.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                }
            }   
        }
    }
}
