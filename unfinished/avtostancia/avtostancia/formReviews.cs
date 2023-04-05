using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace avtostancia
{
    public partial class formReviews : Form
    {
        public formReviews()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {



            string que = "INSERT INTO `reviews` (idUsers, review) VALUES (@ul, @rw)";

            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            cmd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = DataBank.id;
            cmd.Parameters.Add("@rw", MySqlDbType.VarChar).Value = textBox1.Text;

            db.conOpen();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отзыв успешно отправлен");
            }
            else
                MessageBox.Show("Неизвестная ошибка!");
        }

        private void formReviews_Load(object sender, EventArgs e)
        {

        }
    }
}
