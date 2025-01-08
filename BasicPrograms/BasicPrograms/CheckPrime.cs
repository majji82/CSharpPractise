namespace BasicPrograms
{
    class CheckPrime
    {
        public bool PrimeOrNot(int x)
        {
            int c = 0;
            for(int i=1; i<=x/2; i++)
            {
                if (x % i == 0) c++;
            }

            if (c == 1) return true;
            else return false;
        }
    }
}