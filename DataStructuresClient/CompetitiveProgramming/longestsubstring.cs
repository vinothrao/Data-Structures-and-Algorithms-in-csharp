using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveProgramming
{
    public class longestsubstring
    {

        public static int NaiveApproach()
        {
            string s = " ";  
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                HashSet<char> sub = new HashSet<char>() { s[i] };
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (!sub.Contains(s[j]))
                    { sub .Add(s[j]); }
                    else
                    {                     
                        break;
                    }
                }
                max = Math.Max(max, sub.Count);
              
            }
            return max;
           
        }

        public static int SlidingWindow()
        {
            string s = " ";

            int i = 0,j=0,max=0;
            HashSet<char> subString = new HashSet<char>();
            
            while(i<s.Length && j<s.Length)
            {                
                if(!subString.Contains(s[j]))
                {
                    subString.Add(s[j]);
                   
                    j++;
                }
                else
                {
                   
                    subString.Clear();
                    i++;
                }
            }
            return max;

        }

    }


}
