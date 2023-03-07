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
    public partial class OgretmenProfil : Form
    {
        public OgretmenProfil()
        {
            InitializeComponent();
        }

        public String ogrtAd;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgretmenProfil_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("SELECT * FROM ogrtGiris", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                textBox1.Text = dr1[0] + " ";
                textBox2.Text = dr1[1] + " ";
                textBox3.Text = dr1[2] + " ";
                textBox4.Text = dr1[3] + " ";
                textBox5.Text = dr1[4] + " ";
                textBox6.Text = dr1[5] + " ";
                textBox7.Text = dr1[6] + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE ogrtGiris SET ogrtAd=@p1,ogrtSoyAd=@p2,ogrtKullaniciAdi=@p3, ogrtSifre=@p4, ogrtMail=@p5, ogrtAdres=@p6 WHERE ogrtId=" + textBox1.Text + "", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox5.Text);
            komut.Parameters.AddWithValue("@p5", textBox6.Text);
            komut.Parameters.AddWithValue("@p6", textBox7.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Değişiklik Kaydedildi");
        }
    }
}
