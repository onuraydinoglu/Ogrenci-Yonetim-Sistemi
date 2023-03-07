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
    public partial class OgrenciNotlarSayfasi : Form
    {
        public OgrenciNotlarSayfasi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgrenciDerslerSayfasi_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT dersAdi,vize,final,durum FROM notlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT dersAdi,vize,final,durum FROM tumNotlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT dersAdi,vize,final,durum,yil FROM tumNotlar WHERE yil=" + comboBox1.Text + "", bgl.baglanti());
            da.Fill(dt1);
            dataGridView3.DataSource = dt1;
            bgl.baglanti().Close();
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT dersAdi,vize,final,durum,yariyil FROM tumNotlar WHERE yariyil=" + comboBox2.Text + "", bgl.baglanti());
            da.Fill(dt1);
            dataGridView3.DataSource = dt1;
            bgl.baglanti().Close();
            comboBox1.Text = "";
        }
    }
}
