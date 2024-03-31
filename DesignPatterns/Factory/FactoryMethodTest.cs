using System;

namespace DesignPatterns.Factory
{
    internal class FactoryMethodTest
    {
        public static void Validate(int id)
        {
            var factory = new SnackFactory();
            var snack = factory.CreateSnack(id);
            Console.WriteLine("-----------------------------------------------" + "\n");
            Console.WriteLine($"Your snack is {snack.Name}!" + "\n");

            foreach (var ingredient in snack.Ingredients)
            {
                Console.WriteLine(ingredient + "\n");
            }

            Console.WriteLine($"Your {snack.Name} is done." + "\n");
            Console.WriteLine("-----------------------------------------------" + "\n");
        }
    }
}
