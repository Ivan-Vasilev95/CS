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

namespace SA_Project
{
    public partial class _3X3 : Form
    {
        List<TextBox> myTextboxList = new List<TextBox>();
        List<TextBox> cap_hor = new List<TextBox>();
        List<TextBox> cap_ver = new List<TextBox>();
        List<decimal> init_value = new List<decimal>();
        List<decimal> cap_hor_value = new List<decimal>();
        List<decimal> cap_ver_value = new List<decimal>();
        decimal Z1 = 0;
        public _3X3()
        {
            InitializeComponent();
        }

        private void _3X3_Load(object sender, EventArgs e)
        {
            myTextboxList.Add(textBox1);
            myTextboxList.Add(textBox3);
            myTextboxList.Add(textBox4);
            myTextboxList.Add(textBox6);
            myTextboxList.Add(textBox7);
            myTextboxList.Add(textBox8);
            myTextboxList.Add(textBox10);
            myTextboxList.Add(textBox11);
            myTextboxList.Add(textBox12);


            cap_hor.Add(textBox14);
            cap_hor.Add(textBox15);
            cap_hor.Add(textBox2);


            cap_ver.Add(textBox5);
            cap_ver.Add(textBox9);
            cap_ver.Add(textBox13);
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
        private void Key_Validation(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {

            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Въвеждайте само чифри!", "Системен Анализ", buttons);
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hor_pos = 0;
            int ver_pos = 0;

            if (Z1 != 0)
            {
                MessageBox.Show("Първо решение на задачата е получено!");
            }
            else
            {
                if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0 && textBox7.Text.Length > 0
                    && textBox8.Text.Length > 0 && textBox9.Text.Length > 0 && textBox10.Text.Length > 0 && textBox11.Text.Length > 0
                    && textBox2.Text.Length > 0 && textBox12.Text.Length > 0 && textBox13.Text.Length > 0 && textBox14.Text.Length > 0 && textBox15.Text.Length > 0)
                {

                    for (int i = 0; i < myTextboxList.Count; i++)
                    {
                        init_value.Add(System.Convert.ToDecimal(myTextboxList[i].Text));
                    }
                    for (int i = 0; i < cap_hor.Count; i++)
                    {
                        cap_hor_value.Add(System.Convert.ToDecimal(cap_hor[i].Text));
                    }
                    for (int i = 0; i < cap_ver.Count; i++)
                    {
                        cap_ver_value.Add(System.Convert.ToDecimal(cap_ver[i].Text));
                    }

                    for (int i = 0; i < myTextboxList.Count; i++)
                    {
                        myTextboxList[i].Text = "0";
                    }
                    for (int i = 0; i < cap_hor.Count; i++)
                    {
                        cap_hor[i].Text = "0";
                    }
                    for (int i = 0; i < cap_ver.Count; i++)
                    {
                        cap_ver[i].Text = "0";
                    }

                    for (int i = 0; i < myTextboxList.Count; i++)
                    {
                        if (cap_hor_value[hor_pos] > 0 && cap_ver_value[ver_pos] > 0)
                        {
                            if (cap_ver_value[ver_pos] > cap_hor_value[hor_pos])
                            {
                                myTextboxList[i].Text = cap_hor_value[hor_pos].ToString();
                                cap_ver_value[ver_pos] -= cap_hor_value[hor_pos];
                                cap_hor_value[hor_pos] = 0;
                            }
                            else if (cap_ver_value[ver_pos] < cap_hor_value[hor_pos])
                            {
                                myTextboxList[i].Text = cap_ver_value[ver_pos].ToString();
                                cap_hor_value[hor_pos] -= cap_ver_value[ver_pos];
                                cap_ver_value[ver_pos] = 0;
                            }
                            else if (cap_ver_value[ver_pos] == cap_hor_value[hor_pos])
                            {
                                myTextboxList[i].Text = cap_ver_value[ver_pos].ToString();
                                cap_hor_value[hor_pos] -= cap_ver_value[ver_pos];
                                cap_ver_value[ver_pos] = 0;
                            }

                            hor_pos++;
                            if (hor_pos == 3)
                            {
                                hor_pos = 0;
                                ver_pos++;
                            }
                        }
                        else
                        {
                            hor_pos++;
                            if (hor_pos == 3)
                            {
                                hor_pos = 0;
                                ver_pos++;
                            }
                        }
                    }

                    for (int i = 0; i < myTextboxList.Count; i++)
                    {
                        Z1 += init_value[i] * (System.Convert.ToDecimal(myTextboxList[i].Text));
                    }

                    Z1_Box.Text = Z1.ToString();
                }
                else
                {
                    MessageBox.Show("Please fill all the boxes with values");
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file_path="";
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_path = fd.FileName;
            }


            using (TextReader reader = File.OpenText(file_path))
            {
                string text = reader.ReadLine();
                string[] bits = text.Split(' ');

                for (int i = 0; i < myTextboxList.Count; i++)
                {
                    myTextboxList[i].Text = bits[i];
                }
                int j = 0;
                for (int i = myTextboxList.Count; i < myTextboxList.Count + cap_ver.Count; i++)
                {
                    cap_ver[j].Text = bits[i];
                    j++;
                }
                j = 0;

                for (int i = myTextboxList.Count + cap_ver.Count; i < myTextboxList.Count + cap_ver.Count + cap_hor.Count; i++)
                {
                    cap_hor[j].Text = bits[i];
                    j++;
                }

            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void writeToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    for(int i = 0; i < myTextboxList.Count; i++)
                    {
                        sw.Write(myTextboxList[i].Text + " ");
                    }
                    for(int i = 0; i < cap_ver.Count; i++)
                    {
                        sw.Write(cap_ver[i].Text + " ");
                    }
                    for (int i = 0; i < cap_hor.Count; i++)
                    {
                        sw.Write(cap_hor[i].Text + " ");
                    }
                    sw.Write("" + Environment.NewLine);
                    sw.Write("Z1 = " + Z1_Box.Text);
                }
            }
        }
    }
}
