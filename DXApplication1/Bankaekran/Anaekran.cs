using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
namespace Bankaekran
{
    public partial class Anaekran : DevExpress.XtraEditors.XtraForm
    {
        public Anaekran()
        {
            InitializeComponent();
        }

        SqlConnection bgl;
        public string kulid, par;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void simpleButton1_Click(object sender, EventArgs e)
        {
       
            bgl = new SqlConnection(@"Data Source=DESKTOP-4GELN25\SQLEXPRESS;Initial Catalog=bankadb;Integrated Security=True");
            bgl.Open();
          
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bgl;
            cmd.CommandText = "select * from  musteri_tablo where id = @p1 and sifre = @p2 ";
            cmd.Parameters.AddWithValue("@p1" , kullaniciAdiTxt.Text);
            cmd.Parameters.AddWithValue("@p2", kullaniciParolaTxt.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı Biz Sizin İçin İşlemleri Hallediyoruz");
                kulid = kullaniciAdiTxt.Text;
                par = kullaniciParolaTxt.Text;
                bgl.Close();
                Kullanici kul = new Kullanici();
                kul.kulid = kullaniciAdiTxt.Text;
                kul.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tekrar Deneyin");

          
        }

        private void Anaekran_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }
    }
}