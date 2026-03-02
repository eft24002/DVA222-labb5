using System;
using System.Collections.Generic;
namespace DVA222_Labb5
{
    public class Evaluator: IVisitor {
        public Evaluator(IVisitable t) {
            s = new Stack<int>();
            t.Accept(this);
        }
        public void Visit(Literal e) {
            s.Push(e.Value);
        }
        public void Visit(Add e) {
            e.Left.Accept(this);
            int left = s.Pop();
            e.Right.Accept(this);
            int right = s.Pop();
            s.Push(left+right);
        }
        public void Visit(Mul e) {
            e.Left.Accept(this);
            int left = s.Pop();
            e.Right.Accept(this);
            int right = s.Pop();
            s.Push(left*right);
        }
        public void Visit(Div e)
        {
            e.Left.Accept(this);
            int left = s.Pop();
            e.Right.Accept(this);
            int right = s.Pop();
            s.Push(left/right);
        }
          public void Visit(Fct e)
        {
            e.Left.Accept(this);
            int left = s.Pop();
            e.Right.Accept(this);
            int right = s.Pop();
            s.Push((int)Math.Pow(left, right));
        }

        public void Visit(Max e)
        {
            e.Left.Accept(this);
            int left = s.Pop();
            e.Right.Accept(this);
            int right = s.Pop();
            s.Push(Math.Max(left, right));
        }
        

        public void Clear() => s.Clear();
        public override string ToString() => s.Peek().ToString();
        private Stack<int> s;
    }

}