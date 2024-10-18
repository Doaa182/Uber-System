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
    public partial class Login_Form : AutoCloseForm
    {
        string connection_string = Globals.connection_string;
        OracleConnection database_connection;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Welcome_Form welcome_form = new Welcome_Form();
            welcome_form.Show();
            this.Hide();
        }

        private void login_passenger()
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            string search_passenger_query = "SELECT * FROM Passenger WHERE p_email = :email AND p_password = :password";
            OracleCommand search_passenger_command = new OracleCommand(search_passenger_query, database_connection);
            search_passenger_command.Parameters.Add(":p_email", OracleDbType.Varchar2).Value = email_entry.Text;
            search_passenger_command.Parameters.Add(":p_password", OracleDbType.Varchar2).Value = password_entry.Text;
            OracleDataReader data_reader = search_passenger_command.ExecuteReader();
            if (data_reader.Read())
            {
                Globals.loggedInUserId = int.Parse(data_reader["p_id"].ToString());
                Globals.loggedInUserType = "Passenger";
                Passenger_Home_Page passenger_home_page = new Passenger_Home_Page();
                passenger_home_page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password !");
            }

            database_connection.Close();
        }
        private void login_driver()
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            string search_driver_query = "SELECT * FROM Driver WHERE d_email = :email AND d_password = :password";
            OracleCommand search_driver_command = new OracleCommand(search_driver_query, database_connection);
            search_driver_command.Parameters.Add(":d_email", OracleDbType.Varchar2).Value = email_entry.Text;
            search_driver_command.Parameters.Add(":d_password", OracleDbType.Varchar2).Value = password_entry.Text;
            OracleDataReader data_reader = search_driver_command.ExecuteReader();
            if (data_reader.Read())
            {
                Globals.loggedInUserId = int.Parse(data_reader["d_id"].ToString());
                Globals.loggedInUserType = "Driver";
                Driver_Home_Page driver_home_page = new Driver_Home_Page();
                driver_home_page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password !");
            }
            database_connection.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            FormErrorHandler.TryTo(delegate () {
                if (passenger_radio_btn.Checked)
                {
                    login_passenger();
                }
                else if (driver_radio_btn.Checked)
                {
                    login_driver();
                }
                else
                {
                    MessageBox.Show("Select Either Passenger Radio Button or Driver Radio Button");
                }
            });
                    
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void user_type_groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
