namespace ComplexCalculatorApp;

public class CalculatorController
{
    private readonly ViewCalculator _viewCalculator;
    private readonly ICalculable _calculator;

    public CalculatorController(ViewCalculator viewCalculator, ICalculable calculator)
    {
        _viewCalculator = viewCalculator;
        _calculator = calculator;
    }

    public void Start()
    {
        _viewCalculator.Run();
    }
}