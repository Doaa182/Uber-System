
namespace Uber_App
{
    partial class Form1
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
            this.generate_report_btn = new System.Windows.Forms.Button();
            this.passenger_id_entry = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generate_report_btn
            // 
            this.generate_report_btn.Location = new System.Drawing.Point(346, 502);
            this.generate_report_btn.Name = "generate_report_btn";
            this.generate_report_btn.Size = new System.Drawing.Size(165, 34);
            this.generate_report_btn.TabIndex = 0;
            this.generate_report_btn.Text = "Generate Report";
            this.generate_report_btn.UseVisualStyleBackColor = true;
            this.generate_report_btn.Click += new System.EventHandler(this.generate_report_btn_Click);
            // 
            // passenger_id_entry
            // 
            this.passenger_id_entry.Location = new System.Drawing.Point(717, 508);
            this.passenger_id_entry.Name = "passenger_id_entry";
            this.passenger_id_entry.Size = new System.Drawing.Size(217, 22);
            this.passenger_id_entry.TabIndex = 1;
            this.passenger_id_entry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1348, 476);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Passenger Id : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.passenger_id_entry);
            this.Controls.Add(this.generate_report_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_report_btn;
        private System.Windows.Forms.TextBox passenger_id_entry;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
    }
}