using ClassLibrary;
using ClassLibrary.Basic;
using ClassLibrary.DAO;
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

namespace Hercules.RecepcjaView
{
    /// <summary>
    /// Logika interakcji dla klasy Klient_RecepcjaPage.xaml
    /// </summary>
    public partial class Klient_RecepcjaPage : Page
    {
        public Klient_RecepcjaPage()
        {
            InitializeComponent();
        }

        private void recepcjaKlientCB_Loaded(object sender, RoutedEventArgs e)
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
                        recepcjaKlientCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
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
                klient.Email = tbxEmail.Text;
                if (rbKobieta.IsChecked == true)
                {
                    klient.Plec = "Kobieta";
                }
                else if (rbMezczyzna.IsChecked == true)
                {
                    klient.Plec = "Mężczyzna";
                }

                metody.Dodaj_Klienta(klient, recepcjaKlientCB.Text);
            }
            catch (Exception)
            {

                throw;
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            BazaDAO baza = new BazaDAO();

            var modyfikowanyRekord = dgKlient.SelectedItem as Klient;
            metody.Modyfikuj_Klienta(modyfikowanyRekord, modyfikowanyRekord.Pesel);
        }
    }
}
