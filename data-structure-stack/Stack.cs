using System;
using System.Linq;

namespace data_structure_stack
{
    public class Stack<T>
    {
        public int Top { get; private set; }
        public int Length { get => _items.Length; }
        private readonly T[] _items;
        private const int InitialTopEmptyStack = -1;

        public Stack(int size)
        {
            _items = new T[size];
            Top = InitialTopEmptyStack;
        }

        public void Push(T item)
        {
            if (Top < _items.Length - 1)
            {
                _items[++Top] = item;
            }
            else
            {
                throw new IndexOutOfRangeException("It's not possible push items out of length stack range");
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                _items[Top] = default(T);
                Top--;
            }
        }

        public void PrintElements()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                Console.WriteLine($"items[{i}] = {_items[i]}");
            }
        }

        public bool IsEmpty()
        {
            return Top.Equals(InitialTopEmptyStack);
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }
    }
}

