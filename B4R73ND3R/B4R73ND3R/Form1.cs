using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<List<float>> dataChunk = new List<List<float>>();
        private double[] peakFrequencies = new double[17];
        private DateTime lastTime;
        private UdpReceiver udp = new UdpReceiver();
        ArduinoComands arduino = new ArduinoComands();

        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            udp.DataReceivedEvent += GetUdpPackage;
            Thread thread = new Thread(udp.receivePacket);
            thread.Start();
        }

        private void GetUdpPackage(object sender,ReceivedDataArgs args)
        {
            Console.WriteLine("UDP received from: "+args.ipAdd+":"+args.port+" Message said: "+ (args.receivedItem.Name));
        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Ch1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ChunkTimer_Tick(object sender, EventArgs e)
        {
            //resetDataChunk();
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
