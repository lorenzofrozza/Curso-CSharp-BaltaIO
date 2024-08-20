using System;

namespace Codec
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();


            string characteristics = ReturnName("Lorenzo", "Frozza", 18);
            Console.WriteLine(characteristics);


            var arr = new string[2]; 
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]); 
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]); 
            Console.WriteLine(arr2[0]);


            var mouse = new Product(1, "Mouse Gamer", 249.90, EProductType.Product);
            var teclado = new Product(2, "Teclado Gamer", 329.90, EProductType.Product);
            var manutencaoEletrica = new Product(3, "Manutenção elétrica residencial", 499.90, EProductType.Service);

            Console.WriteLine("\nId: "+mouse.Id);
            Console.WriteLine("Name product: "+mouse.Name);
            Console.WriteLine("Price: $"+mouse.Price);
            Console.WriteLine("Type: "+mouse.Type);

            Console.WriteLine("\nId: "+teclado.Id);
            Console.WriteLine("Name product: "+teclado.Name);
            Console.WriteLine("Price: $"+teclado.Price);
            Console.WriteLine("Type: "+teclado.Type);

            Console.WriteLine("\nId: "+manutencaoEletrica.Id);
            Console.WriteLine("Name product: "+manutencaoEletrica.Name);
            Console.WriteLine("Price: $"+manutencaoEletrica.Price);
            Console.WriteLine("Type: "+manutencaoEletrica.Type);
            Console.WriteLine("ID Type: "+(int)manutencaoEletrica.Type);
        }
        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal");
        }
        static string ReturnName(string name, string surname, int age) //ReturnName(string name, string surname, int age = 22) Ele pega o 22 caso não seja citado na main
        {                                                              //Parametro opicional tem que ter o = e ir no final de todos os outros
            return name + " " + surname + " tem " + age.ToString() + " anos.";
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }

    }

    enum EProductType 
    {
        Product = 1,
        Service = 2
    }
}