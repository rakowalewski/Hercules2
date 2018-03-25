using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;
using ClassLibrary;
using ClassLibrary.DAO;

namespace Hercules.TrenerView
{
    /// <summary>
    /// Logika interakcji dla klasy Harmonogram_TrenerPage.xaml
    /// </summary>
    public partial class Harmonogram_TrenerPage : Page
    {
        public Harmonogram_TrenerPage()
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
                        trenerHarmonogramCB.Items.Add(dr["Login"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pobierzHarmonogramBTN_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            try
            {
                BazaDAO baza = new BazaDAO();
                HarmonogramDG.ItemsSource = metody.Pobierz_Harmonogram(trenerHarmonogramCB.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
