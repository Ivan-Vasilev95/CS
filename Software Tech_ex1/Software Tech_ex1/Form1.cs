using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Software_Tech_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Enabled = true;
            timer1.Interval = 1000;

            if ((progressBar1.Value == progressBar1.Maximum))
            {
                timer1.Enabled = false;
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
               
            }
            else
            {
                progressBar1.Value = (progressBar1.Value + 25);
                this.Opacity = (this.Opacity + 0.05);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath MyGraphicsPath;
            MyGraphicsPath = new GraphicsPath();
            MyGraphicsPath.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new Region(MyGraphicsPath);
        }
    }
}
