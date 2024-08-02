using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a 5x5 two-dimensional array
        int[,] array = new int[5, 5];

        // Initialize index [2,2] to 1 and all other indices to 0
        array[2, 2] = 1;

        // Print the array
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j]);
                if (j < 4)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
