﻿namespace Проект_1_1_Лаб
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
            Button button1;
            button2 = new Button();
            textBoxD = new TextBox();
            textBoxC = new TextBox();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(538, 186);
            button1.Name = "button1";
            button1.Size = new Size(214, 94);
            button1.TabIndex = 0;
            button1.Text = "Вычислить d = f(x, y, c)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(538, 286);
            button2.Name = "button2";
            button2.Size = new Size(214, 87);
            button2.TabIndex = 1;
            button2.Text = "Конец";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(216, 342);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(150, 31);
            textBoxD.TabIndex = 2;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(216, 260);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(150, 31);
            textBoxC.TabIndex = 3;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(216, 223);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(150, 31);
            textBoxY.TabIndex = 4;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(216, 186);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(150, 31);
            textBoxX.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(55, 54);
            label1.MaximumSize = new Size(190, 190);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 6;
            label1.Text = "Задание:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 54);
            label2.Name = "label2";
            label2.Size = new Size(549, 30);
            label2.TabIndex = 7;
            label2.Text = "Вычислить значение условной функции d = f(x, y, c);";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 221);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 9;
            label4.Text = "y =";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 186);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 9;
            label5.Text = "x = ";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 263);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 10;
            label3.Text = "c =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 345);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 11;
            label6.Text = "d = ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxX);
            Controls.Add(textBoxY);
            Controls.Add(textBoxC);
            Controls.Add(textBoxD);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxD;
        private TextBox textBoxC;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
    }
}