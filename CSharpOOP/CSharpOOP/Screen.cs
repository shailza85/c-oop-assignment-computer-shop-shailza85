using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
   public class Screen : Peripheral
    {
        /*
         * Create a “Screen” class derived from “Peripheral” with the following:
            A “Width” property, in whole pixels (int).
            A “Height” property, in whole pixels (int).
            A “ConnectorType” with a value of the “Connector” enumeration.
            A default and greedy constructor.

         */
        public int Width { get; set; }

        public int Height { get; set; }

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
        public Screen()
        {
            Brand = "Dell";
            ConnectorType = Connector.USBTypeB;
            Height = 50;
            Width = 50;


        }
        public Screen(string brand, Connector connector, int buttonCount, int height, int width)
        {
            Brand = brand;
            ConnectorType = connector;
            Height = height;
            Width = width;
        }


    }
}
