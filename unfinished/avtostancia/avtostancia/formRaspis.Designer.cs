
namespace avtostancia
{
    partial class formRaspis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fromCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toCB = new System.Windows.Forms.ComboBox();
            this.dataCB = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.timeSpendTB = new System.Windows.Forms.TextBox();
            this.timePrTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.race = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(115)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.race,
            this.fromStation,
            this.toStation,
            this.timeSpend,
            this.timePr,
            this.date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(742, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // fromCB
            // 
            this.fromCB.FormattingEnabled = true;
            this.fromCB.Location = new System.Drawing.Point(12, 203);
            this.fromCB.Name = "fromCB";
            this.fromCB.Size = new System.Drawing.Size(121, 23);
            this.fromCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Станция отправления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Станция прибытия";
            // 
            // toCB
            // 
            this.toCB.FormattingEnabled = true;
            this.toCB.Location = new System.Drawing.Point(188, 203);
            this.toCB.Name = "toCB";
            this.toCB.Size = new System.Drawing.Size(121, 23);
            this.toCB.TabIndex = 6;
            // 
            // dataCB
            // 
            this.dataCB.FormattingEnabled = true;
            this.dataCB.Location = new System.Drawing.Point(342, 203);
            this.dataCB.Name = "dataCB";
            this.dataCB.Size = new System.Drawing.Size(121, 23);
            this.dataCB.TabIndex = 6;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.Location = new System.Drawing.Point(342, 181);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(42, 19);
            this.data.TabIndex = 7;
            this.data.Text = "Дата";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Отобразить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(342, 314);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // timeSpendTB
            // 
            this.timeSpendTB.Location = new System.Drawing.Point(12, 283);
            this.timeSpendTB.Name = "timeSpendTB";
            this.timeSpendTB.Size = new System.Drawing.Size(121, 23);
            this.timeSpendTB.TabIndex = 10;
            // 
            // timePrTB
            // 
            this.timePrTB.Location = new System.Drawing.Point(188, 283);
            this.timePrTB.Name = "timePrTB";
            this.timePrTB.Size = new System.Drawing.Size(121, 23);
            this.timePrTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время отправления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(190, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Время прибытия";
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(342, 283);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(121, 23);
            this.numberTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(338, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер автобуса";
            // 
            // number
            // 
            this.number.HeaderText = "Номер автобуса";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // race
            // 
            this.race.HeaderText = "Номер рейса";
            this.race.Name = "race";
            this.race.ReadOnly = true;
            // 
            // fromStation
            // 
            this.fromStation.HeaderText = "Станция отправления";
            this.fromStation.Name = "fromStation";
            this.fromStation.ReadOnly = true;
            // 
            // toStation
            // 
            this.toStation.HeaderText = "Станция Прибытия";
            this.toStation.Name = "toStation";
            this.toStation.ReadOnly = true;
            // 
            // timeSpend
            // 
            this.timeSpend.HeaderText = "Отправление";
            this.timeSpend.Name = "timeSpend";
            this.timeSpend.ReadOnly = true;
            // 
            // timePr
            // 
            this.timePr.HeaderText = "Прибытие";
            this.timePr.Name = "timePr";
            this.timePr.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // formRaspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(742, 425);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.timePrTB);
            this.Controls.Add(this.timeSpendTB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataCB);
            this.Controls.Add(this.toCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromCB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRaspis";
            this.Text = "255; 183; 115";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox fromCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox toCB;
        private System.Windows.Forms.ComboBox dataCB;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox timeSpendTB;
        private System.Windows.Forms.TextBox timePrTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn race;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn toStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpend;
        private System.Windows.Forms.DataGridViewTextBoxColumn timePr;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}