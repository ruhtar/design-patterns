using System;

namespace DesignPatterns
{    // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of
    // this class over and over.

    // EN : The Singleton should always be a 'sealed' class to prevent class
    // inheritance through external classes and also through nested classes.
    public sealed class Singleton
    {
        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private Singleton() { }
        private static Singleton _instance;
        
        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field

        public static Singleton GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Singleton();
                return _instance;
            }
            return _instance;
        }
        
        // Finally, any singleton should define some business logic, which can
        // be executed on its instance.
        public static void ValidateSingleton()
        {
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Same instance. Singleton works!");
            }
            else
            {
                Console.WriteLine("Different instances. Singleton doesn't work :( ");
            }
        }
    }
}