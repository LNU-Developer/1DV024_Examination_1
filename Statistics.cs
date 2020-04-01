using System;
using System.Collections.Generic;

namespace StatisticsHelper {
    static class Statistics
    {
        public static dynamic DescriptiveStatistics(int[] source)
        {
            
            Dictionary<string, dynamic> response =   
                       new Dictionary<string, dynamic>()
                       {
                           {"Maximum", Maximum(source)},
                           {"Minimum", Minimum(source)},
                           {"Mean", Mean(source)}, 
                           {"Median", Median(source)},
                           {"Mode", Mode(source)},
                           {"Range", Range(source)},
                           {"Standard Deviation", StandardDeviation(source)}
                       };
        
            return response;
        }

        static int Maximum(int[] source)
        {
            int[] sortedArray = uniqueSortedArray(source);
            return sortedArray[sortedArray.Length-1];
        }

        static double Mean(int[] source)
        {
            double total = 0;
            for (int i = 0; i < source.Length; i++) 
            { 
                total += source[i];
            }
            
            return total/source.Length;
        }

        static double Median(int[] source)
        {
            int[] sortedArray = uniqueSortedArray(source);
            double medianValue = 0;
            
            if (sortedArray.Length % 2 == 0)
            {
                int middleElement1 = sortedArray[(sortedArray.Length/2)-1];
                int middleElement2 = sortedArray[(sortedArray.Length/2)];
                medianValue = (middleElement1+middleElement2)/2;
            } 
            else
            {
                medianValue = sortedArray[sortedArray.Length/2];
            } 

            return medianValue;
        }

        static int Minimum(int[] source)
        {
            int[] sortedArray = uniqueSortedArray(source);
            return sortedArray[0];
        }

        static int[] Mode(int[] source)
        {
            return source;
        }

        static int Range(int[] source)
        {
            int[] sortedArray = uniqueSortedArray(source);    
            return sortedArray[sortedArray.Length - 1] - sortedArray[0];
        }
        static double StandardDeviation(int[] source)
        {
            int[] sortedArray = uniqueSortedArray(source);  
            double average = Mean(sortedArray);
            double[] powerOfDeviations = new double[sortedArray.Length];
            double total = 0; 
            for (int i = 0; i < sortedArray.Length; i++) {
                 powerOfDeviations[i] = Math.Pow((sortedArray[i] - average), 2);
            }
            for (int u = 0; u < powerOfDeviations.Length; u++) 
            {
                total += powerOfDeviations[u];
            }
            return Math.Sqrt(total / powerOfDeviations.Length);
        }

        static int[] uniqueSortedArray (int[] source) {
            
            int[] deepCopy = new int[source.Length];

            for (int i=0; i<source.Length; i++) // Iterate through array, one element at a time
            {
            deepCopy[i] = source[i];
            }
 
            
            Array.Sort(deepCopy);
            return deepCopy;
        }
    }
}