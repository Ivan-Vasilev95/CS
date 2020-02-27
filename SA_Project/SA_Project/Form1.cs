using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += "Изработил - Иван Венциславов Василев." + Environment.NewLine;
            textBox1.Text += "Факултетен номер - 17621308" + Environment.NewLine;
            textBox1.Text += "Специалност КСТ" + Environment.NewLine;
            textBox1.Text += "Семестър : 5" + Environment.NewLine;
            textBox1.Text += "Курс : 3" + Environment.NewLine;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _3X3 frm2 = new _3X3();
            frm2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _3X2 frm3 = new _3X2();
            frm3.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
                Application.Exit();
            }
            else
            {

            }
        }
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void table3X3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _3X3 frm2 = new _3X3();
            frm2.Show();
        }

        private void table3X2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _3X2 frm3 = new _3X2();
            frm3.Show();
        }
    }
}
