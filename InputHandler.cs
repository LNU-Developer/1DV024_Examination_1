using System;
//using NewtonSoft.Json;

namespace InputHandler 
{
    static class Inputs 
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

        public static int[] importJSON () {
            int[] import = new int[] { 5, 1, 1, 1, 3, -2, 2, 5, 7, 4, 5, 16 };
            checkInputs (import);
            return import;
        }
    }
}