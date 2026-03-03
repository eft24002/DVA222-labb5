using System.Collections;
using System.Collections.Generic;
using System;

namespace DVA222_Labb5
{
    public class Max : IVisitable, IEnumerable<IVisitable>
    {
        private IVisitable[] arguments;
        public Max(IVisitable[] arguments)
        {
            if(arguments == null || arguments.Length < 1) throw new ArgumentException("Max function requires at least one arguments.");   
            this.arguments = arguments;
        }
        public void Accept(IVisitor vtor) =>vtor.Visit(this);
        public IEnumerator<IVisitable> GetEnumerator() =>  new MaxEnumerator(this);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class MaxEnumerator : IEnumerator<IVisitable>
        {
            private Max max;
            private int position = -1;
            public MaxEnumerator(Max max)
            {
                this.max = max;
            }
            public IVisitable Current => max.arguments[position];
            object IEnumerator.Current => Current;
            public void Dispose() { }
            public bool MoveNext()
            {
                position++;
                return position < max.arguments.Length;
            }
            public void Reset() => position = -1;
        }
    }   
}