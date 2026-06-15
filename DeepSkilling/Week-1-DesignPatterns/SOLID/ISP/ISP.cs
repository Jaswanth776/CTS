using System;

interface IPrinter
{
    void Print();
}

interface IScanner
{
    void Scan();
}

class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing document");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document");
    }
}

class BasicPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing document");
    }
}

class ISP
{
    static void Main()
    {
        BasicPrinter printer = new BasicPrinter();
        printer.Print();

        MultiFunctionPrinter device =
            new MultiFunctionPrinter();

        device.Print();
        device.Scan();
    }
}
