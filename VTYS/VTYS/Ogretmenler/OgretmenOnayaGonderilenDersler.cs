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
    public partial class OgretmenOnayaGonderilenDersler : Form
    {
        public OgretmenOnayaGonderilenDersler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void OgretmenOnayaGonderilenDersler_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM danismanOnay", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO kesinKayit (dersKodu,dersAdi,dersYili,dersYariYili,dersKredisi,dersAKTS,dersHocasi) SELECT dersKodu, dersAdi, dersYili, dersYariYili, dersKredisi, dersAKTS, dersHocasi FROM danismanOnay",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Onay Gerçekleşti");
        }
    }
}
