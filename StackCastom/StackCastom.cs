using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCastom
{
    public class StackCastom : ICharStack
    {
        private char[] storage;
        private int capacity;
        private int position;

        public StackCastom(int capacity)
        {
            this.capacity = capacity;
            storage = new char[capacity];
            position = -1;
        }

        public bool Add(char value)
        {
            if (!IsFull())
            {
                storage[++position] = value;
                return true;
            }
            return false;
        }

        public char Delete()
        {
            if (!IsEmpty())
            {
                return storage[position--];
            }
            return '!';
        }

        public bool IsEmpty()
        {
            return position < 0;
        }

        public bool IsFull()
        {
            return position >= capacity - 1;
        }
    }
}
