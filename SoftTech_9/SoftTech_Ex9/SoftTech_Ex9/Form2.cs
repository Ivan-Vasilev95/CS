using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = nameBox21.Text + ". " + nameBox22.Text + ". " + nameBox23.Text + ".";
        }

        private void fondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();

            nameBox21.font(fontDialog1.Font);
            nameBox21.color(fontDialog1.Color);
            nameBox22.font(fontDialog1.Font);
            nameBox22.color(fontDialog1.Color);
            nameBox23.font(fontDialog1.Font);
            nameBox23.color(fontDialog1.Color);
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            nameBox21.empty();
            nameBox22.empty();
            nameBox23.empty();
            textBox1.Text = "";


        }

        public void Load_from_File()
        {
            nameBox21.fill(Form1.name1);
            nameBox22.fill(Form1.name2);
            nameBox23.fill(Form1.name3);
            textBox1.Text = Form1.name_shor;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            OpenFileDialog fd = new OpenFileDialog();

            string file_path="";

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_path = fd.FileName;
            }

            if (file_path.Length > 1)
            {
                using (TextReader reader = File.OpenText(file_path))
                {
                    string text = reader.ReadLine();
                    string[] bits = text.Split(' ');

                    nameBox21.fill(bits[0]);
                    nameBox22.fill(bits[1]);
                    nameBox23.fill(bits[2]);
                    textBox1.Text = bits[3];
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(nameBox21.whole_name() + " ");
                    sw.Write(nameBox22.whole_name() + " ");
                    sw.Write(nameBox23.whole_name() + " ");
                    sw.Write(textBox1.Text);
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            colorDialog1.ShowDialog();

            nameBox21.color(colorDialog1.Color);
            nameBox22.color(colorDialog1.Color);
            nameBox23.color(colorDialog1.Color);
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();


            if (textBox1.Focused == true)
            {
                textBox1.Text = "";
            }

            if (nameBox21.Focused_())
            {
                nameBox21.empty();
            }

            if (nameBox22.Focused_())
            {
                nameBox22.empty();
            }

            if (nameBox23.Focused_())
            {
                nameBox23.empty();
            }
        }

        private void nameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (nameBox21.Focused_() == true)
            {
                textBox1.Focus();
            }
            else if (textBox1.Focused == true)
            {
                nameBox23.set_Focus();
            }
            else if (nameBox23.Focused_() == true)
            {
                nameBox22.set_Focus();
            }
            else if (nameBox22.Focused_() == true)
            {
                nameBox21.set_Focus();
            }
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (nameBox21.Focused_() == true)
            {
                nameBox22.set_Focus();
            }
            else if (textBox1.Focused == true)
            {
                nameBox21.set_Focus();
            }
            else if (nameBox23.Focused_() == true)
            {
                textBox1.Focus();
            }
            else if (nameBox22.Focused_() == true)
            {
                nameBox23.set_Focus();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            fileToolStripMenuItem.DropDown.Close();
            editToolStripMenuItem.DropDown.Close();

            Form1.copy_n1 = nameBox21.whole_name();
            Form1.copy_n2 = nameBox22.whole_name();
            Form1.copy_n3 = nameBox23.whole_name();
            Form1.copy_ns = textBox1.Text;

            Form1.check = true;

            nameBox21.empty();
            nameBox22.empty();
            nameBox23.empty();
            textBox1.Text = "";


        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            Form1.copy_n1 = nameBox21.whole_name();
            Form1.copy_n2 = nameBox22.whole_name();
            Form1.copy_n3 = nameBox23.whole_name();
            Form1.copy_ns = textBox1.Text;

            Form1.check = true;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
        }

        void DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.Cancel == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();


            if (textBox1.Focused == true)
            {
                textBox1.Text = Form1.copy_rs;
            }

            if (nameBox21.Focused_())
            {
                nameBox21.fill(Form1.copy_rs);
            }

            if (nameBox22.Focused_())
            {
                nameBox22.fill(Form1.copy_rs);
            }

            if (nameBox23.Focused_())
            {
                nameBox23.fill(Form1.copy_rs);
            }
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();
        }
    }
}
