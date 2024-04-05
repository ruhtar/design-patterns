using System;

namespace DesignPatterns.Strategy;

public class StrategyTest
{
    public static void Validate()
    {
        var context = new StrategyContext();
        context.SetStrategy(new Sum());
        var result1 = context.Calculate(6, 2);
        Console.WriteLine($"Result for Sum strategy: {result1}" + "\n");

        context.SetStrategy(new Subtraction());
        var result2 = context.Calculate(6, 2);
        Console.WriteLine($"Result for Subtraction strategy: {result2}" + "\n");

        context.SetStrategy(new Multiplication());
        var result3 = context.Calculate(6, 2);
        Console.WriteLine($"Result for Multiplication strategy: {result3}" + "\n");

        context.SetStrategy(new Division());
        var result4 = context.Calculate(6, 2);
        Console.WriteLine($"Result for Division strategy: {result4}" + "\n");
    }
}
