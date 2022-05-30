using System;

namespace GitHubCoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("new line added");
            Add(12, 22);
        }
        static void Add(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }
    }
}
