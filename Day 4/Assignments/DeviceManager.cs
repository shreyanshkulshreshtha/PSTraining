using OfficeSystem.Devices;

namespace OfficeSystem.DeviceController
{
    public class DeviceManager
    {
        private IPrinter _printer;
        private IScanner _scanner;

        public IPrinter Printer
        {
            get { return _printer; }
            set { this._printer = value; }
        }

        public IScanner Scanner
        {
            get { return _scanner; }
            set { this._scanner = value; }
        }

        public DeviceManager() { }
        public DeviceManager(IPrinter printer, IScanner scanner)
        {
            this._printer = printer;
            this._scanner = scanner;
        }

        public void PrintDocument()
        {
            this._printer.Print();
        }

        public void ScanDocument()
        {
            this._scanner.Scan();
        }
    }
}