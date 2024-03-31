using DesignPatterns.Factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            //SingletonTest.ValidateSingleton();
            #endregion

            #region Mediator
            //MediatorTest.Validate();
            #endregion

            #region Factory Method
            FactoryMethodTest.Validate(id: 1);
            FactoryMethodTest.Validate(id: 2);
            #endregion

            Console.ReadLine();
        }
    }
}