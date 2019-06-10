using System;
using System.Linq;

namespace DataStructureImplementation
{
    public class StackUsingArray
    {
        int[] stack = new int[5];
        int top = 0;
        public bool IsEmpty()
        {
            return stack.Any();
        }

        public void Push(int item)
        {
            if (top == stack.Length)
                throw new Exception("Stack is overflow");

            stack[top] = item;
            top++;
        }

        public int pop()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty");]
            return stack[top];
        }

    }
}
