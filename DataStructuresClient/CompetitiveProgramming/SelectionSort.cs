using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveProgramming
{
  public class SelectionSort
    {

        public static void Sort(int[] elements)
        {
            int length = elements.Length;
            int smallestIndex=0;
            for(int i=0;i<length;i++)
            {
                for(int j=i+1;j<length;j++)
                {
                    if(elements[i] > elements[j] )
                    {
                        smallestIndex = j;
                    }
                }

                int tmp = elements[smallestIndex];
                elements[smallestIndex] = elements[i];
                elements[i] = tmp;
            }
        }

    }
}
