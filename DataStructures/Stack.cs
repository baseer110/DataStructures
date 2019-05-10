using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Stack
    {
        public int[] stack;//= new [10];
        public int top;

        public Stack(int value)
        {
            stack = new int[10];
            top = -1;
        }

        public void push(int value)
        {
            stack[++top] = value;
        }

        public void pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                top--;
            }
        }

        public void print()
        {
            Console.WriteLine("Printing --->");
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }

    }
}
