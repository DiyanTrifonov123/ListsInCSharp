using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа на списъка: ");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrintCount(numbers);

            Console.Write("Въведи числа на първия масив: ");
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayToList(numbers, array1);

            Console.Write("Въведи число, за да провериш дали го има: ");
            int num = int.Parse(Console.ReadLine());
            IsNumInList(numbers, num);

            Console.Write("Въведи числа на втория масив: ");
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayToListTwo(numbers, array2);

            Console.WriteLine();
        }

        private static void AddArrayToListTwo(List<int> numbers, int[] array2)
        {
            numbers.InsertRange(3, array2);
            Console.WriteLine(string.Join(", ",numbers));
            numbers.Sort();
            Console.Write($"Добавяме втория масив към списъка с първия масив {string.Join("*", numbers)}");
        }

        private static void IsNumInList(List<int> numbers, int num)
        {
            if (numbers.Contains(num))
            {
                Console.WriteLine($"Числото {num} е на {numbers.IndexOf(num)}!");
            }
            else
            {
                Console.WriteLine($"Числото {num} не е в списъка!");
            }
        }

        private static void AddArrayToList(List<int> numbers, int[] array1)
        {
            numbers.AddRange(array1);
            numbers.Sort();
            Console.WriteLine($"Добавя се първия масива към списъка: {string.Join(" ", numbers)}");
        }

        private static void PrintCount(List<int> numbers)
        {
            Console.WriteLine($"Броя на елементите от списъка: {numbers.Count}");
        }
    }
}
