using System;

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
        }

        public T Pop()
        {
            if (IsEmpty())
                return default(T);

            _items[Top] = default(T);
            return _items[Top--];
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
            return Top.Equals(-1);
        }
    }
}

