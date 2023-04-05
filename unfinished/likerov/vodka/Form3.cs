using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vodka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string finish1 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string budget1 = textBox3.Text;
            string attracted1 = textBox4.Text;
            string impressions1 = textBox5.Text;
            string idUser = DataBank.id;

            string que = "INSERT INTO `adversting` (`idUsers`, `start`, `finish`, `budget`, `attracted`, `impressions`) VALUES ('" + idUser + "', '" + start1 + "', '" + finish1 + "', '" + budget1 + "', '" + attracted1 + "', '" + impressions1 + "')";



            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());
            cmd.Parameters.Add("@uR", MySqlDbType.VarChar).Value = "user";

            db.conOpen();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отчёт успешно внесён!");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string start1 = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            string subject1 = textBox1.Text;
            string ohvat1 = textBox2.Text;
            string polozh1 = textBox6.Text;
            string otric = textBox7.Text;
            string idUser = DataBank.id;

            string que = "INSERT INTO `survey` (`idUsers`, `Дата опроса`, `Тема опроса`, `Задействовано людей`, `Положительных ответов`, `Отрицательных ответов`) VALUES ('" + idUser + "', '" + start1 + "', '" + subject1 + "', '" + ohvat1 + "', '" + polozh1 + "', '" + otric + "')";



            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());
            cmd.Parameters.Add("@uR", MySqlDbType.VarChar).Value = "user";

            db.conOpen();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отчёт успешно внесён!");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();

        }
    }
}
