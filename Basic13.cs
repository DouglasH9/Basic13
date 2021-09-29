using System;
using System.Collections.Generic;

namespace Basic13
{
    public static class Exercises
    {
        public static void Hello()
        { 
            Console.WriteLine("Hello there");
        }
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i <=255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"Number is {i}, sum is {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static void FindMax(int[] numbers)
        {
            int max = 0;
            int value = 0;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                value = numbers[i];
                if (value > max)
                {
                    max = value;
                }
            }
            Console.WriteLine($"The max is: {max}");
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            float avg = (float)sum/(float)numbers.Length;
            Console.WriteLine($"The average is {avg}");
        }
        // public static void OddArray()
        // {
        //     int count = 0;
        //     for (int i = 1; i <= 255; i++)
        //     {
        //         if (i % 2 != 0)
        //         {
        //             count++;
        //         }
        //     }
        //     int[] odds = new int[count];
        //     for (int i = 1; i <= 255; i++)
        //     {
        //         if (i % 2 != 0)
        //         {
        //             odds[i] = i;
        //         }
        //         return odds;
        //     }
        //     for (int i = 0; i < odds.Length; i++)
        //     {
        //         Console.WriteLine(odds[i]);
        //     }
        // }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count++;
                }
            }
            return count;
            // Console.WriteLine(count);
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (numbers[i]*numbers[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Abs(numbers[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
    }
}