using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Tech_ex1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            decimal suma = 0;
            if (textBox1.Text.Length > 0)
                {  
                suma = System.Convert.ToDecimal(textBox1.Text);
                if (textBox2.Text.Length > 0)
                {
                    suma=suma + System.Convert.ToDecimal(textBox2.Text);
                }
                if (textBox3.Text.Length > 0)
                {
                    suma = suma - System.Convert.ToDecimal(textBox3.Text);
                }
                    string str = suma.ToString("0");
                    textBox4.Text = str;
                }
                else
                {

                }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Key_Validation(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c))
            { 

            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Въвеждайте само чифри!", "Базова стипендия , Допълнителни доходи и Такси", buttons);
                e.Handled = true;
            }
        }
    }
}
