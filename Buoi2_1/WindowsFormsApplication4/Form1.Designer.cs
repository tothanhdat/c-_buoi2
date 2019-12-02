namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.boxNumber1 = new System.Windows.Forms.TextBox();
            this.boxNumber2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.boxAnswer = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Location = new System.Drawing.Point(88, 87);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(53, 13);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "Number 1";
            this.Number1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Location = new System.Drawing.Point(88, 149);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(53, 13);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "Number 2";
            this.Number2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // boxNumber1
            // 
            this.boxNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNumber1.Location = new System.Drawing.Point(147, 79);
            this.boxNumber1.Name = "boxNumber1";
            this.boxNumber1.Size = new System.Drawing.Size(132, 26);
            this.boxNumber1.TabIndex = 2;
            this.boxNumber1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // boxNumber2
            // 
            this.boxNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNumber2.Location = new System.Drawing.Point(147, 141);
            this.boxNumber2.Name = "boxNumber2";
            this.boxNumber2.Size = new System.Drawing.Size(132, 26);
            this.boxNumber2.TabIndex = 3;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(49, 215);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(60, 33);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(125, 215);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(60, 33);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "_";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(203, 215);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(60, 33);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "X";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(282, 215);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(60, 33);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "-:-";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // boxAnswer
            // 
            this.boxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAnswer.Location = new System.Drawing.Point(147, 283);
            this.boxAnswer.Name = "boxAnswer";
            this.boxAnswer.Size = new System.Drawing.Size(132, 26);
            this.boxAnswer.TabIndex = 9;
            this.boxAnswer.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(88, 291);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(42, 13);
            this.Answer.TabIndex = 8;
            this.Answer.Text = "Answer";
            this.Answer.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 338);
            this.Controls.Add(this.boxAnswer);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.boxNumber2);
            this.Controls.Add(this.boxNumber1);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.TextBox boxNumber1;
        private System.Windows.Forms.TextBox boxNumber2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.TextBox boxAnswer;
        private System.Windows.Forms.Label Answer;
    }
}

