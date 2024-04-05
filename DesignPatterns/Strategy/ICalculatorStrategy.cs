namespace DesignPatterns.Strategy;

/// <summary>
/// Common Interface to all classes (concrete implementations) that defines all the wanted behaviours.
/// </summary>
public interface ICalculatorStrategy
{
    double Operation(double firstNumber, double secondNumber);
}