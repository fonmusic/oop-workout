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
        _logger.Log("Input method called");
        return result;
    }

    public ICalculable Add(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nAdd method called with parameter {complexNumber}");
        var result = _calculator.Add(complexNumber);
        _logger.Log("Add method called");
        return result;
    }
    
    public ICalculable Subtract(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nSubtract method called with parameter {complexNumber}");
        var result = _calculator.Subtract(complexNumber);
        _logger.Log("Subtract method called");
        return result;
    }

    public ICalculable Multiply(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nMultiply method called with parameter {complexNumber}");
        var result = _calculator.Multiply(complexNumber);
        _logger.Log("Multiply method called");
        return result;
    }
    
    public ICalculable Divide(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nDivide method called with parameter {complexNumber}");
        var result = _calculator.Divide(complexNumber);
        _logger.Log("Divide method called");
        return result;
    }

    public ComplexNumber GetResult()
    {
        var result = _calculator.GetResult();
        _logger.Log($"GetResult method called. Result: {result}");
        return result;
    }
}