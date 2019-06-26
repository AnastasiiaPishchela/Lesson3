using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask3._3
{
    class Program
    {
        //Написать функцию, возвращающую произведение n элементов арифметической прогрессии чисел с первым элементом a1 и шагом t(an = a(n - 1) + t)
        // Функция должна возвращать результат для любой арифметической прогрессии, которая задается значениями первого элемента и шага
        static void Main(string[] args)
        {
            int n = 100, a1 = 2, t = 3;
            int an = a1, i = 0, aNext = a1;
            while (i < n - 1)
            {
                aNext = aNext + t;
                an = aNext + an;
                i++;
            }
            Console.WriteLine(an);
            Console.ReadKey();
        }
    }
}
