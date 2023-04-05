using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace vodka
{
    public partial class forgetpass : Form
    {

        Random rnd = new Random();
        public int code;

        db db = new db();
        public forgetpass()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        string id;
        private void mail()
        {

            code = rnd.Next(123123, 999999);


            MailAddress fromAdress = new MailAddress("musicrar99@gmail.com", "Music Helper - Твой уникальный музыкальный помошник");
            MailAddress toAdress = new MailAddress(txtForgetPasswordEmail.Text);
            MailMessage message = new MailMessage(fromAdress, toAdress);


            message.Subject = "Восстановление пароля.";
            message.Body = "Ваш код для восстановления пароля: " + code;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "782jJhshx*9sjxH");


            smtpClient.Send(message);
            MessageBox.Show("Письмо с кодом для восстановления успешно отправлен!");


        }

        private void btnForgetPassordNextStep_Click(object sender, EventArgs e)
        {
            if (code.ToString() == txtForgetPasswordCode.Text)
            {
                txtForgetPasswordConformPassword.Enabled = true;
                txtForgetPasswordNewPassword.Enabled = true;
                btnForgetPasswordChange.Enabled = true;
                btnForgetPassordNextStep.Enabled = false;
                btnForgetPassordSendAgain.Enabled = false;
            }

            else
            {
                MessageBox.Show("Код введён неверно!");
            }
        }

        private void btnForgetPassordSendAgain_Click(object sender, EventArgs e)
        {
            mail();
        }

        private void btnForgetPasswordChange_Click(object sender, EventArgs e)
        {
            if (txtForgetPasswordNewPassword.Text == txtForgetPasswordConformPassword.Text)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE `users` SET `password` = @nPA WHERE `users`.`id` = @id;", db.getC());

                cmd.Parameters.Add("@nPA", MySqlDbType.VarChar).Value = txtForgetPasswordConformPassword.Text;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                db.conOpen();
                cmd.ExecuteNonQuery();
                db.conClose();


                MessageBox.Show("Пароль успешно изменён!");
            }
            else
            {
                MessageBox.Show("Пароль не изменён");
            }
        }

        private void btnForgetPasswordSendMail_Click(object sender, EventArgs e)
        {
            string email = txtForgetPasswordEmail.Text;

            db db = new db();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @uE", db.getC());

            cmd.Parameters.Add("@uE", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {


                txtForgetPasswordCode.Enabled = true;
                btnForgetPassordNextStep.Enabled = true;
                btnForgetPassordSendAgain.Enabled = true;
                btnForgetPasswordSendMail.Enabled = false;

                id = table.Rows[0][0].ToString();

                mail();
            }
            else
                MessageBox.Show("Пользователь с данной почтой не найден!");
        }
    }
}
