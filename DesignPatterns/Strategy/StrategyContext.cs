using System;

namespace DesignPatterns.Strategy;
/// <summary>
/// This class is where the ConcreteStrategy will be instantiated.
/// </summary>
internal class StrategyContext
{
    // The Context maintains a reference to one of the Strategy objects. The
    // Context does not know the concrete class of a strategy. It should
    // work with all strategies via the Strategy interface.
    private ICalculatorStrategy calculatorStrategy;

    public StrategyContext(ICalculatorStrategy calculatorStrategy) => this.calculatorStrategy = calculatorStrategy;

    public StrategyContext() { }

    public void SetStrategy(ICalculatorStrategy calculatorStrategy) => this.calculatorStrategy = calculatorStrategy;

    public double Calculate(double firstNumber, double secondNumber)
    {
        if (this.calculatorStrategy == null)
            throw new ArgumentNullException(nameof(calculatorStrategy));

        return calculatorStrategy.Operation(firstNumber, secondNumber);
    }
}
