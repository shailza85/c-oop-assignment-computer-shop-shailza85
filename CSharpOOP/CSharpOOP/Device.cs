using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpOOP
{

    /*
     *Create an abstract “Device” class with the following:
        A “Brand” property
        A “CPU” property (reference to “CPU” object)
        A “Memory” property (a list of “Memory” objects)
        A “Connectors” property (a read-only dictionary keyed with values of the Connector enumeration and valued with ints to represent the number of connections available)
        A “Peripherals” property (a polymorphic list of Peripheral objects), private
      */
    public abstract class Device
    {
        public string Brand { get; set; }

        public CPU Cpu { get; set; }

        public List<Memory> Memory { get; set; }
        protected IReadOnlyDictionary<Connector, int> Connectors { get; }
        private List<Peripheral> Peripherals { get; set; }

        /*Create a public “Connector” enumeration of “USBTypeA”, 
        * “USBTypeB”, “USBTypeC”, “MiniUSB”, “MicroUSB”, “DisplayPort” 
        * and “Integrated”.
        * */
        public Connector connector { get; set; }
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

        public Device()
        {
            Connectors = new Dictionary<Connector, int>
            {
                { Connector.USBTypeA,0 },
                { Connector.USBTypeB,1 },
                { Connector.USBTypeC,2 },
                { Connector.MiniUSB,3 },
                { Connector.MicroUSB,4 },
                { Connector.DisplayPort,5 },
                { Connector.Integrated,6 }
        };
            }
        
        //Create your dictionary in the constructor as a normal dictionary, then feed it into the constructor of ReadOnlyDictionary.

        /*
         * A “ConnectPeripheral()” method that accepts a polymorphic peripheral argument and:
            Throws an exception if there are no available connectors of the connection-type of the peripheral.
            Unless the type is “Integrated”.
            Otherwise, adds the peripheral to the list.
            
               */


        //For the “ConnectPeripheral()” method, the Aug31Practice branch has an example of adding to a polymorphic list.
        //It will require some validation as well.

        Type t = Connector.Integrated.GetType();
        public void ConnectPeripheral(Peripheral peripheral)
        {
            if (Connectors==null || Connectors.GetType()!= t)
            {
                throw new Exception("No available connectors of the connection-type of the peripheral!");
                
            }
            else
            {
                Peripherals.Add(peripheral);
            }

        }

       // A “DisconnectPeripheral()” method that accepts a type of peripheral, 
        //and will disconnect all connected peripherals of that type.
           

        //For the “RemovePeripheral()” method, you could try using a Where() with a clause 
        //checking for type not equal to the type to remove
        //(see Sept03Practice commit “SpaceCovered and LinesDrawn;”, Drawing.cs).

        public void DisconnectPeripheral(Peripheral peripheral)
        {
            if (Peripherals != null)
            {
                var toRemove = Peripherals.Where(x => typeof(Connector) == typeof(Connector)).ToList();

                foreach (var item in toRemove)
                    Peripherals.Remove(item);
            }


        }
        // An abstract “StartUp()” method that will be overridden in each derived class, 
        // with some functionality of your choice.Write something to the console, make the computer beep, whatever you’d like.

        public abstract void StartUp();
        
    }
}
