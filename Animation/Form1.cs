using Animation.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {

        public Timer timer;
        public PictureBox pctCars;
        public PictureBox pctBike;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);

            timer.Enabled = false;

            //Car

            pctCars = new PictureBox();
            this.Controls.Add(pctCars);

            this.pctCars.Location = new Point(27, 97);
            this.pctCars.Size = new Size(100, 70);
            this.pctCars.BackColor = Color.Red;

            string p = Application.StartupPath + @"/images/road.png";

            this.BackgroundImage = Image.FromFile(p);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            string path = Application.StartupPath + @"/images/" + "car.png";

            this.pctCars.Image = Image.FromFile(path);
            this.pctCars.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctCars.BackColor = SystemColors.Window;

            //Bike
            pctBike = new PictureBox();
            this.Controls.Add(pctBike);

            this.pctBike.Location = new Point(41, 254);
            this.pctBike.Size = new Size(100, 70);

            string path1 = Application.StartupPath + @"/images/bike.jpg";

            this.pctBike.Image = Image.FromFile(path1);
            this.pctBike.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(new pnlBtn(this));

        }

        private void timer_Tick(object sender, EventArgs e)
        {



            pctCars.Left += 40;
            pctBike.Left += 35;

            int lung = this.Width - 135;
            
            if(pctCars.Location.X >= lung)
            {   
                timer.Enabled = false;
                MessageBox.Show("The car won","Car",MessageBoxButtons.OK,MessageBoxIcon.Information);
                pctCars.Location = new Point(20, 97);
                pctBike.Location = new Point(20,254);
                
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
