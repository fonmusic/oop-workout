namespace ComplexCalculatorApp.Models;

/// <summary>
/// Logger for the calculator.
/// </summary>
public class Logger
{
    /// <summary>
    /// Logs a line to the console.
    /// </summary>
    /// <param name="line">The line to log.</param>
    public void Log(string line)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(line);
        Console.ResetColor();
    }
}