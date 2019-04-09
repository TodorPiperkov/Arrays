using System;
using System.Linq;

namespace _03RoundNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < myArray.Length; i++)
            {
                double index = myArray[i];
                Console.WriteLine("{0} => {1}", myArray[i], Math.Round(index, MidpointRounding.AwayFromZero));
            }
        }
    }
}
