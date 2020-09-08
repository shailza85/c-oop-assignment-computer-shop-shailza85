using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
   public class Keyboard : Peripheral
    {

        /*
         * Create a “Keyboard” class derived from “Peripheral” with the following:
            A “Type” enumeration of: “Mechanical” or “Membrane”.
            A “ConnectorType” property with a value of the “Connector” enumeration.
            A default and greedy constructor.

         */
       public Type type { get; set; }
        public enum Type
        {
            Mechanical,
            Membrane
        }
        public Connector ConnectorType  { get; set; }
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

        public Keyboard()
        {
            Brand = "Dell";
            ConnectorType = Connector.USBTypeB;
        }
        public Keyboard(string brand, Connector connector)
        {
            Brand = brand;
            ConnectorType = connector;
        }



    }
}
