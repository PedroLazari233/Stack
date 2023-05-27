using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private int _top;
        private List<object> _elements;

        public Stack()
        {
            _elements = new List<object>();
            _top = -1;
        }

        private bool IsEmpty()
        {
            return _top == -1;
        }

        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Error: Can't pass empty objects!");
            }

            _top++;
            _elements.Add(obj);
        }

        public object Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Error: Tha stack is empty!");
                return -1;
            }

            object obj = _elements[_top];
            _top--;
            return obj;
        }

        public void Clear()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is already empty!");
                return;
            }

            _top = -1;
            _elements.Clear();
        }
    }
}
