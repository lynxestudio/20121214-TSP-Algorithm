using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TSP
{
    public partial class Form1 : Form
    {

        Thread worker = null;
        public Form1()
        {
            InitializeComponent();
            pnDraw.started = false;
            pnDraw.Invalidate();
        }

      

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (worker != null)
                worker = null;
            else
            {
                worker = new Thread(new ThreadStart(pnDraw.run));
                worker.Priority = ThreadPriority.Lowest;
                pnDraw.SetCityCount(Convert.ToInt32(numCities.Value));
                pnDraw.SetpopulationSize(Convert.ToInt32(numPob.Value));
                pnDraw.SetmutationPercent(Convert.ToDouble(nmMutation.Value));
                pnDraw.startThread(); //setting the values
                worker.Start(); //execute the thread
                btnStart.Enabled = false;
            }

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        void Exit(){
             if (worker != null && worker.IsAlive)
            {
                worker.Abort();
                worker = null;
            }
            Dispose();
            Application.Exit();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

    }
}
