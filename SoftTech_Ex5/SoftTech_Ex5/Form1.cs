using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex5
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> txtCollection = new Dictionary<string, string>();
        string comText;
        int cPos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = txtCollection.Count.ToString();

            System.Object[] ItemObject = new System.Object[10];

            ItemObject[0] = "Василев";
            ItemObject[1] = "Иванов";
            ItemObject[2] = "Ангелов";
            ItemObject[3] = "Маринов";
            ItemObject[4] = "Николаева";
            ItemObject[5] = "Найденова";
            ItemObject[6] = "Петров";
            ItemObject[7] = "Михалев";
            ItemObject[8] = "Трендафил";
            ItemObject[9] = "Божинов";

            comboBox1.Items.AddRange(ItemObject);
        }

        private void крайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_KeyPress(object sender,KeyPressEventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comText = "";
            }
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (comboBox1.Text.Length == 15)
            {
                MessageBox.Show("Фамилията е до 15 букви!", "Въвеждане на Фамилиая");
                e.Handled = false;
                return;
            }
            if (e.KeyChar.ToString() != "\r")
            {
                if (e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar >= 'А' && e.KeyChar <= 'Я')
                {
                    comText = comText + e.KeyChar;
                    cPos = comText.Length - 1;
                }
                else
                {
                    e.Handled = true;
                }
                if (comText == "")
                {
                    return;
                }
                int index = comboBox1.FindString(comText);
                if (index < 0)
                {
                    return;
                }
                comboBox1.SelectedIndex = index;
                comboBox1.Text = comboBox1.SelectedItem.ToString();
                comboBox1.SelectionStart = cPos;
                comboBox1.SelectionLength = comboBox1.Text.Length;
                e.Handled = true;
            }
            else
            {
                if (comboBox1.FindString(comText) < 0)
                {
                    comboBox1.Items.Add(comText);
                    comboBox1.Sorted = true;
                }
            }
            textBox2.Text = txtCollection.Count.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "")
            {
                comText = "";
            }
            if (e.KeyChar == '\b') { return; }
            if (textBox1.Text.Length == 10)
            {
                MessageBox.Show("ЕГН е 10 цифри!", "Въвеждане на ЕГН");
                e.Handled = false;
                return;
            }
            if (e.KeyChar.ToString() != "\r")
            {
                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                {
                    comText = comText + e.KeyChar;
                    cPos = comText.Length - 1;
                }
                else
                {
                    e.Handled = true;
                }
                if (comText == "") { return; }
                int index = comboBox1.FindString(comText);
                if (index < 0) { return; }
                comboBox1.SelectedIndex = index;
                comboBox1.Text = comboBox1.SelectedItem.ToString();
                comboBox1.SelectionStart = cPos;
                comboBox1.SelectionLength = comboBox1.Text.Length;
                e.Handled = true;
            }
            else
            {
                if (comboBox1.FindString(comText) < 0)
                {
                    comboBox1.Items.Add(comText);
                    comboBox1.Sorted = true;
                }
            }
        }

        private void актуализирайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Въведете ЕГН", "Актуализация"); return; }
            if (textBox1.Text.Length < 10) { MessageBox.Show("Въведеното ЕГН е непълно!", "Актуализация");return; }
            int i = Array.IndexOf(txtCollection.Keys.ToArray(), textBox1.Text);
            if (i >= 0)
            {
                listView1.Items[i].Remove();
                txtCollection.Remove(textBox1.Text);

                string newName = comboBox1.Text;
                string newEGN = textBox1.Text;
                string[] row = { newEGN, newName };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                txtCollection.Add(newEGN, newName);

                comboBox1.Text = "";
                textBox1.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Няма записани Фамилии!" + Environment.NewLine, "Актуализация");
                return;
            }
            textBox2.Text = txtCollection.Count.ToString();
        }

        private void добавиИмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length <= 0)
            {
                MessageBox.Show("Моля въведете фамилия!");
            }
            else if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Моля въведете ЕГН!");
            }
            else
            {
                string EGN;
                string Name;

                EGN = textBox1.Text;
                Name = comboBox1.Text;

                if (txtCollection.ContainsKey(EGN))
                {
                    MessageBox.Show("Следното ЕГН вече е въведено!");
                }
                else if (EGN.Length == 10)
                {
                    txtCollection.Add(EGN, Name);

                    string[] row = { textBox1.Text, comboBox1.Text };
                    var listViewItem = new ListViewItem(row);

                    listView1.Items.Add(listViewItem);

                    textBox2.Text = txtCollection.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Въведеното ЕГН е непълно!");
                }
            }
        }

        private void намериПоЕГНToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (txtCollection.ContainsKey(textBox1.Text))
            {
                comboBox1.Text = txtCollection[textBox1.Text];
            }
            else
            {
                MessageBox.Show("Не е намеро даденото ЕГН!");
            }
            textBox2.Text = txtCollection.Count.ToString();
        }

        private void отсраниПоЕГНToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCollection.ContainsKey(textBox1.Text))
            {
                int i = Array.IndexOf(txtCollection.Keys.ToArray(), textBox1.Text);
                if (i >= 0)
                {
                    listView1.Items[i].Remove();
                    txtCollection.Remove(textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("Записаното ЕГН не съществува");
            }
            textBox2.Text = txtCollection.Count.ToString();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.Text.Length <= 0)
            {
                MessageBox.Show("Фамилията не е въведена!");
            }
        }
    }
}
