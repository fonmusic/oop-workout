namespace ComplexCalculatorApp;

public interface ICalculable
{
    ICalculable Input(ComplexNumber complexNumber);
    ICalculable Add(ComplexNumber complexNumber);
    ICalculable Subtract(ComplexNumber complexNumber);
    ICalculable Multiply(ComplexNumber complexNumber);
    ICalculable Divide(ComplexNumber complexNumber);
    ComplexNumber GetResult();
}