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
    public partial class SecondaryWizard : MetroForm
    {
        public SecondaryWizard()
        {
            InitializeComponent();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("....الرجاء التواصل مع الدعم الفني وشكرا", "الدعم الفني", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
    }
}
