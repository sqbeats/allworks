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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db = new db();

            string name = textBox1.Text;
            string fason = comboBox1.Text;
            string category = textBox2.Text;
            string count = textBox3.Text;
            string price = textBox4.Text;
            string que = "INSERT INTO `goods` (`name`, `category`, `fason`, `count`, `price`) VALUES ('"+name+"', '"+category+"','"+fason+"', '"+count+"', '"+price+"' )";

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            db.conOpen();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Товар успешно добавлен");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
        }
    }
}
