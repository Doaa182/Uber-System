using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_App
{
    public class AutoCloseForm : Form
    {

        public AutoCloseForm()
        {
            this.FormClosing += FormClosing2;
        }
        public void FormClosing2(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
