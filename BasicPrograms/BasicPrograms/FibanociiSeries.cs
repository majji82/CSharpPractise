namespace BasicPrograms
{
    public class FibanociiSeries
    {
        public void Fib(int num)
        {
            int a = 0, b = 1;
            int c = a + b;

            Console.Write(a + " " + b + " " + c + " ");
            while(b+c<num)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(c + " ");
            }
        }
    }
}