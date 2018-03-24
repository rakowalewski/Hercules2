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

namespace Hercules.TrenerView
{
    /// <summary>
    /// Logika interakcji dla klasy Trening_TrenerPage.xaml
    /// </summary>
    public partial class Trening_TrenerPage : Page
    {
        public Trening_TrenerPage()
        {
            InitializeComponent();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
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
                        trenerTreningCB.Items.Add(dr["Login"].ToString());
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
            string idTrenera;
            try
            {
                var connectionString = @"Data Source=RAFAL-PC;initial catalog=FITNES;integrated security=True";
                using (var con = new SqlConnection(connectionString))
                {

                    con.Open();
                    string query = "Select IdTrener from Trener where Login = @login";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@login", trenerTreningCB.Text));
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    idTrenera = dataReader["IdTrenera"].ToString();
                    
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                BazaDAO baza = new BazaDAO();
                Trening trening = new Trening();
                trening.IdTrener = Int32.Parse(idTrenera);
                trening.Pesel = peselKlientaTB.Text;
                trening.DataGodzRozp = rozpoczecieDP.Text;
                trening.DataGodzZak = zakonczenieDP.Text;
                if (czyZakonczonyCHB.IsChecked == true)
                {
                    trening.CzyZakonczono = true;
                }
                trening.Kwota = Int32.Parse(naleznoscTB.Text);
                metody.Dodaj_Trening(trening);

            }
            catch (Exception)
            {

                throw;
            }
            

           
        }

        private void ComboBox_Loaded_1(object sender, RoutedEventArgs e)
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
                        trenerTreningCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void szukajBTN_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            try
            {
                BazaDAO baza = new BazaDAO();
                if (dniaCHB.IsChecked == true)
                {
                    metody.Pobierz_Trening_Dnia(dataTreningDP.Text, trenerTreningSzukajCB.Text);
                }
                else
                {
                    metody.Pobierz_Trening_Trener(trenerTreningSzukajCB.Text);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TabControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            dataTreningDP.IsEnabled = true;
        }
    }
}
