using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace secondhand
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passwordField.Text = "Введите пароль";
            passwordField.ForeColor = Color.Gray;
            passwordField.UseSystemPasswordChar = false;

            nameField.Text = "Введите имя";
            nameField.ForeColor = Color.Gray;

            sNameField.Text = "Введите фамилию";
            sNameField.ForeColor = Color.Gray;

            secondNameField.Text = "Введите отчество";
            secondNameField.ForeColor = Color.Gray;

            emailField.Text = "Введите элекронную почту";
            emailField.ForeColor = Color.Gray;

            codeF.Enabled = false;

        }

        Random rnd = new Random();
        public int code;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void label2_Enter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_Leave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void register_Load(object sender, EventArgs e)
        {
            string filename = @"C:\Users\pc\Desktop\sogl.txt";
            using (StreamReader rdr = new StreamReader(filename))
            {
                String content = rdr.ReadToEnd();
                soglas.Text = content;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = loginField.Text;
            string pas = passwordField.Text;
            string email = emailField.Text;
            string phone = phoneField.Text;
            string name = nameField.Text;
            string surn = sNameField.Text;
            string secname = secondNameField.Text;
            string que = "INSERT INTO `users` (`login`, `password`, `name`, `surname`, `secondname`, `phone`, `email`, `role`) VALUES ('" + log + "', '" + pas + "', '" + name + "', '" + surn + "', '" + secname + "', '" + phone + "', '" + email + "', @uR)";



            if (nameField.Text == "Введите имя")
            {
                MessageBox.Show("Для регистрации аккаунта введите ваше Имя!");
                return;
            }

            if (sNameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Для регистрации аккаунта введите вашу Фамилию!");
                return;
            }

            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Для регистрации аккаунта введите ваш Логин!");
                return;
            }

            if (passwordField.Text == "Введите пароль")
            {
                MessageBox.Show("Для регистрации аккаунта введите ваш Пароль!");
                return;
            }

            if (secondNameField.Text == "Введите отчество")
            {
                MessageBox.Show("Для регистрации аккаунта введите ваше Отчество!");
                return;
            }

            if (emailField.Text == "Введите элекронную почту")
            {
                MessageBox.Show("Для регистрации аккаунта введите ваш Email!");
                return;
            }

            if (phoneField.Text == "")
            {
                MessageBox.Show("Для регистрации аккаунта введите ваш Номер Телефона!");
                return;
            }


            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());
            cmd.Parameters.Add("@uR", MySqlDbType.VarChar).Value = "user";

            db.conOpen();

            if (cmd.ExecuteNonQuery() == 1) /* code.ToString() == codeF.Text */
            {
                MessageBox.Show("Аккаунт успешно зарегестрирован");
                this.Hide();
                Form1 fr = new Form1();
                fr.Show();
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введите пароль")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Введите пароль";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Введите элекронную почту")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {
                emailField.Text = "Введите элекронную почту";
                emailField.ForeColor = Color.Gray;
            }
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите имя")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.Text = "Введите имя";
                nameField.ForeColor = Color.Gray;
            }
        }

        private void sNameField_Enter(object sender, EventArgs e)
        {
            if (sNameField.Text == "Введите фамилию")
            {
                sNameField.Text = "";
                sNameField.ForeColor = Color.Black;
            }
        }

        private void sNameField_Leave(object sender, EventArgs e)
        {
            if (sNameField.Text == "")
            {
                sNameField.Text = "Введите фамилию";
                sNameField.ForeColor = Color.Gray;
            }
        }

        private void secondNameField_Enter(object sender, EventArgs e)
        {
            if (secondNameField.Text == "Введите отчество")
            {
                secondNameField.Text = "";
                secondNameField.ForeColor = Color.Black;
            }
        }

        private void secondNameField_Leave(object sender, EventArgs e)
        {
            if (secondNameField.Text == "")
            {
                secondNameField.Text = "Введите отчество";
                secondNameField.ForeColor = Color.Gray;
            }
        }

        private void codd_Click(object sender, EventArgs e)
        {
            if (emailField.Text == "Введите элекронную почту")
            {
                MessageBox.Show("Для отправки кода подтверждения сначала нужно ввести Email!");
                return;
            }

            codeF.Enabled = true;

            code = rnd.Next(123123, 999999);

            MailAddress fromAdress = new MailAddress("musicrar99@gmail.com", "Antique-Music - Магазин Музыкального Антиквариата");
            MailAddress toAdress = new MailAddress(emailField.Text, loginField.Text);
            MailMessage message = new MailMessage(fromAdress, toAdress);
            message.Subject = "Спасибо за регистрацию!";
            message.Body = "Для подтвержения регистрации введите данный код: " + code + "\n\nСпасибо, что пользуетесь нашим продуктом!";


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "782jJhshx*9sjxH");


            smtpClient.Send(message);
            MessageBox.Show("Письмо с кодом для подтверждения регистрации успешно отправленно");
            codd.Enabled = false;
        }
    }
}
