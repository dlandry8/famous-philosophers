using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3FamousPhilosophers
{
    public partial class frmSplashPhilosopher : Form
    {
        public frmSplashPhilosopher()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------
        //  Method:         tmrSplash_Tick
        //  Description:    Tick event for the timer.  Increments the
        //                      progress bar until it is full.
        //  Programmer:     David Landry
        //  Date:           11/29/2016
        //--------------------------------------------------------------------
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            pgbPhilosopher.Increment(1);
            if (pgbPhilosopher.Value >= 100)
                Dispose();
        }
    }
}
