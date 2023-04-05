using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace session1
{
    public partial class function : Form
    {
        public function()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string adres = textBox2.Text;
            string phonem = maskedTextBox1.Text;
            string que = "INSERT INTO `поставщики` (`Наименование`, `Адрес`, `Номер телефона`) VALUES ('" + name + "', '" + adres + "', '" + phonem + "')";



            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            db.conOpen();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Поставщик успешно внесён в Базу Данных");
            }
            else
                MessageBox.Show("Неизвестная ошибка!");
            db.conClose();
        }

        string post1;
        private void button2_Click(object sender, EventArgs e)
        {
            string name11 = textBox3.Text;
            string count = textBox4.Text;
            string post = textBox5.Text;
            string date = dateTimePicker1.Value.ToString();
            string que1 = "SELECT * FROM `поставщики` WHERE `Наименование` = '"+post +"'";

            db db = new db();

            DataTable tab = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand(que1, db.getC());

            adp.SelectCommand = cmd;
            adp.Fill(tab);



            if (tab.Rows.Count > 0)
            {
                post1 = tab.Rows[0][0].ToString();

                string que2 = "INSERT INTO `goods` (`idPost`, `Наименование`, `Количество`, `Дата поставки`) VALUES ('" + post1 + "', '" + name11 + "', '" + count + "', '" + dateTimePicker1.Value + "')";

                MySqlCommand cmd1 = new MySqlCommand(que2, db.getC());

                db.conOpen();
                if (cmd1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Товар успешно внесён в Базу Данных!");
                }
                else
                    MessageBox.Show("Неизвестная ошибка!");
                db.conClose();
            }
            else
                MessageBox.Show("Введите существующее имя поставщика!");

            


        }
    }
}
