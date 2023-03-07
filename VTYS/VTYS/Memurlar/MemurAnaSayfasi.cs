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

namespace VTYS.Memurlar
{
    public partial class MemurAnaSayfasi : Form
    {
        public MemurAnaSayfasi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public String MemurKullaniciAdi;

        private void MemurAnaSayfasi_Load(object sender, EventArgs e)
        {
            label2.Text = MemurKullaniciAdi;

            SqlCommand komut = new SqlCommand("SELECT mAd,mSoyAd FROM mGiris WHERE mKullaniciAdi=@p1", bgl.baglanti());
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
            SqlCommand komut = new SqlCommand("INSERT INTO ogrtGiris (ogrtAd,ogrtSoyAd,ogrtKullaniciAdi,ogrtSifre,ogrtMail,ogrtAdres) VALUES (@p1,@p2,@p3,@p4,@p5,@p6) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p5", textBox5.Text);
            komut.Parameters.AddWithValue("@p6", textBox6.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO ogrGiris (ogrAd,ogrSoyAd,ogrKullaniciAdi,ogrSifre,ogrBolum,ogrMail,ogrAdres,ogrDanisman) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox14.Text);
            komut.Parameters.AddWithValue("@p2", textBox13.Text);
            komut.Parameters.AddWithValue("@p3", textBox12.Text);
            komut.Parameters.AddWithValue("@p4", textBox11.Text);
            komut.Parameters.AddWithValue("@p5", textBox10.Text);
            komut.Parameters.AddWithValue("@p6", textBox9.Text);
            komut.Parameters.AddWithValue("@p7", textBox8.Text);
            komut.Parameters.AddWithValue("@p8", textBox7.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Eklendi");
        }
    }
}
