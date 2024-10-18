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
    public partial class Form1 : AutoCloseForm
    {
        CrystalReport2 CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
        }

        private void generate_report_btn_Click(object sender, EventArgs e)
        {
            int passenger_id = int.Parse(passenger_id_entry.Text);
            CR.SetParameterValue(0, passenger_id);
            crystalReportViewer1.ReportSource = CR;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
