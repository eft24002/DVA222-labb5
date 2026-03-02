namespace DVA222_Labb5
{
    interface IVisitor {
        void Visit(Literal elem);
        void Visit(Add elem);
        void Visit(Mul elem);
    }
}