using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureImplementation
{

    public class Node<T> where T : class
    {
        public Node(T item, Node<T> node)
        {
            item = item;
            next = node;
        }
        public T item;
        public Node<T> next;
    }

}
