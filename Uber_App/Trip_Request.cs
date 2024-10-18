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
    public partial class Trip_Request : AutoCloseForm
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string target_table;
        OracleConnection conn;
        string ordb = Globals.connection_string;

        public Trip_Request()
        {
            InitializeComponent();
        }

        private void Trip_Request_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TRIP_REQUESTS' table. You can move, or remove it, as needed.
            //this.tRIP_REQUESTSTableAdapter.Fill(this.dataSet1.TRIP_REQUESTS);
            // TODO: This line of code loads data into the 'dataSet1.TRIP_REQUESTS' table. You can move, or remove it, as needed.
          
            conn = new OracleConnection(ordb);
            conn.Open();

            string show_driver_accepted_trip_requests = "SELECT * FROM Accepted_Trip_Requests WHERE  dr_id  = :dr_id";


            OracleCommand show_passenger_accepted_trip_requests_cmd = new OracleCommand(show_driver_accepted_trip_requests, conn);


            show_passenger_accepted_trip_requests_cmd.Parameters.Add(":dr_id", Globals.loggedInUserId);


            OracleDataReader accepted_requests_data_reader = show_passenger_accepted_trip_requests_cmd.ExecuteReader();


            if (accepted_requests_data_reader.Read())
            {
                target_table = "Accepted_Trip_Requests";

                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;

            }
            else
            {
                target_table = "";
                button5.Enabled = false;
            }
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String constr = Globals.connection_string;
            String cmdstr = "select * from TRIP_REQUESTS";

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Completed_Trip trip = new Completed_Trip();
            trip.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


            string get_trip_request_query = "SELECT * FROM Accepted_Trip_Requests WHERE dr_id = :dr_id";
            string add_canceled_request_query = "INSERT INTO Canceled_Requests (ps_id, dr_id, estimated_cost, start_location, destination, ride_type, trip_start_time, estimated_end_time, payment_method, cancelation_time, promocode) VALUES (:ps_id, :dr_id, :estimated_cost, :start_location, :destination, :ride_type, :trip_start_time, :estimated_end_time, :payment_method, :cancelation_time, :promocode)";
            string delete_request_query = "DELETE FROM Accepted_Trip_Requests WHERE dr_id = :dr_id";

            OracleCommand get_trip_cmd = new OracleCommand(get_trip_request_query, conn);
            OracleCommand insert_request_cmd = new OracleCommand(add_canceled_request_query, conn);
            OracleCommand delete_request_cmd = new OracleCommand(delete_request_query, conn);


            delete_request_cmd.Parameters.Add(":dr_id", Globals.loggedInUserId);
            get_trip_cmd.Parameters.Add(":dr_id", Globals.loggedInUserId);


            OracleDataReader get_req_reader = get_trip_cmd.ExecuteReader();

            if (get_req_reader.Read())
            {

                insert_request_cmd.Parameters.Add(":ps_id", get_req_reader["ps_id"]);
                insert_request_cmd.Parameters.Add(":dr_id", get_req_reader["dr_id"]);
                insert_request_cmd.Parameters.Add(":estimated_cost", get_req_reader["estimated_cost"]);
                insert_request_cmd.Parameters.Add(":start_location", get_req_reader["start_location"].ToString());
                insert_request_cmd.Parameters.Add(":destination", get_req_reader["destination"].ToString());
                insert_request_cmd.Parameters.Add(":ride_type", get_req_reader["ride_type"].ToString());
                insert_request_cmd.Parameters.Add(":trip_start_time", DateTime.Now.ToString("dd-MMM-yy"));
                insert_request_cmd.Parameters.Add(":estimated_end_time", DateTime.Now.ToString("dd-MMM-yy"));
                insert_request_cmd.Parameters.Add(":payment_method", get_req_reader["payment_method"].ToString());
                insert_request_cmd.Parameters.Add(":cancelation_time", DateTime.Now.ToString("dd-MMM-yy"));
                insert_request_cmd.Parameters.Add(":promocode", get_req_reader["promocode"].ToString());
                insert_request_cmd.ExecuteNonQuery();
                delete_request_cmd.ExecuteNonQuery();
            }
            button1.Enabled = true;
            button5.Enabled = false;
            button2.Enabled = true;
            button4.Enabled = true;
            MessageBox.Show("Trip Canceled");
            conn.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Driver_Home_Page welcome_form = new Driver_Home_Page();
            welcome_form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            string get_trip_request_query = "SELECT * FROM Trip_Requests WHERE t_id = :t_id";
            string add_accepted_request_query = "INSERT INTO Accepted_Trip_Requests (ps_id, dr_id, estimated_cost, start_location, destination, ride_type, trip_start_time, estimated_end_time, payment_method, trip_status, promocode) VALUES (:ps_id, :dr_id, :estimated_cost, :start_location, :destination, :ride_type, :trip_start_time, :estimated_end_time, :payment_method, :trip_status, :promocode)";
            string delete_request_query = "DELETE FROM Trip_Requests WHERE t_id = :t_id";



            OracleCommand get_trip_cmd = new OracleCommand(get_trip_request_query, conn);
            OracleCommand delete_request_cmd = new OracleCommand(delete_request_query, conn);
            OracleCommand insert_request_cmd = new OracleCommand(add_accepted_request_query, conn);

            get_trip_cmd.Parameters.Add(":t_id", int.Parse(trip_id_entry.Text));
            delete_request_cmd.Parameters.Add(":t_id", int.Parse(trip_id_entry.Text));
            OracleDataReader get_req_reader = get_trip_cmd.ExecuteReader();
            if (get_req_reader.Read())
            {
                insert_request_cmd.Parameters.Add(":ps_id", int.Parse(get_req_reader["ps_id"].ToString()));
                insert_request_cmd.Parameters.Add(":dr_id", Globals.loggedInUserId);
                insert_request_cmd.Parameters.Add(":estimated_cost", get_req_reader["estimated_cost"]);
                insert_request_cmd.Parameters.Add(":start_location", get_req_reader["start_location"].ToString());
                insert_request_cmd.Parameters.Add(":destination", get_req_reader["destination"].ToString());
                insert_request_cmd.Parameters.Add(":ride_type", get_req_reader["ride_type"].ToString());
                insert_request_cmd.Parameters.Add(":trip_start_time", DateTime.Now.ToString("dd-MMM-yy"));
                insert_request_cmd.Parameters.Add(":estimated_end_time", DateTime.Now.ToString("dd-MMM-yy"));
                insert_request_cmd.Parameters.Add(":payment_method", get_req_reader["payment_method"].ToString());
                insert_request_cmd.Parameters.Add(":trip_status", get_req_reader["trip_status"].ToString());
                insert_request_cmd.Parameters.Add(":promocode", get_req_reader["promocode"].ToString());
                insert_request_cmd.ExecuteNonQuery();
                delete_request_cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Trip Accepted");
            conn.Close();

        }
    }
}





