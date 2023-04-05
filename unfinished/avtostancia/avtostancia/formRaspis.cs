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
    public partial class formRaspis : Form
    {
        public formRaspis()
        {
            InitializeComponent();

            addButton.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            timeSpendTB.Visible = false;
            timePrTB.Visible = false;
            numberTB.Visible = false;
            label5.Visible = false;

            LoadData();

        }

        private void LoadData()
        {
            if (DataBank.role != "user")
            {
                addButton.Visible = true;

                button1.Visible = false;

                label3.Visible = true;
                label4.Visible = true;
                timeSpendTB.Visible = true;
                timePrTB.Visible = true;
                label5.Visible = true;
                numberTB.Visible = true;


            }

            db db = new db();

            db.conOpen();
            MySqlCommand selectFrom = new MySqlCommand("SELECT `fromStation` FROM `schedule` GROUP BY `fromStation`", db.getC());
            MySqlDataReader dr = selectFrom.ExecuteReader();
            while (dr.Read())
            {
                string fromm = dr["fromStation"].ToString();
                fromCB.Items.Add(fromm);
            }
            db.conClose();

            db.conOpen();
            MySqlCommand selectFrom1 = new MySqlCommand("SELECT `toStation` FROM `schedule` GROUP BY `toStation`", db.getC());
            MySqlDataReader dr1 = selectFrom1.ExecuteReader();
            while (dr1.Read())
            {
                string fromm = dr1["toStation"].ToString();
                toCB.Items.Add(fromm);
            }
            db.conClose();

            db.conOpen();
            MySqlCommand selectFrom2 = new MySqlCommand("SELECT `date` FROM `schedule` GROUP BY `date`", db.getC());
            MySqlDataReader dr2 = selectFrom2.ExecuteReader();
            while (dr2.Read())
            {
                string fromm = dr2["date"].ToString();
                dataCB.Items.Add(fromm);
            }
            db.conClose();
        }

        private void send_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db = new db();

            string from = fromCB.Text;
            string to = toCB.Text;
            string date = dataCB.Text;

            db.conOpen();

            string query = "SELECT `number`, `race`, `fromStation`, `toStation`, `timeSend`, `timePr`, `date` FROM `schedule` WHERE `fromStation` = '"+from+"' and `toStation` = '"+to+"' and `date` = '"+date+"'";

            MySqlCommand command = new MySqlCommand(query, db.getC());

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            dataGridView1.Rows.Clear();

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
                dataGridView1.Rows.Add(s);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string from = fromCB.Text;
            string to = toCB.Text;
            string date = dataCB.Text;
            string timeSpend = timeSpendTB.Text;
            string timePr = timePrTB.Text;
            string number = numberTB.Text;

            string que = "INSERT INTO `schedule` (`number`, `fromStation`, `toStation`, `timeSend`, `timePr`, `date`, `race`) VALUES ('"+number+"', '"+from+"', '"+to+"', '"+timeSpend+"', '"+timePr+"', '"+date+"', 000)";

            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            db.conOpen();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Рейс внесён в расписание");
            }
            else
                MessageBox.Show("Неизвестная ошибка!");
            db.conClose();
        }
    }
}
