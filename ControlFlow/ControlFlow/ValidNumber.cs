namespace ControlFlow
{
    public class ValidNumber
    {
        public void Valid(int x)
        {
            if(x>=1 && x<=10) Console.WriteLine("Valid");
            else Console.WriteLine("Invalid");
        }
    }
}