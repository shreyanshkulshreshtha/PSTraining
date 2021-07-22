using OfficeSystem.Devices;
using OfficeSystem.DeviceController;

namespace DeviceController
{
    public class DeviceOperator
    {
        private static void Main(string[] args)
        {
            DeviceManager _manager = new DeviceManager();
            _manager.Printer = new Printer();
            _manager.Scanner = new Scanner();
            _manager.PrintDocument();
            _manager.ScanDocument();

            PrinterScanner printerScanner = new PrinterScanner();
            _manager.Printer = printerScanner;
            _manager.Scanner = printerScanner;
            _manager.PrintDocument();
            _manager.ScanDocument();
        }
    }
}