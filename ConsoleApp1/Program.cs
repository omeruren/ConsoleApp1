using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] CreateArray(int number)
        {
            Random rnd = new Random();
            int[] ary = new int[number];
            for (int i = 0; i <ary.Length; i++)
            {
                ary[i] = rnd.Next(30);
            }
            return ary;
        }

        static void PrintArray (int[]ary,string text){

                Console.WriteLine($"{text}");
            foreach (var item in ary)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n");
        }
        static void Ascending(int[] ary)
        {
            
            int temporaryNumber = 0;
            for (int i = 0; i <= ary.Length - 1; i++)
            {
                for (int j = i + 1; j < ary.Length; j++)
                {
                    if (ary[i] > ary[j])
                    {
                        temporaryNumber = ary[i];
                        ary[i] = ary[j];
                        ary[j] = temporaryNumber;
                    }

                }
            }

            PrintArray(ary, "\n\n\t\t\t=== PRINTING ARRAY IN ASCENDING ORDER ===\n");
            /*
            foreach (var item in ary)
            {
                Console.WriteLine(item);
            }*/
        }

        static void Descending(int[]ary)
        {
           int temporaryNumber = 0;
            for (int i = 0; i <= ary.Length - 1; i++)
            {
                for (int j = i + 1; j < ary.Length; j++)
                {
                    if (ary[i] < ary[j])
                    {
                        temporaryNumber = ary[i];
                        ary[i] = ary[j];
                        ary[j] = temporaryNumber;
                    }

                }
            }
            PrintArray(ary, "\n\n\t\t\t=== PRINTING ARRAY IN DESCENDING ORDER ===\n");
        }

        static void Average(int[] ary)
        {
            int average = 0;
            foreach (var item in ary)
            {
                average += item;
            }
            Console.WriteLine($"The average of array is {average/ary.Length}");
        }

        static void MaxValue(int[] ary)
        {
            int maxElement = ary[0];

            for (int i = 1; i < ary.Length; i++)
            {
                if (ary[i] > maxElement)
                    maxElement = ary[i];
            }
            Console.WriteLine($"Max Value  is {maxElement}");
        }

        static void MinValue(int[] ary)
        {
            int minElement = ary[0];

            for (int i = 1; i < ary.Length; i++)
            {
                if (ary[i] < minElement)
                    minElement = ary[i];
            }
            Console.WriteLine($"Minimum Value is {minElement}");
        }

        static void NumberCount(int[] ary)
        {
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
            foreach (int num in ary)
            {
                if (numberCount.ContainsKey(num))
                {
                    numberCount[num]++;
                }
                else
                {
                    numberCount[num] = 1;
                }
            }
            Console.WriteLine("THERE ARE ");
            foreach (var entry in numberCount)
            {
                Console.Write($" \n{entry.Key} out of {entry.Value}\n");
            }
            Console.WriteLine("\n IN ARRAY.");

        }
        static void MedianNumber(int[] ary)
        {
            
            for (int i = ary.Length / 2 - 1; i >= 1; i--)
            {
                Console.WriteLine("The Median of array is {0}",ary[i]);
                break;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[] ary = CreateArray(20);// Creates an array with 20 elements.
            PrintArray(ary,"\t\t\t\t\t === ARRAY ===\n");
            Ascending(ary); // Sorts array in ascending order
            Descending(ary); // Sorts array in descending order
            MaxValue(ary); // Finds the Maximum value of array
            MinValue(ary); // Finds the Minimum value of array
            Average(ary); // Finds the Average of array
            MedianNumber(ary); // Finds the median of array
            NumberCount(ary); //Finds how many of a number there are in an array 

            Console.ReadKey();
        }
    }
}
