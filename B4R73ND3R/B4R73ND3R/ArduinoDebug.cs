using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Gtec.ArduinoComands;


public class ArduinoDebug
{
    public void Debug()
    {
        ArduinoComands arduino = new ArduinoComands();
        arduino.Connect("COM4");
        arduino.Pump(1, 3000);
    }
}
