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

namespace Bankaekran
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        int bakiye, gndpara, kalanpara,karsibakiye,karsibakiyetop;
        public string kendihesap,musteri;
        private void transferButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GELN25\SQLEXPRESS;Initial Catalog=bankadb;Integrated Security=True");
            SqlCommand cmdbky = new SqlCommand("SELECT bakiye from bakiye_tablo where hesap_id = @hesapid and musteri_id = @cmdbkymusteriid ",con);
            SqlCommand da;
            SqlCommand karsipara;
            SqlCommand transfer;
            con.Open();
            gndpara = Convert.ToInt32(Gönderparatxt.Text);
            cmdbky.Parameters.AddWithValue("@hesapid", kendihesaptxt.Text);
            cmdbky.Parameters.AddWithValue("@cmdbkymusteriid", anahesapLbl.Text);
            bakiye = (int)cmdbky.ExecuteScalar();
   
            
            if (gndpara > bakiye)
            {
                MessageBox.Show("Bakiyenizden Fazla Para Göndermek İStediniz. Lütfen Miktarı Kontrol Ediniz");
            }
            else if( gndpara < bakiye)
            {
                try
                {
                   
                    kalanpara = bakiye - gndpara;
                    //Burada kendi bakiyemizi güncelliyoruz
                    da = new SqlCommand("update bakiye_tablo set bakiye = @kalanpara where musteri_id = @hesap and hesap_id = @kendihesap ", con);
                    da.Parameters.AddWithValue("@kalanpara", kalanpara);
                    da.Parameters.AddWithValue("@kendihesap", kendihesaptxt.Text);
                    da.Parameters.AddWithValue("@hesap", anahesapLbl.Text);

                    //Burada Karşı hesap bakiyesi çekiyoruz
                    karsipara = new SqlCommand("SELECT bakiye from bakiye_tablo where hesap_id = @krshesap and musteri_id = @karsimusteri ", con);
                    karsipara.Parameters.AddWithValue("@krshesap", karsıhesaptxt.Text);
                    karsipara.Parameters.AddWithValue("@karsimusteri", karsimüsteriidtxt.Text);
                    karsibakiye = (int)karsipara.ExecuteScalar();
                    karsibakiyetop = karsibakiye + gndpara;
                    

                    //Burada Karşı Hesabın parasını güncelliyoruz
                    transfer = new SqlCommand("update bakiye_tablo set bakiye = @karsibakiyetop where musteri_id = @krsid and hesap_id = @krshesaptxt ", con);
                    transfer.Parameters.AddWithValue("@karsibakiyetop", karsibakiyetop);
                    transfer.Parameters.AddWithValue("@krsid", karsimüsteriidtxt.Text);
                    transfer.Parameters.AddWithValue("@krshesaptxt", karsıhesaptxt.Text);
                    transfer.ExecuteNonQuery();
                    con.Close();



                    MessageBox.Show("Gönderilen Para = " + gndpara + "" +
                        " Kalan Para = " + kalanpara);
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message + " Hata Kodlu Bir Sorun Var Lütfen Geliştirici İle İletişime Geçiniz ");
                
                }




            }

        }
        public string anahesap;
        private void Transfer_Load(object sender, EventArgs e)
        {
            anahesapLbl.Text = anahesap;
        }
    }
}
