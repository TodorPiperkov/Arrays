using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <=7)
            {
                Console.WriteLine(days[index - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
