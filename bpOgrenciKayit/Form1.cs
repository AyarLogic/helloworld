using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bpOgrenciKayit
{
    public partial class Form1 : Form
    {
        // 1. VERITABANI ADRESI
        string baglantiMetni = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Ogrenci_DB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            // Böylece program açılır açılmaz öğrenciler tabloda görünür.
            Listele();
        }

        void Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM OgrencilerX", baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dvgOgrencilerX.DataSource = dt;
        }

        // 4. EKLE BUTONU
        private void butEkle_Click(object sender, EventArgs e)
        {
           
        }

        private void butEkle_Click_1(object sender, EventArgs e)
        {
            if (txtAdi.Text == "" || txtSoyadi.Text == "" || cmbBolum.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }
            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            SqlCommand komut = new SqlCommand("INSERT INTO OgrencilerX (Ad, Soyad, Bolum) VALUES (@ad, @soyad, @bolum)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAdi.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@bolum", cmbBolum.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci eklendi!");
            Listele();
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbBolum.Text = "";

        }
    }
}