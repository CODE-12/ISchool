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
using ISchool.ExcelAlgorithm;

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

        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            if (string.IsNullOrWhiteSpace(opf.FileName)) 
                return;
            IExcelAlgo dataList = new StudentDataList(opf.FileName);
            dataGridView1.DataSource = await dataList.Load();
        }
    }
}
