namespace ComplexCalculatorApp;

public class ViewCalculator
{
    private readonly ICalculable _calculator;

    public ViewCalculator(ICalculable calculator)
    {
        _calculator = calculator;
    }

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

    private void PrintResult()
    {
        var result = _calculator.GetResult();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Result: {result}");
        Console.ResetColor();
    }

    private static void Greeting()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to Complex Calculator!\n");
        Console.ResetColor();
    }

    private static ComplexNumber GetComplexNumber()
    {
        var realPart = PromptDouble("Input real part: ");
        var imaginaryPart = PromptDouble("Input imaginary part: ");
        var complexNumber = new ComplexNumber(realPart, imaginaryPart);
        return complexNumber;
    }

    private static string? PromptString(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(message);
        return Console.ReadLine();
    }

    private static double PromptDouble(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(message);
        Console.ResetColor();
        return Convert.ToDouble(Console.ReadLine());
    }
}