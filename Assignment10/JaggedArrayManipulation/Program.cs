// See https://aka.ms/new-console-template for more information
using System;
namespace JaggedArrayManipulation;
internal class Program
{
    static void Main()
    {
        // Create a jagged array to store scores of three students
        int[][] studentScores = new int[][]
        {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
        };

        // Print scores of each student using nested loops
        Console.WriteLine("Scores of each student:");
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write($"{studentScores[i][j]} ");
            }
            Console.WriteLine();
        }

        // Calculate and print the average score for each student
        Console.WriteLine("\nAverage score for each student:");
        for (int i = 0; i < studentScores.Length; i++)
        {
            double sum = 0;
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                sum += studentScores[i][j];
            }
            double average = sum / studentScores[i].Length;
            Console.WriteLine($"Student {i + 1}: {average:F2}");
        }

        // Calculate and print the average score for all students combined
        Console.WriteLine("\nAverage score for all students combined:");
        double totalSum = 0;
        int totalCount = 0;
        for (int i = 0; i < studentScores.Length; i++)
        {
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                totalSum += studentScores[i][j];
                totalCount++;
            }
        }
        double totalAverage = totalSum / totalCount;
        Console.WriteLine($"Overall Average: {totalAverage:F2}");
        Console.ReadKey();
    }
}
