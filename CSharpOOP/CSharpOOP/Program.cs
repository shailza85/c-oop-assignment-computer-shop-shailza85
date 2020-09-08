using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cellphone myCellPhone = new Cellphone();
            myCellPhone.ConnectPeripheral(new Mouse("hp", Mouse.Connector.USBTypeA, 34));
            Console.WriteLine(myCellPhone);



        }
    }
}
