namespace DVA222_Labb5
{
    public class FactorialOfNegativeException : ArgumentException
    {
        public FactorialOfNegativeException() : base("You cannot calculate the factorial of a negative number.")
        {}
    }
}