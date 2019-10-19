using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gtec.ArduinoComands
{
    /// <summary>
    /// Provides the functionallity to interact with the Arduino Smart Home environment.
    /// </summary>
    public class ArduinoComands
    {
        #region Properties...

        /// <summary>
        /// The connection state.
        /// </summary>
        public bool Connected
        {
            get { return _connected; }
        }

        /// <summary>
        /// Returns an array of one based channel indices supporting pwm.
        /// </summary>
        public static int[] Channels
        {
            get { return new int[] { 3, 11 }; }
        }

        #endregion

        #region Enumerations

        /// <summary>
        /// Available IO states.
        /// </summary>
        public enum IOstates
        {
            High, Low
        }

        /// <summary>
        /// Available commands-
        /// </summary>
        public enum Commands
        {
            Test
        }

        #endregion

        #region Private Members...

        /// <summary>
        /// The current connection state.
        /// </summary>
        private bool _connected;

        /// <summary>
        /// The serial port object.
        /// </summary>
        private SerialPort _serialPort;

        /// <summary>
        /// The response if a command has been sent and received successfully.
        /// </summary>
        private const string ResponseOK = "CMD OK\n";

        /// <summary>
        /// The timeout timespan in millisecond to receive responses.
        /// </summary>
        private int ResponseTimeoutMs = 2000;

        #endregion

        /// <summary>
        /// Creates a new instance of <see cref="ArduinoGinTonic"/> 
        /// </summary>
        public ArduinoComands()
        {
            _connected = false;
            _serialPort = null;
        }

        /// <summary>
        /// Determines number of available COM ports and returns a list with availble COM Port names.
        /// </summary>
        /// <returns>Available COM Ports as a list of strings.</returns>
        public List<string> GetAvailableComPorts()
        {
            return new List<string>(SerialPort.GetPortNames());
        }

        /// <summary>
        /// Connects to a <see cref="ArduinoGinTonic"/> device.
        /// </summary>
        /// <param name="comPort">The COM port to connect to.</param>
        public bool Connect(string comPort)
        {
            if (comPort == null)
                throw new NullReferenceException("Invalid input.");

            if (comPort.StartsWith("COM") == false && comPort.StartsWith("com") == false)
                throw new ArgumentException("Invalid input.");

            try
            {
                //Open Com Port
                _serialPort = new SerialPort(comPort);
                _serialPort.BaudRate = 9600;
                _serialPort.ReadTimeout = 1;
                _serialPort.Open();

                //wait until serial port is ready
                Thread.Sleep(3000);

                //Validate that the correct hardware is connected
                _serialPort.Write(FormCommand(Commands.Test));

                //Acquire response
                string response = GetResponse(ResponseTimeoutMs);

                //validate response
                if (!response.Equals(ResponseOK))
                    throw new Exception(response);

                //turn motors off
                SetDigitalIO(Channels[0], IOstates.Low);
                SetDigitalIO(Channels[1], IOstates.Low);

                //enable motors
                for (int i = 1; i < 14; i++)
                {
                    SetDigitalIO(i, IOstates.Low);
                }
                /*SetDigitalIO(8, IOstates.Low);
                SetDigitalIO(9, IOstates.Low);*/

                _connected = true;
            }
            catch
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();

                _connected = false;

                throw new System.IO.IOException("Could not open device");
            }
            return _connected;
        }

        /// <summary>
        /// Disconnects from a <see cref="ArduinoGinTonic"/> device. 
        /// </summary>
        public bool Disconnect()
        {
            //if connected
            if (_connected || _serialPort != null)
            {
                //Try to clear buffers
                try
                {
                    _serialPort.DiscardOutBuffer();
                    _serialPort.DiscardInBuffer();
                }
                catch
                {
                    //Do nothing
                }
                //Try to close the port
                try
                {
                    if (_serialPort.IsOpen)
                    {
                        _serialPort.Close();
                    }
                }
                //reset variables
                finally
                {
                    _connected = false;
                    _serialPort = null;
                }
            }
            return _connected;
        }

        /// <summary>
        /// Set a single channel to an available io state.
        /// </summary>
        /// <param name="channel">One based channel index to configure.</param>
        /// <param name="state">The <see cref="IOstates"/> to set.</param>
        public void SetDigitalIO(int channel, IOstates state)
        {
            //form command
            string cmd = FormCommand(channel, state);

            //send command
            Send(cmd);
        }

        /// <summary>
        /// Sets all digital IOs to an available io state.
        /// </summary>
        /// <param name="state">The <see cref="IOstates"/> to set.</param>
        public void SetDigitalIO(IOstates state)
        {
            SetDigitalIO(Channels[0], state);
            SetDigitalIO(Channels[1], state);
        }

        /// <summary>
        /// Enable PWM output for a channel.
        /// </summary>
        /// <param name="channel">One based channel index to configure.</param>
        /// <param name="pwmValue">The pwm duty cycle to set. Values between 0 and 255 are valid.</param>
        public void SetDigitalIO(int channel, int pwmValue)
        {
            //form command
            string cmd = FormCommand(channel, pwmValue);

            //send command
            Send(cmd);
        }

        #region Private methods...

        private void Send(string cmd)
        {
            //write command
            _serialPort.Write(cmd);

            //Acquire response
            string response = GetResponse(ResponseTimeoutMs);

            //validate response
            if (!response.Equals(ResponseOK))
                throw new Exception(response);
        }

        private static string FormCommand(Commands command)
        {
            if (command == Commands.Test)
                return "C_TEST\n";
            else
                throw new ArgumentException("Unknown command.");
        }

        private static string FormCommand(IOstates ioState)
        {
            if (ioState == IOstates.High)
                return "C_ALL_HIGH\n";
            else
                return "C_ALL_LOW\n";
        }

        private static string FormCommand(int channel, IOstates ioState)
        {
            if (ioState == IOstates.High)
                return String.Format("C_DIG{0}_HIGH\n", channel.ToString());
            else
                return String.Format("C_DIG{0}_LOW\n", channel.ToString());
        }

        private static string FormCommand(int channel, int pwmValue)
        {
            return String.Format("C_DIG{0}_PWM{1}\n", channel.ToString(), pwmValue.ToString());
        }

        private string GetResponse(int timeout)
        {
            string response = "";

            if (_serialPort == null)
                throw new NullReferenceException("No device connected.");

            Stopwatch stopWatch = new Stopwatch();

            try
            {
                stopWatch.Start();

                //Check if end of response is received
                while (!response.EndsWith("\n"))
                {
                    int bytesToRead = _serialPort.BytesToRead;
                    //check if bytes are available to receive
                    if (bytesToRead > 0)
                    {
                        //read response
                        byte[] receiveBuf = new byte[bytesToRead];
                        _serialPort.Read(receiveBuf, 0, bytesToRead);

                        //append response
                        response = response + Encoding.Default.GetString(receiveBuf);
                    }

                    if (stopWatch.ElapsedMilliseconds >= ResponseTimeoutMs)
                        throw new TimeoutException("Request timed out.");
                }
            }
            catch (Exception ex)
            {
                stopWatch.Stop();
                stopWatch.Reset();

                throw new Exception(ex.Message);
            }

            //return response message
            return response;
        }

        #endregion

        public void Pump(int StT, int StG)
        {
            if (StG > StT)
            {
                SetDigitalIO(3, 255);
                SetDigitalIO(11, 255);
                //timer StT
                SetDigitalIO(3, 0);
                //Timer StG
                SetDigitalIO(11, 0);
            }
            else
            {
                SetDigitalIO(3, 255);
                SetDigitalIO(11, 255);
                //timer StG
                SetDigitalIO(11, 0);
                //Timer StT
                SetDigitalIO(3, 0);
            }

            
        }
    }
}
