namespace ComplexCalculatorApp.Controllers;

/// <summary>
/// Controller for the calculator.
/// </summary>
public class CalculatorController
{
    private readonly ViewCalculator _viewCalculator;
    private readonly ICalculable _calculator;

    public CalculatorController(ViewCalculator viewCalculator, ICalculable calculator)
    {
        _viewCalculator = viewCalculator;
        _calculator = calculator;
    }

    /// <summary>
    ///  Starts the calculator.
    /// </summary>
    public void Start()
    {
        _viewCalculator.Run();
    }
}