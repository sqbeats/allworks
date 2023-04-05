
namespace avtostancia
{
    partial class forgetpass
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
            this.txtForgetPasswordEmail = new System.Windows.Forms.TextBox();
            this.txtForgetPasswordCode = new System.Windows.Forms.TextBox();
            this.txtForgetPasswordConformPassword = new System.Windows.Forms.TextBox();
            this.txtForgetPasswordNewPassword = new System.Windows.Forms.TextBox();
            this.btnForgetPasswordSendMail = new System.Windows.Forms.Button();
            this.btnForgetPassordNextStep = new System.Windows.Forms.Button();
            this.btnForgetPassordSendAgain = new System.Windows.Forms.Button();
            this.btnForgetPasswordChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtForgetPasswordEmail
            // 
            this.txtForgetPasswordEmail.Location = new System.Drawing.Point(32, 31);
            this.txtForgetPasswordEmail.Name = "txtForgetPasswordEmail";
            this.txtForgetPasswordEmail.Size = new System.Drawing.Size(252, 23);
            this.txtForgetPasswordEmail.TabIndex = 0;
            // 
            // txtForgetPasswordCode
            // 
            this.txtForgetPasswordCode.Location = new System.Drawing.Point(32, 89);
            this.txtForgetPasswordCode.Name = "txtForgetPasswordCode";
            this.txtForgetPasswordCode.Size = new System.Drawing.Size(252, 23);
            this.txtForgetPasswordCode.TabIndex = 0;
            // 
            // txtForgetPasswordConformPassword
            // 
            this.txtForgetPasswordConformPassword.Location = new System.Drawing.Point(32, 176);
            this.txtForgetPasswordConformPassword.Name = "txtForgetPasswordConformPassword";
            this.txtForgetPasswordConformPassword.Size = new System.Drawing.Size(252, 23);
            this.txtForgetPasswordConformPassword.TabIndex = 0;
            // 
            // txtForgetPasswordNewPassword
            // 
            this.txtForgetPasswordNewPassword.Location = new System.Drawing.Point(32, 147);
            this.txtForgetPasswordNewPassword.Name = "txtForgetPasswordNewPassword";
            this.txtForgetPasswordNewPassword.Size = new System.Drawing.Size(252, 23);
            this.txtForgetPasswordNewPassword.TabIndex = 0;
            // 
            // btnForgetPasswordSendMail
            // 
            this.btnForgetPasswordSendMail.Location = new System.Drawing.Point(103, 60);
            this.btnForgetPasswordSendMail.Name = "btnForgetPasswordSendMail";
            this.btnForgetPasswordSendMail.Size = new System.Drawing.Size(110, 23);
            this.btnForgetPasswordSendMail.TabIndex = 1;
            this.btnForgetPasswordSendMail.Text = "Отправить код";
            this.btnForgetPasswordSendMail.UseVisualStyleBackColor = true;
            this.btnForgetPasswordSendMail.Click += new System.EventHandler(this.btnForgetPasswordSendMail_Click);
            // 
            // btnForgetPassordNextStep
            // 
            this.btnForgetPassordNextStep.Location = new System.Drawing.Point(32, 118);
            this.btnForgetPassordNextStep.Name = "btnForgetPassordNextStep";
            this.btnForgetPassordNextStep.Size = new System.Drawing.Size(75, 23);
            this.btnForgetPassordNextStep.TabIndex = 1;
            this.btnForgetPassordNextStep.Text = "Ввести";
            this.btnForgetPassordNextStep.UseVisualStyleBackColor = true;
            this.btnForgetPassordNextStep.Click += new System.EventHandler(this.btnForgetPassordNextStep_Click);
            // 
            // btnForgetPassordSendAgain
            // 
            this.btnForgetPassordSendAgain.Location = new System.Drawing.Point(113, 118);
            this.btnForgetPassordSendAgain.Name = "btnForgetPassordSendAgain";
            this.btnForgetPassordSendAgain.Size = new System.Drawing.Size(171, 23);
            this.btnForgetPassordSendAgain.TabIndex = 1;
            this.btnForgetPassordSendAgain.Text = "Отправить код повторно";
            this.btnForgetPassordSendAgain.UseVisualStyleBackColor = true;
            this.btnForgetPassordSendAgain.Click += new System.EventHandler(this.btnForgetPassordSendAgain_Click);
            // 
            // btnForgetPasswordChange
            // 
            this.btnForgetPasswordChange.Location = new System.Drawing.Point(94, 205);
            this.btnForgetPasswordChange.Name = "btnForgetPasswordChange";
            this.btnForgetPasswordChange.Size = new System.Drawing.Size(130, 23);
            this.btnForgetPasswordChange.TabIndex = 1;
            this.btnForgetPasswordChange.Text = "Сменить пароль";
            this.btnForgetPasswordChange.UseVisualStyleBackColor = true;
            this.btnForgetPasswordChange.Click += new System.EventHandler(this.btnForgetPasswordChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Закрыть";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // forgetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnForgetPasswordChange);
            this.Controls.Add(this.btnForgetPassordSendAgain);
            this.Controls.Add(this.btnForgetPassordNextStep);
            this.Controls.Add(this.btnForgetPasswordSendMail);
            this.Controls.Add(this.txtForgetPasswordNewPassword);
            this.Controls.Add(this.txtForgetPasswordConformPassword);
            this.Controls.Add(this.txtForgetPasswordCode);
            this.Controls.Add(this.txtForgetPasswordEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgetpass";
            this.Text = "forgetpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForgetPasswordEmail;
        private System.Windows.Forms.TextBox txtForgetPasswordCode;
        private System.Windows.Forms.TextBox txtForgetPasswordConformPassword;
        private System.Windows.Forms.TextBox txtForgetPasswordNewPassword;
        private System.Windows.Forms.Button btnForgetPasswordSendMail;
        private System.Windows.Forms.Button btnForgetPassordNextStep;
        private System.Windows.Forms.Button btnForgetPassordSendAgain;
        private System.Windows.Forms.Button btnForgetPasswordChange;
        private System.Windows.Forms.Label label2;
    }
}