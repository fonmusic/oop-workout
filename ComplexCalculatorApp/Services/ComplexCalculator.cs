namespace ComplexCalculatorApp.Services;

/// <summary>
/// Calculator that can perform operations on complex numbers.
/// </summary>
public class ComplexCalculator : ICalculable
{
    private ComplexNumber _result;

    public ComplexCalculator(ComplexNumber initialValue)
    {
        _result = initialValue;
    }

    /// <summary>
    /// Input method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to input.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Input(ComplexNumber complexNumber)
    {
        _result = complexNumber;
        return this;
    }

    /// <summary>
    /// Add method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to add.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Add(ComplexNumber complexNumber)
    {
        _result += complexNumber;
        return this;
    }
    
    /// <summary>
    /// Subtract method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to subtract.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Subtract(ComplexNumber complexNumber)
    {
        _result -= complexNumber;
        return this;
    }

    /// <summary>
    /// Multiply method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to multiply.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Multiply(ComplexNumber complexNumber)
    {
        _result *= complexNumber;
        return this;
    }
    
    /// <summary>
    /// Divide method for the calculator.
    /// </summary>
    /// <param name="complexNumber">The complex number to divide.</param>
    /// <returns>The calculator.</returns>
    public ICalculable Divide(ComplexNumber complexNumber)
    {
        _result /= complexNumber;
        return this;
    }

    /// <summary>
    /// Gets the result of the calculator.
    /// </summary>
    /// <returns>The result of the calculator.</returns>
    public ComplexNumber GetResult()
    {
        return _result;
    }
}