using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
   public class Mouse : Peripheral
    {
        /*
         * Create a “Mouse” class derived from “Peripheral” with the following:
        A “ButtonCount” property (int).
        A “ConnectorType” with a value of the “Connector” enumeration.
        A default and greedy constructor.

         */

        public int ButtonCount { get; set; }

        public Connector ConnectorType { get; set; }
        public enum Connector
        {
            USBTypeA,
            USBTypeB,
            USBTypeC,
            MiniUSB,
            MicroUSB,
            DisplayPort,
            Integrated
        }


        public Mouse()
        {
            Brand = "Dell";
            ConnectorType = Connector.USBTypeB;
            ButtonCount = 52;
        }
        public Mouse(string brand, Connector connector, int buttonCount)
        {
            Brand = brand;
            ConnectorType = connector;
            ButtonCount = buttonCount;
        }

    }
}
