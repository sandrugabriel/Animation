using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {

        private Timer timer;
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);

            timer.Enabled = true;





        }

        private void timer_Tick(object sender, EventArgs e)
        {



            btnTest.Left += 40;

            int lung = this.Width - 20;

            if(btnTest.Location.X >= lung)
            {
                btnTest.Location = new Point(-38, 80);
            }
           



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
