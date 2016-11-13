namespace RSA
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.RichTextBox();
            this.p_text = new System.Windows.Forms.TextBox();
            this.q_text = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fi_text = new System.Windows.Forms.TextBox();
            this.d_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.decrypt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(888, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(23, 191);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(486, 275);
            this.answer.TabIndex = 1;
            this.answer.Text = "";
            // 
            // p_text
            // 
            this.p_text.Location = new System.Drawing.Point(542, 34);
            this.p_text.Name = "p_text";
            this.p_text.Size = new System.Drawing.Size(100, 20);
            this.p_text.TabIndex = 2;
            this.p_text.TextChanged += new System.EventHandler(this.p_text_TextChanged);
            // 
            // q_text
            // 
            this.q_text.Location = new System.Drawing.Point(690, 34);
            this.q_text.Name = "q_text";
            this.q_text.Size = new System.Drawing.Size(100, 20);
            this.q_text.TabIndex = 3;
            this.q_text.TextChanged += new System.EventHandler(this.q_text_TextChanged);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(23, 34);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(248, 63);
            this.message.TabIndex = 4;
            this.message.Text = "";
            this.message.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Шифрование";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "P = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Q =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите параметры, оставьте поле пустым, если хотите, чтобы система сама их сгене" +
    "рировала";
            // 
            // e_text
            // 
            this.e_text.Location = new System.Drawing.Point(344, 67);
            this.e_text.Name = "e_text";
            this.e_text.Size = new System.Drawing.Size(100, 20);
            this.e_text.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "E = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Фи =";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // fi_text
            // 
            this.fi_text.Location = new System.Drawing.Point(542, 64);
            this.fi_text.Name = "fi_text";
            this.fi_text.Size = new System.Drawing.Size(100, 20);
            this.fi_text.TabIndex = 15;
            this.fi_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // d_text
            // 
            this.d_text.Location = new System.Drawing.Point(690, 67);
            this.d_text.Name = "d_text";
            this.d_text.Size = new System.Drawing.Size(100, 20);
            this.d_text.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(660, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "D = ";
            // 
            // decrypt
            // 
            this.decrypt.Font = new System.Drawing.Font("Salina", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypt.Location = new System.Drawing.Point(586, 191);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(456, 256);
            this.decrypt.TabIndex = 18;
            this.decrypt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 500);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.d_text);
            this.Controls.Add(this.fi_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.e_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.q_text);
            this.Controls.Add(this.p_text);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.TextBox p_text;
        private System.Windows.Forms.TextBox q_text;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox e_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fi_text;
        private System.Windows.Forms.TextBox d_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox decrypt;
    }
}

