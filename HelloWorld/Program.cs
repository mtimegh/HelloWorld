using System;
using System.Runtime.CompilerServices;


namespace HelloWorld
{   // PascalCase - kazdy wyraz w ciagu -> duza litera -> klasy/namespace/pliki
    class Program
    {
        static void Main(string[] args)
        {
            double a = 20;
            double b = 10;

                     
            

            Math math = new Math();

            double addResult = math.Add(a, b);
            double subtractResult = math.Subtract(a, b);

            Console.WriteLine(addResult.ToString());
            Console.WriteLine(subtractResult.ToString());

            
        }
    }
}

