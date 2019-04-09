using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 == 0)
                {
                    sum += myArr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
