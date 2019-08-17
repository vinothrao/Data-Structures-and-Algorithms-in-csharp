using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveProgramming
{
    public class TrappingRainWater
    {
        public static int Trap(int[] height)
        {

            List<int> capacity = new List<int>();

            int totalCapacity = 0;

            foreach(var h in height)
            {
                
                if(h>capacity.Max())
                {
                    foreach (var i in capacity)
                        totalCapacity = +capacity.Max() - i;                  

                }
                capacity.Add(h);
            }

            return totalCapacity;
        }
    }
}
