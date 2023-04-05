using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace secondhand
{
    public partial class formCheck : Form
    {
        public formCheck()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCheck_Load(object sender, EventArgs e)
        {
            label1.Text = "Количество оплаченных товаров: " + DataBank.totalcount;
            label2.Text = "Итоговая сумма: " + DataBank.totalpricee + " рублей";
        }
    }
}
