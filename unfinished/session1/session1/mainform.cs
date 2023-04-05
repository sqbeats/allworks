using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace session1
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            function fun = new function();
            fun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otcheti otc = new Otcheti();
            otc.Show();
        }
    }
}
