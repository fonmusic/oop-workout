namespace ComplexCalculatorApp.Services;

/// <summary>
/// Decorator for the calculator.
/// </summary>
public class LoggerDecorator : ICalculable
{
    private readonly ICalculable _calculator;
    private readonly Logger _logger;

    public LoggerDecorator(ICalculable calculator, Logger logger)
    {
        _calculator = calculator;
        _logger = logger;
    }

    /// <summary>
    ///  Input method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to input.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Input(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nInput method called with parameter {complexNumber}");
        var result = _calculator.Input(complexNumber);
        return result;
    }

    /// <summary>
    /// Add method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to add.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Add(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nAdd method called with parameter {complexNumber}");
        var result = _calculator.Add(complexNumber);
        return result;
    }
    
    /// <summary>
    /// Subtract method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to subtract.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Subtract(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nSubtract method called with parameter {complexNumber}");
        var result = _calculator.Subtract(complexNumber);
        return result;
    }

    /// <summary>
    /// Multiply method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to multiply.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Multiply(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nMultiply method called with parameter {complexNumber}");
        var result = _calculator.Multiply(complexNumber);
        return result;
    }
    
    /// <summary>
    /// Divide method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to divide.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Divide(ComplexNumber complexNumber)
    {
        _logger.Log($"Current value of calculator {_calculator.GetResult()}." +
                   $"\nDivide method called with parameter {complexNumber}");
        var result = _calculator.Divide(complexNumber);
        return result;
    }

    /// <summary>
    /// Gets the result of the calculator.
    /// </summary>
    /// <returns>The result of the calculator.</returns>
    public ComplexNumber GetResult()
    {
        var result = _calculator.GetResult();
        _logger.Log($"GetResult method called. Result: {result}");
        return result;
    }
}