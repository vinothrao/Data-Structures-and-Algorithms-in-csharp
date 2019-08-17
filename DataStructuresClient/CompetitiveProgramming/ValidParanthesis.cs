using System;
using System.Collections.Generic;
using System.Text;

namespace CompetitiveProgramming
{
   public class ValidParanthesis
    {
       
        public static int i = 0;

        public static bool ValidateParanthesis(string s)
        {
             Stack<char> stack = new Stack<char>();
            foreach(var c in s)
            { 
                if(c== '(' || c== '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        var item = stack.Peek();
                        if ((item == '{' && c == '}') || (item == '(' && c == ')') || (item == '[' && c == ']'))
                            stack.Pop();
                    }

                }

            }

            return stack.Count == 0;
        }

        public static void push(char j)
        {
           
           
        }

     


    }
}
