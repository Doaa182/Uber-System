using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Uber_App
{
    public partial class Form1report : AutoCloseForm
    {
        CrystalReport4 CR;
        public Form1report()
        {
            InitializeComponent();
        }

        private void generate_report_btn_Click(object sender, EventArgs e)
        {
            string car_type = car_type_entry.Text;
            CR.SetParameterValue(0,car_type);
            crystalReportViewer1.ReportSource = CR;
        }

        private void Form1report_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport4();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void car_type_entry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
