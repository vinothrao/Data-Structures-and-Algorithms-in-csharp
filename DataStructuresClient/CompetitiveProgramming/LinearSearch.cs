using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveProgramming
{
   public class LinearSearch<T> where T:class
    {

        public static int Search(T[] items,T searchItem)
        {
            for(int i=0;i<items.Length;i++ )
            {
                if (items[i] == searchItem)
                    return i;
            }
            //if not found
            return -1;
        }


    }
}
