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
    /// Логика взаимодействия для personalFile.xaml
    /// </summary>
    public partial class personalFile : Page
    {
        public personalFile()
        {
            InitializeComponent();
        }

        public class Users
        {
            public string workerInfoID { get; set; }
            public string surname { get; set; }
            public string name { get; set; }
            public string secondname { get; set; }
            public string address { get; set; }
            public string birthday { get; set; }
            public string email { get; set; }
            public string phoneNumber { get; set; }
        }



        private void fillData()
        {
            db db = new db();
            db.conOpen();
            string query = "SELECT * FROM `workerinfo`";

            MySqlCommand command = new MySqlCommand(query, db.getC());
            MySqlDataReader reader = command.ExecuteReader();


            db.conOpen();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }

            reader.Close();

            db.conClose();

            db.conOpen();

            string query1 = "SELECT count(*) FROM `workerinfo`";

            MySqlCommand cmd = new MySqlCommand(query1, db.getC());

            values.Text = "Записей: " + cmd.ExecuteScalar().ToString();

            db.conClose();

            List<Users> usersList = new List<Users>();
            for (int i = 0; i < data.Count; i++)
            {
                usersList.Add(new Users { workerInfoID = data[i][0], surname = data[i][1], name = data[i][2], secondname = data[i][3], address = data[i][4], birthday = data[i][5], phoneNumber = data[i][6], email = data[i][7] });
            }
            personalGrid.ItemsSource = usersList;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void usersGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "NAME_DOC")
            {
                e.Column.Header = "Наименование";

                // ...

                Style style = new Style(typeof(DataGridCell));
                style.Setters.Add(new Setter(DataGridCell.ContentTemplateProperty, Resources["templ"]));
                e.Column.CellStyle = style;
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    int workerInfoID = personalGrid.SelectedIndex + 1;

                     db db = new db();
                     string query = "DELETE FROM `workerinfo` WHERE `workerInfoID` = '"+workerInfoID+"'";

                     MySqlCommand command = new MySqlCommand(query, db.getC());

                     db.conOpen();

                     if (command.ExecuteNonQuery() == 1)
                     {
                         MessageBox.Show("Личное дело №" + workerInfoID + " успешно удалено!");
                        personalGrid.ItemsSource = null;
                        fillData();
                     }
                     db.conClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    personalGrid.ItemsSource = null;
                    fillData();
                }
            }
        }
    }
}
