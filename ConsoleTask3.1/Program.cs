using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1 Описать и вызвать функцию, сортирующую массив значений целого типа произвольной длины(по возрастанию или убыванию – задавать отдельным параметром перечислимого типа). 

namespace ConsoleTask3._1
{
    class Program
    {
        static String SORT_TYPE = "Desc";
        static void Main(string[] args)
        {
            int[] masToSort = { 5, 2, 1, 3, 4 };
            Array.Sort(masToSort);
            if (SORT_TYPE.Equals("Desc"))
            {
                Array.Reverse(masToSort);
            }
            for (int i = 0; i < masToSort.Length; i++)
            {
                Console.Write(masToSort[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
