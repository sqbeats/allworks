
namespace Slesar
{
    partial class formWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formWorker));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconReviews = new FontAwesome.Sharp.IconButton();
            this.iconUsersCart = new FontAwesome.Sharp.IconButton();
            this.iconProfile = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.maxim = new System.Windows.Forms.PictureBox();
            this.minim = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(64)))), ((int)(((byte)(213)))));
            this.panelMenu.Controls.Add(this.iconReviews);
            this.panelMenu.Controls.Add(this.iconUsersCart);
            this.panelMenu.Controls.Add(this.iconProfile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(196, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // iconReviews
            // 
            this.iconReviews.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconReviews.FlatAppearance.BorderSize = 0;
            this.iconReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconReviews.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconReviews.IconChar = FontAwesome.Sharp.IconChar.CommentMedical;
            this.iconReviews.IconColor = System.Drawing.SystemColors.Control;
            this.iconReviews.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReviews.IconSize = 36;
            this.iconReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconReviews.Location = new System.Drawing.Point(0, 175);
            this.iconReviews.Name = "iconReviews";
            this.iconReviews.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconReviews.Size = new System.Drawing.Size(196, 60);
            this.iconReviews.TabIndex = 4;
            this.iconReviews.Text = " Заказы";
            this.iconReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconReviews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconReviews.UseVisualStyleBackColor = true;
            this.iconReviews.Click += new System.EventHandler(this.iconReviews_Click);
            // 
            // iconUsersCart
            // 
            this.iconUsersCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconUsersCart.FlatAppearance.BorderSize = 0;
            this.iconUsersCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUsersCart.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconUsersCart.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUsersCart.IconColor = System.Drawing.SystemColors.Control;
            this.iconUsersCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsersCart.IconSize = 36;
            this.iconUsersCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconUsersCart.Location = new System.Drawing.Point(0, 115);
            this.iconUsersCart.Name = "iconUsersCart";
            this.iconUsersCart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconUsersCart.Size = new System.Drawing.Size(196, 60);
            this.iconUsersCart.TabIndex = 2;
            this.iconUsersCart.Text = " Пользователи";
            this.iconUsersCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconUsersCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconUsersCart.UseVisualStyleBackColor = true;
            this.iconUsersCart.Click += new System.EventHandler(this.iconShopCart_Click);
            // 
            // iconProfile
            // 
            this.iconProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconProfile.FlatAppearance.BorderSize = 0;
            this.iconProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconProfile.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconProfile.IconColor = System.Drawing.SystemColors.Control;
            this.iconProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProfile.IconSize = 36;
            this.iconProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.Location = new System.Drawing.Point(0, 55);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconProfile.Size = new System.Drawing.Size(196, 60);
            this.iconProfile.TabIndex = 1;
            this.iconProfile.Text = " Профиль";
            this.iconProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconProfile.UseVisualStyleBackColor = true;
            this.iconProfile.Click += new System.EventHandler(this.iconProfile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(64)))), ((int)(((byte)(213)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(196, 55);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work Locksmith";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Image = global::Slesar.Properties.Resources.photo;
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(69, 52);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(64)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Controls.Add(this.maxim);
            this.panel1.Controls.Add(this.minim);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(196, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 55);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.Location = new System.Drawing.Point(44, 21);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(139, 18);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Домашняя страница";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(64)))), ((int)(((byte)(213)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 6;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // maxim
            // 
            this.maxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(64)))), ((int)(((byte)(213)))));
            this.maxim.Image = global::Slesar.Properties.Resources.icons8_развернуть_окно_24;
            this.maxim.Location = new System.Drawing.Point(533, 3);
            this.maxim.Name = "maxim";
            this.maxim.Size = new System.Drawing.Size(23, 23);
            this.maxim.TabIndex = 5;
            this.maxim.TabStop = false;
            this.maxim.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // minim
            // 
            this.minim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(64)))), ((int)(((byte)(213)))));
            this.minim.Image = global::Slesar.Properties.Resources.icons8_свернуть_окно_24;
            this.minim.Location = new System.Drawing.Point(504, 3);
            this.minim.Name = "minim";
            this.minim.Size = new System.Drawing.Size(23, 23);
            this.minim.TabIndex = 4;
            this.minim.TabStop = false;
            this.minim.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(64)))), ((int)(((byte)(213)))));
            this.close.Image = global::Slesar.Properties.Resources.icons8_закрыть_окно_24;
            this.close.Location = new System.Drawing.Point(562, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label11);
            this.panelDesktop.Controls.Add(this.pictureBox11);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(196, 55);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(588, 506);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(251, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(311, 52);
            this.label11.TabIndex = 3;
            this.label11.Text = "Work Locksmith";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox11.Image = global::Slesar.Properties.Resources.photo;
            this.pictureBox11.Location = new System.Drawing.Point(75, 126);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(205, 174);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // formWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "formWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formWorker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formWorker_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox maxim;
        private System.Windows.Forms.PictureBox minim;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconReviews;
        private FontAwesome.Sharp.IconButton iconUsersCart;
        private FontAwesome.Sharp.IconButton iconProfile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}