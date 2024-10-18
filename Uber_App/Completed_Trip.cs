using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace Uber_App
{
    public partial class Completed_Trip : AutoCloseForm
    {
        public Completed_Trip()
        {
            InitializeComponent();
        }

        private void Completed_Trip_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Trip_Request trip_Request = new Trip_Request();
            trip_Request.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String conn = Globals.connection_string;
            String cmd = @"select * from Compeleted_Trips where dr_id=:id";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd, conn);
            adapter.SelectCommand.Parameters.Add("id", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}


