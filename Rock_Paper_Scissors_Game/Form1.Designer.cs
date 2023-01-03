
namespace Rock_Paper_Scissors_Game
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
            this.textBox_Rslt = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Ply = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBox_B2 = new System.Windows.Forms.TextBox();
            this.textBox_B3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Rslt2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Rslt3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Rslt
            // 
            this.textBox_Rslt.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_Rslt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Rslt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Rslt.Location = new System.Drawing.Point(257, 182);
            this.textBox_Rslt.Name = "textBox_Rslt";
            this.textBox_Rslt.ReadOnly = true;
            this.textBox_Rslt.Size = new System.Drawing.Size(19, 16);
            this.textBox_Rslt.TabIndex = 2;
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(292, 44);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.ReadOnly = true;
            this.textBox_B.Size = new System.Drawing.Size(154, 23);
            this.textBox_B.TabIndex = 3;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_Bot_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, -91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player B";
            // 
            // button_Ply
            // 
            this.button_Ply.Location = new System.Drawing.Point(377, 131);
            this.button_Ply.Name = "button_Ply";
            this.button_Ply.Size = new System.Drawing.Size(69, 23);
            this.button_Ply.TabIndex = 9;
            this.button_Ply.Text = "Play";
            this.button_Ply.UseVisualStyleBackColor = true;
            this.button_Ply.Click += new System.EventHandler(this.button_Ply_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(101, 44);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(141, 23);
            this.textBoxA.TabIndex = 10;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(101, 73);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.ReadOnly = true;
            this.textBoxA2.Size = new System.Drawing.Size(141, 23);
            this.textBoxA2.TabIndex = 12;
            // 
            // textBoxA3
            // 
            this.textBoxA3.Location = new System.Drawing.Point(101, 102);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.ReadOnly = true;
            this.textBoxA3.Size = new System.Drawing.Size(141, 23);
            this.textBoxA3.TabIndex = 13;
            // 
            // textBox_B2
            // 
            this.textBox_B2.Location = new System.Drawing.Point(292, 73);
            this.textBox_B2.Name = "textBox_B2";
            this.textBox_B2.ReadOnly = true;
            this.textBox_B2.Size = new System.Drawing.Size(154, 23);
            this.textBox_B2.TabIndex = 14;
            // 
            // textBox_B3
            // 
            this.textBox_B3.Location = new System.Drawing.Point(292, 102);
            this.textBox_B3.Name = "textBox_B3";
            this.textBox_B3.ReadOnly = true;
            this.textBox_B3.Size = new System.Drawing.Size(154, 23);
            this.textBox_B3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Player B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Scissors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Paper";
            // 
            // textBox_Rslt2
            // 
            this.textBox_Rslt2.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_Rslt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Rslt2.Location = new System.Drawing.Point(257, 211);
            this.textBox_Rslt2.Name = "textBox_Rslt2";
            this.textBox_Rslt2.ReadOnly = true;
            this.textBox_Rslt2.Size = new System.Drawing.Size(19, 16);
            this.textBox_Rslt2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Player A wins";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Player B wins";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "of 100 games";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(226, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tie:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox_Rslt3
            // 
            this.textBox_Rslt3.BackColor = System.Drawing.Color.LightGreen;
            this.textBox_Rslt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Rslt3.Location = new System.Drawing.Point(257, 240);
            this.textBox_Rslt3.Name = "textBox_Rslt3";
            this.textBox_Rslt3.ReadOnly = true;
            this.textBox_Rslt3.Size = new System.Drawing.Size(19, 16);
            this.textBox_Rslt3.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "of 100 games";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(282, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "of 100 games";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(543, 277);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_Rslt3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Rslt2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_B3);
            this.Controls.Add(this.textBox_B2);
            this.Controls.Add(this.textBoxA3);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.button_Ply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_Rslt);
            this.Name = "Form1";
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Rslt;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Ply;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBox_B2;
        private System.Windows.Forms.TextBox textBox_B3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Rslt2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Rslt3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}

