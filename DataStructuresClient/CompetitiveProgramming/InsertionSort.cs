using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveProgramming
{
    public class InsertionSort
    {

        public static void Sort(int[] elements)
        {
            var length = elements.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (elements[j] > elements[i])
                    {
                        var tmp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = tmp;
                    }
                }
            }
        }

    }
}
