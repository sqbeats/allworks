using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySqlConnector;
using System.Data;

namespace WPFModernVerticalMenu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int id;
        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        // Start: MenuLeft PopupButton //
        private void btnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnHome;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Главная";
            }
        }

        private void btnHome_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnDashboard_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDashboard;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Пользователи";
            }
        }

        private void btnDashboard_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnProducts_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnProducts;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Рабочая зона";
            }
        }

        private void btnProducts_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnProductStock_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnProductStock;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Учет медикаментов";
            }
        }

        private void btnProductStock_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnOrderList_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDiagnosis;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Диагнозы";
            }
        }

        private void btnOrderList_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnBilling_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnPacients;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Пациенты";
            }
        }

        private void btnBilling_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        /*private void btnPointOfSale_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnPointOfSale;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Poin Of Sale";
            }
        }*/

        private void btnPointOfSale_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        /*private void btnSecurity_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnSecurity;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Security";
            }
        } */

        private void btnSecurity_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        private void btnSetting_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnSetting;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Настройки";
            }
        }

        private void btnSetting_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        // End: MenuLeft PopupButton //

        // Start: Button Close | Restore | Minimize 
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        // End: Button Close | Restore | Minimize

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            alentaTxt.Visibility = Visibility.Hidden;
            sloganTxt.Visibility = Visibility.Hidden;
            fContainer.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            alentaTxt.Visibility = Visibility.Hidden;
            sloganTxt.Visibility = Visibility.Hidden;
            fContainer.Navigate(new System.Uri("Pages/Dashboard.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            string que = "SELECT * FROM `auth` WHERE userID = '" + id + "'";

            db db = new db();

            DataTable tab = new DataTable();
            MySqlCommand cmd = new MySqlCommand(que, db.getC());
            MySqlDataAdapter adp = new MySqlDataAdapter();

            adp.SelectCommand = cmd;
            adp.Fill(tab);

            int workerID = int.Parse(tab.Rows[0][5].ToString());

            string que2 = "SELECT * FROM `workerinfo` WHERE workerInfoID = '"+workerID+"'";

            DataTable tab2 = new DataTable();
            MySqlCommand cmd2 = new MySqlCommand(que2, db.getC());

            MySqlDataAdapter adp2 = new MySqlDataAdapter();

            adp2.SelectCommand = cmd2;
            adp.Fill(tab2);

            db.conOpen();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Model.DataBank.userID = int.Parse(reader["userID"].ToString());
                Model.DataBank.role = reader["role"].ToString();
                Model.DataBank.lastSeen = reader["lastSeen"].ToString();
                Model.DataBank.workerInfoID = int.Parse(reader["workerInfoID"].ToString());
            }

            db.conClose();
            db.conOpen();

            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                Model.DataBank.surname = reader2["surname"].ToString();
                Model.DataBank.name = reader2["name"].ToString();
                Model.DataBank.secondname = reader2["secondname"].ToString();
                Model.DataBank.address = reader2["address"].ToString();
                Model.DataBank.birthday = reader2["birthday"].ToString();
                Model.DataBank.phoneNumber = reader2["phoneNumber"].ToString();
                Model.DataBank.email = reader2["email"].ToString();
            }
            db.conClose();

            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, t) => { timeText.Text = DateTime.Now.ToString("h:mm:ss tt"); };
            timer.Start();


            nssText.Text = Model.DataBank.surname + " " + Model.DataBank.name + " " + Model.DataBank.secondname;

            if(Model.DataBank.role == "doctor")
            {
                roleText.Text = "Должность: Доктор ||";
            }

        }

        private void btnDiagnosis_Click(object sender, RoutedEventArgs e)
        {
            alentaTxt.Visibility = Visibility.Hidden;
            sloganTxt.Visibility = Visibility.Hidden;
            fContainer.Navigate(new System.Uri("Pages/diagnoses.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnPacients_Click(object sender, RoutedEventArgs e)
        {
            alentaTxt.Visibility = Visibility.Hidden;
            sloganTxt.Visibility = Visibility.Hidden;
            fContainer.Navigate(new System.Uri("Pages/pacients.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
