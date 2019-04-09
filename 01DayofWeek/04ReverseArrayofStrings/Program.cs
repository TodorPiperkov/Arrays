using System;
using System.Linq;

namespace _04ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').ToArray().Reverse().ToArray()));
        }
    }
}
