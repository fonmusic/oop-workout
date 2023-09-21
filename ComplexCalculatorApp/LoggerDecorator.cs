namespace ComplexCalculatorApp;

public class LoggerDecorator : ICalculable
{
    private readonly ICalculable _calculator;
    private readonly Logger _logger;

    public LoggerDecorator(ICalculable calculator, Logger logger)
    {
        _calculator = calculator;
        _logger = logger;
    }

    public ICalculable Input(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nInput method called with parameter {complexNumber}");
        var result = _calculator.Input(complexNumber);
        return result;
    }

    public ICalculable Add(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nAdd method called with parameter {complexNumber}");
        var result = _calculator.Add(complexNumber);
        return result;
    }
    
    public ICalculable Subtract(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nSubtract method called with parameter {complexNumber}");
        var result = _calculator.Subtract(complexNumber);
        return result;
    }

    public ICalculable Multiply(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nMultiply method called with parameter {complexNumber}");
        var result = _calculator.Multiply(complexNumber);
        return result;
    }
    
    public ICalculable Divide(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nDivide method called with parameter {complexNumber}");
        var result = _calculator.Divide(complexNumber);
        return result;
    }

    public ComplexNumber GetResult()
    {
        var result = _calculator.GetResult();
        _logger.Log($"GetResult method called. Result: {result}");
        return result;
    }
}