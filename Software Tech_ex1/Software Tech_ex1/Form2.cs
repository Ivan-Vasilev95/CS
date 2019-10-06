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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            textBox1.Focus();

          


        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    textBox5.Focus();
                    break;
                case Keys.Down:
                    textBox2.Focus();
                    break;
                case Keys.Enter:
                    textBox2.Focus();
                    break;
            }
        }
        private void TextBox1_KeyPress(object sender,KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c) || e.KeyChar==(char)Keys.Back || e.KeyChar==(char)Keys.Enter)
            {
             
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Въвеждайте само букви!", "Въвеждане на име , презиме , и фамилия", buttons);
                e.Handled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Width = (statusStrip1.Width / 2);
            toolStripStatusLabel2.Width = (toolStripStatusLabel1.Width / 2);
            toolStripStatusLabel3.Width = (toolStripStatusLabel1.Width / 2) - 2;

            DateTime d = DateTime.Now;
            toolStripStatusLabel2.Text = d.ToLongDateString();
            toolStripStatusLabel3.Text = d.ToLongTimeString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox3_MouseMove(object sender, EventArgs e)
        {
            string s = "Въведете ЕГН!";
            toolStripStatusLabel1.Text = s;
        }

        private void TextBox5_MouseMove(object sender, EventArgs e)
        {
            string s = "Въведете име!";
            toolStripStatusLabel1.Text = s;
        }

        private void TextBox4_MouseMove(object sender, EventArgs e)
        {
            string s = "Въведете адрес!";
            toolStripStatusLabel1.Text = s;
        }

        private void TextBox2_MouseMove(object sender, EventArgs e)
        {
            string s = "Въведете фамилия!";
            toolStripStatusLabel1.Text = s;
        }

        private void TextBox1_MouseMove(object sender, EventArgs e)
        {
            string s = "Въведете презиме!";
            toolStripStatusLabel1.Text = s;
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {
          
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Въвеждайте само чифри!", "ЕГН", buttons);
                e.Handled = true;
            }
        }

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    textBox1.Focus();
                    break;
                case Keys.Down:
                    textBox3.Focus();
                    break;
                case Keys.Enter:
                    textBox3.Focus();
                    break;
            }
        }

        private void TextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    textBox2.Focus();
                    break;
                case Keys.Down:
                    textBox4.Focus();
                    break;
                case Keys.Enter:
                    textBox4.Focus();
                    break;
            }
        }

        private void TextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    textBox3.Focus();
                    break;
                case Keys.Down:
                    textBox5.Focus();
                    break;
                case Keys.Enter:
                    textBox5.Focus();
                    break;
            }
        }

        private void TextBox5_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    textBox4.Focus();
                    break;
                case Keys.Down:
                    textBox1.Focus();
                    break;
                case Keys.Enter:
                    textBox1.Focus();
                    break;
            }
        }

        private void TextBox_txtChange(object sender, EventArgs e)
        {
            int pos = textBox1.SelectionStart;
            int TextL = textBox1.Text.Length;
            if (TextL > 0)
            {
                string TextFirst = textBox1.Text.Substring(0, 1);
                string TextEnd = textBox1.Text.Substring(1, TextL - 1);
                textBox1.Text = TextFirst.ToUpper() + TextEnd.ToLower();
                textBox1.SelectionStart = pos;
            }
        }

        private void TextBox2_txtChange(object sender, EventArgs e)
        {
            int pos = textBox2.SelectionStart;
            int TextL = textBox2.Text.Length;
            if (TextL > 0)
            {
                string TextFirst = textBox2.Text.Substring(0, 1);
                string TextEnd = textBox2.Text.Substring(1, TextL - 1);
                textBox2.Text = TextFirst.ToUpper() + TextEnd.ToLower();
                textBox2.SelectionStart = pos;
            }
        }

        private void TextBox3_txtChange(object sender, EventArgs e)
        {
            int pos = textBox3.SelectionStart;
            int TextL = textBox3.Text.Length;
            if (TextL > 0)
            {
                string TextFirst = textBox3.Text.Substring(0, 1);
                string TextEnd = textBox3.Text.Substring(1, TextL - 1);
                textBox3.Text = TextFirst.ToUpper() + TextEnd.ToLower();
                textBox3.SelectionStart = pos;
            }
        }

        private void Change_Pic(object sender, EventArgs e)
        {
            String ImageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

