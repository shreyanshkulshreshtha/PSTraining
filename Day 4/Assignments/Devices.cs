using System;

namespace OfficeSystem.Devices
{
    public interface IPrinter
    {
        void Print()
        {
            Console.WriteLine("Printing Document");
        }
    }

    public interface IScanner
    {
        void Scan()
        {
            Console.WriteLine("Scanning Document");
        }
    }

    public class Printer : IPrinter { }
    public class Scanner : IScanner { }
    public class PrinterScanner : IPrinter, IScanner { }
}