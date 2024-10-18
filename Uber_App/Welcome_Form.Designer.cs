
namespace Uber_App
{
    partial class Welcome_Form
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
            this.register_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(218, 259);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(146, 45);
            this.register_btn.TabIndex = 0;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(385, 259);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(146, 45);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Our System";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Car Types Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fine Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.register_btn);
            this.Name = "Welcome_Form";
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.Welcome_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}