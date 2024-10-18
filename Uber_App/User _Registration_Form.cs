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
    public partial class User_Registration_Form : AutoCloseForm
    {
        string connection_string = Globals.connection_string;
        OracleConnection database_connection;
        public User_Registration_Form()
        {
            InitializeComponent();

        }

        private void add_passenger()
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            string insert_passenger_query= "INSERT INTO Passenger (p_phone_no, p_e_wallet_no, p_email, p_password, p_name) VALUES(:p_phone_no, :p_e_wallet_no, :p_email, :p_password, :p_name)";
            OracleCommand create_passenger_command = new OracleCommand(insert_passenger_query, database_connection);
            create_passenger_command.Parameters.Add(":p_phone_no", OracleDbType.Varchar2).Value = phone_entry.Text; 
            create_passenger_command.Parameters.Add(":p_e_wallet_no", OracleDbType.Varchar2).Value = e_wallet_entry.Text; 
            create_passenger_command.Parameters.Add(":p_email", OracleDbType.Varchar2).Value = email_entry.Text; 
            create_passenger_command.Parameters.Add(":p_password", OracleDbType.Varchar2).Value = pass_entry.Text; 
            create_passenger_command.Parameters.Add(":p_name", OracleDbType.Varchar2).Value = name_entry.Text; 
            int affected_rows = create_passenger_command.ExecuteNonQuery();
            database_connection.Close();
            MessageBox.Show("User Registered Succesfully as Passenger");
            back_btn_Click(null, null);

        }
        private void add_driver()
        {
            database_connection = new OracleConnection(connection_string);
            database_connection.Open();
            string insert_driver_query = "INSERT INTO Driver(d_phone_no, d_e_wallet_no, d_email, d_password, d_name, d_car_type, d_car_model, d_plate_no) VALUES(:d_phone_no, :d_e_wallet_no, :d_email, :d_password, :d_name, :d_car_type, :d_car_model, :d_plate_no)";
            OracleCommand create_driver_command = new OracleCommand(insert_driver_query, database_connection);
            create_driver_command.Parameters.Add(":d_phone_no", OracleDbType.Varchar2).Value = phone_entry.Text;
            create_driver_command.Parameters.Add(":d_e_wallet_no", OracleDbType.Varchar2).Value = e_wallet_entry.Text;
            create_driver_command.Parameters.Add(":d_email", OracleDbType.Varchar2).Value = email_entry.Text;
            create_driver_command.Parameters.Add(":d_password", OracleDbType.Varchar2).Value = pass_entry.Text;
            create_driver_command.Parameters.Add(":d_name", OracleDbType.Varchar2).Value = name_entry.Text;
            create_driver_command.Parameters.Add(":d_car_type", OracleDbType.Varchar2).Value = car_type_entry.Text;
            create_driver_command.Parameters.Add(":d_car_model", OracleDbType.Varchar2).Value = car_model_entry.Text;
            create_driver_command.Parameters.Add(":d_plate_no", OracleDbType.Varchar2).Value = plate_number_entry.Text;
            create_driver_command.ExecuteNonQuery();
            database_connection.Close();
            MessageBox.Show("User Registered Succesfully as Driver");
            back_btn_Click(null, null);
        }

        private void submit_btn_click(object sender, EventArgs e)
        {
            FormErrorHandler.TryTo( delegate() {
                if (passenger_radio_btn.Checked)
                {
                    add_passenger();
                }
                else if (driver_radio_btn.Checked)
                {
                    add_driver();
                }
                else
                {
                    MessageBox.Show("Please Select Either Passenger Radio Button or Driver Radio Button");
                }
            });
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Welcome_Form welcome_form = new Welcome_Form();
            welcome_form.Show();
            this.Hide();
        }

        private void driver_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            car_model_entry.Enabled = true;
            car_model_label.Enabled = true;
            car_type_entry.Enabled = true;
            car_type_label.Enabled = true;
            plate_number_entry.Enabled = true;
            plate_number_label.Enabled = true;
        }

        private void passenger_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            car_model_entry.Enabled = false;
            car_model_label.Enabled = false;
            car_type_entry.Enabled = false;
            car_type_label.Enabled = false;
            plate_number_entry.Enabled = false;
            plate_number_label.Enabled = false;
        }

        private void User_Registration_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
