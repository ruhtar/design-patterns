namespace DesignPatterns.Strategy;

public class Sum : ICalculatorStrategy
{
    public double Operation(double firstNumber, double secondNumber) => firstNumber + secondNumber;
}

public class Subtraction : ICalculatorStrategy
{
    public double Operation(double firstNumber, double secondNumber) => firstNumber - secondNumber;
}

public class Multiplication : ICalculatorStrategy
{
    public double Operation(double firstNumber, double secondNumber) => firstNumber * secondNumber;
}

public class Division : ICalculatorStrategy
{
    public double Operation(double firstNumber, double secondNumber) => firstNumber / secondNumber;
}
