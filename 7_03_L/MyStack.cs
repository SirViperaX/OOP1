using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_03_L
{
    internal class MyStack : IStack
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
            if (size == capacity)
            {
                Resize(capacity * 2);
            }
            arr[size++] = value;
            Console.WriteLine(" Success.");

        }
        public int Count => size;
        private void Resize(int newCapacity)
        {
            Console.WriteLine($"Resizing stack from {capacity} to {newCapacity}");
            int[] newarr = new int[newCapacity];
            for (int i = 0; i < size; i++)
            {
                newarr[i] = arr[i];
            }
            capacity = newCapacity;
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
                if (size == capacity / 4)
                {
                    Resize(capacity / 2);
                }
                return arr[size];
            }
            else
            {
                throw new StackEmptyException("Stack empty");
            }
        }
    }
}
