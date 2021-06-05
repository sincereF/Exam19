using System;

namespace Exam19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Написать программу для подсчета суммы чисел, кратных 3 в диапазоне от 30 до 60:");
            

            counting count = new counting();
            for (int i = 30; i <= 60; i++)
            {
                if (i % 3 == 0)
                {
                    count.Sum = i;
                }
            }

            Console.WriteLine("\nСумма чисел равна " + count.Sum);
            Console.ReadKey();
        }
    }
}
