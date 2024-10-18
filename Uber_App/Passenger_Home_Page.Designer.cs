
namespace Uber_App
{
    partial class Passenger_Home_Page
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
            this.update_passenger_info_btn = new System.Windows.Forms.Button();
            this.request_trip_btn = new System.Windows.Forms.Button();
            this.cancel_request_btn = new System.Windows.Forms.Button();
            this.trip_status_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.show_canceled_trips_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // update_passenger_info_btn
            // 
            this.update_passenger_info_btn.Location = new System.Drawing.Point(596, 386);
            this.update_passenger_info_btn.Name = "update_passenger_info_btn";
            this.update_passenger_info_btn.Size = new System.Drawing.Size(179, 39);
            this.update_passenger_info_btn.TabIndex = 0;
            this.update_passenger_info_btn.Text = "Update Info";
            this.update_passenger_info_btn.UseVisualStyleBackColor = true;
            this.update_passenger_info_btn.Click += new System.EventHandler(this.update_passenger_info_btn_Click);
            // 
            // request_trip_btn
            // 
            this.request_trip_btn.Location = new System.Drawing.Point(392, 386);
            this.request_trip_btn.Name = "request_trip_btn";
            this.request_trip_btn.Size = new System.Drawing.Size(179, 39);
            this.request_trip_btn.TabIndex = 4;
            this.request_trip_btn.Text = "Request New Trip";
            this.request_trip_btn.UseVisualStyleBackColor = true;
            this.request_trip_btn.Click += new System.EventHandler(this.request_trip_btn_Click);
            // 
            // cancel_request_btn
            // 
            this.cancel_request_btn.Location = new System.Drawing.Point(198, 386);
            this.cancel_request_btn.Name = "cancel_request_btn";
            this.cancel_request_btn.Size = new System.Drawing.Size(174, 39);
            this.cancel_request_btn.TabIndex = 6;
            this.cancel_request_btn.Text = "Cancel Request";
            this.cancel_request_btn.UseVisualStyleBackColor = true;
            this.cancel_request_btn.Click += new System.EventHandler(this.cancel_request_btn_Click);
            // 
            // trip_status_btn
            // 
            this.trip_status_btn.Location = new System.Drawing.Point(12, 386);
            this.trip_status_btn.Name = "trip_status_btn";
            this.trip_status_btn.Size = new System.Drawing.Size(174, 39);
            this.trip_status_btn.TabIndex = 7;
            this.trip_status_btn.Text = "Show Trip Status";
            this.trip_status_btn.UseVisualStyleBackColor = true;
            this.trip_status_btn.Click += new System.EventHandler(this.trip_status_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 313);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(174, 43);
            this.back_btn.TabIndex = 34;
            this.back_btn.Text = "Logout";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // show_canceled_trips_btn
            // 
            this.show_canceled_trips_btn.Location = new System.Drawing.Point(209, 313);
            this.show_canceled_trips_btn.Name = "show_canceled_trips_btn";
            this.show_canceled_trips_btn.Size = new System.Drawing.Size(163, 43);
            this.show_canceled_trips_btn.TabIndex = 35;
            this.show_canceled_trips_btn.Text = "Show Canceled Trips";
            this.show_canceled_trips_btn.UseVisualStyleBackColor = true;
            this.show_canceled_trips_btn.Click += new System.EventHandler(this.show_canceled_trips_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 258);
            this.dataGridView1.TabIndex = 36;
            // 
            // Passenger_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.show_canceled_trips_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.trip_status_btn);
            this.Controls.Add(this.cancel_request_btn);
            this.Controls.Add(this.request_trip_btn);
            this.Controls.Add(this.update_passenger_info_btn);
            this.Name = "Passenger_Home_Page";
            this.Text = "Passenger_Home_Page";
            this.Load += new System.EventHandler(this.Passenger_Home_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update_passenger_info_btn;
        private System.Windows.Forms.Button request_trip_btn;
        private System.Windows.Forms.Button cancel_request_btn;
        private System.Windows.Forms.Button trip_status_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button show_canceled_trips_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}