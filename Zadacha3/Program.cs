using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи числа:");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            byte count = 1;
            byte maxCount = 0;
            int repeatedElement = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        repeatedElement = numbers[i];
                        maxCount = count;
                    }
                    count = 1;
                }
            }
            Console.WriteLine($"{repeatedElement} se povtarq {maxCount} puti!");
        }
    }
}
