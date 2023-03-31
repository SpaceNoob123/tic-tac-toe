using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Tic-Tac-Toe";
            int player = 1;
            

            //Button left Top
            btlefttop = new Button();
            btlefttop.Text = "";
            btlefttop.Click += button1_Click;
            btlefttop.ForeColor = Color.Green;
            btlefttop.Size = new Size(90, 100);
            btlefttop.Location = new Point(150, 150);
            btlefttop.BackColor = Color.White;
            btlefttop.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button right Top
            btrighttop = new Button();
            btrighttop.Text = "";
            btrighttop.Click += button1_Click;
            btrighttop.ForeColor = Color.Green;
            btrighttop.Size = new Size(90, 100);
            btrighttop.Location = new Point(350, 150);
            btrighttop.BackColor = Color.White;
            btrighttop.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button Top
            bttop = new Button();
            bttop.Text = "";
            bttop.Click += button1_Click;
            bttop.ForeColor = Color.Green;
            bttop.Size = new Size(90, 100);
            bttop.Location = new Point(250, 150);
            bttop.BackColor = Color.White;
            bttop.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button Left
            btleft = new Button();
            btleft.Text = "";
            btleft.Click += button1_Click;
            btleft.ForeColor = Color.Green;
            btleft.Size = new Size(90, 100);
            btleft.Location = new Point(150, 260);
            btleft.BackColor = Color.White;
            btleft.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button Center
            btcenter = new Button();
            btcenter.Text = "";
            btcenter.Click += button1_Click;
            btcenter.ForeColor = Color.Green;
            btcenter.Size = new Size(90, 100);
            btcenter.Location = new Point(250, 260);
            btcenter.BackColor = Color.White;
            btcenter.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button Right
            btright = new Button();
            btright.Text = "";
            btright.Click += button1_Click;
            btright.ForeColor = Color.Green;
            btright.Size = new Size(90, 100);
            btright.Location = new Point(350, 260);
            btright.BackColor = Color.White;
            btright.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button bottom Left
            btbottomleft = new Button();
            btbottomleft.Text = "";
            btbottomleft.Click += button1_Click;
            btbottomleft.ForeColor = Color.Green;
            btbottomleft.Size = new Size(90, 100);
            btbottomleft.Location = new Point(150, 370);
            btbottomleft.BackColor = Color.White;
            btbottomleft.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button bottom
            btbottom = new Button();
            btbottom.Text = "";
            btbottom.Click += button1_Click;
            btbottom.ForeColor = Color.Green;
            btbottom.Size = new Size(90, 100);
            btbottom.Location = new Point(250, 370);
            btbottom.BackColor = Color.White;
            btbottom.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            //Button bottom right
            btbottomright = new Button();
            btbottomright.Text = "";
            btbottomright.Click += button1_Click;
            btbottomright.ForeColor = Color.Green;
            btbottomright.Size = new Size(90, 100);
            btbottomright.Location = new Point(350, 370);
            btbottomright.BackColor = Color.White;
            btbottomright.Font = new Font("Times New Roman", 13, FontStyle.Bold | FontStyle.Italic);



            void button1_Click(object sender, EventArgs e)
            {
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, "x");
                        player = 0;
                        break;
                    case 0:
                        sender.GetType().GetProperty("Text").SetValue(sender, "o");
                        player = 1;
                        break;
                }
                sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                Check_win();
            }



            void Check_win()
            {
                //Horizontal
                if (btlefttop.Text == bttop.Text && bttop.Text == btrighttop.Text)
                {
                    if (btlefttop.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
                if (btleft.Text == btcenter.Text && btcenter.Text == btright.Text)
                {
                    if (btleft.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
                if (btbottomleft.Text == btbottom.Text && btbottom.Text == btbottomright.Text)
                {
                    if (btbottomleft.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
                //Vertical
                if (btlefttop.Text == btleft.Text && btleft.Text == btbottomleft.Text)
                {
                    if (btlefttop.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
                if (bttop.Text == btcenter.Text && btcenter.Text == btbottom.Text)
                {
                    if (bttop.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
                if (btrighttop.Text == btright.Text && btright.Text == btbottomright.Text)
                {
                    if (btrighttop.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
                //Diagonal
                if (btlefttop.Text == btcenter.Text && btcenter.Text == btbottomright.Text)
                {
                    if (btlefttop.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
                if (btbottomleft.Text == btcenter.Text && btcenter.Text == btrighttop.Text)
                {
                    if (btbottomleft.Text != "")
                    {
                        MessageBox.Show("Вы победили!");
                        return;
                    }
                }
            }
            


            this.Controls.Add(btlefttop);
            this.Controls.Add(btrighttop);
            this.Controls.Add(bttop);
            this.Controls.Add(btbottom);
            this.Controls.Add(btbottomleft);
            this.Controls.Add(btbottomright);
            this.Controls.Add(btright);
            this.Controls.Add(btleft);
            this.Controls.Add(btcenter);
        }
        Button btlefttop;
        Button btrighttop;
        Button bttop;
        Button btbottom;
        Button btbottomleft;
        Button btbottomright;
        Button btright;
        Button btleft;
        Button btcenter;
        #endregion
    }
}

