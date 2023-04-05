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

namespace likerovodochniy
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string log = password.Text;
            string pas = login.Text;
            string que = "SELECT * FROM `users` WHERE `login` = '" + log + "' and `password` = '" + pas + "'";

            db db = new db();

            DataTable tab = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            adp.SelectCommand = cmd;
            adp.Fill(tab);

            if (tab.Rows.Count > 0)
            {
                string role = tab.Rows[0][8].ToString();

                if (tab.Rows.Count > 0 & role == "adverst")
                {
                    string iduser = tab.Rows[0][0].ToString();

                    formAdverst fr1 = new formAdverst();
                    fr1.id = iduser;
                    fr1.Show();
                    this.Hide();
                }
                else if (role == "director")
                {
                    string iduser = tab.Rows[0][0].ToString();

                    formDirector fr2 = new formDirector();
                    fr2.id = iduser;
                    fr2.Show();
                    this.Hide();
                }
                else if (role == "supervisor")
                {
                    string iduser = tab.Rows[0][0].ToString();

                    formSupervisor fr3 = new formSupervisor();
                    /*fr3.id = iduser;*/
                    fr3.Show();
                    this.Hide();
                }
                else if (role == "employer")
                {
                    string iduser = tab.Rows[0][0].ToString();

                    formEmployer fr4 = new formEmployer();
                    /*fr4.id = iduser;*/
                    fr4.Show();
                    this.Hide();
                }
                else if (tab.Rows.Count > 0 & role == "adverstDir")
                {
                    string iduser = tab.Rows[0][0].ToString();

                    formAdverst fr1 = new formAdverst();
                    fr1.id = iduser;
                    fr1.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Неверный Логин или Пароль!");
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Введите логин или Email")
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
                password.PasswordChar = '*';
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
                password.PasswordChar = '\0';
            }
        }
    }
}
