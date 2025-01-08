namespace BasicPrograms
{
    class Factorial
    {
        public long FactorialOfNum(int x)
        {
            if (x < 0) return -1;
            if (x == 0 || x == 1) return 1;

            else return x*FactorialOfNum(x-1);
        }
    }
}