﻿using System.Drawing.Imaging;

namespace _2pacalypse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(11, 109);
            label1.Name = "label1";
            label1.Size = new Size(59, 40);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(76, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "64.231.75.201";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(390, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 39);
            textBox2.TabIndex = 4;
            textBox2.Text = "80";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(294, 109);
            label2.Name = "label2";
            label2.Size = new Size(90, 40);
            label2.TabIndex = 3;
            label2.Text = "Port:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(180, 18);
            label3.Name = "label3";
            label3.Size = new Size(347, 40);
            label3.TabIndex = 5;
            label3.Text = "50centpocalypse v3.0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(550, 18);
            label4.Name = "label4";
            label4.Size = new Size(187, 22);
            label4.TabIndex = 6;
            label4.Text = "-Coded by MC Strela";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(11, 405);
            label5.Name = "label5";
            label5.Size = new Size(241, 36);
            label5.TabIndex = 7;
            label5.Text = "Botnets Online: ";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(46, 184);
            button1.Name = "button1";
            button1.Size = new Size(318, 91);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(508, 81);
            label6.Name = "label6";
            label6.Size = new Size(290, 54);
            label6.TabIndex = 9;
            label6.Text = "50ways to catch a money \r\ncheck me out now";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(11, 9);
            label7.Name = "label7";
            label7.Size = new Size(0, 22);
            label7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            //label8.ForeColor = Color.FromArgb(0, 192, 0);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(17, 9);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(11, 8);
            button2.Name = "button2";
            button2.Size = new Size(59, 23);
            button2.TabIndex = 12;
            button2.Text = "play";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(11, 8);
            button3.Name = "button3";
            button3.Size = new Size(59, 23);
            button3.TabIndex = 13;
            button3.Text = "pause";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "50CENTPOCALYPSE V3.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button3;
    }
}