using System;

namespace guia7_ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GUIA 7 EJERCICIO 3 ";

            int x = 0;
            int y = 0;

            Console.WriteLine("escriba el primer numero");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("escriba el segundo numero");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("====");
            if (x < y)
            {
                for (x = 2; x <= y; x = x + 2)
                {
                    
                    Console.WriteLine(x);
                    
                }
                Console.WriteLine("====");
            }
            else if (x > y)
            {
                Console.WriteLine("no se puede ejecutar");
            }
        }
    }
}
