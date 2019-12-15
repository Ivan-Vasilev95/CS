namespace SoftTech_Ex9
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.крайToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.старТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подредиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хоризонталноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикалноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заПроизводителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.подредиToolStripMenuItem,
            this.заПроизводителяToolStripMenuItem,
            this.крайToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новToolStripMenuItem,
            this.намериToolStripMenuItem,
            this.toolStripSeparator1,
            this.крайToolStripMenuItem1});
            this.авторToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("авторToolStripMenuItem.Image")));
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // новToolStripMenuItem
            // 
            this.новToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новToolStripMenuItem.Image")));
            this.новToolStripMenuItem.Name = "новToolStripMenuItem";
            this.новToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.новToolStripMenuItem.Text = "Нов...";
            this.новToolStripMenuItem.Click += new System.EventHandler(this.новToolStripMenuItem_Click);
            // 
            // намериToolStripMenuItem
            // 
            this.намериToolStripMenuItem.Name = "намериToolStripMenuItem";
            this.намериToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.намериToolStripMenuItem.Text = "Намери";
            this.намериToolStripMenuItem.Click += new System.EventHandler(this.намериToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // крайToolStripMenuItem1
            // 
            this.крайToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("крайToolStripMenuItem1.Image")));
            this.крайToolStripMenuItem1.Name = "крайToolStripMenuItem1";
            this.крайToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.крайToolStripMenuItem1.Text = "Край";
            this.крайToolStripMenuItem1.Click += new System.EventHandler(this.крайToolStripMenuItem1_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новТекстToolStripMenuItem,
            this.старТекстToolStripMenuItem});
            this.текстToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("текстToolStripMenuItem.Image")));
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.текстToolStripMenuItem.Text = "Текст";
            this.текстToolStripMenuItem.Click += new System.EventHandler(this.текстToolStripMenuItem_Click);
            // 
            // новТекстToolStripMenuItem
            // 
            this.новТекстToolStripMenuItem.Name = "новТекстToolStripMenuItem";
            this.новТекстToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.новТекстToolStripMenuItem.Text = "Нов Текст";
            this.новТекстToolStripMenuItem.Click += new System.EventHandler(this.новТекстToolStripMenuItem_Click);
            // 
            // старТекстToolStripMenuItem
            // 
            this.старТекстToolStripMenuItem.Name = "старТекстToolStripMenuItem";
            this.старТекстToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.старТекстToolStripMenuItem.Text = "Стар Текст";
            this.старТекстToolStripMenuItem.Click += new System.EventHandler(this.старТекстToolStripMenuItem_Click);
            // 
            // подредиToolStripMenuItem
            // 
            this.подредиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хоризонталноToolStripMenuItem,
            this.вертикалноToolStripMenuItem,
            this.каскадноToolStripMenuItem});
            this.подредиToolStripMenuItem.Name = "подредиToolStripMenuItem";
            this.подредиToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.подредиToolStripMenuItem.Text = "Подреди";
            this.подредиToolStripMenuItem.Click += new System.EventHandler(this.подредиToolStripMenuItem_Click);
            // 
            // хоризонталноToolStripMenuItem
            // 
            this.хоризонталноToolStripMenuItem.Name = "хоризонталноToolStripMenuItem";
            this.хоризонталноToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.хоризонталноToolStripMenuItem.Text = "Хоризонтално";
            this.хоризонталноToolStripMenuItem.Click += new System.EventHandler(this.хоризонталноToolStripMenuItem_Click);
            // 
            // вертикалноToolStripMenuItem
            // 
            this.вертикалноToolStripMenuItem.Name = "вертикалноToolStripMenuItem";
            this.вертикалноToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вертикалноToolStripMenuItem.Text = "Вертикално";
            this.вертикалноToolStripMenuItem.Click += new System.EventHandler(this.вертикалноToolStripMenuItem_Click);
            // 
            // каскадноToolStripMenuItem
            // 
            this.каскадноToolStripMenuItem.Name = "каскадноToolStripMenuItem";
            this.каскадноToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.каскадноToolStripMenuItem.Text = "Каскадно";
            this.каскадноToolStripMenuItem.Click += new System.EventHandler(this.каскадноToolStripMenuItem_Click);
            // 
            // заПроизводителяToolStripMenuItem
            // 
            this.заПроизводителяToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заПроизводителяToolStripMenuItem.Image")));
            this.заПроизводителяToolStripMenuItem.Name = "заПроизводителяToolStripMenuItem";
            this.заПроизводителяToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.заПроизводителяToolStripMenuItem.Text = "За Производителя";
            this.заПроизводителяToolStripMenuItem.Click += new System.EventHandler(this.заПроизводителяToolStripMenuItem_Click);
            // 
            // крайToolStripMenuItem
            // 
            this.крайToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("крайToolStripMenuItem.Image")));
            this.крайToolStripMenuItem.Name = "крайToolStripMenuItem";
            this.крайToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.крайToolStripMenuItem.Text = "Край";
            this.крайToolStripMenuItem.Click += new System.EventHandler(this.крайToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(483, 20);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Текстов Редактор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крайToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намериToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem крайToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem старТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подредиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заПроизводителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хоризонталноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикалноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадноToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

