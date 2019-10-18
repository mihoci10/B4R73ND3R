using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtec.Unicorn;

namespace B4R73ND3R
{
    class BrainReader
    {

        //  VARIABLES
        private Unicorn device;
        private uint numberOfAcquiredChannels;
        private Unicorn.AmplifierConfiguration configuration;
        private ushort samplingRate;

        public IList<string> GetDeviceList()
        {
            return Unicorn.GetAvailableDevices(true);
        }

        public void ConnectDevice(string serial)
        {
            device = new Unicorn(serial);
        }

        void InitAcquisitionMembers()
        {
            numberOfAcquiredChannels = device.GetNumberOfAcquiredChannels();
            configuration = device.GetConfiguration();
            samplingRate = Unicorn.SamplingRate;

            Console.WriteLine("Acquisition Configuration: ");
            Console.WriteLine("Sampling Rate: " + samplingRate + "Hz");
            Console.WriteLine("Number Of Acquired Channels: " + numberOfAcquiredChannels);
            Console.WriteLine();
        }

        void ReadData()
        {
            try
            {
                // Start data acquisition.
                //-------------------------------------------------------------------------------------
                device.StartAcquisition(TestsignaleEnabled);
                Console.WriteLine("Data acquisition started.");

                // Calculate number of get data calls.
                uint numberOfGetDataCalls = AcquisitionDurationInSeconds * samplingRate / FrameLength;

                // Limit console update rate to max. 25Hz or slower to prevent acquisition timing issues.                   
                int consoleUpdateRate = (int)((samplingRate / FrameLength) / 25.0f);
                if (consoleUpdateRate == 0)
                    consoleUpdateRate = 1;

                using (BinaryWriter fileWriter = new BinaryWriter(File.Open(DataFile, FileMode.Create)))
                {
                    // Acquisition loop.
                    //-------------------------------------------------------------------------------------
                    for (uint i = 0; i < numberOfGetDataCalls; i++)
                    {
                        // Receives the configured number of samples from the Unicorn device and writes it to the acquisition buffer.
                        device.GetData(FrameLength, receiveBufferHandle.AddrOfPinnedObject(), (uint)(receiveBuffer.Length / sizeof(float)));

                        // Write data to file.
                        fileWriter.Write(receiveBuffer, 0, (int)(FrameLength * numberOfAcquiredChannels * sizeof(float)));

                        // Update console to indicate that the data acquisition is running.
                        if (i % consoleUpdateRate == 0)
                            Console.Write(".");
                    }
                }

                // Stop data acquisition.
                //-------------------------------------------------------------------------------------
                device.StopAcquisition();
                Console.WriteLine();
                Console.WriteLine("Data acquisition stopped.");
            }
        }
    }
}
