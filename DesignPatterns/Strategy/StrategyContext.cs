namespace DesignPatterns.Strategy;
/// <summary>
/// This class is where the ConcreteStrategy will be instantiated.
/// </summary>
internal class StrategyContext
{
    private ICalculatorStrategy calculatorStrategy;

    public void SetStrategy(ICalculatorStrategy calculatorStrategy) => this.calculatorStrategy = calculatorStrategy;

    public double Calculate(double firstNumber, double secondNumber) => calculatorStrategy.Operation(firstNumber, secondNumber);
}
