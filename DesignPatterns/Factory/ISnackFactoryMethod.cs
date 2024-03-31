namespace DesignPatterns.Factory
{
    internal interface ISnackFactoryMethod
    {
        public abstract Snack CreateSnack(int id);
    }
}
