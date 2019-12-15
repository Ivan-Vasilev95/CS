using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Име: Иван Венциславов Василев." + Environment.NewLine;
            textBox1.Text += "Специалност: КСТ." + Environment.NewLine;
            textBox1.Text += "Курс: 3" + Environment.NewLine;
            textBox1.Text += "Факултетен №: 17621308";
        }
    }
}
