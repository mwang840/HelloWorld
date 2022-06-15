// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            var flipped = new Random();
            int headsOrTails = flipped.Next(0,2);
            Console.WriteLine((headsOrTails==0) ? "Heads" : "Tails");
        }
    }
}

