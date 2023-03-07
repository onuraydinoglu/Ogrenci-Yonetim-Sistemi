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
    public partial class OgretmenGirisSayfasi : Form
    {
        public OgretmenGirisSayfasi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM ogrtGiris WHERE ogrtKullaniciAdi=@p1 and ogrtSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgretmenAnaSayfasi OgrtGrs = new OgretmenAnaSayfasi();
                OgrtGrs.OgretmenKullaniciAdi = textBox1.Text;
                OgrtGrs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!!");
            }
            bgl.baglanti().Close();
        }

        private void OgretmenGirisSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
