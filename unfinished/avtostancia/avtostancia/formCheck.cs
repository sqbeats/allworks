using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace avtostancia
{
    public partial class formCheck : Form
    {
        public formCheck()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCheck_Load(object sender, EventArgs e)
        {
            if (cInfo.lgoti == "Отсутсвуют")
            {
                label6.Text = "РАЗОВЫЙ = " + cInfo.price1 + " руб.";
            }
            else
                label6.Text = "РАЗОВЫЙ ЛЬГОТНЫЙ =  " + cInfo.price1 + " руб.";


            label7.Text = "БАГАЖ = " + cInfo.bagage + " руб.";
            label8.Text = "ДОПЛАТА ЗА ДЕТЕЙ = " + cInfo.child + cInfo.childs + " руб.";
            label9.Text = "ДОПЛАТА ЗА ЖИВОТНЫХ = " + cInfo.animals + " руб.";
            label10.Text = "ИТОГО == " + cInfo.prices + " руб.";
            label11.Text = "НОМЕР РЕЙСА: " +  cInfo.race;
        }
    }
}
