using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сергеев Александр 

            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            //а) используя склеивание;

            Console.WriteLine("Доброго времени суток, мой друг. заполните вашу анкету");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine(name + " приятно познакомиться, назовите вашу фамилию?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Сколько вам полных лет: ");
            string age = Console.ReadLine();
            Console.WriteLine("Укажите ваш вес: ");
            string weight = Console.ReadLine();
            Console.WriteLine("Укажите ваш рост: ");
            string height = Console.ReadLine();
            Console.Write("Фамилия: " + lastname + " Имя: " + name + " Возраст: " + age + " Вес: " + weight + " Рост: " + height);
            Console.ReadKey();

            //б) используя форматированный вывод;

            //Console.WriteLine("Доброго времени суток, мой друг. Заполните вашу анкету");
            //Console.WriteLine("Как вас зовут?");
            //string Name = Console.ReadLine();
            //Console.WriteLine(Name + " приятно познакомиться, назовите вашу фамилию?");
            //string Lastname = Console.ReadLine();
            //Console.WriteLine("Сколько вам полных лет: ");
            //string Age = Console.ReadLine();
            //Console.WriteLine("Укажите ваш вес: ");
            //string Weight = Console.ReadLine();
            //Console.WriteLine("Укажите ваш рост: ");
            //string Height = Console.ReadLine();
            //string result = String.Format("Имя: {0} Фамилия: {1} Возраст {2} Вес {3} Рост {4}",
            //                                Name,
            //                                Lastname,
            //                                Age,
            //                                Weight,
            //                                Height);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //в) используя вывод со знаком $.

            //Console.WriteLine("Доброго времени суток, мой друг. Заполните вашу анкету");
            //Console.WriteLine("Как вас зовут?");
            //string Name = Console.ReadLine();
            //Console.WriteLine(Name + " приятно познакомиться, назовите вашу фамилию?");
            //string Lastname = Console.ReadLine();
            //Console.WriteLine("Сколько вам полных лет: ");
            //string Age = Console.ReadLine();
            //Console.WriteLine("Укажите ваш вес: ");
            //string Weight = Console.ReadLine();
            //Console.WriteLine("Укажите ваш рост: ");
            //string Height = Console.ReadLine();
            //string result = $"Имя: {Name} Фамилия: {Lastname} Возраст: {Age} Вес: {Weight} Рост: {Height} "; 
            //Console.WriteLine(result);
            //Console.ReadKey();
        }
    }
}
