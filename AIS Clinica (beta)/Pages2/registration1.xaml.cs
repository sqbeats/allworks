using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MySqlConnector;
using System.Data;

namespace WPFModernVerticalMenu.Pages2
{
    /// <summary>
    /// Логика взаимодействия для registration1.xaml
    /// </summary>
    public partial class registration1 : Page
    {
        public registration1()
        {
            InitializeComponent();
        }

        private void txtNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == "+")
               && (txtNumber.Text.Contains("+")
               && txtNumber.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string secondname = txtSecondname.Text;
            string number = txtNumber.Text;
            string address = txtAddress.Text;
            string birthday = dpBirthday.DisplayDate.ToString("yyyy-MM-dd");
            string log = txtUser.Text;
            string pass = txtPassword.Text;
            string email = txtEmail.Text;
            string role = cbRole.Text;
            if (role == "Доктор")
            {
                role = "doctor";
            }
            else if (role == "Администратор")
            {
                role = "admin";
            }
            string nullDate = "1111-11-01 12:00:00";
            long workerInfoID = 0;



            string que1 = "INSERT INTO `workerInfo` (`surname`, `name`, `secondname`, `address`, `birthday`, `phoneNumber`, `email`) VALUES ('" + surname + "', '" + name + "', '" + secondname + "', '" + address + "', '" + birthday + "', '"+ number +"', '"+ email +"')";


            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que1, db.getC());

            db.conOpen();

            if (cmd.ExecuteNonQuery() == 1) 
            {
                workerInfoID = cmd.LastInsertedId;
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();

            string que = "INSERT INTO `auth` (`login`, `password`, `role`, `workerInfoID`, `lastSeen`) VALUES ('" + log + "', '" + pass + "', '" + role + "', '" + workerInfoID + "', '"+ nullDate +"')";

            MySqlCommand cmd1 = new MySqlCommand(que, db.getC());

            db.conOpen();

            if (cmd1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация завершена успешно");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();

        }
    }
}
