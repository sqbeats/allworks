
namespace Slesar
{
    partial class Form3
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
            this.adresss = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.trouble = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adresss
            // 
            this.adresss.Location = new System.Drawing.Point(12, 36);
            this.adresss.Multiline = true;
            this.adresss.Name = "adresss";
            this.adresss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adresss.Size = new System.Drawing.Size(223, 55);
            this.adresss.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(173, 24);
            this.name.TabIndex = 1;
            this.name.Text = "Укажите ваш адрес";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(38, 187);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(173, 23);
            this.send.TabIndex = 2;
            this.send.Text = "Оставить заявку";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // trouble
            // 
            this.trouble.Location = new System.Drawing.Point(12, 126);
            this.trouble.Multiline = true;
            this.trouble.Name = "trouble";
            this.trouble.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.trouble.Size = new System.Drawing.Size(223, 55);
            this.trouble.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Опишите вашу проблему";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 345);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.trouble);
            this.Controls.Add(this.adresss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adresss;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox trouble;
        private System.Windows.Forms.Label label1;
    }
}