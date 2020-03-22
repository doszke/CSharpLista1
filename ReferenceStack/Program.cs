using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceStack
{

    class ReferenceStack<T>
    {

        internal class Element<K>
        {
            private Element<K> before;
            private K value;
            private Element<K> after;

            internal Element(Element<K> before, K value, Element<K> after)
            {
                this.Before = before;
                this.Value = value;
                this.After = after;
            }

            internal Element<K> After { get => after; set => after = value; }
            internal Element<K> Before { get => before; set => this.before = value; }
            internal K Value { get => value; set => this.value = value; }
        }

        private Element<T> last;
        private int size = 0;

        public void Push(T value)
        {
            Element<T> element;
            if (size == 0)
            {
                element = new Element<T>(null, value, null);
            }
            else
            {
                element = new Element<T>(last, value, null);
                if (size > 1) { 
                    last.After = element;
                } 
                element.Before = last;
            }
            last = element;
            size++;
        }


        public T Pop()
        {
            Element<T> popped;
            if (size == 0)
            {
                return default(T);
            }
            else if (size == 1)
            {
                popped = last;
                last = null;
                size--;
            }
            else
            {
                popped = last;
                last = popped.Before;
                last.After = null;
                size--;
            }
            return popped.Value;
        }

        public int Size()
        {
            return size;
        }
    }

    class Program { 

        static void Main(string[] args)
        {

            ReferenceStack<char> stack = new ReferenceStack<char>();
            for (int i = 65; i < 91; i++)
            {
                stack.Push((char)i);
            }
            Console.WriteLine(stack.Size());

            StringBuilder sb = new StringBuilder();

            while (stack.Size() > 0 )
            {
                sb.Append(stack.Pop());
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine(stack.Size());
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
