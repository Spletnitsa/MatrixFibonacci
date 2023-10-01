namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static public long FastPower(long digit, int pow) 
        {
            if (pow == 0)
                return 1;
            else if (pow == 1)
                return digit;
            else if (pow == 2)
                return digit * digit;
            else if (pow % 2 == 0)
            {
                digit *= digit;
                return FastPower(digit, pow / 2);
            }
            else if (pow % 2 != 0)
                return digit * FastPower(digit, pow - 1);

            return 0;
        }
    }
}