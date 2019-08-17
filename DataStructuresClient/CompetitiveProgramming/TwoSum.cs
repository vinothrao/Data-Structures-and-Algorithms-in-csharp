using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveProgramming
{
    public class TwoSum
    {

        public int[] TwoSumFind(int[] nums, int target)
        {

            //Dictionary<int, int> numbers = new Dictionary<int, int>();
            Hashtable numbers = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (numbers.Contains(diff))
                {
                     
                    return new int[] { (int)numbers[diff] , i };
                }

                numbers[nums[i]]=i;
                

            }
            return null;

        }
    }

    public class InternlDict
    {
        int key;
        int value;
    }
}
