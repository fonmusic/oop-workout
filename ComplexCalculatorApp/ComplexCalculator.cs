namespace ComplexCalculatorApp;

public class ComplexCalculator : ICalculable
{
    private ComplexNumber _result;

    public ComplexCalculator(ComplexNumber initialValue)
    {
        _result = initialValue;
    }

    public ICalculable Input(ComplexNumber complexNumber)
    {
        _result = complexNumber;
        return this;
    }

    public ICalculable Add(ComplexNumber complexNumber)
    {
        _result += complexNumber;
        return this;
    }
    
    public ICalculable Subtract(ComplexNumber complexNumber)
    {
        _result -= complexNumber;
        return this;
    }

    public ICalculable Multiply(ComplexNumber complexNumber)
    {
        _result = _result * complexNumber;
        return this;
    }
    
    public ICalculable Divide(ComplexNumber complexNumber)
    {
        _result = _result / complexNumber;
        return this;
    }

    public ComplexNumber GetResult()
    {
        return _result;
    }
}