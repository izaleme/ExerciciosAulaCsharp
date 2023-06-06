using System;

namespace MultipleInheritance.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("CombDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("CombDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
