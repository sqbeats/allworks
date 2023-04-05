using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using MySqlConnector;

namespace likerovodochniy
{
    public partial class formAdverst : Form
    {

        public string id;
        public formAdverst()
        {
            InitializeComponent();

            LoadData();
            LoadData2();

            dataGridView1.DefaultCellStyle.Font = new Font("Book Antiqua", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 12);
            dataGridView2.DefaultCellStyle.Font = new Font("Book Antiqua", 12);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 12);
        }

        private void formAdverst_Load(object sender, EventArgs e)
        {
            db db = new db();
            DataTable table = new DataTable();
            db.conOpen();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string queryy = "SELECT `id`, `login`, `email`, `name`,`surname`, `secondname`, `phone`, `role`, `image`  FROM `users` WHERE id = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(queryy, db.getC());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataBank.email = reader["email"].ToString();
                DataBank.login = reader["login"].ToString();
                DataBank.name = reader["name"].ToString();
                DataBank.surname = reader["surname"].ToString();
                DataBank.secondname = reader["secondname"].ToString();
                DataBank.number = reader["phone"].ToString();
                DataBank.id = reader["id"].ToString();
                DataBank.role = reader["role"].ToString();
            }
            db.conClose();


            this.Text = "ОТДЕЛ РЕКЛАМЫ              ПОЛЬЗОВАТЕЛЬ: " + DataBank.surname.ToUpper() + " " + DataBank.name.ToUpper();

            name.Text = "Имя: " + DataBank.name;
            surname.Text = "Фамилия: " + DataBank.surname;
            secondName.Text = "Отчество: " + DataBank.secondname;
            phone.Text = "Номер телефона: " + DataBank.number;
            email.Text = "Электронная почта: " + DataBank.email;
            if (DataBank.role == "adverst")
            {
                dolj.Text = "Должность: Рекламный агент";
                tabControl1.TabPages.Remove(tabPage3);
            }
            else if (DataBank.role == "adverstDir")
            {
                dolj.Text = "Должность: Руководитель Отдела Рекламы";
                tabControl1.TabPages.Remove(tabPage2);
            }

            if (DataBank.role == "adverst")
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                DataTable table1 = new DataTable();
                db.conOpen();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                string quee = "SELECT idUsers FROM adversting WHERE idUsers = '" + DataBank.id + "' AND dateFill BETWEEN '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";

                MySqlCommand cmd1 = new MySqlCommand(quee, db.getC());

                adapter1.SelectCommand = cmd1;
                adapter1.Fill(table1);

                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                string quee2 = "SELECT idUsers FROM survey WHERE idUsers = '" + DataBank.id + "' AND dateFill BETWEEN '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";

                MySqlCommand cmd2 = new MySqlCommand(quee2, db.getC());

                adapter2.SelectCommand = cmd2;
                adapter2.Fill(table2);

                db.conClose();

                try
                {
                    db.conOpen();

                    MySqlCommand cmd3 = new MySqlCommand("SELECT image FROM users WHERE id = '"+DataBank.id+"'", db.getC());
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd3);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "users");
                    int c = ds.Tables["users"].Rows.Count;

                    if (c > 0)
                    {
                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])(ds.Tables["users"].Rows[c - 1]["image"]);
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        pictureBox6.Image = Image.FromStream(stmBLOBData);
                        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    db.conClose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                if (table1.Rows.Count > 0 || table2.Rows.Count > 0)
                    {
                        label13.Text = "Проведенно рекламных акций: " + table1.Rows.Count.ToString();
                        label14.Text = "Проведенно опросов: " + table2.Rows.Count.ToString();
                    }
                    else
                    {
                        label13.Text = "Проведенно рекламных акций: " + "0";
                        label14.Text = "Проведенно опросов: " + "0";
                    }
                }
            else
                {
                    panel5.Visible = false;
                }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string finish1 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string budget1 = textBox1.Text;
            string attracted1 = textBox2.Text;
            string impressions1 = textBox3.Text;
            string idUser = DataBank.id;
            DateTime now = DateTime.Now;
            

            string que = "INSERT INTO `adversting` (`idUsers`, `start`, `finish`, `budget`, `attracted`, `impressions`, `dateFill`) VALUES ('" + idUser + "', '" + start1 + "', '" + finish1 + "', '" + budget1 + "', '" + attracted1 + "', '" + impressions1 + "', '"+now.ToString("yyyy-MM-dd HH:mm:ss")+"')";



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

        private void button2_Click(object sender, EventArgs e)
        {
            string start1 = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            string subject1 = textBox7.Text;
            string ohvat1 = textBox4.Text;
            string polozh1 = textBox5.Text;
            string otric = textBox6.Text;
            string idUser = DataBank.id;
            DateTime now = DateTime.Now;

            string que = "INSERT INTO `survey` (`idUsers`, `date`, `theme`, `involved`, `passed`, `refused`, dateFill) VALUES ('" + idUser + "', '" + start1 + "', '" + subject1 + "', '" + ohvat1 + "', '" + polozh1 + "', '" + otric + "', '"+now.ToString("yyyy-MM-dd HH-mm-ss")+"')";

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

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (DataBank.role == "adverst")
            {
                db db = new db();
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                DataTable table1 = new DataTable();
                db.conOpen();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                string quee = "SELECT idUsers FROM adversting WHERE idUsers = '" + DataBank.id + "' AND dateFill BETWEEN '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";

                MySqlCommand cmd1 = new MySqlCommand(quee, db.getC());

                adapter1.SelectCommand = cmd1;
                adapter1.Fill(table1);

                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                string quee2 = "SELECT idUsers FROM survey WHERE idUsers = '" + DataBank.id + "' AND dateFill BETWEEN '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";

                MySqlCommand cmd2 = new MySqlCommand(quee2, db.getC());

                adapter2.SelectCommand = cmd2;
                adapter2.Fill(table2);

                db.conClose();

                if (table1.Rows.Count > 0 || table2.Rows.Count > 0)
                {
                    label13.Text = "Проведенно рекламных акций: " + table1.Rows.Count.ToString();
                    label14.Text = "Проведенно опросов: " + table2.Rows.Count.ToString();
                }
                else
                {
                    label13.Text = "Проведенно рекламных акций: " + "0";
                    label14.Text = "Проведенно опросов: " + "0";
                }
            }
            else
            {
                label13.Visible = false;
                label14.Visible = false;
            }
        }



        private void LoadData()
        {
            db db = new db();

            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            db.conOpen();

            string query = "SELECT `idUsers`, `start`, `finish`, `budget`, `attracted`, `impressions`, `dateFill` FROM `adversting` WHERE dateFill BETWEEN '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";

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
                dataGridView1.Rows.Add(s);
        }

        private void LoadData2()
        {
            db db = new db();

            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            db.conOpen();

            string query = "SELECT `idUsers`, `date`, `theme`, `involved`, `passed`, `refused`, `dateFill` FROM `survey` WHERE dateFill BETWEEN '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";

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
                dataGridView2.Rows.Add(s);
        }

        private void LoadData3()
        {
            db db = new db();

            db.conOpen();

            string query = "SELECT `idUsers`, `start`, `finish`, `budget`, `attracted`, `impressions`, `dateFill` FROM `adversting` WHERE dateFill BETWEEN '" + startDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";

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
                dataGridView1.Rows.Add(s);
        }

        private void LoadData4()
        {
            db db = new db();

            

            db.conOpen();

            string query = "SELECT `idUsers`, `date`, `theme`, `involved`, `passed`, `refused`, `dateFill` FROM `survey` WHERE dateFill BETWEEN '" + startDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + endDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";

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
                dataGridView2.Rows.Add(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData3();
            dataGridView2.Rows.Clear();
            LoadData4();
        }
    }
}
