using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Написать функцию, возвращающую произведение элементов убывающей геометрической прогрессии чисел с первым элементом a1 и шагом t, 
// при этом последний элемент должен быть больше alim(an = an - 1 / t, an > alim)

namespace ConsoleTask3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = 2, t = 3, n = 4, alim = 10;
            double an = a1, i = 0, aNext = a1;
            while (aNext > alim && i < n - 1)
            {
                aNext = aNext / t;
                an = aNext * an;
                i++;
            }
            Console.WriteLine(an);
            Console.ReadKey();
        }
    }
}
