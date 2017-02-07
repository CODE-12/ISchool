using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

//saleh 
namespace ISchool.Teacher
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true ;
            panel2.Visible = false; panel3.Visible = false; panel4.Visible = false;
            

        }

        private void linkLabel1_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false ;
            panel2.Visible = true ; panel3.Visible = false; panel4.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false ;
            panel2.Visible = false; panel3.Visible = true ; panel4.Visible = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false ;
            panel2.Visible = false; panel3.Visible = false; panel4.Visible = true ;
        }
    }
}
