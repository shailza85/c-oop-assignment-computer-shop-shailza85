using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Cellphone : Device
    {
        /*
         * Create a “CellPhone” class derived from “Device” with the following:
            A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.
            A default and greedy constructor.

         */

        public Screen Screen
        {
            get
            {
                 return Screen;
            }
            set
            {
                Screen.ConnectorType = (Screen.Connector)Connector.Integrated;
            }
        }
        public Cellphone()
        {
            Brand = "Apple";
            //Screen.ConnectorType = (Screen.Connector)Connector.Integrated;
        }

        public Cellphone(string brand, CPU cpu, Memory memory, Screen screen)
        {
            Brand = brand;
            //Cpu = cpu;
            Memory = new List<Memory>();
            Screen = screen;

        }
        public override void StartUp()
        {
            Console.WriteLine("beep!");
        }
    }
}
