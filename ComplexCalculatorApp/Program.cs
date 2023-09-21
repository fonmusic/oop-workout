using ComplexCalculatorApp;

var initialValue = new ComplexNumber(0, 0);
var calculator = new ComplexCalculator(initialValue);
var logger = new Logger();
var loggerDecorator = new LoggerDecorator(calculator, logger);
var viewCalculator = new ViewCalculator(loggerDecorator);

var controller = new CalculatorController(viewCalculator, loggerDecorator);
controller.Start();