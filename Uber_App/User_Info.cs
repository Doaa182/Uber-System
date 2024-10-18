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
    public partial class User_Info : AutoCloseForm
    {
        string connection_string = Globals.connection_string;
        OracleConnection database_connection;
        public User_Info()
        {
            InitializeComponent();
        }

        private void User_Info_Load(object sender, EventArgs e)
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            string search_passenger_query = "SELECT * FROM Passenger WHERE p_id = :p_id";
            OracleCommand search_passenger_command = new OracleCommand(search_passenger_query, database_connection);
            search_passenger_command.Parameters.Add(":p_id", OracleDbType.Varchar2).Value = Globals.loggedInUserId.ToString();
            OracleDataReader data_reader = search_passenger_command.ExecuteReader();

            if(data_reader.Read())
            {
                name_entry.Text = data_reader["p_name"].ToString();
                email_entry.Text = data_reader["p_email"].ToString();
                pass_entry.Text = data_reader["p_password"].ToString();
                phone_entry.Text = data_reader["p_phone_no"].ToString();
                e_wallet_entry.Text = data_reader["p_e_wallet_no"].ToString();
                car_model_entry.Enabled = false;
                car_type_entry.Enabled = false;
                plate_number_entry.Enabled = false;
            }
            else
            {
              MessageBox.Show(data_reader.ToString());
            }
        }

        private void update_passenger_btn_Click(object sender, EventArgs e)
        {

            FormErrorHandler.TryTo(delegate () {
                database_connection = new OracleConnection(connection_string);
                database_connection.Open();
                OracleCommand command = new OracleCommand("update_passenger", database_connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("passenger_id", OracleDbType.Varchar2).Value = Globals.loggedInUserId;
                command.Parameters.Add("phone_number", OracleDbType.Varchar2).Value = phone_entry.Text;
                command.Parameters.Add("e_wallet_number", OracleDbType.Varchar2).Value = e_wallet_entry.Text;
                command.Parameters.Add("email", OracleDbType.Varchar2).Value = email_entry.Text;
                command.Parameters.Add("password", OracleDbType.Varchar2).Value = pass_entry.Text;
                command.Parameters.Add("name", OracleDbType.Varchar2).Value = name_entry.Text;

                command.ExecuteNonQuery();
                database_connection.Close();
                MessageBox.Show("Info Updated Succesfuly");
            });

            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Passenger_Home_Page passenger_home = new Passenger_Home_Page();
            passenger_home.Show();
            this.Hide();
        }
    }
}
