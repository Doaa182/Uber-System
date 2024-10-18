
namespace Uber_App
{
    partial class Form1report
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.car_type_entry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generate_report_btn
            // 
            this.generate_report_btn.Location = new System.Drawing.Point(283, 502);
            this.generate_report_btn.Name = "generate_report_btn";
            this.generate_report_btn.Size = new System.Drawing.Size(185, 44);
            this.generate_report_btn.TabIndex = 0;
            this.generate_report_btn.Text = "Generate Report";
            this.generate_report_btn.UseVisualStyleBackColor = true;
            this.generate_report_btn.Click += new System.EventHandler(this.generate_report_btn_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1171, 481);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // car_type_entry
            // 
            this.car_type_entry.Location = new System.Drawing.Point(693, 513);
            this.car_type_entry.Name = "car_type_entry";
            this.car_type_entry.Size = new System.Drawing.Size(129, 22);
            this.car_type_entry.TabIndex = 2;
            this.car_type_entry.TextChanged += new System.EventHandler(this.car_type_entry_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Car Type :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.car_type_entry);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.generate_report_btn);
            this.Name = "Form1report";
            this.Text = "Form1report";
            this.Load += new System.EventHandler(this.Form1report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_report_btn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox car_type_entry;
        private System.Windows.Forms.Label label1;
    }
}