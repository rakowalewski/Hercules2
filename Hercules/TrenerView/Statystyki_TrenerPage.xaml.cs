using ClassLibrary;
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
    /// Logika interakcji dla klasy Statystyki_TrenerPage.xaml
    /// </summary>
    public partial class Statystyki_TrenerPage : Page
    {
        public Statystyki_TrenerPage()
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
                        TrenerCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PobierzMiesiacBTN_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            try
            {
                BazaDAO baza = new BazaDAO();
                ZarobkiMiesiacTB.Text = metody.Raport_Miesieczny(poczatkowaDP.Text, koncowaDP.Text, TrenerCB.Text).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PobierzRokBTN_Click(object sender, RoutedEventArgs e)
        {
            BazaDAO baza = new BazaDAO();
            Metody metody = new Metody();
            ZarobkiRokTB.Text = metody.Raport_Roczny(RokRokTB.Text, TrenerCB.Text).ToString();
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
                        TrenerCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void historiaTreningowBTN_Click(object sender, RoutedEventArgs e)
        {
            BazaDAO baza = new BazaDAO();
            Metody metody = new Metody();
            historiaTreningowDG.ItemsSource = metody.Pobierz_Trening_Historia(peselHistoriaTreningowTB.Text, trenerHistoriaCB.Text);
        }
    }
}
