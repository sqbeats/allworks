using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vodka
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

            if (DataBank.role == "adverst")
            {
                role.Text = "Должность: Рекламный агент";
            }
            else if (DataBank.role == "director")
            {
                role.Text = "Должность: Директор";
            }
            else if (DataBank.role == "supervisor")
            {
                role.Text = "Должность: Начальник Смены";
            }
            else if (DataBank.role == "employer")
            {
                role.Text = "Должность: Отдел кадров";
            }
        }
    }
}
