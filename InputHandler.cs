using System;
using Newtonsoft.Json;
using System.IO;

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
            int[] import = JsonConvert.DeserializeObject<int[]>(File.ReadAllText(@"data.json"));
            checkInputs (import);
            return import;
        }
    }
}