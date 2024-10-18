using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_App
{
    public partial class Welcome_Form : AutoCloseForm
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            User_Registration_Form registration_form = new User_Registration_Form();
            registration_form.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Login_Form login_form = new Login_Form();
            login_form.Show();
            this.Hide();
        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1report CR = new Form1report();
            this.Hide();
            CR.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
