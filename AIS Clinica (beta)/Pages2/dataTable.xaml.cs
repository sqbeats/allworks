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
using System.Collections.ObjectModel;
using MySqlConnector;
using System.Data;

namespace WPFModernVerticalMenu.Pages2
{
    /// <summary>
    /// Логика взаимодействия для dataTable.xaml
    /// </summary>
    public partial class dataTable : Page
    {
        public dataTable()
        {
            InitializeComponent();
        }

        public class Users
        {
            public string idUsers { get; set; }
            public string login { get; set; }
            public string password { get; set; }
            public string role { get; set; }
            public string lastSeen { get; set; }
            public string workerInfoID { get; set; }
        }

        private void fillData()
        {
            db db = new db();
            db.conOpen();
            string query = "SELECT * FROM `auth`";

            MySqlCommand command = new MySqlCommand(query, db.getC());
            MySqlDataReader reader = command.ExecuteReader();


            db.conOpen();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            db.conClose();

            db.conOpen();

            string query1 = "SELECT count(*) FROM `auth`";

            MySqlCommand cmd = new MySqlCommand(query1, db.getC());

            values.Text = "Записей: " + cmd.ExecuteScalar().ToString();

            db.conClose();

            List<Users> usersList = new List<Users>();
            for (int i = 0; i < data.Count; i++)
            {
                string role1 = data[i][3];

                if (role1 == "doctor")
                    role1 = "Доктор";


                usersList.Add(new Users { idUsers = data[i][0], login = data[i][1], password = data[i][2], role = role1, lastSeen = data[i][4], workerInfoID = data[i][5] });
            }
            usersGrid.ItemsSource = usersList;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int userID = usersGrid.SelectedIndex + 1;

                db db = new db();
                string query = "DELETE FROM `auth` WHERE `workerInfoID` = '" + userID + "'";

                MySqlCommand command = new MySqlCommand(query, db.getC());

                db.conOpen();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно удалена");
                    usersGrid.ItemsSource = null;
                    fillData();
                }
                db.conClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
