using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex6
{
    public partial class User: UserControl
    {
        public override string Text
        {
            get
            {
                return textBox1.Text;
            }
        }

        public User()
        {
            InitializeComponent();

        }
        private bool parLangValue = true;
        public bool parLang
        {
            get
            {
                return parLangValue;
            }
            set
            {
                parLangValue = value;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (parLang == true)
            {
                if((e.KeyChar>='а'& e.KeyChar <= 'я') || (e.KeyChar>='А'&e.KeyChar<='Я')||(e.KeyChar=='-'))
                {}
                else
                {
                    if ((e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == Convert.ToChar(Keys.Enter)))
                    {
                        e.Handled = false;
                    }
                    else if ((e.KeyChar==Convert.ToChar(Keys.Space)) && !(string.IsNullOrWhiteSpace(textBox1.Text)))
                    {
                        if(textBox1.Text.Contains(" "))
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                    else
                    {
                        e.Handled=true;
                    }
                }
            }
            else
            {
                if((e.KeyChar>='a'&e.KeyChar<='z')||(e.KeyChar>='A'& e.KeyChar <= 'Z') || (e.KeyChar == '-'))
                {}
                else
                {
                    if ((e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == Convert.ToChar(Keys.Enter)))
                    {
                        e.Handled = false;
                    }
                    else if ((e.KeyChar == Convert.ToChar(Keys.Space)) && !(string.IsNullOrWhiteSpace(textBox1.Text)))
                    {
                        if (textBox1.Text.Contains(" "))
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
