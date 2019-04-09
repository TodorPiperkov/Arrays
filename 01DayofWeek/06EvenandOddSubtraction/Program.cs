using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 == 0)
                {
                    sumEven += myArr[i];
                }
                else
                {
                    sumOdd += myArr[i];
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
