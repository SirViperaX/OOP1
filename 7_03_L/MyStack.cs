using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_03_L
{
    internal class MyStack
    {
        private int[] arr;
        private int capacity;
        private int size;
        public MyStack() : this(4)
        {
        }
        public MyStack(int capacity)
        {
            this.capacity = capacity;
            arr = new int[capacity];
            size = 0;
        }
        public void Push(int value)
        {
            Console.Write($"Try to push {value}...");
            if (size < capacity)
            {
                arr[size++] = value;
                Console.WriteLine(" Success.");
            }
            else
            {
                Console.WriteLine(" Failed.");
                throw new StackFullException("Stack full");
            }
        }
        private void Resize(int newsize)
        {
            int[] newarr = new int[newsize];
            for(int i = 0; i < size; i++) 
            {
                newarr[i] = arr[i];
            }
            arr = newarr;
        }
        public bool Empty
        {
            get
            {
                return size == 0;
            }
        }
        public int Pop()
        {
            if (!this.Empty)
            {
                size--;
                return arr[size];
            }
            else
            {
                throw new StackEmptyException("Stack empty");
            }
        }
    }
}
