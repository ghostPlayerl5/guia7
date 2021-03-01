using System;

namespace guia7_ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            Console.Title = "GUIA 7 EJERCICIO 1 ";
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t MENU\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("[A]Seno \t");               
                Console.Write("[B]Coseno\t");               
                Console.Write("[C]Tangente\t");               
                Console.Write("[D]Raiz Cuadrada\t");                
                Console.Write("[E]Potencia\t");                
                Console.Write("[F]Par o Impar\t");
                Console.Write("[Esc]Salir\t\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Elige una de las opciones......");
                op = Console.ReadKey(true);
                switch (op.Key)
                {
                    case ConsoleKey.A:
                        int numA = 0;
                        Console.WriteLine("digite el numero..");
                        numA = int.Parse(Console.ReadLine());
                        double seno = Math.Sin(numA);
                        Console.WriteLine("El seno de " + numA + "=" + seno);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:
                        int numB = 0;
                        Console.WriteLine("Digite el numero...");
                        numB = int.Parse(Console.ReadLine());
                        double cos = Math.Cos(numB);
                        Console.WriteLine("El coseno" + numB + "=" + cos);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.C:
                        int numC = 0;
                        Console.WriteLine("Digite el numero...");
                        numC = int.Parse(Console.ReadLine());
                        double tan = Math.Tan(numC);
                        Console.WriteLine("La tangente de " + numC + "=" + tan);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D:
                        int numD = 0;
                        Console.WriteLine("Digite el numero...");
                        numD = int.Parse(Console.ReadLine());
                        double raiz = Math.Sqrt(numD);
                        Console.WriteLine("La raiz cuadrada de" + numD + "=" + raiz);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.E:
                        int numEY = 0;
                        int numEX = 0;
                        Console.WriteLine("Digite el valor de Y...");
                        numEY = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el valor de X(exponente)...");
                        numEX = int.Parse(Console.ReadLine());
                        double potencia = Math.Pow(numEY, numEX);
                        Console.WriteLine("El numero "+ numEY + " a la potencia de "+ numEX +" es = " + potencia);
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F:
                        int numF = 0;
                        Console.WriteLine("Digite un numero...");
                        numF = int.Parse(Console.ReadLine());
                        if((numF % 2)== 0 )
                        {
                            Console.WriteLine("es par");
                        }
                        else
                        {
                            Console.WriteLine("es impar");
                        }
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        Console.Write("Arrivederci :D");
                        Console.ReadKey();
                        break;

                }
            }
            while ( op.Key  != ConsoleKey.Escape);           
        }
    }
}
