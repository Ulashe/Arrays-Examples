using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5]; // Initializing an array
            arr1[0] = 3; // You can assign values to individual array elements, by using the index number
            int[] arr2 = new int[3] { 8, 9, 17 }; // You can also create and initialize an array
            int[] arr3 = { 3, 4, 5 }; // You can assign values to the array at the time of declaration
            int[] arr4 = new int[] { 12, 13, 25 }; // You may also omit the size of the array
            int[] arr5 = arr4; // You can copy an array variable into another target array variable
            for(int i = 0; i < 5; i++)
            {
                arr1[i] = (i + 1) * 2;
            }

            for(int i=0; i < 3; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("-----------------\n");
            // Foreach
            int[] arr6 = new int[10];
            Random random = new Random();
            for(int i = 0; i < arr6.Length; i++)
            {
                arr6[i] = random.Next(1, 100);
            }
            int y = 0;
            foreach(int i in arr6)
            {
                Console.WriteLine("Element {0}: {1}", y, i);
                y++;
            }
            Console.WriteLine("\n-----------------");
            // Multidimensional arrays (rectangular arrays)
            string[,] cars = new string[2, 3] { { "BMW", "VW", "AUDI" }, { "NISSAN", "TOYOTA", "HONDA" } };
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("cars[{0},{1}]: {2}", i, j, cars[i,j]);
                }
            }
            Console.WriteLine("\n-----------------");


            Console.ReadLine();
        }
    }
}
