using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftTech_Ex8
{
    public partial class Form1 : Form
    {
        public static string url="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            LinkLabel.Link link2 = new LinkLabel.Link();
            LinkLabel.Link link3 = new LinkLabel.Link();
            LinkLabel.Link link4 = new LinkLabel.Link();
            LinkLabel.Link link5 = new LinkLabel.Link();
            LinkLabel.Link link6 = new LinkLabel.Link();

            link.LinkData = "https://www.youtube.com";
            link2.LinkData = "https://www.amazon.com";
            link3.LinkData = "https://www.google.com";
            link4.LinkData = "https://www.facebook.com";
            link5.LinkData = "https://9gag.com";
            link6.LinkData = "http://cs.tu-varna.bg";

            linkLabel1.Links.Add(link);
            linkLabel2.Links.Add(link2);
            linkLabel3.Links.Add(link3);
            linkLabel4.Links.Add(link4);
            linkLabel5.Links.Add(link5);
            linkLabel6.Links.Add(link6);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            url = "https://www.youtube.com";
            Form2 frm2 = new Form2();
            frm2.Text = "YouTube";
            frm2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            url = "https://www.amazon.com";
            Form2 frm2 = new Form2();
            frm2.Text = "Amazon";
            frm2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            url = "https://www.google.com";
            Form2 frm2 = new Form2();
            frm2.Text = "Google";
            frm2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            url = "https://www.facebook.com";
            Form2 frm2 = new Form2();
            frm2.Text = "Facebook";
            frm2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            url = "https://9gag.com";
            Form2 frm2 = new Form2();
            frm2.Text = "9GAG";
            frm2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            url = "http://cs.tu-varna.bg";
            Form2 frm2 = new Form2();
            frm2.Text = "CodeCademy";
            frm2.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
