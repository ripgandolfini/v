using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Adatbázisbeolvasás
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Barlang> barlangok = new List<Barlang>();

        MySql.Data.MySqlClient.MySqlConnection myConnection;

        string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=barlangok";

       

        public MainWindow()
        {
            InitializeComponent();
            myConnection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
            myConnection.Open();
            MySqlCommand sqlcommand = new MySqlCommand();
            sqlcommand.Connection = myConnection;
            sqlcommand.CommandText = "select * from barlang";
            var myReader = sqlcommand.ExecuteReader();
            while (myReader.Read()) {
                Barlang barlang = new Barlang(myReader);
                barlangok.Add(barlang);
            }
            myConnection.Close();
            myDtg.ItemsSource = barlangok;
        }
    }
}