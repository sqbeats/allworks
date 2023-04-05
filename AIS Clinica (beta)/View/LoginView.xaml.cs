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
using System.Windows.Shapes;
using System.Data;
using MySqlConnector;

namespace WPFModernVerticalMenu.View
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimaze_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            string lg = txtUser.Text;
            string ps = txtPass.Password;
            string que = "SELECT * FROM `auth` WHERE `login` = '" + lg + "' and `password` = '" + ps + "'";

            if (string.IsNullOrWhiteSpace(lg))
                errors.AppendLine("Поле 'Имя пользователя' не может быть пустым!");
            if (string.IsNullOrWhiteSpace(ps))
                errors.AppendLine("Поле 'Пароль' не может быть пустым!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                db db = new db();

                DataTable tab = new DataTable();
                MySqlCommand cmd = new MySqlCommand(que, db.getC());

                MySqlDataAdapter adp = new MySqlDataAdapter();

                adp.SelectCommand = cmd;
                adp.Fill(tab);

                if (tab.Rows.Count > 0)
                {
                    int iduser = int.Parse(tab.Rows[0][0].ToString());

                    string que1 = "UPDATE `auth` SET `lastSeen` = '" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "' WHERE `userID` = '" + iduser + "'";

                    MySqlCommand cmd1 = new MySqlCommand(que1, db.getC());

                    db.conOpen();

                    cmd1.ExecuteNonQuery();

                    MainWindow int1 = new MainWindow();

                    int1.id = iduser;
                    int1.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Неправильный логин или пароль!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
