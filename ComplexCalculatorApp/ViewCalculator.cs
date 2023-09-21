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
        while (true)
        {
            var realPart = PromptDouble("Input real part: ");
            var imaginaryPart = PromptDouble("Input imaginary part: ");
            var complexNumber = new ComplexNumber(realPart, imaginaryPart);

            _calculator.Input(complexNumber);

            while (true)
            {
                var cmd = PromptString("Input command (*, -, +, /, =): ");
                switch (cmd)
                {
                    case "*":
                    {
                        realPart = PromptDouble("Input real part: ");
                        imaginaryPart = PromptDouble("Input imaginary part: ");
                        var complexMultiplier = new ComplexNumber(realPart, imaginaryPart);
                        _calculator.Multiply(complexMultiplier);
                        continue;
                    }
                    case "-":
                    {
                        realPart = PromptDouble("Input real part: ");
                        imaginaryPart = PromptDouble("Input imaginary part: ");
                        var complexSubtraction = new ComplexNumber(realPart, imaginaryPart);
                        _calculator.Subtract(complexSubtraction);
                        continue;
                    }
                    case "+":
                    {
                        realPart = PromptDouble("Input real part: ");
                        imaginaryPart = PromptDouble("Input imaginary part: ");
                        var complexAddition = new ComplexNumber(realPart, imaginaryPart);
                        _calculator.Add(complexAddition);
                        continue;
                    }
                    case "/":
                    {
                        realPart = PromptDouble("Input real part: ");
                        imaginaryPart = PromptDouble("Input imaginary part: ");
                        var complexDivision = new ComplexNumber(realPart, imaginaryPart);
                        _calculator.Divide(complexDivision);
                        continue;
                    }
                }

                if (cmd != "=") continue;
                var result = _calculator.GetResult();
                Console.WriteLine($"Result: {result}");
                break;
            }

            var continueCmd = PromptString("Continue? (Y/N): ");
            if (continueCmd?.ToUpper() != "Y")
            {
                break;
            }
        }
    }

    private static string? PromptString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    private static double PromptDouble(string message)
    {
        Console.Write(message);
        return Convert.ToDouble(Console.ReadLine());
    }
}