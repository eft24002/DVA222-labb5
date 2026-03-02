namespace DVA222_Labb5
{
    public class Max : IVisitable
    {
        public Max(IVisitable Left, IVisitable Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
        public void Accept(IVisitor vtor) => vtor.Visit(this);
        public readonly IVisitable Left, Right;
    }
}