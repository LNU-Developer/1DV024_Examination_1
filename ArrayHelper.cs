using System;

namespace ArrayHelper {
    static class ArrayManipulation
    {
        public static int[] uniqueSortedArray (int[] source) 
        {
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