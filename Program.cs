using System;
using System.IO;
using System.Diagnostics;

namespace CSC205Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "numbers.txt";
            Stopwatch stopwatch = new Stopwatch();

            // Generate a file with random numbers
            Method01(fileName, 1000, 1, 1001);

            // Read all lines from the file
            string[] lines = File.ReadAllLines(fileName);
            int[] values = new int[lines.Length];

            // Convert each line to an integer and store it in the array
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(lines[i]);
            }

            stopwatch.Start();
            Console.WriteLine("starting ... ");

            // Sort the array using selection sort
            Method02(values);

            Console.WriteLine("done! ... ");
            stopwatch.Stop();
            Console.WriteLine("time measured: {0} ms", stopwatch.ElapsedMilliseconds);

            // Print the sorted values
            foreach (int value in values)
                Console.Write(value + " ");
            Console.WriteLine();
        }

        // Method01 generates a file with random numbers within a specified range
        static void Method01(string fileName, int total, int lowerRange, int upperRange)
        {
            // Create a StreamWriter to write to the specified file
            using (var writer = new StreamWriter(fileName))
            {
                // Create a Random object to generate random numbers
                Random r = new Random();
                int number = 0;

                // Loop to generate 'total' random numbers
                for (int i = 1; i < total; i++)
                {
                    // Generate a random number within the specified range
                    number = r.Next(lowerRange, upperRange);
                    // Write the generated number to the file
                    writer.WriteLine(number);
                }
            }
        }

        // Method02 sorts an array of integers using the selection sort algorithm
        static void Method02(int[] arr)
        {
            // Loop through each element in the array
            for (int start = 0; start < arr.Length - 1; start++)
            {
                // Assume the current position is the minimum
                int posMin = start;

                // Loop through the remaining elements to find the actual minimum
                for (int i = start + 1; i < arr.Length; i++)
                {
                    // Update posMin if a smaller element is found
                    if (arr[i] < arr[posMin])
                    {
                        posMin = i;
                    }
                }

                // Swap the found minimum element with the current element
                int tmp = arr[start];
                arr[start] = arr[posMin];
                arr[posMin] = tmp;
            }
        }
    }
}

