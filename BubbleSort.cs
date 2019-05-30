using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] unsortedArray = new int[] { 1000, 512, 300, 954, 15, 67, 2, 15, 78, 90, 87, 555 };
            Console.WriteLine("----UNSORTED----");

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine(unsortedArray[i]);
            }

            int[] sortedArray = BubbleSort(unsortedArray);
            Console.WriteLine("----BUBBLE SORTED----");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
            Console.ReadLine();
        }



        private static int[] BubbleSort(int[] unsortedArray)
        {
            int length = unsortedArray.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0;j<length - 1 - i;j++ )
                {
                    if(unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int num = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = num;
                    }
                }
            }

            return unsortedArray;
        }
    }
}
