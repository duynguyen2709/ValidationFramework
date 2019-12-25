using System;
using System.Collections.Generic;

namespace Validation_App.Rule
{
    public class Utility
    {
        public static List<Type> NumericTypes = new List<Type>()
            {
                typeof(int),
                typeof(uint),
                typeof(float),
                typeof(double),
                typeof(decimal),
                typeof(sbyte),
                typeof(byte),
                typeof(decimal)
            };

        public static List<Type> StringTypes = new List<Type>()
            {
                typeof(string),
                typeof(char)
            };
    }
}
