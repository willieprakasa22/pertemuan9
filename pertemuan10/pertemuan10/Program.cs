using pertemuan10;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Pilih Printer");
        Console.WriteLine("================");
        Console.WriteLine("1. Epson");
        Console.WriteLine("2. Canon");
        Console.WriteLine("3. LaserJet");

        Console.Write("Nomor Printer [1..3] : ");
        int nomorPrinter = Convert.ToInt32(Console.ReadLine());

        PrinterWindows printerWindows = new PrinterWindows("cbdcbdj", "1100");
        if (nomorPrinter == 1)
        {
            printerWindows = new Epson("Epson", "11*12");
            printerWindows.show();
            printerWindows.print();

        }

        else if (nomorPrinter == 2)
        {
            printerWindows = new Canon("Canon", "10*11");
            printerWindows.show();
            printerWindows.print();
        }

        else if (nomorPrinter == 3)
        {
            printerWindows = new Canon("LaserJet", "9*10");
            printerWindows.show();
            printerWindows.print();
        }

        Console.ReadLine();
    }
}