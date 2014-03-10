using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTC_Clock
{
    public partial class Digital : Form
    {
        public Digital(int h, int m, int s)
        {
            InitializeComponent();
            string stunde, minute, sekunde;
            stunde = Convert.ToString(h);
            minute = Convert.ToString(m);
            sekunde = Convert.ToString(s);

            TimeSpan time3 = new TimeSpan(h, m, s);

            lblTime.Text = time3.ToString();
            lblH.Text = stunde;
            lblM.Text = minute;
            lblS.Text = sekunde;
        }
    }
}
