using System;
using System.Collections.Generic;
using System.Linq;
using ErrorChecker;
using ArrayHelper;

namespace StatisticsHelper {
    static class Statistics
    {
        public static dynamic DescriptiveStatistics(int[] source)
        {
            ErrorHandler.checkInputs (source);
            Dictionary<string, dynamic> response =   
                       new Dictionary<string, dynamic>()
                       {
                           {"Maximum", Maximum(source)},
                           {"Minimum", Minimum(source)},
                           {"Mean", Mean(source)}, 
                           {"Median", Median(source)},
                           {"Mode", Mode(source)},
                           {"Range", Range(source)},
                           {"StandardDeviation", StandardDeviation(source)}
                       };
        
            return response;
        }

        public static int Maximum(int[] source)
        {
            int[] sortedArray = ArrayManipulation.uniqueSortedArray(source);
            return sortedArray[sortedArray.Length-1];
        }

        public static double Mean(int[] source)
        {
            double total = 0;
            for (int i = 0; i < source.Length; i++) 
            { 
                total += source[i];
            }
            
            return Math.Round(total/source.Length, 1);
        }

        public static double Median(int[] source)
        {
            int[] sortedArray = ArrayManipulation.uniqueSortedArray(source);
            double medianValue = 0;
            
            if (sortedArray.Length % 2 == 0)
            {
                double middleElement1 = sortedArray[(sortedArray.Length/2)-1];
                double middleElement2 = sortedArray[(sortedArray.Length/2)];
                medianValue = (middleElement1+middleElement2)/2;
            } 
            else
            {
                medianValue = sortedArray[sortedArray.Length/2];
            } 

            return Math.Round(medianValue, 1);
        }

        public static int Minimum(int[] source)
        {
            int[] sortedArray = ArrayManipulation.uniqueSortedArray(source);
            return sortedArray[0];
        }

        public static int[] Mode(int[] source)
        {
            int[] sortedArray = ArrayManipulation.uniqueSortedArray(source);
            int[] countArray = new int[sortedArray.Length];
            
            for (int x = 0; x < countArray.Length; x++) {
                countArray[x]=1;
            }

            for (int i = 1; i < sortedArray.Length; i++) {
                 if (sortedArray[i] == sortedArray[i-1])
                 countArray[i] = countArray[i-1]+1;
            }

            int max = countArray.Max();
            
            
            List<int> modeList = new List<int>();
            for (int u = 0; u < countArray.Length; u++) {
                if(countArray[u] == max)
                modeList.Add(sortedArray[u]);
            }
            
            return modeList.ToArray();
        }

        public static int Range(int[] source)
        {
            int[] sortedArray = ArrayManipulation.uniqueSortedArray(source);    
            return sortedArray[sortedArray.Length - 1] - sortedArray[0];
        }
        public static double StandardDeviation(int[] source)
        {
            int[] sortedArray = ArrayManipulation.uniqueSortedArray(source);  
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
            return Math.Round(Math.Sqrt(total / powerOfDeviations.Length), 1);
        }
    }
}