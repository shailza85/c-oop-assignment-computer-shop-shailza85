using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Desktop : Device
    {
        /*
         * Create a “Desktop” class derived from “Device” with the following:
            A default and greedy constructor.
         * 
         */

        public Desktop()
        {
            Brand = "HP";
            Cpu = new CPU();
            Memory = new List<Memory>();
        }

        public Desktop(string brand, CPU cpu)
        {
            Brand = brand;
            Cpu = cpu;
        }

        public override void StartUp()
        {
            Console.WriteLine("beep!");
        }
    }
}
