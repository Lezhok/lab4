internal class Printer
{
    public virtual void Print(string value)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(value);
    }

}

internal class PrinterYellow : Printer
{
    public override void Print(string value)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine(value);
    }
}

internal class PrinterBlue : Printer
{
    public new void Print(string value)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(value);
    }

}

internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new Printer[3];
        arr[0] = new Printer();
        arr[1] = new PrinterYellow();
        arr[2] = new PrinterBlue();

        foreach (Printer r in arr)
        {
            r.Print("Hello");
        }

        ((PrinterBlue)arr[2]).Print("ad");
    }

}