using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bankaekran
{

    class sqlbaglanti
    {
        Anaekran ana = new Anaekran();
        public SqlConnection baglan;
        public SqlCommand cmd;
        public string message;
        public SqlDataReader dr;

        
            
        public SqlConnection baglanti()
        {
          
          baglan = new SqlConnection(@"Data Source=DESKTOP-4GELN25\SQLEXPRESS;Initial Catalog=bankadb;Integrated Security=True");
          return baglan;

        }

        public  SqlDataReader Verigetir()
        {
            baglanti().Open();
            
            cmd = new SqlCommand();
            cmd.Connection = baglanti();
            cmd.CommandText = "select * from bakiye_tablo where musteri_id = @p1 ";
            cmd.Parameters.AddWithValue("@p1", ana.kulid);
            

            return dr;
        }
        
    }
}
