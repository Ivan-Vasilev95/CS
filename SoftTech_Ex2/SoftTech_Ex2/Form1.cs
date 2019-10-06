using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex2
{
    public partial class Form1 : Form
    {
        public string[,] MainText = new string[,] { { "Файл", "Редактор", "Покажи", "Помощ","Край" }, { "File", "Edit", "View", "Help","End" } };
        public string[,] FileItems = new string[,] { { "Нов", "Отвори", "Затвори", " ", "Край" }, { "New", "Open", "Close", " ", "Exit" } };
        public string[,] EditItems = new string[,] { { "Отрежи", "Копирай", "Постави","Изтрий" }, { "Cut", "Copy", "Paste","Delete" } };
        public Form1()
        {
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
           
    }

        private void Button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (menuStrip1.Items.Count - 1)); i++)
            {
                menuStrip1.Items[i].Text = MainText[0, i];
            }
            for (i = 0; (i <= (fileToolStripMenuItem.DropDownItems.Count - 1)); i++)
            {
                fileToolStripMenuItem.DropDownItems[i].Text = FileItems[0, i];
            }
            for (i = 0; (i <= (editToolStripMenuItem.DropDownItems.Count - 1)); i++)
            {
                editToolStripMenuItem.DropDownItems[i].Text = EditItems[0, i];
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if ((this.menuStrip1.Visible == true))
            {
                if (viewToolStripMenuItem.DropDownItems.Count==0)
                {
                    ToolStripMenuItem CodeToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem FormToolStripMenuItem = new ToolStripMenuItem();
                    CodeToolStripMenuItem.Text = "Code";
                    FormToolStripMenuItem.Text = "Form";
                    viewToolStripMenuItem.DropDownItems.Add(CodeToolStripMenuItem);
                    viewToolStripMenuItem.DropDownItems.Add(FormToolStripMenuItem);
                    CodeToolStripMenuItem.Click += new System.EventHandler(this.CodeToolStripMenuItem_Click);
                    FormToolStripMenuItem.Click += new System.EventHandler(this.FormToolStripItem_Click);
                }
                else
                {

                }

            }
            else
            {

            }
        } 
        private void CodeToolStripMenuItem_Click(object sender,System.EventArgs e)
        {
            MessageBox.Show("Позиция Code", "Нови позиции");
        }
        private void FormToolStripItem_Click(object sender,System.EventArgs e)
        {
            MessageBox.Show("Позиция Form", "Нови позиции");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (menuStrip1.Items.Count - 1)); i++)
            {
                menuStrip1.Items[i].Text = MainText[1, i];
            }
            for (i = 0; (i <= (fileToolStripMenuItem.DropDownItems.Count - 1)); i++)
            {
                fileToolStripMenuItem.DropDownItems[i].Text = FileItems[1, i];
            }
            for (i = 0; (i <= (editToolStripMenuItem.DropDownItems.Count - 1)); i++)
            {
                editToolStripMenuItem.DropDownItems[i].Text = EditItems[1, i];
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if ((this.menuStrip1.Visible == true))
            {
                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
            }
            else
            {
                menuStrip2.Visible = false;
                menuStrip1.Visible = true;
            }
        }

        private void EndToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeToolStripMenuItem1.Checked = false;
            openToolStripMenuItem.Checked = false;

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.Checked = false;
            closeToolStripMenuItem1.Checked = false;
        }

        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.Checked = false;
            openToolStripMenuItem.Checked = false;
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.Checked = false;
            pasteToolStripMenuItem.Checked = false;
            deleteToolStripMenuItem.Checked = false;

        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.Checked = false;
            pasteToolStripMenuItem.Checked = false;
            deleteToolStripMenuItem.Checked = false;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.Checked = false;
            copyToolStripMenuItem.Checked = false;
            deleteToolStripMenuItem.Checked = false;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.Checked = false;
            copyToolStripMenuItem.Checked = false;
            pasteToolStripMenuItem.Checked = false;
        }

        private void КрайToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void КрайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
