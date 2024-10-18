using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uber_App
{
    public abstract class Globals
    {
        public static int loggedInUserId;
        public static string loggedInUserType;
        public static string connection_string = "Data Source=ORCL; User Id=scott; Password=scott;";
    }

    public abstract class FormErrorHandler
    {
        public static void TryTo(Action todo)
        {
            try
            {
                todo();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("error occured, check that you filled the data correctly");
            }
        }
    }
}
