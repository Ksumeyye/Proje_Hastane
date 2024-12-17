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

namespace Proje_Hastane
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi(); //sqlbaglantisi adlı sınıfımdan bgl nesnesi ürettim. //bu bgl sayesinde baglantı methoduma ulaşacağım.

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }

        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("p3", MskTC.Text);
            komut.Parameters.AddWithValue("p4", MskTel.Text);
            komut.Parameters.AddWithValue("p5", TxtSifre.Text);
            komut.Parameters.AddWithValue("p6", CmbCinsiyet.Text);
            komut.ExecuteNonQuery(); //Delete,insert gibi sorguları kullanabilmek için ExecuteNonQuery kullandım.
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: "+TxtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
