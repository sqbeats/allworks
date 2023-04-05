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
using MySqlConnector;
using System.Data;

namespace WPFModernVerticalMenu.Pages2
{
    /// <summary>
    /// Логика взаимодействия для nearestPatient.xaml
    /// </summary>
    public partial class nearestPatient : Page
    {
        public nearestPatient()
        {
            InitializeComponent();
        }

        public class Users
        {
            public string patientRecordsID { get; set; }
            public string patientID { get; set; }
            public string record { get; set; }
        }

        private void fillData()
        {
            db db = new db();
            db.conOpen();
            string day = dpSelection.DisplayDate.ToString("yyyy-MM-dd HH-mm-ss");
            string today = DateTime.Today.ToString("yyyy-MM-dd HH-mm-ss");
            string query = "SELECT * FROM `patientrecords` WHERE record >= '" + today + "'";


            MySqlCommand command = new MySqlCommand(query, db.getC());
            MySqlDataReader reader = command.ExecuteReader();


            db.conOpen();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            db.conClose();

            db.conOpen();

            string query1 = "SELECT count(*) FROM `patientrecords` WHERE record >= '" + today + "'";

            MySqlCommand cmd = new MySqlCommand(query1, db.getC());

            values.Text = "Записей: " + cmd.ExecuteScalar().ToString();

            db.conClose();

            List<Users> usersList = new List<Users>();
            for (int i = 0; i < data.Count; i++)
            {
                usersList.Add(new Users { patientRecordsID = data[i][0], patientID = data[i][1], record = data[i][2]});
            }
            usersGrid.ItemsSource = usersList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void dpSelection_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            
        }

        private void dpSelection_CalendarClosed(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            usersGrid.ItemsSource = null;

            string day = "";
            DateTime? ddd = dpSelection.SelectedDate;
            if (ddd.HasValue)
            {
                day = ddd.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            }

            db db = new db();
            db.conOpen();
            string query = "SELECT * FROM `patientrecords` WHERE record >= '" + day + "'";


            MySqlCommand command = new MySqlCommand(query, db.getC());
            MySqlDataReader reader = command.ExecuteReader();


            db.conOpen();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            db.conClose();

            db.conOpen();

            string query1 = "SELECT count(*) FROM `patientrecords` WHERE record >= '" + day + "'";

            MySqlCommand cmd = new MySqlCommand(query1, db.getC());

            values.Text = "Записей: " + cmd.ExecuteScalar().ToString();

            db.conClose();

            List<Users> usersList = new List<Users>();
            for (int i = 0; i < data.Count; i++)
            {
                usersList.Add(new Users { patientRecordsID = data[i][0], patientID = data[i][1], record = data[i][2] });
            }
            usersGrid.ItemsSource = usersList;
        }

        private void dpSelection_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
