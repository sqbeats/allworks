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
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();

            LoadData();

            lblTitleChildForm.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textId.Visible = false;
            textRole.Visible = false;
            button1.Visible = false;

        }


        private void LoadData()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT * FROM `users`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textRole.Text == "user" || textRole.Text == "director" || textRole.Text == "worker" && textId.Text != "")
            {

                db db = new db();

                string idd = textId.Text;
                string rolee = textRole.Text;

                MySqlCommand cmd = new MySqlCommand("UPDATE `users` SET `role` = '" + rolee + "' WHERE `users`.`id` = '" + idd + "';", db.getC());

                db.conOpen();
                cmd.ExecuteNonQuery();
                db.conClose();

                db.conOpen();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Роль успешно изменена");
                }
                else
                    MessageBox.Show("Ошибка!\nВведите существующую роль и существующий id!");
                db.conClose();
            }
            else
                MessageBox.Show("Ошибка!\nВведите существующую роль и существующий id!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            LoadData();
        }

        private void formUsers_Load(object sender, EventArgs e)
        {
            if (DataBank.role == "director")
            {
                lblTitleChildForm.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                textId.Visible = true;
                textRole.Visible = true;
                button1.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
