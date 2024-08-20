using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //     Plus();
            //     Minus();
            //     DividedBy();
            //     Times();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-- CALCULADORA -- ");
            Console.WriteLine("\n1 - Soma \n2 - Subtração \n3 - Divisão \n4 - Multiplicação \n5 - Potenciação \n6 - Sair");
            Console.WriteLine("\n--------------------");
            Console.WriteLine("");

            Console.Write("Selecione uma opção: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Plus(); break;
                case 2: Minus(); break;
                case 3: DividedBy(); break;
                case 4: Times(); break;
                case 5: PowerOf(); break;
                case 6: System.Environment.Exit(0); break; // Exite sempre pede parâmetro e o 0 significa que saiu com sucesso
                default: Menu(); break;
            }
        }
        static void Plus()
        {
            Console.Clear(); // Limpa o console
            Console.WriteLine("\n-- SOMA --");
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float result = v1 + v2;
            // Console.WriteLine("O resultado da soma é "+ result); //concatenation
            Console.WriteLine($"O resultado da soma é {result}"); //interpolation
            // Console.WriteLine($"O resultado da soma é {v1+v2}"); //interpolation
            // Console.WriteLine("O resultado da soma é " +(v1+v2)); //concatenation or interpolation
            Console.WriteLine("");
            Console.ReadKey(); // Não deixa o console encerrar
            Menu();
        }
        static void Minus()
        {
            Console.Clear();
            Console.WriteLine("\n-- SUBTRAÇÃO --");
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine($"\nO resultado da subtração é {result}"); //interpolation
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
        static void DividedBy()
        {
            Console.Clear();
            Console.WriteLine("\n-- DIVISÃO --");
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;
            Console.WriteLine($"\nO resultado da divisão é {result}"); //interpolation
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
        static void Times()
        {
            Console.Clear();
            Console.WriteLine("\n-- MULTIPLICAÇÃO --");
            Console.Write("\nPrimeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("\nSegundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"\nO resultado da multiplicação é {result}"); //interpolation
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
        static void PowerOf()
        {
            Console.Clear();
            Console.WriteLine("\n-- POTENCIAÇÃO --");
            Console.Write("\nValor da Base: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.Write("\nValor do Expoente: ");
            double v2 = double.Parse(Console.ReadLine());

            double result = Math.Pow(v1,v2);
            Console.WriteLine($"\nO resultado de {v1}^{v2} é {result}"); //interpolation
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
    }
}
