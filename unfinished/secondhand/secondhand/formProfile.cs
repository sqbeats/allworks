using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace secondhand
{
    public partial class Профиль : Form
    {
        public Профиль()
        {
            InitializeComponent();
        }

        private void Профиль_Load(object sender, EventArgs e)
        {
            name.Text = "Имя: " + DataBank.name;
            surname.Text = "Фамилия: " + DataBank.surname;
            secondName.Text = "Отчество: " + DataBank.secondname;
            phone.Text = "Номер телефона: " + DataBank.number;
            email.Text = "Электронная почта: " + DataBank.email;

            if (DataBank.role == "user")
            {
                role.Text = "Должность: Пользователь";
            }
            else if (DataBank.role == "director")
            {
                role.Text = "Должность: Директор";
            }
            else if (DataBank.role == "worker")
            {
                role.Text = "Должность: Работник";
            }

        }
    }
}
