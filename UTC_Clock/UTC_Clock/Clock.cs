using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTC_Clock
{
    class Clock
    {
        public Clock(string[] time)
        {
            int h, m, s;
            h = Convert.ToInt32(time[1]);
            m = Convert.ToInt32(time[2]);
            s = Convert.ToInt32(time[3]);

            if((s >=60) || (h >= 24) || (m >=60))
                Console.WriteLine("Error");
            else
            {
                Application.EnableVisualStyles();
                Application.Run(new Digital(h, m, s));
            }

        }

        //private void Tick(int h, int m, int s)
        //{

            
        //}
    }
}
