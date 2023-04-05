using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace vodka
{
    public partial class formOtcRab : Form
    {
        public formOtcRab()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db = new db();

            DateTime dt = DateTime.Now;
            string start = dt.ToShortDateString();
            string namedd = namedCB.Text;
            string izg = textBox1.Text;
            string brak = textBox2.Text;
            string idUser = DataBank.id;

            DataTable table = new DataTable();
            db.conOpen();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string que1 = "SELECT id FROM products WHERE name = '" + namedd + "'";
            MySqlCommand cmd2 = new MySqlCommand(que1, db.getC());

            adapter.SelectCommand = cmd2;
            adapter.Fill(table);

            string idProducts = table.Rows[0][0].ToString();


            string que = "INSERT INTO `warehouse` (`idProducts`, `idUsers`,`Дата`, `Изготовлено`, `Брак`) VALUES ('"+idProducts+"' ,'" + idUser + "', '" + start + "', '" + izg + "', '" + brak + "')";

            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            db.conOpen();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отчёт успешно внесён!");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();


            int counts = int.Parse(izg) - int.Parse(brak);
            string que2 = "UPDATE `products` SET `countOnWarehouse` = '"+counts+"' WHERE `products`.`name` = '"+namedd+"'";

            MySqlCommand cmd1 = new MySqlCommand(que2, db.getC());

            db.conOpen();

            if (cmd1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отчёт успешно внесён!");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            db db = new db();
            string fio = sotrCB.Text;
            DateTime dt = DateTime.Now;
            string start1 = dt.ToShortDateString();
            string idUser = DataBank.id;
            string hours = textBox4.Text;

            string[] subs = fio.Split(' ');

            string name1 = subs[1];
            string surname1 = subs[0];
            string secondname1 = subs[2];



            DataTable table = new DataTable();
            db.conOpen();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string queryy = "SELECT `id`  FROM `workersInfo` WHERE `Имя` =  '"+name1+"' and `Фамилия` = '"+surname1+"' and `Отчество` = '"+secondname1+"'";
            MySqlCommand cmd = new MySqlCommand(queryy, db.getC());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            string idWorker = table.Rows[0][0].ToString();

            string que = "INSERT INTO `workers` (`Дата`, `idworkersInfo`, `Количество отработанных часов`, `Начальник смены`) VALUES ('" + start1 + "', '"+idWorker+"', '"+hours+"' ,'" + idUser + "')";

            MySqlCommand cmd1 = new MySqlCommand(que, db.getC());

            db.conOpen();

            if (cmd1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отчёт успешно внесён!");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();
        }

        private void formOtcRab_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db db = new db();

            string named = namedTB.Text;
            string priced = countTB.Text;

            string que = "INSERT INTO `products` (name, price, countOnWarehouse) VALUES ('"+named+"', '"+priced+"', 0)";

            MySqlCommand cmd1 = new MySqlCommand(que, db.getC());

            db.conOpen();

            if (cmd1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Отчёт успешно внесён!");
            }
            else
                MessageBox.Show("Проверьте подлинность введённых данных");
            db.conClose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sotrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void namedCB_MouseClick(object sender, MouseEventArgs e)
        {
            namedCB.Items.Clear();

            db db = new db();

            db.conOpen();
            MySqlCommand selectFrom = new MySqlCommand("SELECT name FROM `products` GROUP BY `name`", db.getC());
            MySqlDataReader dr = selectFrom.ExecuteReader();
            while (dr.Read())
            {
                string fromm = dr["name"].ToString();
                namedCB.Items.Add(fromm);
            }
            db.conClose();
        }

        private void sotrCB_MouseClick(object sender, MouseEventArgs e)
        {
            sotrCB.Items.Clear();

            db db = new db();

            db.conOpen();
            MySqlCommand selectFrom = new MySqlCommand("SELECT `Имя`, `Фамилия`, `Отчество` FROM `workersInfo` GROUP BY `Имя`, `Фамилия`, `Отчество`", db.getC());
            MySqlDataReader dr = selectFrom.ExecuteReader();
            while (dr.Read())
            {
                string fromm = dr["Фамилия"].ToString() + " " + dr["Имя"].ToString() + " " + dr["Отчество"].ToString();
                sotrCB.Items.Add(fromm);
            }
            db.conClose();
        }
    }
}
