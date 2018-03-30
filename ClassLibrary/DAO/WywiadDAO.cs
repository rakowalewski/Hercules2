using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class WywiadDAO: BazaDAO
    {
        public Wywiad Pobierz_Wywiad(string IdKlient)
        {
            BazaDAO baza = new BazaDAO();
            Wywiad wywiad = new Wywiad();
            string query = "Select * from Wywiad where IdKlient = @idKlient";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@idKlient", IdKlient));
            sqlReader = cmd.ExecuteReader();
            
            while (sqlReader.Read())
            {
                // bool zmienna = liczba == 1 ? true : false
                //var temp = sqlReader["ZabRytmuSerca"].ToString();
                wywiad.WadaSerca = bool.Parse(sqlReader["WadaSerca"].ToString());
                wywiad.Nadcisnienie = bool.Parse(sqlReader["Nadcisnienie"].ToString());
                wywiad.ZabRytmSerca = bool.Parse(sqlReader["ZabRytmuSerca"].ToString());
                wywiad.Epilepsja = bool.Parse(sqlReader["Epilepsja"].ToString());
                wywiad.Alergia = bool.Parse(sqlReader["Alergia"].ToString());
                wywiad.Astma = bool.Parse(sqlReader["Astma"].ToString());
                wywiad.Cukrzyca = bool.Parse(sqlReader["Cukrzyca"].ToString());
                wywiad.InneChoroby = sqlReader["InneChoroby"].ToString();


            }
            con.Close();
            return wywiad;


            
        }

        public void Zapisz_Wywiad(Wywiad wywiad)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert into Wywiad(IdKlient,WadaSerca,Nadcisnienie,ZabRytmuSerca,Epilepsja,Alergia,Astma,Cukrzyca,InneChoroby) values(@idklient, @WadaSerca, @Nadcisnienie, @ZabRytmuSerca, @Epilepsja, @Alergia, @Astma, @Cukrzyca, @InneChoroby)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@idklient", wywiad.IdKlient));
            cmd.Parameters.Add(new SqlParameter("@WadaSerca", wywiad.WadaSerca));
            cmd.Parameters.Add(new SqlParameter("@Nadcisnienie", wywiad.Nadcisnienie));
            cmd.Parameters.Add(new SqlParameter("@ZabRytmuSerca", wywiad.ZabRytmSerca));
            cmd.Parameters.Add(new SqlParameter("@Epilepsja", wywiad.Epilepsja));
            cmd.Parameters.Add(new SqlParameter("@Alergia", wywiad.Alergia));
            cmd.Parameters.Add(new SqlParameter("@Astma", wywiad.Astma));
            cmd.Parameters.Add(new SqlParameter("@Cukrzyca", wywiad.Cukrzyca));
            cmd.Parameters.Add(new SqlParameter("@InneChoroby", wywiad.InneChoroby));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
