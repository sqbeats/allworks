using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            login.Text = "Введите логин или Email";
            login.ForeColor = Color.Gray;

            password.Text = "Введите пароль";
            password.ForeColor = Color.Gray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = login.Text;
            string pas = password.Text;
            string que = "SELECT * FROM `users` WHERE `login` = '"+log+"' and `password` = '"+pas+"'";

            db db = new db();

            DataTable tab = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            adp.SelectCommand = cmd;
            adp.Fill(tab);

            string role = tab.Rows[0][8].ToString();

            if (tab.Rows.Count > 0 & role == "user")
            {
                string iduser = tab.Rows[0][0].ToString();

                Form2 fr1 = new Form2();
                fr1.id = iduser;
                fr1.Show();
                this.Hide();
            }
            else if (role == "director")
            {
                string iduser = tab.Rows[0][0].ToString();

                formAdm fr2 = new formAdm();
                fr2.id = iduser;
                fr2.Show();
                this.Hide();
            }
            else if (role == "worker")
            {
                string iduser = tab.Rows[0][0].ToString();

                formWorker fr3 = new formWorker();
                fr3.Show();
                fr3.id = iduser;
                this.Hide();
            }
            else
                MessageBox.Show("Неизвестная ошибка");



        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register reg = new register();
            reg.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if(login.Text == "Введите логин или Email")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Введите логин или Email";
                login.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {            
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
            }
        }
    }
}
