using System;
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
        private BrainReader bRdr = new BrainReader();
        private FFT_Analyzer fft = new FFT_Analyzer();
        private List<List<float>> dataChunk = new List<List<float>>();

        public Form1()
        {
            InitializeComponent();
            resetDataChunk();
        }

        public override void Refresh()
        { 
            base.Refresh();
        }

        void resetDataChunk()
        {
            if (dataChunk.Count > 0)
            {
                for (int i = 0; i < dataChunk.Count; i++)
                {
                    fft.doFFT(dataChunk[i]);
                }
            }

            dataChunk.Clear();

            for (int i = 0; i < 17; i++)
                dataChunk.Add(new List<float>());
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
            bRdr = new BrainReader();
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

        private void Timer5_Tick(object sender, EventArgs e)
        {
            outputBox.Text = "";

            //TICK REFRESH
            for (int i = 0; i < bRdr.currentDataBuffer.Length; i++)
            {
                dataChunk[i].Add(bRdr.currentDataBuffer[i]);
                outputBox.Text += "Channel " + i.ToString() + ": " + bRdr.currentDataBuffer[i] + "\n";
            }
        }

        private void Ch1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ChunkTimer_Tick(object sender, EventArgs e)
        {
            resetDataChunk();
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
