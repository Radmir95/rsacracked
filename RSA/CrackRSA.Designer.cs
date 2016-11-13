namespace RSA
{
    partial class CrackRSA
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
            this.answer = new System.Windows.Forms.RichTextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxSW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCrack = new System.Windows.Forms.Button();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxFi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeOfWorking = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(20, 195);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(368, 95);
            this.answer.TabIndex = 0;
            this.answer.Text = "";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(77, 31);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(300, 20);
            this.textBoxN.TabIndex = 1;
            // 
            // textBoxSW
            // 
            this.textBoxSW.Location = new System.Drawing.Point(77, 68);
            this.textBoxSW.Name = "textBoxSW";
            this.textBoxSW.Size = new System.Drawing.Size(300, 20);
            this.textBoxSW.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "N = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SW =";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(77, 103);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(300, 20);
            this.textBoxE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "e = ";
            // 
            // buttonCrack
            // 
            this.buttonCrack.Location = new System.Drawing.Point(527, 303);
            this.buttonCrack.Name = "buttonCrack";
            this.buttonCrack.Size = new System.Drawing.Size(100, 30);
            this.buttonCrack.TabIndex = 7;
            this.buttonCrack.Text = "Взломать";
            this.buttonCrack.UseVisualStyleBackColor = true;
            this.buttonCrack.Click += new System.EventHandler(this.buttonCrack_Click);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(481, 103);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(25, 13);
            this.labelQ.TabIndex = 8;
            this.labelQ.Text = "q = ";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(481, 73);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(25, 13);
            this.labelP.TabIndex = 9;
            this.labelP.Text = "p = ";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(481, 133);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(25, 13);
            this.labelD.TabIndex = 10;
            this.labelD.Text = "d = ";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(538, 73);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(224, 20);
            this.textBoxP.TabIndex = 11;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(538, 100);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(224, 20);
            this.textBoxQ.TabIndex = 12;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(538, 130);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(224, 20);
            this.textBoxD.TabIndex = 13;
            // 
            // textBoxFi
            // 
            this.textBoxFi.Location = new System.Drawing.Point(538, 157);
            this.textBoxFi.Name = "textBoxFi";
            this.textBoxFi.Size = new System.Drawing.Size(224, 20);
            this.textBoxFi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "fi =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Расшифрованное слово:";
            // 
            // timeOfWorking
            // 
            this.timeOfWorking.Location = new System.Drawing.Point(527, 234);
            this.timeOfWorking.Name = "timeOfWorking";
            this.timeOfWorking.Size = new System.Drawing.Size(93, 20);
            this.timeOfWorking.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Время работы:";
            // 
            // CrackRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeOfWorking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFi);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.buttonCrack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSW);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.answer);
            this.Name = "CrackRSA";
            this.Text = "Взлом RSA";
            this.Load += new System.EventHandler(this.CrackRSA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxSW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCrack;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxFi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timeOfWorking;
        private System.Windows.Forms.Label label6;
    }
}