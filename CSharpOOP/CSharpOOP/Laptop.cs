using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Laptop : Device
    {
        /*
         * Create a “Laptop” class derived from “Device” with the following:
            A “Screen” property that must have a “Screen” object with the “Integrated” connector type assigned.
            A “Keyboard” property that must have a “Keyboard” object with the “Integrated” connector type assigned.
            A default and greedy constructor.
         */

        public Screen Screen {

            get
            {
                return Screen;
            }
            set
            {
                Screen.ConnectorType = (Screen.Connector)Connector.Integrated;
            }
        }
        public int Keyboard { get; set; }

        public Laptop()
        {
           //Screen.ConnectorType = (Screen.Connector)Connector.Integrated;


        }

        public Laptop(Screen screen, int keyboard)
        {
            Screen = screen;
            Keyboard = keyboard;
        }

        public override void StartUp()
        {
            Console.Beep();
        }
    }
}
