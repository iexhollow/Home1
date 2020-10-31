using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сергеев Александр
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            int tmp;

            tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadKey();
        }
    }
}
