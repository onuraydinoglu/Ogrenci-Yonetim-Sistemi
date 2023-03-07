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

namespace VTYS.Ogrenciler
{
    public partial class OgrenciGirisSayfasi : Form
    {
        public OgrenciGirisSayfasi()
        {
            InitializeComponent();
        }

        sqlbaglantisi baglan = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM ogrGiris WHERE ogrKullaniciAdi=@p1 and ogrSifre=@p2", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgrenciAnaSayfasi grs = new OgrenciAnaSayfasi();
                grs.ogrKullaniciAdi = textBox1.Text;
                grs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!!");
            }
            baglan.baglanti().Close();
        }
    }
}
