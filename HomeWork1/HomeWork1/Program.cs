using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сергеев Александр
            // 1) Написать метод, возвращающий минимальное из трёх чисел.

            Console.Write("Введите А ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите А ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите А ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c < a && c < b)
            {
                Console.WriteLine($"min = {c}");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine($"min = {a}");
                }
                else
                {
                    Console.WriteLine($"min = {b}");
                }
            }
        }
    }
}
