 using System;

namespace guia7_ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GUIA 7 EJERCICIO 2 ";
            int x = 0;

            Console.WriteLine("escribe un numero entre el 1 y el 15");
            x = int.Parse(Console.ReadLine());
            if (x <= 15)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.WriteLine("*");
                }
            }
            else
            Console.ReadKey();
        }
    }
}
