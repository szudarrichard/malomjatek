﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malom
{
    public partial class Form1 : Form
    {
        static PictureBox[,] babuk = new PictureBox[2, 9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nevellenorzes();
            button2.Visible = false;
        }

        private void nevellenorzes()
        {
            string nev1 = jatekos1_TBOX.Text;
            string nev2 = jatekos2_TBOX.Text;

            /*if(nev1 == "" || nev2 == "")
            {
                MessageBox.Show($"Adj meg mindkét játékosnak nevet!");
            }
            else
            {
             labelek, textboxok, buttonok eltüntetése   
            }*/

            gombeltuntetes();
            palyageneralas();
            babugeneralas();
        }

        private void babugeneralas()
        {
            int x = 250;
            int y = 400;
            int szin = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    PictureBox babu = new PictureBox();
                    babu.Size = new Size(50, 50);
                    babu.Name = $"babu_{i}_{j}";
                    babu.BackgroundImage = keplista.Images[szin % 2];
                    babu.Location = new Point(x + 6, y);
                    babu.BackgroundImageLayout = ImageLayout.Zoom;
                    //babu.MouseClick += new MouseEventHandler(babuklikk);
                    babuk[i, j] = babu;
                    this.Controls.Add(babu);

                    szin++;
                    x += 55;
                }
                x = 250;
                y += 55;
            }
        }

        private void gombeltuntetes()
        {
            jatekos1_TBOX.Visible = false;
            jatekos2_TBOX.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void palyageneralas()
        {
            int x = 150;
            int y = 30;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox kulsoresz = new PictureBox();
                    kulsoresz.Size = new Size(50, 50);
                    kulsoresz.Location = new Point(x + 6, y);
                    kulsoresz.Name = $"{i}_{j}";
                    //kulsoresz.MouseClick += new MouseEventHandler(mozgatasClick);
                    if ((i + j) % 3 == 0)
                    {
                        kulsoresz.BackColor = Color.FromArgb(255, 216, 176);
                    }
                    else
                    {
                        kulsoresz.BackColor = Color.White;
                        kulsoresz.Enabled = false;
                    }
                    this.Controls.Add(kulsoresz);
                    //jatekter[i, j] = kulsoresz;

                    x += 50;
                }

                x = 150;
                y += 50;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gombeltuntetes();
            richTextBox1.Visible = true;
            Xbutton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gombvisszahozas();
        }

        private void gombvisszahozas()
        {
            jatekos1_TBOX.Visible = true;
            jatekos2_TBOX.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            richTextBox1.Visible = false;
            Xbutton.Visible = false;
        }
    }
}
