using System;
using StatisticsHelper;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 4, 8, 2, 4, 5 };
            dynamic response = Statistics.DescriptiveStatistics(test);

            foreach (KeyValuePair<string, dynamic> item in response)
            {
            Console.WriteLine($"{item.Key}: {item.Value}");
            }

            //Console.WriteLine($"1. Maximum:         : {response.Maximum}");
            //Console.WriteLine($"2. Minimum:         : {response.Minimum}");
            //Console.WriteLine($"3. Medelvärde       : {response.Mean}");
            //Console.WriteLine($"4. Median           : {response.Median}");
            //Console.WriteLine($"5. Typvärde         : {response.Mode}");
            //Console.WriteLine($"6. Variationsbredd  : {response.Range}");
            //Console.WriteLine($"7. Standardavvikelse: {response.StandardDeviation}");
        }
    }
}
