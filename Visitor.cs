namespace DVA222_Labb5
{
    public interface IVisitor {
        void Visit(Literal elem);
        void Visit(Add elem);
        void Visit(Mul elem);
        void Visit(Div elem);
        void Visit(Max elem);
        void Visit(Fct elem);
    }
}