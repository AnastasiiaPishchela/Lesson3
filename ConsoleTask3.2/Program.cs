using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Описать и вызвать функцию, которая определяет, отсортирован ли в заданном порядке массив значений целого типа произвольной длины(по возрастанию или убыванию – задавать отдельным
// параметром перечислимого типа).

namespace ConsoleTask3._2
{
    class Program
    {
        static String SORT_TYPE = "Asc";
        static void Main(string[] args)
        {
            int[] masToSort = { 1, 3, 2, 4, 5 };
            int[] masSorted = new int[masToSort.Length];
            masToSort.CopyTo(masSorted, 0);
            if (SORT_TYPE.Equals("Asc"))
            {
                Array.Sort(masSorted);
            }
            else if (SORT_TYPE.Equals("Desc"))
            {
                Array.Sort(masSorted);
                Array.Reverse(masSorted);
            }
            bool isSortedCorrect = true;
            for (int i = 0; i < masToSort.Length; i++)
            {
                if (masToSort[i] != masSorted[i])
                {
                    isSortedCorrect = false;
                    break;
                }
            }

            Console.WriteLine("Array sorted as expected: " + isSortedCorrect);

            for (int i = 0; i < masToSort.Length; i++)
            {
                Console.Write(masToSort[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < masSorted.Length; i++)
            {
                Console.Write(masSorted[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
