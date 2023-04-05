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
using System.Windows.Media;
using MySqlConnector;

namespace likerovodochniy
{
    public partial class formDirector : Form
    {
        public string id;
        public formDirector()
        {
            InitializeComponent();

            dataGridView1.DefaultCellStyle.Font = new Font("Book Antiqua", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 12);

            LoadData();
        }

        byte[] imageData;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG файлы (*,.jpg)|*.jpg|Bitmap файлы (*.bmp)|*.bmp|Все файлы (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }

                pictureBox1.Image = new ImageSourceConverter().ConvertFromString(openFileDialog1.FileName) as Image;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                label10.Visible = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void formDirector_Load(object sender, EventArgs e)
        {
            db db = new db();
            DataTable table = new DataTable();
            db.conOpen();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string queryy = "SELECT `id`, `login`, `email`, `name`,`surname`, `secondname`, `phone`, `role`  FROM `users` WHERE id = '" + id + "'";
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

                try
                {
                    db.conOpen();

                    MySqlCommand cmd3 = new MySqlCommand("SELECT image FROM users WHERE id = '" + DataBank.id + "'", db.getC());
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


            this.Text = "КАБИНЕТ ДИРЕКТОРА" + "                             " + "ПОЛЬЗОВАТЕЛЬ: " + DataBank.surname.ToUpper() + " " + DataBank.name.ToUpper();

            name.Text = "Имя: " + DataBank.name;
            surname.Text = "Фамилия: " + DataBank.surname;
            secondName.Text = "Отчество: " + DataBank.secondname;
            phone.Text = "Номер телефона: " + DataBank.number;
            email.Text = "Электронная почта: " + DataBank.email;
            dolj.Text = "Должность: Директор";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string namee = name3.Text;
            string surnamee = surnamename3.Text;
            string secondnamee = secondname3.Text;
            string emaill = email3.Text;
            string phonee = phone3.Text;
            string login = login3.Text;
            string password = password3.Text;

            if (namee == "" || namee == " " || surnamee == "" || surnamee == " " || secondnamee == "" || secondnamee == " " || emaill == "" || emaill == " " || phonee == "+7 (   )    -" || login == "" || login == " " || password == "" || password == " ")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                db db = new db();

                DataTable table1 = new DataTable();
                db.conOpen();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                string quee = "SELECT login, email FROM users WHERE login = '" + login + "' OR email = '" + emaill + "'";

                MySqlCommand cmd1 = new MySqlCommand(quee, db.getC());

                adapter1.SelectCommand = cmd1;
                adapter1.Fill(table1);

                if (table1.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с таким логином или электронной почтой уже зарегестрирован!");
                }
                else
                {
                    db.conOpen();
                    using (var cmd = new MySqlCommand($"INSERT INTO `users` (login, password, surname, name, secondname, phone, email, role, image) VALUES (@log, @pass, @surname, @name, @secondname, @phone, @email, @role, @image)", db.getC()))
                    {
                        cmd.Parameters.Add(new MySqlParameter("@image", imageData));
                        cmd.Parameters.Add(new MySqlParameter("@log", login));
                        cmd.Parameters.Add(new MySqlParameter("@pass", password));
                        cmd.Parameters.Add(new MySqlParameter("@phone", phonee));
                        cmd.Parameters.Add(new MySqlParameter("@email", emaill));
                        cmd.Parameters.Add(new MySqlParameter("@name", namee));
                        cmd.Parameters.Add(new MySqlParameter("@surname", surnamee));
                        cmd.Parameters.Add(new MySqlParameter("@secondname", secondnamee));
                        cmd.Parameters.Add(new MySqlParameter("@role", roleCB.Text));
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Учетная запись для " + surnamee + " " + namee + " успешно зарегестрированна!");
                        }
                        else
                        {
                            MessageBox.Show("Проверьте правильность всех введённых данных.");
                        }
                    }
                    db.conClose();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (password3.UseSystemPasswordChar == true)
            {
                password3.UseSystemPasswordChar = false;
            }
            else
            {
                password3.UseSystemPasswordChar = true;
            }
        }

        private void roleCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roleCB_Click(object sender, EventArgs e)
        {
            roleCB.Items.Clear();

            db db = new db();

            db.conOpen();
            MySqlCommand selectFrom = new MySqlCommand("SELECT `role` FROM `users` GROUP BY `role`", db.getC());
            MySqlDataReader dr = selectFrom.ExecuteReader();
            while (dr.Read())
            {
                string fromm = dr["role"].ToString();
                roleCB.Items.Add(fromm);
            }
            db.conClose();
        }
    }
}
