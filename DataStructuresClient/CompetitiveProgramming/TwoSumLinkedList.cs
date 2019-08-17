using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetitiveProgramming
{
   public class TwoSumLinkedList
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode temp = new ListNode(l1.val);
            temp = l1;
            string num1="",num2="";
            int val1, val2;
            int i = 0;

             while(temp.next!=null)
            {
                num1 += Convert.ToString(temp.val);
                temp = temp.next;
                i++;
            }

            temp = l2;
            i = 0;
            while(temp.next != null)
            {
                num2 += Convert.ToString(temp.val);
                temp = temp.next;
                i++;
            }

            val1 = Convert.ToInt32(num1.Reverse());
            val2 = Convert.ToInt32(num2.Reverse());

            temp.val = val1 + val2;
            temp.next = null;
            return temp;
            
        }


    }
}


/**
 * Definition for singly-linked list. */
  public class ListNode {
     public int val;
      public ListNode next;
     public ListNode(int x) { val = x; }
 }

