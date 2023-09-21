namespace ComplexCalculatorApp.Views;

/// <summary>
/// View for the calculator.
/// </summary>
public class ViewCalculator
{
    private readonly ICalculable _calculator;

    public ViewCalculator(ICalculable calculator)
    {
        _calculator = calculator;
    }

    /// <summary>
    /// Runs the interface for the calculator.
    /// </summary>
    public void Run()
    {
        Greeting();
        while (true)
        {
            _calculator.Input(GetComplexNumber());
            while (true)
            {
                var cmd = PromptString("Input command (*, -, +, /, =): ");
                switch (cmd)
                {
                    case "*":
                    {
                        _calculator.Multiply(GetComplexNumber());
                        continue;
                    }
                    case "-":
                    {
                        _calculator.Subtract(GetComplexNumber());
                        continue;
                    }
                    case "+":
                    {
                        _calculator.Add(GetComplexNumber());
                        continue;
                    }
                    case "/":
                    {
                        _calculator.Divide(GetComplexNumber());
                        continue;
                    }
                }

                if (cmd != "=") continue;
                PrintResult();
                break;
            }

            var continueCmd = PromptString("Continue? (Y/N): ");
            if (continueCmd?.ToUpper() != "Y")
            {
                break;
            }
        }
    }

    /// <summary>
    /// Prints the result of the calculator.
    /// </summary>
    private void PrintResult()
    {
        var result = _calculator.GetResult();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Result: {result}");
        Console.ResetColor();
    }

    /// <summary>
    /// Prints the greeting for the calculator.
    /// </summary>
    private static void Greeting()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to Complex Calculator!\n");
        Console.ResetColor();
    }

    /// <summary>
    /// Prompts the user for a complex number.
    /// </summary>
    /// <returns>The complex number.</returns>
    private static ComplexNumber GetComplexNumber()
    {
        var realPart = PromptDouble("Input real part: ");
        var imaginaryPart = PromptDouble("Input imaginary part: ");
        var complexNumber = new ComplexNumber(realPart, imaginaryPart);
        return complexNumber;
    }

    /// <summary>
    /// Prompts the user for a string.
    /// </summary>
    /// <param name="message">The message to prompt the user with.</param>
    /// <returns>The string.</returns>
    private static string? PromptString(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(message);
        return Console.ReadLine();
    }

    /// <summary>
    /// Prompts the user for a double.
    /// </summary>
    /// <param name="message">The message to prompt the user with.</param>
    /// <returns></returns>
    private static double PromptDouble(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(message);
        Console.ResetColor();
        return Convert.ToDouble(Console.ReadLine());
    }
}