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
    public partial class formContacts : Form
    {
        public formContacts()
        {
            InitializeComponent();

            fromF.Text = "От кого";
            fromF.ForeColor = Color.Gray;

            subjectF.Text = "Тема";
            subjectF.ForeColor = Color.Gray;

            fromF.Enabled = false;
            textF.Enabled = false;
            subjectF.Enabled = false;
            sendmaa.Enabled = false;
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            fromF.Enabled = true;
            textF.Enabled = true;
            subjectF.Enabled = true;
            sendmaa.Enabled = true;
        }

        private void sendmaa_Click(object sender, EventArgs e)
        {
            MailAddress fromAdress = new MailAddress("musicrar99@gmail.com", fromF.Text);
            MailAddress toAdress = new MailAddress("musicrarsup@gmail.com", "Work Locksmith - Слесарное дело");
            MailMessage message = new MailMessage(fromAdress, toAdress);
            message.Subject = subjectF.Text;
            message.Body = textF.Text;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "782jJhshx*9sjxH");


            smtpClient.Send(message);
            MessageBox.Show("Ваше обращение успешно зарегистрированно!");
        }

        private void fromF_Enter(object sender, EventArgs e)
        {
            if (fromF.Text == "От кого")
            {
                fromF.Text = "";
                fromF.ForeColor = Color.Black;
            }
        }

        private void fromF_Leave(object sender, EventArgs e)
        {
            if (fromF.Text == "")
            {
                fromF.Text = "От кого";
                fromF.ForeColor = Color.Gray;
            }
        }

        private void subjectF_Enter(object sender, EventArgs e)
        {
            if (subjectF.Text == "Тема")
            {
                subjectF.Text = "";
                subjectF.ForeColor = Color.Black;
            }
        }

        private void subjectF_Leave(object sender, EventArgs e)
        {
            if (subjectF.Text == "")
            {
                subjectF.Text = "Тема";
                subjectF.ForeColor = Color.Gray;
            }
        }
    }
}
