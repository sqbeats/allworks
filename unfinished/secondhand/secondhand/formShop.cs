using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace secondhand
{
    public partial class formShop : Form
    {
        public formShop()
        {
            InitializeComponent();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        string cat;
        string fason;
        string nameG;
        string countGod;
        string priceGod;
        string countGod1;
        string priceGod1;
        string countGod2;
        string priceGod2;
        string countGod3;
        string priceGod3;
        string countGod4;
        string priceGod4;
        string countGod5;
        string priceGod5;
        string nameGod;
        string nameGod1;
        string nameGod2;
        string nameGod3;
        string nameGod4;
        string nameGod5;
        int totalprice;

        private void formShop_Load(object sender, EventArgs e)
        {

            db db = new db();

            db.conOpen();
            MySqlCommand selectFrom = new MySqlCommand("SELECT `category` FROM `goods` GROUP BY `category`", db.getC());
            MySqlDataReader dr = selectFrom.ExecuteReader();
            while (dr.Read())
            {
                string fromm = dr["category"].ToString();
                categoryCB.Items.Add(fromm);
            }
            db.conClose();
        }

        private void goodsCB_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void fasonCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            db db = new db();

            cat = categoryCB.Text;
            fason = fasonCB.Text;

            if (categoryCB.Text != "" && fasonCB.Text != "")
            {
                string que1 = "SELECT name, count, price FROM goods WHERE category = '" + cat + "' and fason = '" + fason + "'";


                DataTable tab1 = new DataTable();
                MySqlDataAdapter adp1 = new MySqlDataAdapter();
                MySqlCommand cmd1 = new MySqlCommand(que1, db.getC());

                adp1.SelectCommand = cmd1;
                adp1.Fill(tab1);

                if (tab1.Rows.Count < 1)
                {
                    label2.Text = "";
                    label3.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label8.Text = "";
                    label9.Text = "";
                    label11.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    label16.Text = "";
                    label15.Text = "";
                    label17.Text = "";
                    label4.Text = "";
                    label7.Text = "";
                    label10.Text = "";
                    label14.Text = "";
                    label18.Text = "";
                    label19.Text = nameGod5;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count > 0 && tab1.Rows.Count < 2)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label4.Text = nameGod;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count > 1 && tab1.Rows.Count < 3)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 2 && tab1.Rows.Count < 4)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 3 && tab1.Rows.Count < 5)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    countGod3 = tab1.Rows[3][1].ToString();
                    priceGod3 = tab1.Rows[3][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    nameGod3 = tab1.Rows[3][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label11.Text = "Кол-ва на складах: " + countGod3;
                    label12.Text = "Цена: " + priceGod3 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    label14.Text = nameGod3;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 4 && tab1.Rows.Count < 6)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    countGod3 = tab1.Rows[3][1].ToString();
                    priceGod3 = tab1.Rows[3][2].ToString();
                    countGod4 = tab1.Rows[4][1].ToString();
                    priceGod4 = tab1.Rows[4][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    nameGod3 = tab1.Rows[3][0].ToString();
                    nameGod4 = tab1.Rows[4][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label11.Text = "Кол-ва на складах: " + countGod3;
                    label12.Text = "Цена: " + priceGod3 + " рублей";
                    label13.Text = "Кол-ва на складах: " + countGod4;
                    label16.Text = "Цена: " + priceGod4 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    label14.Text = nameGod3;
                    label18.Text = nameGod4;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 5 && tab1.Rows.Count < 7)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    countGod3 = tab1.Rows[3][1].ToString();
                    priceGod3 = tab1.Rows[3][2].ToString();
                    countGod4 = tab1.Rows[4][1].ToString();
                    priceGod4 = tab1.Rows[4][2].ToString();
                    countGod5 = tab1.Rows[5][1].ToString();
                    priceGod5 = tab1.Rows[5][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    nameGod3 = tab1.Rows[3][0].ToString();
                    nameGod4 = tab1.Rows[4][0].ToString();
                    nameGod5 = tab1.Rows[5][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label11.Text = "Кол-ва на складах: " + countGod3;
                    label12.Text = "Цена: " + priceGod3 + " рублей";
                    label13.Text = "Кол-ва на складах: " + countGod4;
                    label16.Text = "Цена: " + priceGod4 + " рублей";
                    label15.Text = "Кол-ва на складах: " + countGod5;
                    label17.Text = "Цена: " + priceGod5 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    label14.Text = nameGod3;
                    label18.Text = nameGod4;
                    label19.Text = nameGod5;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                }
            }
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {


            db db = new db();

            cat = categoryCB.Text;
            fason = fasonCB.Text;

            if (categoryCB.Text != "" && fasonCB.Text != "")
            {
                string que1 = "SELECT name, count, price FROM goods WHERE category = '" + cat + "' and fason = '" + fason + "'";


                DataTable tab1 = new DataTable();
                MySqlDataAdapter adp1 = new MySqlDataAdapter();
                MySqlCommand cmd1 = new MySqlCommand(que1, db.getC());

                adp1.SelectCommand = cmd1;
                adp1.Fill(tab1);

                db.conOpen();
                MySqlCommand selectFrom = new MySqlCommand("SELECT `name` FROM `goods` WHERE category = '" + cat + "' and fason = '" + fason + "' GROUP BY `name`", db.getC());
                MySqlDataReader dr1 = selectFrom.ExecuteReader();
                nameCB.Items.Clear();
                while (dr1.Read())
                {
                    string from = dr1["name"].ToString();
                    nameCB.Items.Add(from);
                }
                db.conClose();

                if (tab1.Rows.Count < 1)
                {
                    label2.Text = "";
                    label3.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label8.Text = "";
                    label9.Text = "";
                    label11.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    label16.Text = "";
                    label15.Text = "";
                    label17.Text = "";
                    label4.Text = "";
                    label7.Text = "";
                    label10.Text = "";
                    label14.Text = "";
                    label18.Text = "";
                    label19.Text = nameGod5;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count > 0 && tab1.Rows.Count < 2)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label4.Text = nameGod;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count > 1 && tab1.Rows.Count < 3)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 2 && tab1.Rows.Count < 4)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 3 && tab1.Rows.Count < 5)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    countGod3 = tab1.Rows[3][1].ToString();
                    priceGod3 = tab1.Rows[3][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    nameGod3 = tab1.Rows[3][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label11.Text = "Кол-ва на складах: " + countGod3;
                    label12.Text = "Цена: " + priceGod3 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    label14.Text = nameGod3;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 4 && tab1.Rows.Count < 6)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    countGod3 = tab1.Rows[3][1].ToString();
                    priceGod3 = tab1.Rows[3][2].ToString();
                    countGod4 = tab1.Rows[4][1].ToString();
                    priceGod4 = tab1.Rows[4][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    nameGod3 = tab1.Rows[3][0].ToString();
                    nameGod4 = tab1.Rows[4][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod1 + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label11.Text = "Кол-ва на складах: " + countGod3;
                    label12.Text = "Цена: " + priceGod3 + " рублей";
                    label13.Text = "Кол-ва на складах: " + countGod4;
                    label16.Text = "Цена: " + priceGod4 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    label14.Text = nameGod3;
                    label18.Text = nameGod4;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                }
                else if (tab1.Rows.Count < 5 && tab1.Rows.Count < 7)
                {
                    countGod = tab1.Rows[0][1].ToString();
                    priceGod = tab1.Rows[0][2].ToString();
                    countGod1 = tab1.Rows[1][1].ToString();
                    priceGod1 = tab1.Rows[1][2].ToString();
                    countGod2 = tab1.Rows[2][1].ToString();
                    priceGod2 = tab1.Rows[2][2].ToString();
                    countGod3 = tab1.Rows[3][1].ToString();
                    priceGod3 = tab1.Rows[3][2].ToString();
                    countGod4 = tab1.Rows[4][1].ToString();
                    priceGod4 = tab1.Rows[4][2].ToString();
                    countGod5 = tab1.Rows[5][1].ToString();
                    priceGod5 = tab1.Rows[5][2].ToString();
                    nameGod = tab1.Rows[0][0].ToString();
                    nameGod1 = tab1.Rows[1][0].ToString();
                    nameGod2 = tab1.Rows[2][0].ToString();
                    nameGod3 = tab1.Rows[3][0].ToString();
                    nameGod4 = tab1.Rows[4][0].ToString();
                    nameGod5 = tab1.Rows[5][0].ToString();
                    label2.Text = "Кол-ва на складах: " + countGod;
                    label3.Text = "Цена: " + priceGod + " рублей";
                    label5.Text = "Кол-ва на складах: " + countGod1;
                    label6.Text = "Цена: " + priceGod + " рублей";
                    label8.Text = "Кол-ва на складах: " + countGod2;
                    label9.Text = "Цена: " + priceGod2 + " рублей";
                    label11.Text = "Кол-ва на складах: " + countGod3;
                    label12.Text = "Цена: " + priceGod3 + " рублей";
                    label13.Text = "Кол-ва на складах: " + countGod4;
                    label16.Text = "Цена: " + priceGod4 + " рублей";
                    label15.Text = "Кол-ва на складах: " + countGod5;
                    label17.Text = "Цена: " + priceGod5 + " рублей";
                    label4.Text = nameGod;
                    label7.Text = nameGod1;
                    label10.Text = nameGod2;
                    label14.Text = nameGod3;
                    label18.Text = nameGod4;
                    label19.Text = nameGod5;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        string idGod;
        private void button1_Click_1(object sender, EventArgs e)
        {
            formPayment frp = new formPayment();
            frp.Show();
        }

        int goodsCount = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            db db = new db();

            goodsCount++;
            label20.Text = "Товаров в корзине: " + goodsCount;
            nameG = nameCB.Text;

            if (nameCB.Text != "")
            {

                string que1 = "SELECT `id`, `price` FROM goods WHERE name = '" + nameG + "'";


                DataTable tab1 = new DataTable();
                MySqlDataAdapter adp1 = new MySqlDataAdapter();
                MySqlCommand cmd1 = new MySqlCommand(que1, db.getC());

                adp1.SelectCommand = cmd1;
                adp1.Fill(tab1);


                string priceG = tab1.Rows[0][1].ToString();
                idGod = tab1.Rows[0][0].ToString();

                totalprice = totalprice + int.Parse(priceG);
                label21.Text = "Цена к оплате: " + totalprice + " руб.";

                DataBank.totalcount = goodsCount.ToString();
                DataBank.totalpricee = totalprice.ToString();

            }

        }

        private void nameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

