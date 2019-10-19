using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gtec.Unicorn;
using Gtec.ArduinoComands;

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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void close_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void Header_MouseMove_1(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        ArduinoComands arduino = new ArduinoComands();

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void GlobalTimer_Tick(object sender, EventArgs e)
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

        Color red = Color.Red;
        Color bg = Color.Transparent;
        bool pic1 = false, pic2 = false, pic3 = false, pic4 = false, pic5 = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic1) gin1tonic5.BackColor = red;
            else gin1tonic5.BackColor = bg;
            pic1 = !pic1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu.Show();
        }

        bool connected = false;
        private void connect_Click(object sender, EventArgs e)
        {
            if (!connected) connected = arduino.Connect(comboBox1.Text);
            else connected = arduino.Disconnect();
            if (connected) { 
                connect.Text = "DISCONNECT";
                connect.BackColor = Color.Red;
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
            }
            else
            {
                connect.Text = "CONNECT";
                connect.BackColor = Color.LimeGreen;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                gin1tonic5.BackColor = bg; 
                gin1tonic3.BackColor = bg;
                gin1tonic1.BackColor = bg;
                random.BackColor = bg;
                mood.BackColor = bg;
            }
            timer1.Enabled = connected;
            timer2.Enabled = connected;
            timer3.Enabled = connected;
            timer4.Enabled = connected;
            timer5.Enabled = connected;

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string a in arduino.GetAvailableComPorts())
            {
                comboBox1.Items.Add(a);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pic2) gin1tonic3.BackColor = red;
            else gin1tonic3.BackColor = bg;
            pic2 = !pic2;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pic3) gin1tonic1.BackColor = red;
            else gin1tonic1.BackColor = bg;
            pic3 = !pic3;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pic4) random.BackColor = red;
            else random.BackColor = bg;
            pic4 = !pic4;
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pic5) mood.BackColor = red;
            else mood.BackColor = bg;
            pic5 = !pic5;
        }
    }
}
