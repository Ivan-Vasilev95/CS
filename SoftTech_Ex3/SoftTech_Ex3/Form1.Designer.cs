namespace SoftTech_Ex3
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
            this.picMap = new System.Windows.Forms.PictureBox();
            this.p0 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новОбектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покажиОбектиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрийОбектиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скрийОбектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преместиОбектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сприПреместванетоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отстраниОбектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p0)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone)).BeginInit();
            this.SuspendLayout();
            // 
            // picMap
            // 
            this.picMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMap.Image = ((System.Drawing.Image)(resources.GetObject("picMap.Image")));
            this.picMap.Location = new System.Drawing.Point(0, 0);
            this.picMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(1920, 858);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            this.picMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P0_MouseDown);
            this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicMap_MouseMove);
            // 
            // p0
            // 
            this.p0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p0.Location = new System.Drawing.Point(0, 0);
            this.p0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(1920, 858);
            this.p0.TabIndex = 1;
            this.p0.TabStop = false;
            this.p0.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новОбектToolStripMenuItem,
            this.покажиОбектиToolStripMenuItem,
            this.скрийОбектиToolStripMenuItem,
            this.крайToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(308, 196);
            // 
            // новОбектToolStripMenuItem
            // 
            this.новОбектToolStripMenuItem.Name = "новОбектToolStripMenuItem";
            this.новОбектToolStripMenuItem.Size = new System.Drawing.Size(307, 48);
            this.новОбектToolStripMenuItem.Text = "Нов обект";
            this.новОбектToolStripMenuItem.Click += new System.EventHandler(this.NewObject_Click);
            // 
            // покажиОбектиToolStripMenuItem
            // 
            this.покажиОбектиToolStripMenuItem.Name = "покажиОбектиToolStripMenuItem";
            this.покажиОбектиToolStripMenuItem.Size = new System.Drawing.Size(307, 48);
            this.покажиОбектиToolStripMenuItem.Text = "Покажи обекти";
            this.покажиОбектиToolStripMenuItem.Click += new System.EventHandler(this.ПокажиОбектиToolStripMenuItem_Click);
            // 
            // скрийОбектиToolStripMenuItem
            // 
            this.скрийОбектиToolStripMenuItem.Name = "скрийОбектиToolStripMenuItem";
            this.скрийОбектиToolStripMenuItem.Size = new System.Drawing.Size(307, 48);
            this.скрийОбектиToolStripMenuItem.Text = "Скрий обекти";
            this.скрийОбектиToolStripMenuItem.Click += new System.EventHandler(this.СкрийОбектиToolStripMenuItem_Click);
            // 
            // крайToolStripMenuItem
            // 
            this.крайToolStripMenuItem.Name = "крайToolStripMenuItem";
            this.крайToolStripMenuItem.Size = new System.Drawing.Size(307, 48);
            this.крайToolStripMenuItem.Text = "Край";
            this.крайToolStripMenuItem.Click += new System.EventHandler(this.КрайToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скрийОбектToolStripMenuItem,
            this.преместиОбектToolStripMenuItem,
            this.сприПреместванетоToolStripMenuItem,
            this.отстраниОбектToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(384, 196);
            // 
            // скрийОбектToolStripMenuItem
            // 
            this.скрийОбектToolStripMenuItem.Name = "скрийОбектToolStripMenuItem";
            this.скрийОбектToolStripMenuItem.Size = new System.Drawing.Size(383, 48);
            this.скрийОбектToolStripMenuItem.Text = "Скрий обект";
            this.скрийОбектToolStripMenuItem.Click += new System.EventHandler(this.СкрийОбектToolStripMenuItem_Click);
            // 
            // преместиОбектToolStripMenuItem
            // 
            this.преместиОбектToolStripMenuItem.Name = "преместиОбектToolStripMenuItem";
            this.преместиОбектToolStripMenuItem.Size = new System.Drawing.Size(383, 48);
            this.преместиОбектToolStripMenuItem.Text = "Премести обект";
            this.преместиОбектToolStripMenuItem.Click += new System.EventHandler(this.ПреместиОбектToolStripMenuItem_Click);
            // 
            // сприПреместванетоToolStripMenuItem
            // 
            this.сприПреместванетоToolStripMenuItem.Name = "сприПреместванетоToolStripMenuItem";
            this.сприПреместванетоToolStripMenuItem.Size = new System.Drawing.Size(383, 48);
            this.сприПреместванетоToolStripMenuItem.Text = "Спри преместването";
            this.сприПреместванетоToolStripMenuItem.Click += new System.EventHandler(this.СприПреместванетоToolStripMenuItem_Click);
            // 
            // отстраниОбектToolStripMenuItem
            // 
            this.отстраниОбектToolStripMenuItem.Name = "отстраниОбектToolStripMenuItem";
            this.отстраниОбектToolStripMenuItem.Size = new System.Drawing.Size(383, 48);
            this.отстраниОбектToolStripMenuItem.Text = "Отстрани обект";
            this.отстраниОбектToolStripMenuItem.Click += new System.EventHandler(this.ОтстраниОбектToolStripMenuItem_Click);
            // 
            // phone
            // 
            this.phone.Image = ((System.Drawing.Image)(resources.GetObject("phone.Image")));
            this.phone.Location = new System.Drawing.Point(1827, 98);
            this.phone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(61, 62);
            this.phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phone.TabIndex = 2;
            this.phone.TabStop = false;
            this.phone.Click += new System.EventHandler(this.NewObject_Click);
            this.phone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Phone_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 858);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.p0);
            this.Controls.Add(this.picMap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p0)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.PictureBox p0;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новОбектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покажиОбектиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрийОбектиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крайToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem скрийОбектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преместиОбектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сприПреместванетоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отстраниОбектToolStripMenuItem;
        private System.Windows.Forms.PictureBox pp;
    }
}

