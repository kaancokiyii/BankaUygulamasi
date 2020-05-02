using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;


namespace Bankaekran
{
    public partial class Kullanici : DevExpress.XtraEditors.XtraForm
    {
        public Kullanici()
        {
            InitializeComponent();
        }
      
        private void hesapButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            hesabım hb = new hesabım();
            hb.Dock = DockStyle.Fill;
            hb.TopLevel = false;
            hb.FormBorderStyle = FormBorderStyle.None;
            Panel.Controls.Add(hb);
            hb.Show();
        
        }
    
        DataTable tablo = new DataTable();
        Anaekran ana = new Anaekran();
        public string kulid;
        string ad, soyad, sehir;
        Transfer tra = new Transfer();
        private void Kullanici_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bankaVerilerDataGrid.bakiye_tablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bakiye_tabloTableAdapter.Fill(this.bankaVerilerDataGrid.bakiye_tablo);
            // TODO: Bu kod satırı 'hesapAdiDataset.hesap_tablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hesap_tabloTableAdapter1.Fill(this.hesapAdiDataset.hesap_tablo);
            // TODO: Bu kod satırı 'bankadbDataSet.hesap_tablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //   this.hesap_tabloTableAdapter.Fill(this.bankadbDataSet.hesap_tablo);
            kullaniciid.Text = kulid;

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4GELN25\SQLEXPRESS;Initial Catalog=bankadb;Integrated Security=True");
            baglan.Open();

            SqlDataReader dr;
            SqlDataAdapter da;
            tra.anahesap = kulid;

            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Bakiye.musteri_id AS ID, Musteri.ad AS Ad, Hesap.hesap_id as HesapId, Bakiye.bakiye, Musteri.soyad, Musteri.sube FROM  musteri_tablo AS Musteri CROSS JOIN bakiye_tablo AS Bakiye , hesap_tablo as Hesap WHERE(Bakiye.musteri_id = @musteriid) and Hesap.kullanici_id = @musteriid and Musteri.id = Bakiye.musteri_id and Hesap.hesap_id = Bakiye.hesap_id  ", baglan);
            adtr.SelectCommand.Parameters.AddWithValue("@musteriid", kullaniciid.Text);
            adtr.Fill(tablo);
            KullaniciDataGrid.DataSource = tablo;

            SqlCommand adgtr = new SqlCommand("SELECT ad from musteri_tablo where id = @musteriid ",baglan);
            SqlCommand soyadgtr = new SqlCommand("SELECT soyad from musteri_tablo where id = @musteriid", baglan);
            SqlCommand sehirgtr = new SqlCommand("SELECT sube from musteri_tablo where id = @musteriid", baglan);

            adgtr.Parameters.AddWithValue("@musteriid", kullaniciid.Text);
            sehirgtr.Parameters.AddWithValue("@musteriid", kullaniciid.Text);
            soyadgtr.Parameters.AddWithValue("@musteriid", kullaniciid.Text);
         
            adLbl.Text = (string)adgtr.ExecuteScalar();
            soyadLbl.Text = (string)soyadgtr.ExecuteScalar();
            Sehir.Text = (string)sehirgtr.ExecuteScalar();
            baglan.Close();

            


        }

        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                tra.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Para para = new Para();
            para.Show();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}