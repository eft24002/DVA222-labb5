namespace DVA222_Labb5
{
    public static class FactorialCalc
    {
        public static int Factorial(int value)
        {
            if (value < 0) throw new FactorialOfNegativeException();

            if(value == 0) return 1;

            return value * Factorial(value-1);
        }
    }
}