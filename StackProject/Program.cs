using System;
using System.Collections.Generic;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push(4);
            Console.WriteLine(stack.ReturnLast());
            stack.Push(5);
            stack.Push(6);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.ReturnLast());
        }
    }

    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if(obj == null)
                throw new InvalidOperationException("Stack object cannot be null.");

            _list.Add(obj);
            _list.TrimExcess();
        }

        public object Pop()
        {
            if(_list.Count == 0)
                throw new InvalidOperationException("Stack empty.");

            var lastIndex = _list.Count - 1;
            var lastElement = _list[lastIndex];
            _list.RemoveAt(lastIndex);
            _list.TrimExcess();
            return lastElement;
        }

        public object ReturnLast()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stack empty.");

            return _list[_list.Count - 1];
        }

        public void Clear()
        {
            _list.Clear();
            _list.TrimExcess();
        }
    }
}
