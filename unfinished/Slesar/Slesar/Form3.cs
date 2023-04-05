using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Slesar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            string adr = adresss.Text;
            string trb = trouble.Text;
            string que = "INSERT INTO `orders` (idUsers, adress, trouble, status) VALUES (@uId, '"+adr+"', '"+trb+"', @u)";

            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            cmd.Parameters.Add("@uId", MySqlDbType.VarChar).Value = DataBank.id;
            cmd.Parameters.Add("@u", MySqlDbType.VarChar).Value = "Ожидает исполнения";

            db.conOpen();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявка успешно оставлена, ожидайте звонка!\nСпасибо, что пользуетесь нашими услугами!");
            }
            else
                MessageBox.Show("Неизвестная ошибка!");
        }
    }
}
