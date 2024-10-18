
namespace Uber_App
{
    partial class Login_Form
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
            this.login_btn = new System.Windows.Forms.Button();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_entry = new System.Windows.Forms.TextBox();
            this.password_entry = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.user_type_groupBox = new System.Windows.Forms.GroupBox();
            this.driver_radio_btn = new System.Windows.Forms.RadioButton();
            this.passenger_radio_btn = new System.Windows.Forms.RadioButton();
            this.user_type_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(271, 262);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(156, 51);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(167, 79);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(54, 17);
            this.email_label.TabIndex = 1;
            this.email_label.Text = "Email : ";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(167, 132);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(77, 17);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password :";
            // 
            // email_entry
            // 
            this.email_entry.Location = new System.Drawing.Point(271, 79);
            this.email_entry.Name = "email_entry";
            this.email_entry.Size = new System.Drawing.Size(233, 22);
            this.email_entry.TabIndex = 3;
            // 
            // password_entry
            // 
            this.password_entry.Location = new System.Drawing.Point(271, 132);
            this.password_entry.Name = "password_entry";
            this.password_entry.Size = new System.Drawing.Size(233, 22);
            this.password_entry.TabIndex = 4;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(650, 385);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 33);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // user_type_groupBox
            // 
            this.user_type_groupBox.Controls.Add(this.driver_radio_btn);
            this.user_type_groupBox.Controls.Add(this.passenger_radio_btn);
            this.user_type_groupBox.Location = new System.Drawing.Point(170, 181);
            this.user_type_groupBox.Name = "user_type_groupBox";
            this.user_type_groupBox.Size = new System.Drawing.Size(470, 54);
            this.user_type_groupBox.TabIndex = 13;
            this.user_type_groupBox.TabStop = false;
            this.user_type_groupBox.Text = "Login as :";
            this.user_type_groupBox.Enter += new System.EventHandler(this.user_type_groupBox_Enter);
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
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_type_groupBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.password_entry);
            this.Controls.Add(this.email_entry);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.login_btn);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.user_type_groupBox.ResumeLayout(false);
            this.user_type_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox email_entry;
        private System.Windows.Forms.TextBox password_entry;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox user_type_groupBox;
        private System.Windows.Forms.RadioButton driver_radio_btn;
        private System.Windows.Forms.RadioButton passenger_radio_btn;
    }
}