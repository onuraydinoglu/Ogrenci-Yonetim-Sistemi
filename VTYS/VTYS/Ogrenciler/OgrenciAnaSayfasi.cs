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
    public partial class OgrenciAnaSayfasi : Form
    {
        public OgrenciAnaSayfasi()
        {
            InitializeComponent();
        }

        public String ogrKullaniciAdi;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT ogrAd,ogrSoyAd FROM ogrGiris WHERE ogrKullaniciAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", ogrKullaniciAdi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDerseKayitOlma OgrKyt = new OgrenciDerseKayitOlma();
            OgrKyt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciKayitliTumDersler tmdrs = new OgrenciKayitliTumDersler();
            tmdrs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciNotlarSayfasi ogrDersler = new OgrenciNotlarSayfasi();
            ogrDersler.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciKayitliDersler kytdrs = new OgrenciKayitliDersler();
            kytdrs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OgrenciTranskript ogrtrn = new OgrenciTranskript();
            ogrtrn.Show();
        }
    }
}
