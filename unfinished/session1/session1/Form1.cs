using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace session1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lg = login.Text;
            string ps = password.Text;
            string que = "SELECT * FROM `auth` WHERE `login` = '" + lg + "' and `password` = '" + ps + "'";

            db db = new db();

            DataTable tab = new DataTable();
            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            MySqlDataAdapter adp = new MySqlDataAdapter();

            adp.SelectCommand = cmd;
            adp.Fill(tab);

            if (tab.Rows.Count > 0)
            {
                this.Hide();
                mainform fr = new mainform();
                fr.Show();
            }
            else
                MessageBox.Show("Неизвестная ошибка");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReg fr = new formReg();
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
