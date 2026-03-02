namespace DVA222_Labb5
{
    public class Literal : IVisitable {
        public readonly int Value;
        public Literal(int Value) {
            this.Value = Value;
        }
        public void Accept(IVisitor vtor) => vtor.Visit(this);
    }
}