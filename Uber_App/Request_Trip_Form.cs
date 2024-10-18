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
    public partial class Request_Trip_Form : AutoCloseForm
    {
        string connection_string = Globals.connection_string;
        OracleConnection database_connection;
        string ride_type;
        public Request_Trip_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void request_ride_btn_Click(object sender, EventArgs e)
        {
            FormErrorHandler.TryTo(delegate () {

                database_connection = new OracleConnection(connection_string);
                database_connection.Open();
                // INSERT INTO Passenger (p_phone_no, p_e_wallet_no, p_email, p_password, p_name) VALUES(:p_phone_no, :p_e_wallet_no, :p_email, :p_password, :p_name)
                string request_trip_query = "INSERT INTO Trip_Requests (ps_id, estimated_cost, start_location, destination, ride_type, payment_method, promocode, trip_start_time, estimated_end_time) VALUES(:ps_id, :estimated_cost, :pickup_location, :destination, :ride_type, :payment_method,  :promo_code, :trip_start_time, :estimated_end_time)";
                OracleCommand request_trip_command = new OracleCommand(request_trip_query, database_connection);
                request_trip_command.Parameters.Add(":ps_id", Globals.loggedInUserId);
                request_trip_command.Parameters.Add(":estimated_cost", OracleDbType.Int32).Value = 50;
                request_trip_command.Parameters.Add(":start_location", OracleDbType.Varchar2).Value = pickup_location_entry.Text;
                request_trip_command.Parameters.Add(":destination", OracleDbType.Varchar2).Value = destination_entry.Text;
                request_trip_command.Parameters.Add(":ride_type", OracleDbType.Varchar2).Value = ride_type;
                request_trip_command.Parameters.Add(":payment_method", OracleDbType.Varchar2).Value = payment_type_cmbbox.SelectedItem;
                request_trip_command.Parameters.Add(":promocode", OracleDbType.Varchar2).Value = promo_code_entry.Text;
                request_trip_command.Parameters.Add(":trip_start_time", DateTime.Now.ToString());
                request_trip_command.Parameters.Add(":estimated_end_time", DateTime.Now.AddHours(1).ToString());
                request_trip_command.ExecuteNonQuery();
                database_connection.Close();
                MessageBox.Show("Trip Placed Succesfully");

            });
            
        }

        private void uber_x_rd_btn_CheckedChanged(object sender, EventArgs e)
        {
            ride_type = "UberX";
        }

        private void Request_Trip_Form_Load(object sender, EventArgs e)
        {

        }

        private void uber_select_rd_btn_CheckedChanged(object sender, EventArgs e)
        {
            ride_type = "UberSelect";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var passHomePage = new Passenger_Home_Page();
            passHomePage.Show();
            this.Hide();
        }
    }
}
