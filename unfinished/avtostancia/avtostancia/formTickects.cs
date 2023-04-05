using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace avtostancia
{
    public partial class formTickects : Form
    {
        public formTickects()
        {
            InitializeComponent();

            db db = new db();

            db.conOpen();
            MySqlCommand selectFrom = new MySqlCommand("SELECT `race` FROM `schedule` GROUP BY `race`", db.getC());
            MySqlDataReader dr = selectFrom.ExecuteReader();
            while (dr.Read())
            {
                string fromm = dr["race"].ToString();
                numberRace.Items.Add(fromm);
            }
            db.conClose();
        }

        int price;
        private void button2_Click(object sender, EventArgs e)
        {
            string bagadge1 = bagadge.Text;
            string lgot = lgoti.Text;
            string childanimal = childrens.Text;
            string racenumber = numberRace.Text;

            string que = "SELECT * FROM `prices`";

            db db = new db();

            DataTable tab = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand(que, db.getC());

            adp.SelectCommand = cmd;
            adp.Fill(tab);


            string bilet = tab.Rows[0][2].ToString();
            string bagage = tab.Rows[1][2].ToString();
            string child = tab.Rows[2][2].ToString();
            string childs = tab.Rows[3][2].ToString();
            string animals = tab.Rows[4][2].ToString();



            int bilet1 = int.Parse(bilet);
            int bagage1= int.Parse(bagage);
            int child1;
            int childs1;
            int animals1;
            int bagadge2 = int.Parse(bagadge1);

            if (childanimal == "Отсутсвует")
            {
                child1 = 0;
                childs1 = 0;
                animals1 = 0;
            }
            else
            {
                child1 = int.Parse(child);
                childs1 = int.Parse(childs);
                animals1 = int.Parse(animals);
            }


            if (lgot == "Отсутсвуют")
            {
                price = bilet1 + (bagage1 * bagadge2) + child1 + childs1 + animals1;
            }
            else if (lgot == "Студент, школьник" || lgot == "Пенсионер" || lgot == "Участник Боевых Действий")
            {
                price = (bilet1 + (bagage1 * bagadge2) + child1 + childs1 + animals1)/2;
            }
            else if (lgot == "Социальная карта")
            {
                price = 0;
            }
            else
                price = 0;

            label5.Text = "Цена: " + price + " руб.";

            cInfo.animals = animals1;
            cInfo.bagage = bagage1 * bagadge2;
            cInfo.child = child1;
            cInfo.childs = childs1;
            cInfo.lgoti = lgot;
            cInfo.prices = price;
            cInfo.race = racenumber;
            cInfo.price1 = bilet1;

              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPayment fP = new formPayment();
            fP.Show();
        }
    }
}
