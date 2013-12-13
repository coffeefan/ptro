using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTRO
{
    static class SimpleLogger
    {
        public static void log(string logtxt)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\temperaturController.txt", true))
            {

                file.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + logtxt);
            }
        }

        public static void sqlLog(string logtxt)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\sqltxt.txt", true))
            {
                file.WriteLine(logtxt);
            }
        }
    }
}
