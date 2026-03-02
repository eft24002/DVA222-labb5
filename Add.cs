namespace DVA222_Labb5
{
     public class Add : IVisitable
    {
        public Add(IVisitable Left, IVisitable Right) {
            this.Left = Left;
            this.Right = Right;
        }
        public void Accept(IVisitor vtor) => vtor.Visit(this);
        public readonly IVisitable Left, Right;
    }
}