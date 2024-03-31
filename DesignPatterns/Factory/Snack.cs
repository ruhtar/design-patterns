using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    internal abstract class Snack
    {
        public abstract string Name { get; }
        public List<string> Ingredients = [];
    }
}
