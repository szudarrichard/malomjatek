﻿
namespace malom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jatekos1_TBOX = new System.Windows.Forms.TextBox();
            this.jatekos2_TBOX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Xbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.keplista = new System.Windows.Forms.ImageList(this.components);
            this.keszitoklbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.játékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újraindításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.témaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alapértelmezettToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sötétToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos 1 neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Játékos 2 neve:";
            // 
            // jatekos1_TBOX
            // 
            this.jatekos1_TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos1_TBOX.Location = new System.Drawing.Point(153, 250);
            this.jatekos1_TBOX.Name = "jatekos1_TBOX";
            this.jatekos1_TBOX.Size = new System.Drawing.Size(105, 26);
            this.jatekos1_TBOX.TabIndex = 2;
            // 
            // jatekos2_TBOX
            // 
            this.jatekos2_TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos2_TBOX.Location = new System.Drawing.Point(153, 301);
            this.jatekos2_TBOX.Name = "jatekos2_TBOX";
            this.jatekos2_TBOX.Size = new System.Drawing.Size(105, 26);
            this.jatekos2_TBOX.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::malom.Properties.Resources.inditas;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(16, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 56);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::malom.Properties.Resources.tablaaa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(301, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 530);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = global::malom.Properties.Resources.szabalyok;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(155, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 56);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(301, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(530, 530);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // Xbutton
            // 
            this.Xbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Xbutton.Location = new System.Drawing.Point(798, 29);
            this.Xbutton.Name = "Xbutton";
            this.Xbutton.Size = new System.Drawing.Size(33, 29);
            this.Xbutton.TabIndex = 8;
            this.Xbutton.Text = "X";
            this.Xbutton.UseVisualStyleBackColor = true;
            this.Xbutton.Visible = false;
            this.Xbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::malom.Properties.Resources.TITLE;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 203);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // keplista
            // 
            this.keplista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("keplista.ImageStream")));
            this.keplista.TransparentColor = System.Drawing.Color.Transparent;
            this.keplista.Images.SetKeyName(0, "feher.png");
            this.keplista.Images.SetKeyName(1, "feka.png");
            // 
            // keszitoklbl
            // 
            this.keszitoklbl.AutoSize = true;
            this.keszitoklbl.BackColor = System.Drawing.Color.Transparent;
            this.keszitoklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keszitoklbl.ForeColor = System.Drawing.Color.White;
            this.keszitoklbl.Location = new System.Drawing.Point(858, 561);
            this.keszitoklbl.Name = "keszitoklbl";
            this.keszitoklbl.Size = new System.Drawing.Size(195, 80);
            this.keszitoklbl.TabIndex = 10;
            this.keszitoklbl.Text = "Készítette:\r\nKatona Koppány Gábor\r\nSzudár Richárd\r\nLázár Adrián\r\n";
            this.keszitoklbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.játékToolStripMenuItem,
            this.témaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // játékToolStripMenuItem
            // 
            this.játékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újraindításToolStripMenuItem});
            this.játékToolStripMenuItem.Name = "játékToolStripMenuItem";
            this.játékToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.játékToolStripMenuItem.Text = "Játék";
            // 
            // újraindításToolStripMenuItem
            // 
            this.újraindításToolStripMenuItem.Name = "újraindításToolStripMenuItem";
            this.újraindításToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.újraindításToolStripMenuItem.Text = "Újraindítás";
            this.újraindításToolStripMenuItem.Click += new System.EventHandler(this.újraindításToolStripMenuItem_Click);
            // 
            // témaToolStripMenuItem
            // 
            this.témaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alapértelmezettToolStripMenuItem,
            this.sötétToolStripMenuItem,
            this.lilaToolStripMenuItem});
            this.témaToolStripMenuItem.Name = "témaToolStripMenuItem";
            this.témaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.témaToolStripMenuItem.Text = "Téma";
            // 
            // alapértelmezettToolStripMenuItem
            // 
            this.alapértelmezettToolStripMenuItem.Name = "alapértelmezettToolStripMenuItem";
            this.alapértelmezettToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.alapértelmezettToolStripMenuItem.Text = "Alapértelmezett";
            this.alapértelmezettToolStripMenuItem.Click += new System.EventHandler(this.alapértelmezettToolStripMenuItem_Click);
            // 
            // sötétToolStripMenuItem
            // 
            this.sötétToolStripMenuItem.Name = "sötétToolStripMenuItem";
            this.sötétToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sötétToolStripMenuItem.Text = "Sötét";
            this.sötétToolStripMenuItem.Click += new System.EventHandler(this.sötétToolStripMenuItem_Click);
            // 
            // lilaToolStripMenuItem
            // 
            this.lilaToolStripMenuItem.Name = "lilaToolStripMenuItem";
            this.lilaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.lilaToolStripMenuItem.Text = "Lila";
            this.lilaToolStripMenuItem.Click += new System.EventHandler(this.lilaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::malom.Properties.Resources.hatter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 650);
            this.Controls.Add(this.keszitoklbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Xbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jatekos2_TBOX);
            this.Controls.Add(this.jatekos1_TBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Malom játék";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jatekos1_TBOX;
        private System.Windows.Forms.TextBox jatekos2_TBOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Xbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList keplista;
        private System.Windows.Forms.Label keszitoklbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem játékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újraindításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem témaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alapértelmezettToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sötétToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lilaToolStripMenuItem;
    }
}

