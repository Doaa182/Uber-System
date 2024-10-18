
namespace Uber_App
{
    partial class User_Registration_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.name_entry = new System.Windows.Forms.TextBox();
            this.email_entry = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pass_entry = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.phone_entry = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.create_user_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.passenger_radio_btn = new System.Windows.Forms.RadioButton();
            this.driver_radio_btn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.car_type_entry = new System.Windows.Forms.TextBox();
            this.car_type_label = new System.Windows.Forms.Label();
            this.car_model_label = new System.Windows.Forms.TextBox();
            this.car_model_entry = new System.Windows.Forms.Label();
            this.plate_number_entry = new System.Windows.Forms.TextBox();
            this.plate_number_label = new System.Windows.Forms.Label();
            this.e_wallet_entry = new System.Windows.Forms.TextBox();
            this.e_wallet_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name : ";
            // 
            // name_entry
            // 
            this.name_entry.Location = new System.Drawing.Point(167, 93);
            this.name_entry.Name = "name_entry";
            this.name_entry.Size = new System.Drawing.Size(174, 22);
            this.name_entry.TabIndex = 1;
            // 
            // email_entry
            // 
            this.email_entry.Location = new System.Drawing.Point(167, 143);
            this.email_entry.Name = "email_entry";
            this.email_entry.Size = new System.Drawing.Size(174, 22);
            this.email_entry.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(34, 143);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(50, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email :";
            // 
            // pass_entry
            // 
            this.pass_entry.Location = new System.Drawing.Point(167, 198);
            this.pass_entry.Name = "pass_entry";
            this.pass_entry.Size = new System.Drawing.Size(174, 22);
            this.pass_entry.TabIndex = 5;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(34, 198);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(81, 17);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password : ";
            // 
            // phone_entry
            // 
            this.phone_entry.Location = new System.Drawing.Point(167, 255);
            this.phone_entry.Name = "phone_entry";
            this.phone_entry.Size = new System.Drawing.Size(174, 22);
            this.phone_entry.TabIndex = 7;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(34, 255);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(115, 17);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone Number : ";
            // 
            // create_user_btn
            // 
            this.create_user_btn.Location = new System.Drawing.Point(465, 393);
            this.create_user_btn.Name = "create_user_btn";
            this.create_user_btn.Size = new System.Drawing.Size(173, 36);
            this.create_user_btn.TabIndex = 8;
            this.create_user_btn.Text = "Submit";
            this.create_user_btn.UseVisualStyleBackColor = true;
            this.create_user_btn.Click += new System.EventHandler(this.submit_btn_click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(644, 393);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(126, 36);
            this.back_btn.TabIndex = 9;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // passenger_radio_btn
            // 
            this.passenger_radio_btn.AutoSize = true;
            this.passenger_radio_btn.Location = new System.Drawing.Point(143, 21);
            this.passenger_radio_btn.Name = "passenger_radio_btn";
            this.passenger_radio_btn.Size = new System.Drawing.Size(97, 21);
            this.passenger_radio_btn.TabIndex = 10;
            this.passenger_radio_btn.TabStop = true;
            this.passenger_radio_btn.Text = "Passenger";
            this.passenger_radio_btn.UseVisualStyleBackColor = true;
            this.passenger_radio_btn.CheckedChanged += new System.EventHandler(this.passenger_radio_btn_CheckedChanged);
            // 
            // driver_radio_btn
            // 
            this.driver_radio_btn.AutoSize = true;
            this.driver_radio_btn.Location = new System.Drawing.Point(290, 21);
            this.driver_radio_btn.Name = "driver_radio_btn";
            this.driver_radio_btn.Size = new System.Drawing.Size(67, 21);
            this.driver_radio_btn.TabIndex = 11;
            this.driver_radio_btn.TabStop = true;
            this.driver_radio_btn.Text = "Driver";
            this.driver_radio_btn.UseVisualStyleBackColor = true;
            this.driver_radio_btn.CheckedChanged += new System.EventHandler(this.driver_radio_btn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.driver_radio_btn);
            this.groupBox1.Controls.Add(this.passenger_radio_btn);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register as :";
            // 
            // car_type_entry
            // 
            this.car_type_entry.Location = new System.Drawing.Point(541, 93);
            this.car_type_entry.Name = "car_type_entry";
            this.car_type_entry.Size = new System.Drawing.Size(174, 22);
            this.car_type_entry.TabIndex = 14;
            // 
            // car_type_label
            // 
            this.car_type_label.AutoSize = true;
            this.car_type_label.Location = new System.Drawing.Point(408, 93);
            this.car_type_label.Name = "car_type_label";
            this.car_type_label.Size = new System.Drawing.Size(74, 17);
            this.car_type_label.TabIndex = 13;
            this.car_type_label.Text = "Car Type :";
            // 
            // car_model_label
            // 
            this.car_model_label.Location = new System.Drawing.Point(541, 143);
            this.car_model_label.Name = "car_model_label";
            this.car_model_label.Size = new System.Drawing.Size(174, 22);
            this.car_model_label.TabIndex = 16;
            // 
            // car_model_entry
            // 
            this.car_model_entry.AutoSize = true;
            this.car_model_entry.Location = new System.Drawing.Point(408, 143);
            this.car_model_entry.Name = "car_model_entry";
            this.car_model_entry.Size = new System.Drawing.Size(80, 17);
            this.car_model_entry.TabIndex = 15;
            this.car_model_entry.Text = "Car Model :";
            // 
            // plate_number_entry
            // 
            this.plate_number_entry.Location = new System.Drawing.Point(541, 193);
            this.plate_number_entry.Name = "plate_number_entry";
            this.plate_number_entry.Size = new System.Drawing.Size(174, 22);
            this.plate_number_entry.TabIndex = 18;
            // 
            // plate_number_label
            // 
            this.plate_number_label.AutoSize = true;
            this.plate_number_label.Location = new System.Drawing.Point(408, 193);
            this.plate_number_label.Name = "plate_number_label";
            this.plate_number_label.Size = new System.Drawing.Size(102, 17);
            this.plate_number_label.TabIndex = 17;
            this.plate_number_label.Text = "Plate Number :";
            // 
            // e_wallet_entry
            // 
            this.e_wallet_entry.Location = new System.Drawing.Point(541, 255);
            this.e_wallet_entry.Name = "e_wallet_entry";
            this.e_wallet_entry.Size = new System.Drawing.Size(174, 22);
            this.e_wallet_entry.TabIndex = 20;
            // 
            // e_wallet_label
            // 
            this.e_wallet_label.AutoSize = true;
            this.e_wallet_label.Location = new System.Drawing.Point(408, 255);
            this.e_wallet_label.Name = "e_wallet_label";
            this.e_wallet_label.Size = new System.Drawing.Size(123, 17);
            this.e_wallet_label.TabIndex = 19;
            this.e_wallet_label.Text = "E-Wallet Number :";
            // 
            // User_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.e_wallet_entry);
            this.Controls.Add(this.e_wallet_label);
            this.Controls.Add(this.plate_number_entry);
            this.Controls.Add(this.plate_number_label);
            this.Controls.Add(this.car_model_label);
            this.Controls.Add(this.car_model_entry);
            this.Controls.Add(this.car_type_entry);
            this.Controls.Add(this.car_type_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.create_user_btn);
            this.Controls.Add(this.phone_entry);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.pass_entry);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.email_entry);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.name_entry);
            this.Controls.Add(this.nameLabel);
            this.Name = "User_Registration_Form";
            this.Text = "User_Registration_Form";
            this.Load += new System.EventHandler(this.User_Registration_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name_entry;
        private System.Windows.Forms.TextBox email_entry;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox pass_entry;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox phone_entry;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button create_user_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.RadioButton passenger_radio_btn;
        private System.Windows.Forms.RadioButton driver_radio_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox car_type_entry;
        private System.Windows.Forms.Label car_type_label;
        private System.Windows.Forms.TextBox car_model_label;
        private System.Windows.Forms.Label car_model_entry;
        private System.Windows.Forms.TextBox plate_number_entry;
        private System.Windows.Forms.Label plate_number_label;
        private System.Windows.Forms.TextBox e_wallet_entry;
        private System.Windows.Forms.Label e_wallet_label;
    }
}

