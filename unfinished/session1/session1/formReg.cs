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
    public partial class formReg : Form
    {
        public formReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lg = login.Text;
            string ps = password.Text;
            string nam1 = name.Text;
            string adress1 = adress.Text;
            string phonem = phone.Text;
            string que = "INSERT INTO `auth` (`login`, `password`, `name`, `adress`, `phone`) VALUES ('" + lg + "', '" + ps + "', '" + nam1 + "', '" + adress1 + "', '" + phonem + "')";



            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            db.conOpen();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешная регистрация");
                this.Hide();
                Form1 fr = new Form1();
                fr.Show();
            }
            else
                MessageBox.Show("Неизвестная ошибка");
            db.conClose();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Blue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }
    }
}
