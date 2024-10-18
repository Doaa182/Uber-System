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
    public partial class Driver_Home_Page : AutoCloseForm
    {
        string ordb = Globals.connection_string;
        OracleConnection conn;
        public Driver_Home_Page()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Trip_Request trip_request = new Trip_Request();
            trip_request.Show();
            this.Hide();

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormErrorHandler.TryTo(delegate () {

                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"update Driver set d_phone_no=:phone, d_e_wallet_no=:wallet,d_email=:email
                               ,d_password=:password,d_name=:name,d_last_canceled_trip=:lasttrip
                              ,d_fine=:fine,d_trip_count=:tripcount,d_rating=:rating,d_isDeleted=:deleted
                               ,d_car_type=:cartype,d_car_model=:carmodel,d_plate_no=:plateno
                                ,d_avail_status=:avail where d_id=:id";

                cmd.Parameters.Add("phone", textBox2.Text);
                cmd.Parameters.Add("wallet", textBox3.Text);
                cmd.Parameters.Add("email", textBox4.Text);
                cmd.Parameters.Add("password", textBox5.Text);
                cmd.Parameters.Add("name", textBox6.Text);
                cmd.Parameters.Add("lasttrip", textBox7.Text);
                cmd.Parameters.Add("fine", textBox8.Text);
                cmd.Parameters.Add("tripcount", textBox9.Text);
                cmd.Parameters.Add("rating", textBox10.Text);
                cmd.Parameters.Add("deleted", textBox11.Text);
                cmd.Parameters.Add("cartype", textBox12.Text);
                cmd.Parameters.Add("carmodel", textBox13.Text);
                cmd.Parameters.Add("plateno", textBox14.Text);
                cmd.Parameters.Add("avail", textBox15.Text);
                cmd.Parameters.Add("id", Globals.loggedInUserId);


                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("Actor modified");
                }

            });
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Welcome_Form welcome_form = new Welcome_Form();
            welcome_form.Show();
            this.Hide();
        }
    }
}



