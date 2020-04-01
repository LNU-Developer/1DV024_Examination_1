using System;
using StatisticsHelper;
using InputHandler;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            dynamic response = Statistics.DescriptiveStatistics(Inputs.importJSON());

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
