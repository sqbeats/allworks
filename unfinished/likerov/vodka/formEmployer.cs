using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace vodka
{
    public partial class formEmployer : Form
    {
        public formEmployer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string secondname = textBox3.Text;
            string number = maskedTextBox1.Text;
            string kadr = DataBank.id;
            string birth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string que = "INSERT INTO `workersInfo` (`Фамилия`, `Имя`, `Отчество`, `Дата рождения`, `Номер телефона` , `Кадровый агент`) VALUES ('"+surname+"', '"+name+"', '"+secondname+"', '"+birth+"', '"+number+"' ,'"+kadr+"')";

            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

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
