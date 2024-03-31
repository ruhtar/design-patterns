namespace DesignPatterns.Factory
{
    internal class Hamburguer : Snack
    {
        private string _name;
        public override string Name => _name;
        public Hamburguer()
        {
            _name = "Hamburguer";
            Ingredients.Add("Hamburger Bun");
            Ingredients.Add("Hamburger Patty");
            Ingredients.Add("Cheese");
            Ingredients.Add("Lettuce");
            Ingredients.Add("Tomato");
            Ingredients.Add("Onion");
            Ingredients.Add("Hamburger Sauce");
        }
    }
}
