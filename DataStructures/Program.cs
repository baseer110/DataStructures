using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructures
{   
    
    class Program
    {
        public static void initializeLinkedList()
        {
            SingleLinkedList oLinkedList = new SingleLinkedList();
            oLinkedList.start = new Node(5);
            oLinkedList.insert(6);
            oLinkedList.insert(4);
            oLinkedList.insert(5);
            oLinkedList.insert(9);

            // oLinkedList.deleteNode(4);

            oLinkedList.searchValue(9);

            oLinkedList.print();
        }

        public static void initializeStack()
        {
            Stack oStack = new Stack(1);
            oStack.push(1);
            oStack.push(2);
            oStack.push(3);
            oStack.print();
            oStack.pop();
            oStack.print();

        }

        public static void initializeQueue()
        {
            Queue oQueue = new Queue();
            oQueue.dequeue();
            oQueue.enqueue(4);
            oQueue.enqueue(10);
            oQueue.enqueue(5);            
            oQueue.print();
            oQueue.dequeue();
            oQueue.dequeue();
            oQueue.dequeue();
            oQueue.print();
        }
        
        
        static void Main(string[] args)
        {
            // Linked List
            // initializeLinkedList();

            // Stack 
            // initializeStack(); 

            // Queue
            initializeQueue();

            Console.ReadKey();
        }
    }
}
