
namespace Uber_App
{
    partial class Trip_Request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
        /// 

     

        #endregion

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trip_id_entry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bulider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Show Completed Trips";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(520, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Cancel_Trip";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(722, 401);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 33);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "accept_req";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trip_id_entry
            // 
            this.trip_id_entry.Location = new System.Drawing.Point(357, 115);
            this.trip_id_entry.Name = "trip_id_entry";
            this.trip_id_entry.Size = new System.Drawing.Size(100, 22);
            this.trip_id_entry.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Trip ID :";
            // 
            // Trip_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trip_id_entry);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Trip_Request";
            this.Text = "Trip_Request";
            this.Load += new System.EventHandler(this.Trip_Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox trip_id_entry;
        private System.Windows.Forms.Label label1;
    }
}

