using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises.Hello();
            Console.WriteLine("Hello World!");
            // Exercises.PrintNumbers();
            // Exercises.PrintOdds();
            // Exercises.PrintSum();
            int[] numArray = {1,2,-10,3,-4,5};
            // Exercises.LoopArray(numArray);
            // Exercises.FindMax(numArray);
            // Exercises.GetAverage(numArray);
            // Exercises.OddArray();
            // Console.WriteLine(Exercises.GreaterThanY(numArray, 9));
            // Exercises.SquareArrayValues(numArray);
            Exercises.EliminateNegatives(numArray);

        }

    }
}
