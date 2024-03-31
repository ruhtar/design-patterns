namespace DesignPatterns.Factory
{
    internal class Sandwich : Snack
    {
        private string _name;
        public override string Name => _name;
        public Sandwich()
        {
            _name = "Sandwich";
            Ingredients.Add("Bread");
            Ingredients.Add("Eggs");
            Ingredients.Add("Cheese");
            Ingredients.Add("Ham");
        }
    }
}
