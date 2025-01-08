namespace BasicPrograms
{
    public class CountDigits
    {
        public int DigitsInNum(int num)
        {
            int c = 0;
            while(num>0)
            {
                num = num / 10;
                c++;
            }

            return c;
        }
    }
}