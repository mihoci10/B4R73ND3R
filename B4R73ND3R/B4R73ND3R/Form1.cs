﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gtec.Unicorn;

namespace B4R73ND3R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public override void Refresh()
        { 
            base.Refresh();
        }


        Color red = Color.Red;
        Color bg = Color.Transparent;
        bool pic1 = false, pic2 = false, pic3 = false, pic4 = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic1) pictureBox1.BackColor = red;
            else pictureBox1.BackColor = bg;
            pic1 = !pic1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            timer2.Start();
            timer2.Enabled = true;
            timer3.Start();
            timer3.Enabled = true;
            timer4.Start();
            timer4.Enabled = true;

            //DEBUG READER
            BrainReader bRdr = new BrainReader();
            IList<string> devices = bRdr.getAllDevices();

            if (devices.Count > 0)
            {
                bRdr.assignDevice(devices[0]);
                bRdr.initAcquisitionMembers();

                Thread worker = new Thread(bRdr.Read);
                worker.IsBackground = true;
                worker.SetApartmentState(ApartmentState.STA);
                worker.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pic2) pictureBox2.BackColor = red;
            else pictureBox2.BackColor = bg;
            pic2 = !pic2;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pic3) pictureBox3.BackColor = red;
            else pictureBox3.BackColor = bg;
            pic3 = !pic3;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pic4) pictureBox4.BackColor = red;
            else pictureBox4.BackColor = bg;
            pic4 = !pic4;
        }
    }
}
