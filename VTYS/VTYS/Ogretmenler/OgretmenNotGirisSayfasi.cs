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
    public partial class OgretmenNotGirisSayfasi : Form
    {
        public OgretmenNotGirisSayfasi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgretmenNotGirisSayfasi_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT ogrId,ogrAd,ogrSoyAd,dersinAdi,vize,final,bütünleme,durum FROM notGirisi", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sistem Programlama")
            {
                label4.Text = "1";
            }
            else if(comboBox1.Text == "Bilgisayar Mimarisi")
            {
                label4.Text = "2";
            }
            else if(comboBox1.Text == "Veri Yapıları")
            {
                label4.Text = "3";
            }
            else
            {
                label4.Text = "1111";
                MessageBox.Show("Geçersiz Ders Adı");
            }
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ogrId,ogrAd,ogrSoyAd,dersinAdi,vize,final,bütünleme,durum FROM notGirisi WHERE derskodu=" + label4.Text + "", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label10.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double puan = Convert.ToInt32(textBox1.Text) * 0.4 + Convert.ToInt32(textBox2.Text) * 0.6;

            SqlCommand komut = new SqlCommand("UPDATE notGirisi SET vize=@p1,final=@p2,bütünleme=@p3, durum=@p4 WHERE ogrId="+ label10.Text + "", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", puan>=50);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (comboBox1.Text == "Sistem Programlama")
            {
                label4.Text = "1";
            }
            else if (comboBox1.Text == "Bilgisayar Mimarisi")
            {
                label4.Text = "2";
            }
            else if (comboBox1.Text == "Veri Yapıları")
            {
                label4.Text = "3";
            }
            else
            {
                label4.Text = "1111";
                MessageBox.Show("Geçersiz Ders Adı");
            }
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ogrId,ogrAd,ogrSoyAd,dersinAdi,vize,final,bütünleme,durum FROM notGirisi WHERE derskodu=" + label4.Text + "", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
        }
    }
}
