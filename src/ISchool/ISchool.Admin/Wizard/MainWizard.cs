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

namespace ISchool.Admin.Wizard
{
    public partial class MainWizard : MetroForm
    {
        public MainWizard()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (this.metroCheckBox1.Checked)
            {
                new SecondaryWizard().ShowDialog();
                this.Close();
            }
        }
    }
}
