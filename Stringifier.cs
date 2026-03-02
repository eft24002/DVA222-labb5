using System.Text;  // stringbuilder

namespace DVA222_Labb5
{
    class Stringifier: IVisitor {
        public Stringifier(IVisitable t) {
            s = new StringBuilder();
            t.Accept(this);
        }
        public void Visit(Literal e) {
            s.Append(e.Value);
        }
        public void Visit(Add e) {
            s.Append("(");
            e.Left.Accept(this);
            s.Append("+");
            e.Right.Accept(this);
            s.Append(")");
        }
        public void Visit(Mul e) {
            e.Left.Accept(this);
            s.Append("*");
            e.Right.Accept(this);
        }
        public void Clear() => s.Clear();
        public override string ToString() => s.ToString();
        private StringBuilder s;
    }
}