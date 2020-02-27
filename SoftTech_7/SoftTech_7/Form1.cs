using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SoftTech_7
{
    public partial class Form1 : Form
    {
        string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ";
        string[] bits;
        string tempname;
        string tempadress = "";
        List<string> mylist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();

            string file_path = @"C:\Users\Ivan Vasilev\source\repos\SoftTech_7\SoftTech_7\Names.txt";
            

            using (TextReader reader = File.OpenText(file_path))
            {
                string text = reader.ReadLine();
                bits = text.Split(' ');
            }


            listBox1.Sorted = true;
            for (int i = 0; i < alphabet.Length; i++)
            {
                string title = alphabet.Substring(i, 1);
                TabPage myTabPage = new TabPage(title);
                myTabPage.Name = title;
                tabControl1.TabPages.Add(myTabPage);
                ListView lb = new ListView();
                lb.Size = new System.Drawing.Size(322, 388);
                lb.Columns.Add("Фамилия", 150, HorizontalAlignment.Left);
                lb.Columns.Add("Адрес", 150, HorizontalAlignment.Left);
                lb.GridLines = true;
                for(int j = 0; j < bits.Length; j++)
                {
                    if (bits[j].StartsWith(alphabet.Substring(i,1)))
                    {
                        tempname = bits[j].ToString();
                        string[] row = { tempname, tempadress };
                        var listViewItem = new ListViewItem(row);
                        lb.Items.Add(listViewItem);
                    }
                }
                lb.Sort();
                lb.View = View.Details;
                myTabPage.Controls.Add(lb);
            }
            
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file_path = "";
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_path = fd.FileName;
            }


            using (TextReader reader = File.OpenText(file_path))
            {
                string text = reader.ReadLine();
                bits = text.Split(' ');
            }

            FillTable();
        }

        private void FillTable()
        {
            tabControl1.TabPages.Clear();

            listBox1.Sorted = true;
            for (int i = 0; i < alphabet.Length; i++)
            {
                string title = alphabet.Substring(i, 1);
                TabPage myTabPage = new TabPage(title);
                myTabPage.Name = title;
                tabControl1.TabPages.Add(myTabPage);
                ListView lb = new ListView();
                lb.Size = new System.Drawing.Size(322, 388);
                lb.Columns.Add("Фамилия", 150, HorizontalAlignment.Left);
                lb.Columns.Add("Адрес", 150, HorizontalAlignment.Left);
                lb.GridLines = true;
                for (int j = 0; j < bits.Length; j++)
                {
                    if (bits[j].StartsWith(alphabet.Substring(i, 1)))
                    {
                        tempname = bits[j].ToString();
                        string[] row = { tempname, tempadress };
                        var listViewItem = new ListViewItem(row);
                        lb.Items.Add(listViewItem);
                    }
                }
                lb.Sort();
                lb.View = View.Details;
                myTabPage.Controls.Add(lb);
            }
        }

        private void saveToFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                
                using (StreamWriter sw = new StreamWriter(s))
                {
                    for(int i = 0; i < bits.Length; i++)
                    {
                        sw.Write(bits[i] + " ");
                    }
                }
            }
        }

        private void addNewNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string extra_name = textBox1.Text;
                Array.Resize(ref bits, bits.Length + 1);
                bits[bits.Length - 1] = extra_name;
                FillTable();
            }
            else
            {
                MessageBox.Show("Моля въведете Фамилия в текстувата котия!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                mylist = bits.ToList();

                if (mylist.Contains(textBox1.Text))
                {
                    string temp = textBox1.Text.Substring(0,1);

                    this.tabControl1.SelectTab(temp);

                }
                else
                {
                    MessageBox.Show("Не съществува такава Фамилия!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля въведете Фамилия в текстувата котия!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addToLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mylist = bits.ToList();

            if (textBox1.Text.Length > 0)
            {
                if (mylist.Contains(textBox1.Text))
                {
                    label2.Text = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Не съществува такава Фамилия!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
