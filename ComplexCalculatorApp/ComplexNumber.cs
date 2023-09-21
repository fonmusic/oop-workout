namespace ComplexCalculatorApp;

public class ComplexNumber
{
    private readonly double _real;
    private readonly double _imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        _real = real;
        _imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a._real + b._real, a._imaginary + b._imaginary);
    }

    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a._real - b._real, a._imaginary - b._imaginary);
    }
    
    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(
            a._real * b._real - a._imaginary * b._imaginary,
            a._real * b._imaginary + a._imaginary * b._real
        );
    }
    
    public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(
            (a._real * b._real + a._imaginary * b._imaginary) / (b._real * b._real + b._imaginary * b._imaginary),
            (a._imaginary * b._real - a._real * b._imaginary) / (b._real * b._real + b._imaginary * b._imaginary)
        );
    }

    public override string ToString()
    {
        return $"{_real} + {_imaginary}i";
    }
}