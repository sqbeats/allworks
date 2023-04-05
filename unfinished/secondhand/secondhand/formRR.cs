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
    public partial class formRR : Form
    {
        public formRR()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT * FROM `reviews`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
