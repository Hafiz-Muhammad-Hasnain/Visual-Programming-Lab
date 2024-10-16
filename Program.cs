using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                { 1, 2 },
                { 4, 5 },
                { 7, 8 }
            };

            Print2DArray(array);
        }

        private static void Print2DArray(int[,] array)
        {
            Console.WriteLine("Elements of 2D array are:");
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(); 
            }
            Console.WriteLine();
        }
    }
}
