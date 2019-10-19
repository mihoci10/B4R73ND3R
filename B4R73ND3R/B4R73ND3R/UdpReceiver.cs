using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Intendix.Board;
using Extendix.ItemReceiver;

namespace B4R73ND3R
{
    class UdpReceiver
    {
        public void receivePacket()
        {
            UdpClient listener = new UdpClient(1000);

            IPEndPoint serverIP = new IPEndPoint(IPAddress.Any, 1000);

            while (true)
            {
                byte[] data = listener.Receive(ref serverIP);
                Console.WriteLine("Data received");
                RaiseDataReceived(new ReceivedDataArgs(serverIP.Address, serverIP.Port, data));
            }
        }

        public delegate void DataReceived(object sender, ReceivedDataArgs args);

        public event DataReceived DataReceivedEvent;

        private void RaiseDataReceived(ReceivedDataArgs args)
        {
            if (DataReceivedEvent != null)
            {
                DataReceivedEvent(this, args);
            }
        }
    }

    public class ReceivedDataArgs
    {
        public IPAddress ipAdd { get; set; }
        public int port { get; set; }
        public BoardItem receivedItem;

        public ReceivedDataArgs(IPAddress ip, int p, byte[] data)
        {
            this.ipAdd = ip;
            this.port = port;

            MemoryStream memoryStream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Binder = new IndependendAssemblyDeserializationBinder();
            memoryStream.Position = 0;

            BoardItem rec = (BoardItem)formatter.Deserialize(memoryStream);

            this.receivedItem = rec;
        }

    }
}
