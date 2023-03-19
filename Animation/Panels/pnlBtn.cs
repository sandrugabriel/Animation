using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation.Panels
{
    internal class pnlBtn : Panel
    {
        private Button btnStart;
        private Button btnStop;
        private Button btnRestart;

        Form1 form;

        public pnlBtn(Form1 form1)
        {

            form = form1;

            this.Location = new System.Drawing.Point(1, 350);
            this.Size = new System.Drawing.Size(918, 85);
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Dock = DockStyle.Bottom;

            //BtnStart

            btnStart = new Button();
            this.Controls.Add(btnStart);

            Font font = new Font("Microsoft YaHei UI Light", 20);

            this.btnStart.Location = new System.Drawing.Point(130,28);
            this.btnStart.Text = "Start";
            this.btnStart.Font = font;
            this.btnStart.Size = new System.Drawing.Size(100,50);
            this.btnStart.Click += new EventHandler(btnStart_Click);

            //BtnStop

            btnStop = new Button();
            this.Controls.Add(btnStop);

            this.btnStop.Location = new System.Drawing.Point(330,28);
            this.btnStop.Text = "Stop";
            this.btnStop.Font = font;
            this.btnStop.Size = new System.Drawing.Size (100,50);
            this.btnStop.Click += new EventHandler(btnStop_Click);

            //BtnRestart

            btnRestart = new Button();
            this.Controls.Add(btnRestart);

            this.btnRestart.Location = new System.Drawing.Point(530,28);
            this.btnRestart.Text = "Restart";
            this.btnRestart.Font = font;
            this.btnRestart.Size = new System.Drawing.Size(120, 50);
            this.btnRestart.Click += new EventHandler(btnRestart_Click);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            this.form.timer.Enabled = true;


        }

        private void btnStop_Click(object sender, EventArgs e) { 
        
        
            this.form.timer.Enabled=false;
        
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.form.timer.Enabled = true;
            this.form.pctCars.Location = new Point(20, 97);
            this.form.pctBike.Location = new Point(20, 254);

        }


    }
}
