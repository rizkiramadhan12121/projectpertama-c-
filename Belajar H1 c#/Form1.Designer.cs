namespace Belajar_H1_c_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tblTambah = new System.Windows.Forms.Button();
            this.tblKurang = new System.Windows.Forms.Button();
            this.tblKali = new System.Windows.Forms.Button();
            this.tblBagi = new System.Windows.Forms.Button();
            this.Cleaar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasil";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(88, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tblTambah
            // 
            this.tblTambah.BackColor = System.Drawing.Color.LightGreen;
            this.tblTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblTambah.Location = new System.Drawing.Point(42, 257);
            this.tblTambah.Name = "tblTambah";
            this.tblTambah.Size = new System.Drawing.Size(40, 40);
            this.tblTambah.TabIndex = 6;
            this.tblTambah.Text = "+";
            this.tblTambah.UseVisualStyleBackColor = false;
            this.tblTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblKurang
            // 
            this.tblKurang.BackColor = System.Drawing.Color.LightCoral;
            this.tblKurang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblKurang.Location = new System.Drawing.Point(88, 257);
            this.tblKurang.Name = "tblKurang";
            this.tblKurang.Size = new System.Drawing.Size(40, 40);
            this.tblKurang.TabIndex = 7;
            this.tblKurang.Text = "-";
            this.tblKurang.UseVisualStyleBackColor = false;
            this.tblKurang.Click += new System.EventHandler(this.tblKurang_Click);
            // 
            // tblKali
            // 
            this.tblKali.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tblKali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblKali.Location = new System.Drawing.Point(134, 257);
            this.tblKali.Name = "tblKali";
            this.tblKali.Size = new System.Drawing.Size(40, 40);
            this.tblKali.TabIndex = 9;
            this.tblKali.Text = "x";
            this.tblKali.UseVisualStyleBackColor = false;
            this.tblKali.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tblBagi
            // 
            this.tblBagi.BackColor = System.Drawing.Color.Goldenrod;
            this.tblBagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblBagi.Location = new System.Drawing.Point(180, 257);
            this.tblBagi.Name = "tblBagi";
            this.tblBagi.Size = new System.Drawing.Size(40, 40);
            this.tblBagi.TabIndex = 10;
            this.tblBagi.Text = "/";
            this.tblBagi.UseVisualStyleBackColor = false;
            this.tblBagi.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cleaar
            // 
            this.Cleaar.BackColor = System.Drawing.Color.LightGray;
            this.Cleaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cleaar.Location = new System.Drawing.Point(109, 310);
            this.Cleaar.Name = "Cleaar";
            this.Cleaar.Size = new System.Drawing.Size(40, 40);
            this.Cleaar.TabIndex = 11;
            this.Cleaar.Text = "C";
            this.Cleaar.UseVisualStyleBackColor = false;
            this.Cleaar.Click += new System.EventHandler(this.Cleaar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(93, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kalkulator ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(117, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kyy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(270, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cleaar);
            this.Controls.Add(this.tblBagi);
            this.Controls.Add(this.tblKali);
            this.Controls.Add(this.tblKurang);
            this.Controls.Add(this.tblTambah);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button tblTambah;
        private System.Windows.Forms.Button tblKurang;
        private System.Windows.Forms.Button tblKali;
        private System.Windows.Forms.Button tblBagi;
        private System.Windows.Forms.Button Cleaar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
