using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public class SingleLinkedList
    {
       public Node start;

        public void insert (int value)
        {
            Node current = start;

            while(current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node(value);
            current.next = newNode;
        }

        public void print()
        {
            Node currentNode = start;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.value);
                currentNode = currentNode.next;
            }
        }

        public void deleteNode(int value)
        {
            // There are 3 cases for delete

            // Case 1 : When value is the start value
            if(value == start.value)
            {
                start = start.next;
                return;
            }

            // Case 2 : When value is in between 2 values for e.g:
            // List = 1,2,3,4,5
            // Value to Delete is 3
            Node currentValue = start;

            while(currentValue.next.value != value)
            {
                currentValue = currentValue.next;
            }

            currentValue.next = currentValue.next.next;
        }

        public void searchValue(int value)
        {
            Node current = start;

            while(current != null)
            {
                if(current.value == value)
                {
                    Console.WriteLine("Value Exist");
                    return;
                }

                current = current.next;
            }
        }

    }
}
