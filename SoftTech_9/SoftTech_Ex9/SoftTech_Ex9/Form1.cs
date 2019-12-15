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
    public partial class Form1 : Form
    {
        Form3 Old = new Form3();
        Form3 Ne = new Form3();
        Form4 frm4 = new Form4();
        string file_path = "";
        public static string name1;
        public static string name2;
        public static string name3;
        public static string name_shor;

        public static string copy_n1;
        public static string copy_n2;
        public static string copy_n3;
        public static string copy_ns;
        public static string copy_rs;
        public static bool check = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void крайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void крайToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void новToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            Form2 frm = new Form2();
            frm.Show();
        }

        private void новТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            frm4.Close();

            Ne.MdiParent = this;
            Ne.Text = "НОВ ТЕКСТ";
            if (Ne.IsDisposed)
            {
                Ne = new Form3();
                Ne.MdiParent = this;
                Ne.Text = "НОВ ТЕКСТ";
                Ne.Show();
            }
            else
            {
                Ne.Show();
            }

            if (Old.Visible == false)
            {
                Ne.Dock = DockStyle.Fill;
                Ne.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Ne.WindowState = FormWindowState.Normal;
                Old.WindowState = FormWindowState.Normal;
                Ne.Dock = DockStyle.Left;
                Old.Dock = DockStyle.Right;
                this.LayoutMdi(MdiLayout.TileVertical);
                вертикалноToolStripMenuItem.Checked = true;
            }
        }

        private void старТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            frm4.Close();

            Old.MdiParent = this;
            Old.Text = "СТАР ТЕКСТ";
            if (Old.IsDisposed)
            {
                Old = new Form3();
                Old.MdiParent = this;
                Old.Text = "СТАР ТЕКСТ";
                Old.Show();
            }
            else
            {
                Old.Show();
            }
            

            if (Ne.Visible == false)
            {
                Old.Dock = DockStyle.Fill;
                Old.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Ne.WindowState = FormWindowState.Normal;
                Old.WindowState = FormWindowState.Normal;
                Ne.Dock = DockStyle.Left;
                Old.Dock = DockStyle.Right;
                this.LayoutMdi(MdiLayout.TileVertical);
                вертикалноToolStripMenuItem.Checked = true;
            }
        }

        private void вертикалноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            if (Ne.Visible == true && Old.Visible == true)
           {
                Old.Dock = DockStyle.Left;
                Ne.Dock = DockStyle.Right;
                this.LayoutMdi(MdiLayout.TileVertical);
                хоризонталноToolStripMenuItem.Checked = false;
                вертикалноToolStripMenuItem.Checked = true;
                каскадноToolStripMenuItem.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;

            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void хоризонталноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            if (Ne.Visible == true && Old.Visible == true)
            {
                Ne.Dock = DockStyle.Top;
                Old.Dock = DockStyle.Bottom;
                this.LayoutMdi(MdiLayout.TileHorizontal);
                хоризонталноToolStripMenuItem.Checked = true;
                вертикалноToolStripMenuItem.Checked = false;
                каскадноToolStripMenuItem.Checked = false;
            }
        }

        private void каскадноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            if (Ne.Visible == true && Old.Visible == true)
            {
                this.LayoutMdi(MdiLayout.Cascade);
                хоризонталноToolStripMenuItem.Checked = false;
                вертикалноToolStripMenuItem.Checked = false;
                каскадноToolStripMenuItem.Checked = true;
            }
        }

        private void намериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            Form2 frm = new Form2();
            OpenFileDialog fd = new OpenFileDialog();

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

                    name1 = bits[0];
                    name2 = bits[1];
                    name3 = bits[2];
                    name_shor = bits[3];
                }

                frm.Load_from_File();
                frm.Show();
            }

        }

        private void заПроизводителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            авторToolStripMenuItem.DropDown.Close();

            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            текстToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();

            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            подредиToolStripMenuItem.DropDown.Close();


            Ne.Close();
            Old.Close();

            if (frm4.IsDisposed)
            {
                frm4 = new Form4();
                frm4.MdiParent = this;
                frm4.Dock = DockStyle.Fill;
                frm4.Show();
            }
            else
            {
                frm4.MdiParent = this;
                frm4.Dock = DockStyle.Fill;
                frm4.Show();
            }


            toolStripStatusLabel1.Text = "Информация за производителя на програмата";

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Old.Visible == true && Ne.Visible == true)
            {
                Old.WindowState = FormWindowState.Normal;
                Ne.WindowState = FormWindowState.Normal;
            }   

            if (хоризонталноToolStripMenuItem.Checked == true)
            {
                Ne.Dock = DockStyle.Top;
                Old.Dock = DockStyle.Bottom;
                this.LayoutMdi(MdiLayout.TileHorizontal);
                return;
            }

            if(вертикалноToolStripMenuItem.Checked == true)
            {
                Ne.Dock = DockStyle.Left;
                Old.Dock = DockStyle.Right;
                this.LayoutMdi(MdiLayout.TileVertical);
                return;
            }

            if(каскадноToolStripMenuItem.Checked == true)
            {
                this.LayoutMdi(MdiLayout.Cascade);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            авторToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            toolStripStatusLabel1.Text = "Изберете нов автор или намери автор";
        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            toolStripStatusLabel1.Text = "Изберете нов и/или стар текст";
        }

        private void подредиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
            toolStripStatusLabel1.Text = "Изберете начин на подреждане на Нов текст и Стар текст";
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
    }
}
