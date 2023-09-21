namespace ComplexCalculatorApp;

public class Logger
{
    public void Log(string line)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(line);
        Console.ResetColor();
    }
}