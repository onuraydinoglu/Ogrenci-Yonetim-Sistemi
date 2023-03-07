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
    public partial class OgrenciDerseKayitOlma : Form
    {
        public OgrenciDerseKayitOlma()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("SELECT * FROM ogrDers WHERE dersId = 1", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                l1.Text = dr1[1] + " ";
                l2.Text = dr1[2] + " ";
                l3.Text = dr1[5] + " ";
                l4.Text = dr1[6] + " ";
                l5.Text = dr1[7] + " ";
            }

            SqlCommand komut2 = new SqlCommand("SELECT * FROM ogrDers WHERE dersId = 2", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                l6.Text = dr2[1] + " ";
                l7.Text = dr2[2] + " ";
                l8.Text = dr2[5] + " ";
                l9.Text = dr2[6] + " ";
                l10.Text = dr2[7] + " ";
            }

            SqlCommand komut3 = new SqlCommand("SELECT * FROM ogrDers WHERE dersId = 3", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                l11.Text = dr3[1] + " ";
                l12.Text = dr3[2] + " ";
                l13.Text = dr3[5] + " ";
                l14.Text = dr3[6] + " ";
                l15.Text = dr3[7] + " ";
            }

            SqlCommand komut4 = new SqlCommand("SELECT * FROM ogrDers WHERE dersId = 4", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                l16.Text = dr4[1] + " ";
                l17.Text = dr4[2] + " ";
                l18.Text = dr4[5] + " ";
                l19.Text = dr4[6] + " ";
                l20.Text = dr4[7] + " ";
            }

            SqlCommand komut5 = new SqlCommand("SELECT * FROM ogrDers WHERE dersId = 5", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                l21.Text = dr5[1] + " ";
                l22.Text = dr5[2] + " ";
                l23.Text = dr5[5] + " ";
                l24.Text = dr5[6] + " ";
                l25.Text = dr5[7] + " ";
            }
            bgl.baglanti().Close();

            SqlCommand komut6 = new SqlCommand("SELECT SUM(dersKredisi) FROM kesinKayit", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label4.Text = dr6[0] + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Taslak";
            if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true)
            {
                MessageBox.Show("Ders eklendi");
            }
            else
            {
                MessageBox.Show("Hiç Ders Şeçmediniz");
            }
            if (checkBox1.Checked == true)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO danismanOnay (dersKodu,dersAdi,dersKredisi,dersAKTS,dersHocasi,dersYili,dersYariYili) VALUES (@p1,@p2,@p3,@p4,@p5,3,6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", l1.Text);
                komut.Parameters.AddWithValue("@p2", l2.Text);
                komut.Parameters.AddWithValue("@p3", l3.Text);
                komut.Parameters.AddWithValue("@p4", l4.Text);
                komut.Parameters.AddWithValue("@p5", l5.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            if (checkBox2.Checked == true)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO danismanOnay (dersKodu,dersAdi,dersKredisi,dersAKTS,dersHocasi,dersYili,dersYariYili) VALUES (@p1,@p2,@p3,@p4,@p5,3,6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", l6.Text);
                komut.Parameters.AddWithValue("@p2", l7.Text);
                komut.Parameters.AddWithValue("@p3", l8.Text);
                komut.Parameters.AddWithValue("@p4", l9.Text);
                komut.Parameters.AddWithValue("@p5", l10.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            if (checkBox3.Checked == true)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO danismanOnay (dersKodu,dersAdi,dersKredisi,dersAKTS,dersHocasi,dersYili,dersYariYili) VALUES (@p1,@p2,@p3,@p4,@p5,3,6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", l11.Text);
                komut.Parameters.AddWithValue("@p2", l12.Text);
                komut.Parameters.AddWithValue("@p3", l13.Text);
                komut.Parameters.AddWithValue("@p4", l14.Text);
                komut.Parameters.AddWithValue("@p5", l15.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            if (checkBox4.Checked == true)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO danismanOnay (dersKodu,dersAdi,dersKredisi,dersAKTS,dersHocasi,dersYili,dersYariYili) VALUES (@p1,@p2,@p3,@p4,@p5,3,6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", l16.Text);
                komut.Parameters.AddWithValue("@p2", l17.Text);
                komut.Parameters.AddWithValue("@p3", l18.Text);
                komut.Parameters.AddWithValue("@p4", l19.Text);
                komut.Parameters.AddWithValue("@p5", l20.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            if (checkBox5.Checked == true)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO danismanOnay (dersKodu,dersAdi,dersKredisi,dersAKTS,dersHocasi,dersYili,dersYariYili) VALUES (@p1,@p2,@p3,@p4,@p5,3,6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", l21.Text);
                komut.Parameters.AddWithValue("@p2", l22.Text);
                komut.Parameters.AddWithValue("@p3", l23.Text);
                komut.Parameters.AddWithValue("@p4", l24.Text);
                komut.Parameters.AddWithValue("@p5", l25.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }
    }
}
