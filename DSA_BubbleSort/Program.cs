using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 1, 7, 4, 7, 9, 0, 2, 3, 4, 5, 6, };

            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }            
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
