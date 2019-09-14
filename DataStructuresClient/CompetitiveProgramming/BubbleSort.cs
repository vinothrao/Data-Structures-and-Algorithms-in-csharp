using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveProgramming
{
   public class BubbleSort
    {
        public static void Sort(int[] elements)
        {
            var length = elements.Length;

            for(int i=0;i<length;i++)
            {
                for(int j=0;j<length;j++)
                {
                    if(elements[j]>elements[j+1])
                    {
                        var tmp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = tmp;
                    }
                }
            }



        }


    }
}
