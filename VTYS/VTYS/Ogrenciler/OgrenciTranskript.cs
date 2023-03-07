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
    public partial class OgrenciTranskript : Form
    {
        public OgrenciTranskript()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgrenciTranskript_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("SELECT ogrAd,ogrSoyAd,ogrBolum,ogrDurum,duzenlenmeTarihi,kayitTarihi FROM ogrGiris", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label9.Text = dr1[0] + " ";
                label10.Text = dr1[1] + " ";
                label11.Text = dr1[2] + " ";
                label12.Text = dr1[3] + " ";
                label13.Text = dr1[4] + " ";
                label14.Text = dr1[5] + " ";
            }
            
            SqlCommand komut6 = new SqlCommand("SELECT SUM(dersAKTS) FROM gecmisDersler", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label15.Text = dr6[0] + " ";
                label16.Text = "3.10";
            }

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT dersKodu,dersAdi,dersHocasi,dersYili,dersYariYili,dersKredisi,dersAKTS FROM gecmisDersler WHERE dersYariYili=1", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT dersKodu,dersAdi,dersHocasi,dersYili,dersYariYili,dersKredisi,dersAKTS FROM gecmisDersler WHERE dersYariYili=2", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT dersKodu,dersAdi,dersHocasi,dersYili,dersYariYili,dersKredisi,dersAKTS FROM gecmisDersler WHERE dersYariYili=3", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("SELECT dersKodu,dersAdi,dersHocasi,dersYili,dersYariYili,dersKredisi,dersAKTS FROM gecmisDersler WHERE dersYariYili=4", bgl.baglanti());
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;

            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("SELECT dersKodu,dersAdi,dersHocasi,dersYili,dersYariYili,dersKredisi,dersAKTS FROM gecmisDersler WHERE dersYariYili=5", bgl.baglanti());
            da5.Fill(dt5);
            dataGridView5.DataSource = dt5;

            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter("SELECT dersKodu,dersAdi,dersHocasi,dersYili,dersYariYili,dersKredisi,dersAKTS FROM gecmisDersler WHERE dersYariYili=6", bgl.baglanti());
            da6.Fill(dt6);
            dataGridView6.DataSource = dt6;
        }
    }
}
