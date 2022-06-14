// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            string name = "Walter Hartwell White", location = "308 Negra Arroyo Lane, ", name3= "Alberquerque, NM";
            Console.WriteLine("My name is: " + name + "\nI live at " + location + name3 + "\n");
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);
            string myValue = "a";
            Console.WriteLine(myValue == "a");
            string param = "Why did the chicken cross the road?";
            Console.WriteLine(param.Contains("road"));
            Console.WriteLine(param.Contains("fox"));
            int saleAmount = 1001;

            int discount = saleAmount > 1000 ? 100 : 50;

            Console.WriteLine($"Discount: {discount}");
        }
    }
}

