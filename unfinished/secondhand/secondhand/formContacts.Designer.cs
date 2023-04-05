
namespace secondhand
{
    partial class formContacts
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
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.Label();
            this.fromF = new System.Windows.Forms.TextBox();
            this.subjectF = new System.Windows.Forms.TextBox();
            this.textF = new System.Windows.Forms.TextBox();
            this.sendmaa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.Location = new System.Drawing.Point(12, 9);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(349, 18);
            this.lblTitleChildForm.TabIndex = 3;
            this.lblTitleChildForm.Text = "Номер телефона горячей линнии: +7(999)-000-0021 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Электронная почта поддержки:  musicrar99@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Электронный адрес: www.xxxx.ru";
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feedback.Location = new System.Drawing.Point(12, 109);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(107, 18);
            this.feedback.TabIndex = 6;
            this.feedback.Text = "Обратная связь";
            this.feedback.Click += new System.EventHandler(this.feedback_Click);
            // 
            // fromF
            // 
            this.fromF.Location = new System.Drawing.Point(12, 130);
            this.fromF.Name = "fromF";
            this.fromF.Size = new System.Drawing.Size(394, 23);
            this.fromF.TabIndex = 7;
            this.fromF.Enter += new System.EventHandler(this.fromF_Enter);
            this.fromF.Leave += new System.EventHandler(this.fromF_Leave);
            // 
            // subjectF
            // 
            this.subjectF.Location = new System.Drawing.Point(12, 159);
            this.subjectF.Name = "subjectF";
            this.subjectF.Size = new System.Drawing.Size(394, 23);
            this.subjectF.TabIndex = 8;
            this.subjectF.Enter += new System.EventHandler(this.subjectF_Enter);
            this.subjectF.Leave += new System.EventHandler(this.subjectF_Leave);
            // 
            // textF
            // 
            this.textF.Location = new System.Drawing.Point(12, 188);
            this.textF.Multiline = true;
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(394, 216);
            this.textF.TabIndex = 9;
            // 
            // sendmaa
            // 
            this.sendmaa.Location = new System.Drawing.Point(144, 410);
            this.sendmaa.Name = "sendmaa";
            this.sendmaa.Size = new System.Drawing.Size(144, 28);
            this.sendmaa.TabIndex = 10;
            this.sendmaa.Text = "Отправить";
            this.sendmaa.UseVisualStyleBackColor = true;
            this.sendmaa.Click += new System.EventHandler(this.sendmaa_Click);
            // 
            // formContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendmaa);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.subjectF);
            this.Controls.Add(this.fromF);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formContacts";
            this.Text = "formContacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label feedback;
        private System.Windows.Forms.TextBox fromF;
        private System.Windows.Forms.TextBox subjectF;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.Button sendmaa;
    }
}