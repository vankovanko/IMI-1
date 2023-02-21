using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svetofar
{
    public partial class Form1 : Form
    {
        int seconds;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTimer.Interval = 1000;
            myTimer.Start();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds < 5)
            {
                //red
                red_btn.BackColor = Color.Red;
                yellow_btn.BackColor = Color.White;
                green_btn.BackColor = Color.White;
            }
            if (seconds > 6)
            {
                //red+yellow
                red_btn.BackColor = Color.Red;
                yellow_btn.BackColor = Color.Yellow;
                green_btn.BackColor = Color.White;
            }
            if (seconds > 11)
            {
                red_btn.BackColor = Color.White;
                yellow_btn.BackColor = Color.White;
                green_btn.BackColor = Color.Green;
            }

            if (seconds > 12)
            {
                red_btn.BackColor = Color.White;
                yellow_btn.BackColor = Color.Yellow;
                green_btn.BackColor = Color.White;
            }
            if (seconds > 16)
            {
                seconds = 0;
            }
           
        }
        private void redbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
   
        