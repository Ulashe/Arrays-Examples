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
            // Jagged arrays (array of arrays)

            string[][] jag = new string[3][]; // Declaring an array, does not create the array in memory
            jag[0] = new string[4] { "Desktop", "Laptop", "Tablet", "Mobile" };
            jag[1] = new string[5] { "BWM", "AUDI", "TOYOTA", "MERCEDES", "PORSCHE" };
            jag[2] = new string[2] { "Microsoft", "Apple" };

            double[][] jag2 = new double[3][] { new double[] { 13.4, 15.6, 17.4 }, new double[] { 2, 4, 5, 1},
            new double[]{ 5, 6, 7} };

            for(int i = 0; i < jag.Length; i++)
            {
                for(int j = 0; j < jag[i].Length; j++)
                {
                    Console.WriteLine("jag[{0}][{1}]: {2}", i, j, jag[i][j]);
                }
            }
            Console.WriteLine("\n-----------------");
            // Reverse and sort
            int[] array = new int[]{ 3, 6, 7, 5, 8, 9, 4, 2 };
            Console.Write("Original array: ");
            foreach(int i in array)
            {
                Console.Write("{0} ", i);
            }
            int[] temp = array;
            Console.Write("\nReversed array: ");
            Array.Reverse(temp);
            foreach(int i in temp)
            {
                Console.Write("{0} ", i);
            }
            Array.Sort(temp);
            Console.Write("\nSorted array: ");
            foreach (int i in temp)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadLine();
        }
    }
}
