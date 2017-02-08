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

namespace ISchool.Teacher
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            RegisterLoginStudent FrmShowStu = new RegisterLoginStudent();
            FrmShowStu.ShowDialog();
            FrmShowStu.Dispose();
            FrmShowStu = null;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            RegisterNotifyAboutStudent RegStuNotify = new RegisterNotifyAboutStudent();
            RegStuNotify.ShowDialog();
            RegStuNotify.Dispose();
            RegStuNotify = null;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ChangePassword ChngPass = new ChangePassword();
            ChngPass.ShowDialog();
            ChngPass.Dispose();
            ChngPass = null;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
