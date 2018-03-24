using ClassLibrary;
using ClassLibrary.Basic;
using ClassLibrary.DAO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy Klient_TrenerPage.xaml
    /// </summary>
    public partial class Klient_TrenerPage : Page
    {
        public Klient_TrenerPage()
        {
            InitializeComponent();
        }

        private void btnSzukaj_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            try
            {
                BazaDAO baza = new BazaDAO();
                dgKlient.ItemsSource = metody.Wyszukaj_Klienta(SzukajTB.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    OpenFileDialog ofd = new OpenFileDialog();
            //    ofd.Filter = "image files |*.jpeg;*.png;*.gif";
            //    if (ofd.ShowDialog() == true)
            //    {
            //        imgKlient.Source = new BitmapImage(new Uri(ofd.FileName));
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            try
            {
                Klient klient = new Klient();
                BazaDAO baza = new BazaDAO();
                klient.Imie = tbxImie.Text;
                klient.Nazwisko = tbxNazwisko.Text;
                klient.Pesel = tbxPesel.Text;
                klient.Adres = tbxAdres.Text;
                klient.Telefon = tbxTelefon.Text;
                if (rbKobieta.IsChecked ==true)
                {
                    klient.Plec = "Kobieta";
                }
                else if (rbMezczyzna.IsChecked == true)
                {
                    klient.Plec = "Mężczyzna";
                }
                
                metody.Dodaj_Klienta(klient, trenerKlientCB.Text);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void trenerKlientCB_Loaded(object sender, RoutedEventArgs e)
        {
           
            try
            {
                var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
                using (var con = new SqlConnection(connectionString))
                {
                    
                    con.Open();
                    string query = "Select * from Trener";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        trenerKlientCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            try
            {
                BazaDAO baza = new BazaDAO();
                Wywiad wywiad = new Wywiad();
                wywiad.Pesel = tbxPesel.Text;
                if (wadaSercaRB.IsChecked == true)
                {
                    wywiad.WadaSerca = true;
                }
                if (nadcisnienieRB.IsChecked == true)
                {
                    wywiad.Nadcisnienie = true;
                }
                if (zaburzeniaRytmuRB.IsChecked == true)
                {
                    wywiad.ZabRytmSerca = true;
                }
                if (epilepsjaRB.IsChecked == true)
                {
                    wywiad.Epilepsja = true;
                }
                if (alergiaRB.IsChecked == true)
                {
                    wywiad.Alergia = true;
                }
                if (astmaRB.IsChecked == true)
                {
                    wywiad.Astma = true;
                }
                if (cukrzycaRB.IsChecked == true)
                {
                    wywiad.Cukrzyca = true;
                }
                wywiad.InneChoroby = inneChorobyTB.Text;
                metody.Zapisz_Wywiad(wywiad);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
