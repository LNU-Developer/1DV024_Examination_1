using System; //To use Console.
using StatisticsHelper; //To use methods in Statistics class
using System.Collections.Generic; //To use KeyValuePair

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 5, 1, 1, 1, 3, -2, 2, 5, 7, 4, 5, 16 };
            dynamic response = Statistics.DescriptiveStatistics(test);

            Console.WriteLine($"1. Maximum:         : {response["Maximum"]}");
            Console.WriteLine($"2. Minimum:         : {response["Minimum"]}");
            Console.WriteLine($"3. Medelvärde       : {response["Mean"]}");
            Console.WriteLine($"4. Median           : {response["Median"]}");
            Console.WriteLine($"5. Typvärde         : {string.Join(", ", response["Mode"])}");
            Console.WriteLine($"6. Variationsbredd  : {response["Range"]}");
            Console.WriteLine($"7. Standardavvikelse: {response["StandardDeviation"]}");
        }
    }
}
