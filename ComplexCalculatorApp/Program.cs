using ComplexCalculatorApp;

var calculator = new ComplexCalculator(new ComplexNumber(0, 0));
var decorator = new LoggerDecorator(calculator, new Logger());
var view = new ViewCalculator(decorator);

view.Run();