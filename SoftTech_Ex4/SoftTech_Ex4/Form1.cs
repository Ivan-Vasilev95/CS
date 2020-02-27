using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex4
{
    public partial class Form1 : Form
    {
        int parPos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            generating_MenuStrip();
            generating_button();
            menuStrip1.BackColor = Color.White;
        }
        public void generating_MenuStrip()
        {
            ToolStripMenuItem fileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.Items.Add(fileToolStripMenuItem);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);

            ToolStripMenuItem newToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem.Text = "New";
            fileToolStripMenuItem.DropDownItems.Add(newToolStripMenuItem);
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);

            ToolStripMenuItem openToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem.Text = "Open";
            fileToolStripMenuItem.DropDownItems.Add(openToolStripMenuItem);
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);

            ToolStripMenuItem closeToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem.Text = "Close";
            fileToolStripMenuItem.DropDownItems.Add(closeToolStripMenuItem);
            closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);

            ToolStripMenuItem enddToolStripMenuItem = new ToolStripMenuItem();
            enddToolStripMenuItem.Text = "End";
            enddToolStripMenuItem.BackColor = Color.Red;
            fileToolStripMenuItem.DropDownItems.Add(enddToolStripMenuItem);
            enddToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);



            ToolStripMenuItem editToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem viewToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem helpToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem endToolStripMenuItem = new ToolStripMenuItem();
            endToolStripMenuItem.BackColor = Color.Red;


            menuStrip1.Items.Add(editToolStripMenuItem);
            menuStrip1.Items.Add(viewToolStripMenuItem);
            menuStrip1.Items.Add(helpToolStripMenuItem);
            menuStrip1.Items.Add(endToolStripMenuItem);
            
            

            editToolStripMenuItem.Text = "Edit";
            viewToolStripMenuItem.Text = "View";
            helpToolStripMenuItem.Text = "Help";
            endToolStripMenuItem.Text = "End";

            editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);

            this.MainMenuStrip = MainMenuStrip;
            Controls.Add(MainMenuStrip);
        }

        public void generating_button()
        {
            Button btnDock = new Button();
            btnDock.Text = "Завърти менюто !";
            btnDock.Left = this.Width / 2;
            btnDock.Top = this.Height / 2;
            btnDock.Click += new System.EventHandler(this.btnDock_Click);
            Controls.Add(btnDock);
        }

        public void btnDock_Click(Object sender,System.EventArgs e)
        {
            switch (parPos)
            {
                case 0:
                    {
                        menuStrip1.Dock = DockStyle.Right;
                        parPos = 1;
                        break;
                    }
                case 1:
                    {
                        menuStrip1.Dock = DockStyle.Bottom;
                        parPos = 2;
                        break;
                    }
                case 2:
                    {
                        menuStrip1.Dock = DockStyle.Left;
                        parPos = 3;
                        break;
                    }
                case 3:
                    {
                        menuStrip1.Dock = DockStyle.Top;
                        parPos = 0;
                        break;
                    }
            }
        }
        private void fileToolStripMenuItem_Click(object sender , EventArgs e)
        {
          
        }
        private void newToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            MessageBox.Show("New submenu item clicked");
        }
        private void openToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            MessageBox.Show("Open submenu item clicked");
        }
        private void closeToolStripMenuItem_Click(object sender,EventArgs e)
        {
            MessageBox.Show("Close submenu item clicked");
        }
        private void editToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            MessageBox.Show("Edit menu item clicked");
        }
        private void viewToolStripMenuItem_Click(object sender , EventArgs e)
        {
            MessageBox.Show("View menu item clicked");
        }
        private void helpToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            MessageBox.Show("Help menu item clicked");
        }
        private void endToolStripMenuItem_Click (object sender ,EventArgs e)
        {
            Application.Exit();
        }
    }
}
