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
    public partial class _3X2 : Form
    {
        List<TextBox> myTextboxList = new List<TextBox>();
        List<TextBox> cap_hor = new List<TextBox>();
        List<TextBox> cap_ver = new List<TextBox>();
        List<TextBox> extraBoxes = new List<TextBox>();
        List<decimal> init_value = new List<decimal>();
        List<decimal> cap_hor_value = new List<decimal>();
        List<decimal> cap_ver_value = new List<decimal>();
        decimal hor_check = 0;
        decimal ver_check = 0;
        decimal Z1 = 0;
        string file_path="";
        public _3X2()
        {
            InitializeComponent();
        }

        private void _3X2_Load(object sender, EventArgs e)
        {

            myTextboxList.Add(textBox1);
            myTextboxList.Add(textBox3);
            myTextboxList.Add(textBox5);
            myTextboxList.Add(textBox6);
            myTextboxList.Add(textBox8);
            myTextboxList.Add(textBox9);


            cap_hor.Add(textBox11);
            cap_hor.Add(textBox12);

            cap_ver.Add(textBox4);
            cap_ver.Add(textBox7);
            cap_ver.Add(textBox10);
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
            if (Z1 != 0)
            {
                MessageBox.Show("Вече имате начално решение");
            }
            else
            {
                int hor_pos = 0;
                int ver_pos = 0;

                if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0
                   && textBox5.Text.Length > 0 && textBox6.Text.Length > 0 && textBox7.Text.Length > 0
                   && textBox8.Text.Length > 0 && textBox9.Text.Length > 0 && textBox10.Text.Length > 0
                   && textBox11.Text.Length > 0 && textBox12.Text.Length > 0)
                {

                    if (hor_check != ver_check)
                    {
                        MessageBox.Show("Моля първо балансирайте таблицата");
                    }
                    else
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

                        Z1box.Text = Z1.ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Моля популнете всички котии");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hor_check == ver_check)
            {
                MessageBox.Show("Таблицата е балансирана");
            }
            else
            {
                tableLayoutPanel1.ColumnCount = (tableLayoutPanel1.ColumnCount + 1);
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                label4.Text = "Склад 3";

                Label namelabel = new Label();
                namelabel.Text = "Капацитет";
                this.Controls.Add(namelabel);

                TextBox tb1 = new TextBox();
                TextBox tb2 = new TextBox();
                TextBox tb3 = new TextBox();
                TextBox hor_3 = new TextBox();

                cap_hor.Add(hor_3);

                cap_ver.Clear();

                cap_ver.Add(tb1);
                cap_ver.Add(tb2);
                cap_ver.Add(tb3);

                extraBoxes.Add(textBox4);
                extraBoxes.Add(textBox7);
                extraBoxes.Add(textBox10);

                for (int i = 0; i < extraBoxes.Count; i++)
                {
                    extraBoxes[i].Text = "0";
                }




                tableLayoutPanel1.Controls.Add(namelabel, 5, (tableLayoutPanel1.RowCount - 5));
                namelabel.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                namelabel.TextAlign = ContentAlignment.MiddleCenter;

                tableLayoutPanel1.Controls.Add(tb1, 5, (tableLayoutPanel1.RowCount - 4));
                tb1.Anchor = ( AnchorStyles.Left | AnchorStyles.Right);
                tb1.TextAlign = HorizontalAlignment.Center;

                tableLayoutPanel1.Controls.Add(tb2, 5, (tableLayoutPanel1.RowCount - 3));
                tb2.Anchor = ( AnchorStyles.Left | AnchorStyles.Right);
                tb2.TextAlign = HorizontalAlignment.Center;

                tableLayoutPanel1.Controls.Add(tb3, 5, (tableLayoutPanel1.RowCount - 2));
                tb3.Anchor = ( AnchorStyles.Left | AnchorStyles.Right);
                tb3.TextAlign = HorizontalAlignment.Center;

                tableLayoutPanel1.Controls.Add(hor_3, 3, (tableLayoutPanel1.RowCount - 1));
                hor_3.Anchor = ( AnchorStyles.Left | AnchorStyles.Right);
                hor_3.TextAlign = HorizontalAlignment.Center;

                int last_item = cap_hor.Count - 1;
                if (hor_check < ver_check)
                {
                    cap_hor[last_item].Text = (ver_check - hor_check).ToString();
                }
                else
                {
                    cap_hor[last_item].Text = (hor_check - ver_check).ToString();
                }


                using (TextReader reader = File.OpenText(file_path))
                {
                    string text = reader.ReadLine();
                    string[] bits = text.Split(' ');

                    int j = 0;
                    for (int i = myTextboxList.Count; i < myTextboxList.Count + cap_ver.Count; i++)
                    {
                        cap_ver[j].Text = bits[i];
                        j++;
                    }
                }
                hor_check = 0;
                ver_check = 0;
                for (int i = 0; i < cap_hor.Count; i++)
                {
                    hor_check += System.Convert.ToDecimal(cap_hor[i].Text);
                }

                for (int i = 0; i < cap_ver.Count; i++)
                {
                    ver_check += System.Convert.ToDecimal(cap_ver[i].Text);
                }

                myTextboxList.Clear();
                myTextboxList.Add(textBox1);
                myTextboxList.Add(textBox3);
                myTextboxList.Add(textBox4);
                myTextboxList.Add(textBox5);
                myTextboxList.Add(textBox6);
                myTextboxList.Add(textBox7);
                myTextboxList.Add(textBox8);
                myTextboxList.Add(textBox9);
                myTextboxList.Add(textBox10);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            for (int i = 0; i < cap_hor.Count; i++)
            {
                hor_check += System.Convert.ToDecimal(cap_hor[i].Text);
            }

            for (int i = 0; i < cap_ver.Count; i++)
            {
                ver_check += System.Convert.ToDecimal(cap_ver[i].Text);
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
                    for (int i = 0; i < myTextboxList.Count; i++)
                    {
                        sw.Write(myTextboxList[i].Text + " ");
                    }

                   
                    for (int i = 0; i < cap_ver.Count; i++)
                    {
                        sw.Write(cap_ver[i].Text + " ");
                    }
                    for (int i = 0; i < cap_hor.Count; i++)
                    {
                        sw.Write(cap_hor[i].Text + " ");
                    }
                    sw.Write("" + Environment.NewLine);
                    sw.Write("Z1 = " + Z1box.Text);
                }
            }
        }
    }
}
