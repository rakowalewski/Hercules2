﻿using ClassLibrary.Basic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.DAO
{
    public class LogowanieDAO : BazaDAO
    {
        public int LogowanieAdministrator(string login, string haslo, string perm)
        {
            BazaDAO baza = new BazaDAO();
            // baza.OpenConnection();
            string query = "SELECT * FROM Konta WHERE Login=@user AND Haslo=@paswd AND Przywileje=@perm";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@user", login));
            cmd.Parameters.Add(new SqlParameter("@paswd", haslo));
            cmd.Parameters.Add(new SqlParameter("@perm", perm));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {

                if (perm == "Trener")
                {
                    //trener tr = new trener();
                    //tr.Show();
                    return 1;

                }
                else if (perm == "Recepcja")
                {
                    //recepcja rc = new recepcja();
                    //rc.Show();
                    return 2;
                }
                else
                {
                    //administrator ad = new administrator();
                    //ad.Show();
                    return 3;

                }
            }
            return 0;
        }

        public Trener Pobierz_Trener_Login(string Login)
        {
            Trener trener = new Trener();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Trener Where Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@login", Login));
            sqlReader = cmd.ExecuteReader();
            while(sqlReader.Read())
            {
                trener.Imie = sqlReader["Imie"].ToString();
                trener.Nazwisko = sqlReader["Nazwisko"].ToString();
                trener.Login = sqlReader["Login"].ToString();
                trener.Haslo = sqlReader["Haslo"].ToString();
            }
           
            return trener;
        }
        public Administrator Pobierz_Administrator_Login(string Login)
        {
            Administrator administrator = new Administrator();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Administrator Where Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@login", Login));
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                administrator.Imie = sqlReader["Imie"].ToString();
                administrator.Nazwisko = sqlReader["Nazwisko"].ToString();
                administrator.Login = sqlReader["Login"].ToString();
                administrator.Haslo = sqlReader["Haslo"].ToString();
            }

            return administrator;
        }
        public Recepcja Pobierz_Recepcja_Login(string Login)
        {
            Recepcja recepcja = new Recepcja();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Recepcja Where Login = @login";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@login", Login));
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                recepcja.Imie = sqlReader["Imie"].ToString();
                recepcja.Nazwisko = sqlReader["Nazwisko"].ToString();
                recepcja.Login = sqlReader["Login"].ToString();
                recepcja.Haslo = sqlReader["Haslo"].ToString();
            }

            return recepcja;
        }
        public List<Administrator> Pobierz_Wsz_Administrator()
        {
            List<Administrator> adminList = new List<Administrator>();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Administrator ";
            SqlCommand cmd = new SqlCommand(query, con);
            
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Administrator admin = new Administrator();
                admin.IdAdministrator = Int32.Parse(sqlReader["IdAdministrator"].ToString());
                admin.IdPrzywileje = Int32.Parse(sqlReader["IdPrzywileje"].ToString());
                admin.Imie = sqlReader["Imie"].ToString();
                admin.Nazwisko = sqlReader["Nazwisko"].ToString();
                admin.Login = sqlReader["Login"].ToString();
                admin.Haslo = sqlReader["Haslo"].ToString();
                adminList.Add(admin);
            }
            con.Close();
            return adminList;
            
        }
        public List<Trener> Pobierz_Wsz_Trener()
        {
            List<Trener> trenerList = new List<Trener>();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Trener ";
            SqlCommand cmd = new SqlCommand(query, con);
            
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Trener trener = new Trener();
                trener.IdTrener = Int32.Parse(sqlReader["IdTrener"].ToString());
                trener.IdPrzywileje = Int32.Parse(sqlReader["IdPrzywileje"].ToString());
                trener.Imie = sqlReader["Imie"].ToString();
                trener.Nazwisko = sqlReader["Nazwisko"].ToString();
                trener.Login = sqlReader["Login"].ToString();
                trener.Haslo = sqlReader["Haslo"].ToString();
                trenerList.Add(trener);
            }
            con.Close();
            return trenerList;
        }
        public List<Recepcja> Pobierz_Wsz_Recepcja()
        {
            List<Recepcja> recepcjaList = new List<Recepcja>();
            BazaDAO baza = new BazaDAO();
            string query = "Select * from Recepcja ";
            SqlCommand cmd = new SqlCommand(query, con);

            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Recepcja recepcja = new Recepcja();
                recepcja.IdRecepcja = Int32.Parse(sqlReader["IdRecepcja"].ToString());
                recepcja.IdPrzywileje = Int32.Parse(sqlReader["IdPrzywileje"].ToString());
                recepcja.Imie = sqlReader["Imie"].ToString();
                recepcja.Nazwisko = sqlReader["Nazwisko"].ToString();
                recepcja.Login = sqlReader["Login"].ToString();
                recepcja.Haslo = sqlReader["Haslo"].ToString();
                recepcjaList.Add(recepcja);
            }
            con.Close();
            return recepcjaList;
        }
    }
}
