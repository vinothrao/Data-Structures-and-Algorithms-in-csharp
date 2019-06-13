using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureImplementation
{
    class StackUsingLinkedList<T> where T:class
    {
        Node<T> head = null;
        
        public StackUsingLinkedList()
        {

        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Push(T item)
        {
            if(head==null)
            {
                head = new Node<T>(item,null);
                
            }
            else
            {
                Node<T> oldNode = head;
                head = new Node<T>(item,oldNode);               
            }
        }

        public T pop()
        {
            if (head == null)
               throw new Exception("Stack is empty");

            var oldHead = head;
            head = oldHead.next;
            oldHead.next = null;
            return head.item;
        }
    }

   
}
