using System;
using System.Collections.Generic;

namespace Plus_Minus
{
    class Program
    {
        public static void plusMinus(List<int> arr)
        {
            decimal length = arr.Count;
            decimal pos = 0;
            decimal neg = 0;
            decimal zero = 0;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                if (arr[i] == 0)
                {
                    zero++;
                }
                if (arr[i] < 0)
                {
                    neg++;
                }
            }

            decimal posRatio = pos / length;
            decimal negRatio = neg / length;
            decimal zeroRatio = zero / length;

            Console.WriteLine(posRatio);
            Console.WriteLine(negRatio);
            Console.WriteLine(zeroRatio);
        }

    }


}
}
