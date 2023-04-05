using FontAwesome.Sharp;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace avtostancia
{
    public partial class Form2 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public string id;
        public Form2()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            label11.Dock = DockStyle.Fill;
            label11.Anchor = AnchorStyles.Top;
            label11.Anchor = AnchorStyles.Bottom;


        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 124, 0);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void iconProfile_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 124, 0));
            OpenChildForm(new Профиль());
            lblTitleChildForm.Text = "Профиль";
        }

        private void iconShopCart_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 124, 0));
            OpenChildForm(new formRaspis());
            lblTitleChildForm.Text = "Расписание";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 124, 0));
            OpenChildForm(new formOtchet());
            lblTitleChildForm.Text = "Отчёты";
        }

        private void iconReviews_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 124, 0));
            OpenChildForm(new formReviews());
            lblTitleChildForm.Text = "Отзывы";
        }

        private void iconInfo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 124, 0));
            lblTitleChildForm.Text = "Информация";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            lblTitleChildForm.Text = "Домашняя страница";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconContacts_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 124, 0));
            OpenChildForm(new formContacts());
            lblTitleChildForm.Text = "Контакты";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
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
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(255, 124, 0));
            OpenChildForm(new formTickects());
            lblTitleChildForm.Text = "Билеты";
        }
    }
}
