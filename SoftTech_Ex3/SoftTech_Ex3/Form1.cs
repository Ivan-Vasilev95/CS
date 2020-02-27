using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex3
{
    public partial class Form1 : Form
    {
        public List<PictureBox> p = new List<PictureBox>();
        PictureBox phone = new PictureBox();
        public object sender1 = new object();
        public string senderName;
        Boolean ParMove;

        public Form1()
        {
            InitializeComponent();
        }

        private void ПокажиОбектиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(PictureBox pp in p)
            {
                pp.Visible = true;
                pp.Enabled = true;
            }
        }

        private void СкрийОбектиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(PictureBox pp in p)
            {
                pp.Visible = false;
                pp.Enabled = true;
            }
        }

        private void КрайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void P0_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:

                    break;
                case MouseButtons.Right:
                    contextMenuStrip1.Show(this, new Point(e.X, e.Y));
                    break;
            }
        }

        private void СкрийОбектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(PictureBox pp in p)
            {
                if ((senderName == pp.Name))
                {
                    pp.Visible = false;
                    pp.Tag = 0;
                }
            }
        }

        private void ПреместиОбектToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            if ((ParMove == true))
            {
                foreach(PictureBox pp in p)
                {
                    if((senderName == pp.Name))
                    {
                        pp.Left = (e.X + ((pp.Width / 2) - (pp.Cursor.Size.Width / 2)));
                        pp.Top = (e.Y + ((pp.Height / 2) - (pp.Cursor.Size.Height / 2)));
                    }
                }
            }
        }

        private void СприПреместванетоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParMove = false;
        }

        private void ОтстраниОбектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(PictureBox pp in p)
            {
                if ((senderName == pp.Name))
                {
                    pp.Visible = false;
                    p.Remove(pp);
                    break;
                }
            }
        }
        private void NewObject_Click(object sender ,EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);

            PictureBox NewP = new PictureBox();
            NewP.Name = "P" + (p.Count + 1).ToString();
            NewP.Width = phone.Width;
            NewP.Height = phone.Height;

            NewP.BackgroundImage = phone.BackgroundImage;
            NewP.SizeMode = phone.SizeMode;
            NewP.Image = phone.Image;
            NewP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Phone_MouseDown);

            NewP.ContextMenu = phone.ContextMenu;
            NewP.ContextMenuStrip = this.contextMenuStrip2;
            NewP.Visible = true;
            NewP.Left = Cursor.Position.X-25;
            NewP.Top = Cursor.Position.Y-35;

            NewP.Click += new System.EventHandler(this.P0_Click);
            NewP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P0_MouseDown);

            p.Add(NewP);
            this.Controls.Add(NewP);
            picMap.SendToBack();
        }

        private void ПреместиОбектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParMove = true;
        }

        private void PicMap_MouseMove(object sender, MouseEventArgs e)
        {
            if ((ParMove == true))
            {
                foreach(PictureBox pp in p)
                {
                    if ((senderName == pp.Name))
                    {
                        pp.Left = (e.X + ((pp.Width / 2) - (pp.Cursor.Size.Width / 2)));
                        pp.Top = (e.Y + ((pp.Height / 2) - (pp.Cursor.Size.Height / 2)));

                    }
                }
            }
        }

        private void P0_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Phone_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:

                    break;
                case MouseButtons.Right:
                    senderName = ((PictureBox)sender).Name;
                    break;
            }
        }
    }
}
