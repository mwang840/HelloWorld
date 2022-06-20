using System;

namespace HelloWorld{
    public class Data{
        public static void Main1(string[] args){
            Console.WriteLine("Signed Integer Bytes");
            Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
        }
    }
}