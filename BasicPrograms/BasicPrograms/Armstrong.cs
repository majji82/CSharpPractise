namespace BasicPrograms
{
    public class Armstrong
    {
        public bool checkArmstrong(int x)
        {
            var digits = new CountDigits();
            var digitsOfNumber = digits.DigitsInNum(x);

            int newNum = 0;
            int num = x;
            while(x>0)
            {
                int temp = x % 10;
                x = x / 10;
                newNum = (int)(newNum + Math.Pow(temp, digitsOfNumber));
            }
            Console.WriteLine(newNum);

            if (newNum == num) return true;
            else return false;
        }
    }
}