using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureImplementation
{
    public class QueueUsingArray
    {
        int[] queue = new int[5];
        int front, rear;

        public QueueUsingArray()
        {
            front = rear = 0;
        }

        public bool IsEmpty()
        {
            return queue.Any();
        }

        public void EnQueue(int item)
        {
            if (rear == queue.Length)
                throw new Exception("Queue overflow");

            queue[rear] = item;
            rear++;
        }

        public int DeQueue()
        {
            if (IsEmpty())
                throw new Exception("queue is empty");

            var item = queue[front];
            front++;
            return item;
        }

    }
}
