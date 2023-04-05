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
    public partial class formPayment : Form
    {
        public formPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string que = "INSERT INTO `orders` (`idUsers`, `totalPrice`, `date`, `status`) VALUES ('"+DataBank.id+"', '"+DataBank.totalpricee+"', '"+date+"', @uR)";

            db db = new db();

            MySqlCommand cmd = new MySqlCommand(que, db.getC());
            cmd.Parameters.Add("@uR", MySqlDbType.VarChar).Value = "Ожидает звонка оператора";
            db.conOpen();
            if (cmd.ExecuteNonQuery() == 1)
            {
                this.Close();
                formCheck frc = new formCheck();
                frc.Show();
            }
            else
                MessageBox.Show("Неизвестная ошибка");
            db.conClose();
            
        }
    }
}
