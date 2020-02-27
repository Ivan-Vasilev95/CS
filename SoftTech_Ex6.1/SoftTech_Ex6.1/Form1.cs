using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user1.Text.EndsWith(" "))
            {
                MessageBox.Show("Text cant end with white space","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label1.Text = user1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user1.parLang == true)
            {
                user1.parLang = false;
                label2.Text = "Английски";
            }
            else
            {
                user1.parLang = true;
                label2.Text = "Български";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
