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
    public partial class Para : DevExpress.XtraEditors.XtraForm
    {
        public Para()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Para_Load(object sender, EventArgs e)
        {
            HamburgerPanel.Visible = false;
        }
        int durum = 0;
        private void simpleButton1_Click(object sender, EventArgs e)
        {/*
            if (durum == 0)
                HamburgerMenu.Stop();
            else 
                HamburgerMenu.Start();
                */
          
        }

        private void HamburgerMenu_Tick(object sender, EventArgs e)
        {
           /* HamburgerPanel.Visible = true;
            if (HamburgerPanel.Width != 100)
            { 
                while (HamburgerPanel.Width == 100)
                {
                    HamburgerPanel.Width += 5;
                    if (HamburgerPanel.Width == 100)
                        HamburgerMenu.Stop();
                }     
            }
            else if (HamburgerPanel.Width == 100)
            {
                while (HamburgerPanel.Width == 5)
                {
                    HamburgerPanel.Width -= 5;
                        if(HamburgerPanel.Width == 5)
                            {
                              HamburgerMenu.Stop();
                            }
                }
               
            }
            if (HamburgerPanel.Width == 5)
                HamburgerPanel.Visible = false;*/
        }
        int param,sonuc,islempara;
      
        string kendihesaptx;
        string musteriid;
        private void button1_Click(object sender, EventArgs e)
        {
            kendihesaptx = tr.kendihesap;
            islemLbl.Text = "1";
            nonamelbl.Text = "Banka Hesabınızdaki Para";
            nonamelbl2.Text = "Çekeceğiniz Tutar";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4GELN25\SQLEXPRESS;Initial Catalog=bankadb;Integrated Security=True");
            SqlCommand cmdbky = new SqlCommand("SELECT bakiye from bakiye_tablo where hesap_id = @hesapid and musteri_id = @cmdbkymusteriid ", con);
            cmdbky.Parameters.AddWithValue("@hesapid", kendihesaptx);
            cmdbky.Parameters.AddWithValue("@cmdbkymusteriid", anahesapLbl.Text);
            param = (int)cmdbky.ExecuteScalar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            islemLbl.Text = "2";
            nonamelbl.Text = "Banka Hesabınızdaki Para";
            nonamelbl2.Text = "Yatıracağınız Tutar";
        }
    }
}