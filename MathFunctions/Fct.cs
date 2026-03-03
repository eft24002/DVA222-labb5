namespace DVA222_Labb5
{
    public class Fct : IVisitable
    {
        public Fct(IVisitable Argument)
        {
            this.Argument = Argument;
        }

        public void Accept(IVisitor vtor) => vtor.Visit(this);
        public readonly IVisitable Argument;
    }
}