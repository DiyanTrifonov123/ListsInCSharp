using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой елементи: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            //input
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи число: ");
                int item = int.Parse(Console.ReadLine());
                numbers.Add(item);
            }

            //obrabotka
            //dobawq w sredata
            //int newIndex = n / 2;
            //numbers.Insert(newIndex, 6);

            //dobawqne w kraya na MIN element
            //int minElement = numbers.Min();
            //numbers.Add(minElement);

            //da iztriq 0te
            //foreach (int chervenoKvadratche in numbers)
            while (numbers.Contains(0))           
            {                
                numbers.Remove(0);
            }

            //pechat
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
            Console.WriteLine($"Броят на елементите е {numbers.Count}");
        }
    }
}
