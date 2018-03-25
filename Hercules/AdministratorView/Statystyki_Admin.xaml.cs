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

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy Statystyki_Admin.xaml
    /// </summary>
    public partial class Statystyki_Admin : Page
    {
        public Statystyki_Admin()
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

        //private void MiesiacCB_Loaded(object sender, RoutedEventArgs e)
        //{
        //    for (int i = 1; i < 13; i++)
        //    {
        //        MiesiacCB.Items.Add(i);
        //    }
        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PobierzRokBTN_Click(object sender, RoutedEventArgs e)
        {
            BazaDAO baza = new BazaDAO();
            Metody metody = new Metody();
            ZarobkiRokTB.Text = metody.Raport_Roczny(RokRokTB.Text, TrenerCB.Text).ToString();
        }
    }
}
