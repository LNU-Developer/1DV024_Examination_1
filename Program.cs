using System;
using StatisticsHelper;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 4, 8, 2, 4, 5 };

            Console.WriteLine($"1. Maximum:         : {Statistics.Maximum(test)}");
            Console.WriteLine($"2. Minimum:         : {Statistics.Minimum(test)}");
            Console.WriteLine($"3. Medelvärde       : {Statistics.Mean(test)}");
            Console.WriteLine($"4. Median           : {Statistics.Median(test)}");
            Console.WriteLine($"5. Typvärde         : {Statistics.Mode(test)}");
            Console.WriteLine($"6. Variationsbredd  : {Statistics.Range(test)}");
            Console.WriteLine($"7. Standardavvikelse: {Statistics.StandardDeviation(test)}");
        }
    }
}
