using System;

namespace DesignPatterns.Factory
{
    internal class SnackFactory : ISnackFactoryMethod
    {
        public Snack CreateSnack(int id)
        {
            switch (id)
            {
                case 1:
                    return new Sandwich();
                case 2:
                    return new Hamburguer();
                default:
                    throw new ArgumentException("Snack not found.");

            }
        }
    }
}
