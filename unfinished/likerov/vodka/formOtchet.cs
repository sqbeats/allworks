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
    public partial class formOtchet : Form
    {
        public formOtchet()
        {
            InitializeComponent();

            LoadData();
            LoadData1();
            LoadData2();
            LoadData3();
            LoadData4();
            LoadData5();
        }

        private void LoadData()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT `idUsers`, `start`, `finish`, `budget`, `attracted`, `impressions` FROM `adversting`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            formRR rr = new formRR();
            rr.Show();
        }

        private void LoadData1()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT * FROM `survey`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData1();
        }

        private void LoadData2()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT `id`, `Фамилия`, `Имя`, `Отчество`, `Дата рождения`, `Номер телефона` , `Кадровый агент` FROM `workersInfo`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void LoadData3()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT `Дата`, `idworkersInfo`, `Количество отработанных часов`, `Начальник смены` FROM `workers`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView4.Rows.Add(s);
        }
        private void LoadData4()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT `idProducts`, `idUsers`, `Дата`, `Изготовлено`, `Брак` FROM `warehouse`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView5.Rows.Add(s);
        }

        private void LoadData5()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT * FROM `products`";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            db.conClose();

            foreach (string[] s in data)
                dataGridView6.Rows.Add(s);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            LoadData3();
            dataGridView5.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
