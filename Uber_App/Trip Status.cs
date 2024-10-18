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
    public partial class TripStatus : AutoCloseForm
    {
        string connection_string = Globals.connection_string;
        OracleConnection database_connection;
        String tripStatus, pickupLoc, destination, rideType, cost, promocode, paymentType;

        private void back_btn_Click(object sender, EventArgs e)
        {
            Passenger_Home_Page passenger_home_page = new Passenger_Home_Page();
            this.Hide();
            passenger_home_page.Show();
        }

        public TripStatus()
        {
            InitializeComponent();
        }

        private void Trip_Status_Form_Load(object sender, EventArgs e)
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            string show_passenger_pending_trip_requests = "SELECT * FROM Trip_Requests WHERE  ps_id = :p_id";
            string show_passenger_accepted_trip_requests = "SELECT * FROM Accepted_Trip_Requests WHERE  ps_id = :ps_id";

            OracleCommand show_passenger_pending_trip_requests_cmd = new OracleCommand(show_passenger_pending_trip_requests, database_connection);
            OracleCommand show_passenger_accepted_trip_requests_cmd = new OracleCommand(show_passenger_accepted_trip_requests, database_connection);

            show_passenger_pending_trip_requests_cmd.Parameters.Add(":p_id", Globals.loggedInUserId);
            show_passenger_accepted_trip_requests_cmd.Parameters.Add(":ps_id", Globals.loggedInUserId);

            OracleDataReader reader;

            OracleDataReader pending_requests_data_reader = show_passenger_pending_trip_requests_cmd.ExecuteReader();
            OracleDataReader accepted_requests_data_reader = show_passenger_accepted_trip_requests_cmd.ExecuteReader();

            if (pending_requests_data_reader.Read())
            {
                reader = pending_requests_data_reader;
            }
            else
            {
                accepted_requests_data_reader.Read();
                reader = accepted_requests_data_reader;
            }

            
            tripStatus = "Searching for a driver...";
            pickupLoc = reader["start_location"].ToString();
            destination = reader["destination"].ToString();
            rideType = reader["ride_type"].ToString();
            paymentType = reader["payment_method"].ToString();
            cost = "$" + reader["estimated_cost"].ToString();
            promocode = reader["promocode"].ToString();

            if (promocode.Length == 0)
            {
                promocode = "...";
            }

            driver_groupbox.Visible = false;


            if (reader == accepted_requests_data_reader)
            {
                driver_groupbox.Visible = true;
                tripStatus = "Found a Driver";
                //Get Driver details
                string driver_details_query = "SELECT * FROM Driver WHERE d_id = :dr_id";
                OracleCommand cmd = new OracleCommand(driver_details_query, database_connection);
                cmd.Parameters.Add(":dr_id", reader["dr_id"].ToString());
                OracleDataReader driverReader = cmd.ExecuteReader();

                if (driverReader.Read())
                {
                    dr_name_lab.Text = driverReader["d_name"].ToString();
                    phone_label.Text = driverReader["d_phone_no"].ToString();
                    cartype_label.Text = driverReader["d_car_type"].ToString();
                    carmodel_label.Text = driverReader["d_car_model"].ToString();
                    plate_label.Text = driverReader["d_plate_no"].ToString();
                    rating_label.Text = driverReader["d_rating"].ToString();
                }
            }

            status_label.Text = tripStatus;
            pickup_label.Text = pickupLoc;
            dest_label.Text = destination;
            ride_label.Text = rideType;
            payment_label.Text = paymentType;
            cost_label.Text = cost;
            promo_label.Text = promocode;


            database_connection.Close();

        }

       
    }
}
