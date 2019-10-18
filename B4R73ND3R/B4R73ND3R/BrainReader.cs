using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtec.Unicorn;
using System.Runtime.InteropServices;
using System.IO;

class BrainReader
{
    // Specifications for the data acquisition.
    //-------------------------------------------------------------------------------------
    const bool TestSignalEnabled = false;
    const uint FrameLength = 1;
    const uint AcquisitionDurationInSeconds = 10;
    const string DataFile = "data.bin";

    // VARIABLES 
    private Unicorn device;
    private uint numberOfAcquiredChannels;
    private Unicorn.AmplifierConfiguration configuration;
    private ushort samplingRate;

    public float[] currentDataBuffer;

    public IList<string> getAllDevices()
    {
        return Unicorn.GetAvailableDevices(true);
    }

    public void assignDevice(string serial)
    {
        device = new Unicorn(serial);
    }

    public void initAcquisitionMembers()
    {
        numberOfAcquiredChannels = device.GetNumberOfAcquiredChannels();
        configuration = device.GetConfiguration();
        samplingRate = Unicorn.SamplingRate;
    }

    public void Read()
    {
        // Allocate memory for the acquisition buffer.
        byte[] receiveBuffer = new byte[FrameLength * sizeof(float) * numberOfAcquiredChannels];
        GCHandle receiveBufferHandle = GCHandle.Alloc(receiveBuffer, GCHandleType.Pinned);
        currentDataBuffer = new float[receiveBuffer.Length / sizeof(float)];

        try
        {
            // Start data acquisition.
            //-------------------------------------------------------------------------------------
            device.StartAcquisition(TestSignalEnabled);
            Console.WriteLine("Data acquisition started.");

            // Acquisition loop.
            //-------------------------------------------------------------------------------------
            while(true)
            {
                // Receives the configured number of samples from the Unicorn device and writes it to the acquisition buffer.
                device.GetData(FrameLength, receiveBufferHandle.AddrOfPinnedObject(), (uint)(receiveBuffer.Length / sizeof(float)));

                int numberOfBytesReceived = receiveBuffer.Length;
                if (numberOfBytesReceived > 0)
                {
                    //convert byte array to float array
                    for (int i = 0; i < numberOfBytesReceived / sizeof(float); i++)
                    {
                        currentDataBuffer[i] = BitConverter.ToSingle(receiveBuffer, i * sizeof(float));
                    }
                }
            }

            // Stop data acquisition.
            //-------------------------------------------------------------------------------------
            device.StopAcquisition();
            Console.WriteLine();
            Console.WriteLine("Data acquisition stopped.");
        }
        catch (DeviceException ex)
        {
            // Write error message to console if something goes wrong.
            PrintExceptionMessage(ex);
        }
    }

    /// <summary>
    /// This Method writes an error message to the console if a <see cref="DeviceException"/> was caught.
    /// </summary>
    /// <param name="ex">The caught exception</param>
    void PrintExceptionMessage(DeviceException ex)
    {
        Console.WriteLine(String.Format("An error occured. Error Code: {0} - {1}", ex.ErrorCode, ex.Message));
    }
}