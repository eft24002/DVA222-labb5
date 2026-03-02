namespace DVA222_Labb5
{
    public class Fct : IVisitable
    {
        public Fct(IVisitable Left, IVisitable Right) {
            this.Left = Left;
            this.Right = Right;
        }
        public void Accept(IVisitor vtor) => vtor.Visit(this);
        public readonly IVisitable Left, Right;
    }
}
