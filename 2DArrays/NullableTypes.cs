using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArrays
{
    class NullableTypes
    {
        public static void Main(string[] args)
        {
            Nullable<int> a = null;
            int? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //var and dynamic-can able to change its data type any time
            //Parse and try parse
            int num = 45;
            bool result = int.TryParse("45", out num);
            Console.WriteLine(result);
            int num1 = int.Parse("45");
        }
    }
}
