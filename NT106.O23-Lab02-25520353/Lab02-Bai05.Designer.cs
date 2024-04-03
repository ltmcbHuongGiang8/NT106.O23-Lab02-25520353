namespace NT106.O23_Lab02_25520353
{
    partial class Lab02_Bai05
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
            this.button1 = new System.Windows.Forms.Button();
            this.Maip3 = new System.Windows.Forms.ProgressBar();
            this.DPp1 = new System.Windows.Forms.ProgressBar();
            this.DPp2 = new System.Windows.Forms.ProgressBar();
            this.DPp3 = new System.Windows.Forms.ProgressBar();
            this.GLp1 = new System.Windows.Forms.ProgressBar();
            this.process1 = new System.Diagnostics.Process();
            this.TRp3 = new System.Windows.Forms.ProgressBar();
            this.Maip2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xem tình trạng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maip3
            // 
            this.Maip3.Location = new System.Drawing.Point(82, 91);
            this.Maip3.Maximum = 15;
            this.Maip3.Name = "Maip3";
            this.Maip3.Size = new System.Drawing.Size(119, 23);
            this.Maip3.TabIndex = 5;
            // 
            // DPp1
            // 
            this.DPp1.Location = new System.Drawing.Point(401, 55);
            this.DPp1.Maximum = 15;
            this.DPp1.Name = "DPp1";
            this.DPp1.Size = new System.Drawing.Size(119, 23);
            this.DPp1.TabIndex = 6;
            // 
            // DPp2
            // 
            this.DPp2.Location = new System.Drawing.Point(401, 91);
            this.DPp2.Maximum = 15;
            this.DPp2.Name = "DPp2";
            this.DPp2.Size = new System.Drawing.Size(119, 23);
            this.DPp2.TabIndex = 7;
            // 
            // DPp3
            // 
            this.DPp3.Location = new System.Drawing.Point(401, 128);
            this.DPp3.Maximum = 15;
            this.DPp3.Name = "DPp3";
            this.DPp3.Size = new System.Drawing.Size(119, 23);
            this.DPp3.TabIndex = 8;
            // 
            // GLp1
            // 
            this.GLp1.Location = new System.Drawing.Point(82, 205);
            this.GLp1.Maximum = 15;
            this.GLp1.Name = "GLp1";
            this.GLp1.Size = new System.Drawing.Size(119, 23);
            this.GLp1.TabIndex = 9;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // TRp3
            // 
            this.TRp3.Location = new System.Drawing.Point(401, 205);
            this.TRp3.Maximum = 15;
            this.TRp3.Name = "TRp3";
            this.TRp3.Size = new System.Drawing.Size(119, 23);
            this.TRp3.TabIndex = 10;
            // 
            // Maip2
            // 
            this.Maip2.Location = new System.Drawing.Point(82, 55);
            this.Maip2.Maximum = 15;
            this.Maip2.Name = "Maip2";
            this.Maip2.Size = new System.Drawing.Size(119, 20);
            this.Maip2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(329, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "P3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(16, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "P1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(329, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "P2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(329, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "P3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(329, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "P1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(398, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tarot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(42, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gặp Lại Chị Bầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(384, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Đào Phở Piano";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(16, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "P2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(16, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "P1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(163, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 55);
            this.button2.TabIndex = 23;
            this.button2.Text = "Xếp loại Phim";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Lab02_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maip2);
            this.Controls.Add(this.TRp3);
            this.Controls.Add(this.GLp1);
            this.Controls.Add(this.DPp3);
            this.Controls.Add(this.DPp2);
            this.Controls.Add(this.DPp1);
            this.Controls.Add(this.Maip3);
            this.Controls.Add(this.button1);
            this.Name = "Lab02_Bai05";
            this.Text = "Lab02_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar Maip3;
        private System.Windows.Forms.ProgressBar DPp1;
        private System.Windows.Forms.ProgressBar DPp2;
        private System.Windows.Forms.ProgressBar DPp3;
        private System.Windows.Forms.ProgressBar GLp1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ProgressBar Maip2;
        private System.Windows.Forms.ProgressBar TRp3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}