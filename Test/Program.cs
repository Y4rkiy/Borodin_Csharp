using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //first algorithm
            Console.WriteLine("Введите число");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            if (inputInt == 7)
            {
                Console.WriteLine("Привет");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine();

            //second algorithm
            Console.WriteLine("Введите имя");
            string inputString = Console.ReadLine();
            if (inputString == "Вячеслав")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
            Console.WriteLine();

            //third algorithm
            Console.WriteLine("Введите числа через пробел");
            string inputArr = Console.ReadLine();
            int[] arr = inputArr.Split(' ').Select(x => int.Parse(x)).ToArray();
            foreach (int a in arr)
            {
                if (a % 3 == 0)
                {
                    Console.Write($"{a} ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
