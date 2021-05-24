using System;

namespace SingletonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton funciona, ambas variables contienen la misma instancia.");
            }
            else
            {
                Console.WriteLine("Singleton falla, las variables contienen instancais distintas.");
            }

            Console.ReadKey();
        }
    }
}