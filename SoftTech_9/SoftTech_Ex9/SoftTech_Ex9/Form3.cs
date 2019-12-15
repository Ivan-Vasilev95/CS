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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            OpenFileDialog fd = new OpenFileDialog();

            string file_path = "";

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_path = fd.FileName;
            }

            if (file_path.Length > 1)
            {
                using (TextReader reader = File.OpenText(file_path))
                {
                    string text = reader.ReadLine();
                    richTextBox1.Text = text;

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
                    sw.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();

            richTextBox1.SelectionFont = fontDialog1.Font;
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            richTextBox1.Text = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            if (Form1.check == true)
            {
                richTextBox1.Text = Form1.copy_n1 + " " + Form1.copy_n2 + " " + Form1.copy_n3 + " " + Form1.copy_ns;
            }
            else
            {
                richTextBox1.Text = Form1.copy_rs;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            Form1.copy_rs = richTextBox1.Text;
            Form1.check = false;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();

            Form1.copy_rs = richTextBox1.Text;
            richTextBox1.Text = "";
            Form1.check = false;
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

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            fileToolStripMenuItem.DropDown.Close();

            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            editToolStripMenuItem.DropDown.Close();
        }
    }
}
