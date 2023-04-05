using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace secondhand
{
    public partial class formOrders : Form
    {
        public formOrders()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            db db = new db();
            string st = "Ожидает звонка оператора";

            db.conOpen();

            string query = "SELECT * FROM `orders` WHERE `status` = '" + st + "'";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textRole.Text != "" && textId.Text != "")
            {

                db db = new db();

                string idd = textId.Text;
                string rolee = textRole.Text;

                MySqlCommand cmd = new MySqlCommand("UPDATE `orders` SET `status` = '" + rolee + "' WHERE `orders`.`id` = '" + idd + "';", db.getC());

                db.conOpen();
                cmd.ExecuteNonQuery();
                db.conClose();


                db.conOpen();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Статус заказа успешно изменён");
                }
                else
                    MessageBox.Show("Ошибка!\nВведите существующий id заказа");
                db.conClose();
            }
            else
                MessageBox.Show("Ошибка!\nВведите существующий id заказа");
        }
    }
}
