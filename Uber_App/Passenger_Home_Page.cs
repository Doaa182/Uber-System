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
    public partial class Passenger_Home_Page : AutoCloseForm
    {
        string connection_string = Globals.connection_string;
        OracleConnection database_connection;
        string target_table;
        public Passenger_Home_Page()
        {
            InitializeComponent();
        }

        private void update_passenger_info_btn_Click(object sender, EventArgs e)
        {
            User_Info user_info_page = new User_Info();
            user_info_page.Show();
            this.Hide();
        }

        private void Passenger_Home_Page_Load(object sender, EventArgs e)
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            string show_passenger_pending_trip_requests = "SELECT * FROM Trip_Requests WHERE  ps_id = :p_id";
            string show_passenger_accepted_trip_requests = "SELECT * FROM Accepted_Trip_Requests WHERE  ps_id = :ps_id";

            OracleCommand show_passenger_pending_trip_requests_cmd = new OracleCommand(show_passenger_pending_trip_requests, database_connection);
            OracleCommand show_passenger_accepted_trip_requests_cmd = new OracleCommand(show_passenger_accepted_trip_requests, database_connection);

            show_passenger_pending_trip_requests_cmd.Parameters.Add(":p_id", Globals.loggedInUserId);
            show_passenger_accepted_trip_requests_cmd.Parameters.Add(":ps_id", Globals.loggedInUserId);

            OracleDataReader accepted_requests_data_reader = show_passenger_accepted_trip_requests_cmd.ExecuteReader();
            OracleDataReader pending_requests_data_reader = show_passenger_pending_trip_requests_cmd.ExecuteReader();


            if (accepted_requests_data_reader.Read())
            {
                target_table = "Accepted_Trip_Requests";
                request_trip_btn.Enabled = false;
                update_passenger_info_btn.Enabled = false;
            }
            else if (pending_requests_data_reader.Read())
            {
                target_table = "Trip_Requests";
                request_trip_btn.Enabled = false;
                update_passenger_info_btn.Enabled = false;

            }
            else
            {
                target_table = "";
                trip_status_btn.Enabled = false;
                cancel_request_btn.Enabled = false;
            }
            

        }

        private void request_trip_btn_Click(object sender, EventArgs e)
        {
            Request_Trip_Form request_trip_form = new Request_Trip_Form();
            request_trip_form.Show();
            this.Hide();
        }

        private void trip_status_btn_Click(object sender, EventArgs e)
        {
            TripStatus trip_status_form = new TripStatus();
            trip_status_form.Show();
            this.Hide();
        }

        private void cancel_request_btn_Click(object sender, EventArgs e)
        {
            FormErrorHandler.TryTo(delegate ()
            {

                database_connection = new OracleConnection(connection_string);
                database_connection.Open();


                string get_trip_request_query = "SELECT * FROM " + target_table + " WHERE ps_id = :ps_id";
                string add_canceled_request_query = "INSERT INTO Canceled_Requests (ps_id, dr_id, estimated_cost, start_location, destination, ride_type, trip_start_time, estimated_end_time, payment_method, cancelation_time, promocode) VALUES (:ps_id, :dr_id, :estimated_cost, :start_location, :destination, :ride_type, :trip_start_time, :estimated_end_time, :payment_method, :cancelation_time, :promocode)";
                string delete_request_query = "DELETE FROM " + target_table + " WHERE ps_id = :ps_id";

                OracleCommand get_trip_cmd = new OracleCommand(get_trip_request_query, database_connection);
                OracleCommand insert_request_cmd = new OracleCommand(add_canceled_request_query, database_connection);
                OracleCommand delete_request_cmd = new OracleCommand(delete_request_query, database_connection);


                delete_request_cmd.Parameters.Add(":ps_id", Globals.loggedInUserId);
                get_trip_cmd.Parameters.Add(":ps_id", Globals.loggedInUserId);


                OracleDataReader get_req_reader = get_trip_cmd.ExecuteReader();

                if (get_req_reader.Read())
                {
                    insert_request_cmd.Parameters.Add(":ps_id", Globals.loggedInUserId);
                    if (target_table == "Accepted_Trip_Requests")
                    {
                        insert_request_cmd.Parameters.Add(":dr_id", get_req_reader["dr_id"]);
                    }
                    else
                    {
                        insert_request_cmd.Parameters.Add(":dr_id", null);
                    }
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
                request_trip_btn.Enabled = true;
                cancel_request_btn.Enabled = false;
                update_passenger_info_btn.Enabled = true;
                trip_status_btn.Enabled = false;
                MessageBox.Show("Trip Canceled");
                database_connection.Close();

            });

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Welcome_Form welcome_form = new Welcome_Form();
            welcome_form.Show();
            this.Hide();
        }

        private void show_canceled_trips_btn_Click(object sender, EventArgs e)
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = database_connection;

            cmd.CommandText = "get_canceled_requests";

            cmd.CommandType = CommandType.StoredProcedure; cmd.Parameters.Add("p_id", Globals.loggedInUserId);

            cmd.Parameters.Add("t_id", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Columns.Add("T_ID");
            dataTable.Columns.Add("PS_ID");
            dataTable.Columns.Add("DR_ID");
            dataTable.Columns.Add("estimated_cost");
            dataTable.Columns.Add("start_location");
            dataTable.Columns.Add("destination");

            while (dr.Read())
            {
                dataTable.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            dataGridView1.DataSource = dataTable;
            dr.Close();
        }
    }
}
