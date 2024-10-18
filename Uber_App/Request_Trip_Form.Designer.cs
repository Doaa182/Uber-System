
namespace Uber_App
{
    partial class Request_Trip_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.pickup_location_entry = new System.Windows.Forms.TextBox();
            this.destination_entry = new System.Windows.Forms.TextBox();
            this.destination_label = new System.Windows.Forms.Label();
            this.payment_type_cmbbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uber_x_rd_btn = new System.Windows.Forms.RadioButton();
            this.uber_select_rd_btn = new System.Windows.Forms.RadioButton();
            this.request_ride_btn = new System.Windows.Forms.Button();
            this.ride_type_group_box = new System.Windows.Forms.GroupBox();
            this.promo_code_entry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.ride_type_group_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pickup Location";
            // 
            // pickup_location_entry
            // 
            this.pickup_location_entry.Location = new System.Drawing.Point(194, 44);
            this.pickup_location_entry.Name = "pickup_location_entry";
            this.pickup_location_entry.Size = new System.Drawing.Size(229, 22);
            this.pickup_location_entry.TabIndex = 2;
            this.pickup_location_entry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // destination_entry
            // 
            this.destination_entry.Location = new System.Drawing.Point(194, 94);
            this.destination_entry.Name = "destination_entry";
            this.destination_entry.Size = new System.Drawing.Size(229, 22);
            this.destination_entry.TabIndex = 4;
            // 
            // destination_label
            // 
            this.destination_label.AutoSize = true;
            this.destination_label.Location = new System.Drawing.Point(38, 94);
            this.destination_label.Name = "destination_label";
            this.destination_label.Size = new System.Drawing.Size(79, 17);
            this.destination_label.TabIndex = 3;
            this.destination_label.Text = "Destination";
            // 
            // payment_type_cmbbox
            // 
            this.payment_type_cmbbox.FormattingEnabled = true;
            this.payment_type_cmbbox.Items.AddRange(new object[] {
            "Cash",
            "VISA"});
            this.payment_type_cmbbox.Location = new System.Drawing.Point(194, 147);
            this.payment_type_cmbbox.Name = "payment_type_cmbbox";
            this.payment_type_cmbbox.Size = new System.Drawing.Size(121, 24);
            this.payment_type_cmbbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ride Type :";
            // 
            // uber_x_rd_btn
            // 
            this.uber_x_rd_btn.AutoSize = true;
            this.uber_x_rd_btn.Location = new System.Drawing.Point(14, 33);
            this.uber_x_rd_btn.Name = "uber_x_rd_btn";
            this.uber_x_rd_btn.Size = new System.Drawing.Size(69, 21);
            this.uber_x_rd_btn.TabIndex = 8;
            this.uber_x_rd_btn.TabStop = true;
            this.uber_x_rd_btn.Text = "UberX";
            this.uber_x_rd_btn.UseVisualStyleBackColor = true;
            this.uber_x_rd_btn.CheckedChanged += new System.EventHandler(this.uber_x_rd_btn_CheckedChanged);
            // 
            // uber_select_rd_btn
            // 
            this.uber_select_rd_btn.AutoSize = true;
            this.uber_select_rd_btn.Location = new System.Drawing.Point(144, 33);
            this.uber_select_rd_btn.Name = "uber_select_rd_btn";
            this.uber_select_rd_btn.Size = new System.Drawing.Size(103, 21);
            this.uber_select_rd_btn.TabIndex = 9;
            this.uber_select_rd_btn.TabStop = true;
            this.uber_select_rd_btn.Text = "Uber Select";
            this.uber_select_rd_btn.UseVisualStyleBackColor = true;
            this.uber_select_rd_btn.CheckedChanged += new System.EventHandler(this.uber_select_rd_btn_CheckedChanged);
            // 
            // request_ride_btn
            // 
            this.request_ride_btn.Location = new System.Drawing.Point(259, 359);
            this.request_ride_btn.Name = "request_ride_btn";
            this.request_ride_btn.Size = new System.Drawing.Size(164, 48);
            this.request_ride_btn.TabIndex = 10;
            this.request_ride_btn.Text = "Request Ride ";
            this.request_ride_btn.UseVisualStyleBackColor = true;
            this.request_ride_btn.Click += new System.EventHandler(this.request_ride_btn_Click);
            // 
            // ride_type_group_box
            // 
            this.ride_type_group_box.Controls.Add(this.uber_select_rd_btn);
            this.ride_type_group_box.Controls.Add(this.uber_x_rd_btn);
            this.ride_type_group_box.Location = new System.Drawing.Point(194, 269);
            this.ride_type_group_box.Name = "ride_type_group_box";
            this.ride_type_group_box.Size = new System.Drawing.Size(262, 65);
            this.ride_type_group_box.TabIndex = 11;
            this.ride_type_group_box.TabStop = false;
            this.ride_type_group_box.Text = "Ride Type";
            // 
            // promo_code_entry
            // 
            this.promo_code_entry.Location = new System.Drawing.Point(194, 207);
            this.promo_code_entry.Name = "promo_code_entry";
            this.promo_code_entry.Size = new System.Drawing.Size(229, 22);
            this.promo_code_entry.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Promo Code";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(41, 371);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(126, 36);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Request_Trip_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.promo_code_entry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ride_type_group_box);
            this.Controls.Add(this.request_ride_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payment_type_cmbbox);
            this.Controls.Add(this.destination_entry);
            this.Controls.Add(this.destination_label);
            this.Controls.Add(this.pickup_location_entry);
            this.Controls.Add(this.label1);
            this.Name = "Request_Trip_Form";
            this.Text = "Request_Trip_Form";
            this.Load += new System.EventHandler(this.Request_Trip_Form_Load);
            this.ride_type_group_box.ResumeLayout(false);
            this.ride_type_group_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pickup_location_entry;
        private System.Windows.Forms.TextBox destination_entry;
        private System.Windows.Forms.Label destination_label;
        private System.Windows.Forms.ComboBox payment_type_cmbbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton uber_x_rd_btn;
        private System.Windows.Forms.RadioButton uber_select_rd_btn;
        private System.Windows.Forms.Button request_ride_btn;
        private System.Windows.Forms.GroupBox ride_type_group_box;
        private System.Windows.Forms.TextBox promo_code_entry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back_btn;
    }
}