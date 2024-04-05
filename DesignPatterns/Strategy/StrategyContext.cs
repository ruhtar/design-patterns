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
        if (calculatorStrategy == null)
            throw new ArgumentNullException("You must set the Strategy implementation via constructor or SetStrategy method.");

        return calculatorStrategy.Operation(firstNumber, secondNumber);
    }
}
