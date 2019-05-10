using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Queue
    {
        public int[] values;
        public int first;
        public int last;

        public Queue()
        {
            values = new int[100];
            first = -1;
            last = -1;
        }

        public void enqueue(int value)
        {
            if(first == -1)
            {
                first++;
            }

            values[++last] = value;
        }

        public void print()
        {
            Console.WriteLine("Priniting Queue");

            if (this.first == -1 && this.last == -1)
            {
                Console.WriteLine("Queue is Empty :(");
                return;
            }

            int queueItemSize = 0;

            while(queueItemSize <= this.last){
                Console.WriteLine(this.values[queueItemSize]);
                queueItemSize++;
            }
            
        }

        public void dequeue()
        {
            if (this.first == -1 && this.last == -1)
            {
                Console.WriteLine("Queue is Empty :(");
                return;
            }

            if (this.first == this.last)
            {
                Console.WriteLine("Last Element Remaining in the List :)");
                Console.WriteLine(this.values[this.first]);
                this.first = -1;
                this.last = -1;
            }

            Console.WriteLine("first : {0} && last : {1}", this.first, this.last);

            this.first ++;
            //this.last --;
        }

    }
}
