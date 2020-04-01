using System;

namespace ErrorChecker {
    static class ErrorHandler 
    {
        public static void checkInputs (int[] source) 
        {
            if (source is null) 
            {
            throw new System.ArgumentNullException();
            }
            if (source.Length == 0) 
            {
            throw new InvalidOperationException("Sequence contains no elements");
            }
        }
    }
}