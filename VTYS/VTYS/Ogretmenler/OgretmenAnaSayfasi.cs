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

namespace VTYS.Ogretmenler
{
    public partial class OgretmenAnaSayfasi : Form
    {
        public OgretmenAnaSayfasi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public String OgretmenKullaniciAdi;

        private void OgretmenAnaSayfa_Load(object sender, EventArgs e)
        {
            label2.Text = OgretmenKullaniciAdi;

            SqlCommand komut = new SqlCommand("SELECT ogrtAd,ogrtSoyAd FROM ogrtGiris WHERE ogrtKullaniciAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgretmenOnayaGonderilenDersler onydrs = new OgretmenOnayaGonderilenDersler();
            onydrs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgretmenNotGirisSayfasi ogrtnot = new OgretmenNotGirisSayfasi();
            ogrtnot.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgretmenProfil ogrprfl = new OgretmenProfil();
            ogrprfl.Show();
        }
    }
}
