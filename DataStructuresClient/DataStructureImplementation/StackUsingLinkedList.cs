using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureImplementation
{
    class StackUsingLinkedList<T> where T:class
    {
        node<T> head = null;
        
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
                head = new node<T>(item,null);
                
            }
            else
            {
                node<T> oldNode = head;
                head = new node<T>(item,oldNode);               
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

    public class node<T> where T:class
    {
        public node(T item,node<T> node)
        {
            item = item;
            next = node;
        }
        public T item;
        public node<T> next ;
    }
}
