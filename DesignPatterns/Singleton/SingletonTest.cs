using System;

namespace DesignPatterns.Singleton
{
    internal class SingletonTest
    {
        public static void ValidateSingleton()
        {
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Same instance. Singleton works!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Different instances. Singleton doesn't work :( ");
                Console.ReadLine();
            }
        }
    }
}
