using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0411
{
    class MyStack
    {
        private int[] data = new int[50];
        private int top = 0;
        public MyStack()
        {
            top = 0;
        }
        public void Push(int n)
        {
            if (top<50)
            {
                data[top++] = n;
            } else
            {
                Console.WriteLine("Stack is full!");
            }

        }

        public int Pop()
        {
            if (top>0)
            {
                return data[--top];
            } else
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
        }
    }
}
