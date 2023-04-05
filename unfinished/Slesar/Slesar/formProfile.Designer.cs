
namespace Slesar
{
    partial class Профиль
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
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.secondName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(11, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 24);
            this.name.TabIndex = 0;
            this.name.Text = "Имя: ";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname.Location = new System.Drawing.Point(12, 35);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(97, 24);
            this.surname.TabIndex = 1;
            this.surname.Text = "Фамилия: ";
            // 
            // secondName
            // 
            this.secondName.AutoSize = true;
            this.secondName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondName.Location = new System.Drawing.Point(11, 59);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(98, 24);
            this.secondName.TabIndex = 2;
            this.secondName.Text = "Отчество: ";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(12, 83);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(160, 24);
            this.phone.TabIndex = 3;
            this.phone.Text = "Номер телефона: ";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(12, 107);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(185, 24);
            this.email.TabIndex = 5;
            this.email.Text = "Электронная почта: ";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.role.Location = new System.Drawing.Point(11, 128);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(115, 24);
            this.role.TabIndex = 5;
            this.role.Text = "Должность: ";
            // 
            // Профиль
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 460);
            this.Controls.Add(this.role);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Профиль";
            this.Text = "formProfile";
            this.Load += new System.EventHandler(this.Профиль_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label secondName;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label role;
    }
}