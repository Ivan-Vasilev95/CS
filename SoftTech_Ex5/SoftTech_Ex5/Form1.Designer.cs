namespace SoftTech_Ex5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавиИмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намериПоЕГНToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актуализирайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отсраниПоЕГНToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.collum1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collum2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиИмеToolStripMenuItem,
            this.намериПоЕГНToolStripMenuItem,
            this.актуализирайToolStripMenuItem,
            this.отсраниПоЕГНToolStripMenuItem,
            this.крайToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавиИмеToolStripMenuItem
            // 
            this.добавиИмеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавиИмеToolStripMenuItem.Image")));
            this.добавиИмеToolStripMenuItem.Name = "добавиИмеToolStripMenuItem";
            this.добавиИмеToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.добавиИмеToolStripMenuItem.Text = "Добави Име";
            this.добавиИмеToolStripMenuItem.Click += new System.EventHandler(this.добавиИмеToolStripMenuItem_Click);
            // 
            // намериПоЕГНToolStripMenuItem
            // 
            this.намериПоЕГНToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("намериПоЕГНToolStripMenuItem.Image")));
            this.намериПоЕГНToolStripMenuItem.Name = "намериПоЕГНToolStripMenuItem";
            this.намериПоЕГНToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.намериПоЕГНToolStripMenuItem.Text = "Намери по ЕГН";
            this.намериПоЕГНToolStripMenuItem.Click += new System.EventHandler(this.намериПоЕГНToolStripMenuItem_Click);
            // 
            // актуализирайToolStripMenuItem
            // 
            this.актуализирайToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("актуализирайToolStripMenuItem.Image")));
            this.актуализирайToolStripMenuItem.Name = "актуализирайToolStripMenuItem";
            this.актуализирайToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.актуализирайToolStripMenuItem.Text = "Актуализирай";
            this.актуализирайToolStripMenuItem.Click += new System.EventHandler(this.актуализирайToolStripMenuItem_Click);
            // 
            // отсраниПоЕГНToolStripMenuItem
            // 
            this.отсраниПоЕГНToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отсраниПоЕГНToolStripMenuItem.Image")));
            this.отсраниПоЕГНToolStripMenuItem.Name = "отсраниПоЕГНToolStripMenuItem";
            this.отсраниПоЕГНToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.отсраниПоЕГНToolStripMenuItem.Text = "Отсрани по ЕГН";
            this.отсраниПоЕГНToolStripMenuItem.Click += new System.EventHandler(this.отсраниПоЕГНToolStripMenuItem_Click);
            // 
            // крайToolStripMenuItem
            // 
            this.крайToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("крайToolStripMenuItem.Image")));
            this.крайToolStripMenuItem.Name = "крайToolStripMenuItem";
            this.крайToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.крайToolStripMenuItem.Text = "Край";
            this.крайToolStripMenuItem.Click += new System.EventHandler(this.крайToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(277, 173);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ЕГН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Брой на елементите в колекцията";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.collum1,
            this.collum2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 212);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(402, 222);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // collum1
            // 
            this.collum1.Text = "ЕГН";
            this.collum1.Width = 97;
            // 
            // collum2
            // 
            this.collum2.Text = "Фамилия";
            this.collum2.Width = 272;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 441);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстообработка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавиИмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намериПоЕГНToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актуализирайToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отсраниПоЕГНToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крайToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader collum1;
        private System.Windows.Forms.ColumnHeader collum2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

