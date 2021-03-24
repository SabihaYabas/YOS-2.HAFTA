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

namespace YurtKayitSistemi
{
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-FBJM4EU2\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            //  //BÖLÜMLERİN LİSTELENMESİ
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select BolumAd from Bolumler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
            //BOŞ ODALARIN LİSTELENMESİ
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select OdaNo from Odalar where OdaKapasite !=OdaAktif", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            //KOMUT KAYDETME İŞLEMİ
            baglanti.Close();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)

        {
            try
            {



                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("Insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values(@p1,p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@P9", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", RchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Basarili Bir Sekilde Eklendi.");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Lutfen Yeniden Deneyin");
            }



        }   
    }
}
//Data Source=LAPTOP-FBJM4EU2\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True