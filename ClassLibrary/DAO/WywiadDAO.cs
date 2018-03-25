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
        public Wywiad Pobierz_Wywiad(string Pesel)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Wywiad as w join Klient as k on w.IdKlient = k.IdKlient where k.Pesel = @pesel";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@pesel", Pesel));
            sqlReader = cmd.ExecuteReader();
            Wywiad wywiad = new Wywiad();
            while (sqlReader.Read())
            {
                // bool zmienna = liczba == 1 ? true : false
                wywiad.WadaSerca = int.Parse(sqlReader["WadaSerca"].ToString()) == 1 ? true : false;
                wywiad.Nadcisnienie = int.Parse(sqlReader["Nadcisnienie"].ToString()) == 1 ? true : false;
                wywiad.ZabRytmSerca = int.Parse(sqlReader["ZabRytmSerca"].ToString()) == 1 ? true : false;
                wywiad.Epilepsja = int.Parse(sqlReader["Epilepsja"].ToString()) == 1 ? true : false;
                wywiad.Alergia = int.Parse(sqlReader["Alergia"].ToString()) == 1 ? true : false;
                wywiad.Astma = int.Parse(sqlReader["Astma"].ToString()) == 1 ? true : false;
                wywiad.Cukrzyca = int.Parse(sqlReader["Cukrzyca"].ToString()) == 1 ? true : false;
                wywiad.InneChoroby = sqlReader["InneChoroby"].ToString();


            }
            con.Close();
            return wywiad;


            
        }

        public void Zapisz_Wywiad(Wywiad wywiad)
        {
            BazaDAO baza = new BazaDAO();
            string query = "Insert into Wywiad(Pesel,WadaSerca,Nadcisnienie,ZabRytmuSerca,Epilepsja,Alergia,Astma,Cukrzyca,InneChoroby) values(@Pesel, @WadaSerca, @Nadcisnienie, @ZabRytmuSerca, @Epilepsja, @Alergia, @Astma, @Cukrzyca, @InneChoroby)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@Pesel", wywiad.Pesel));
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
