using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи число, до което искаш да се отпечати: ");
            byte numFib = byte.Parse(Console.ReadLine());
            List<ulong> numbers = new List<ulong>();
            numbers.Add(1);
            numbers.Add(1);

            for (int i = 2; i < numFib; i++)
            {
                numbers.Add(numbers[i - 2] + numbers[i - 1]);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
