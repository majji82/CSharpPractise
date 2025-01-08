namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();

            //var add = new Addition();
            //Console.WriteLine("The sum of 1 and 2 is: ");
            //Console.WriteLine(add.AddTwoNumbers(1, 2));

            //Maximum of three numbers
            //var max = new MaxOfThree();
            //Console.WriteLine("The max of three numbers is: ");
            //Console.WriteLine(max.Maxi(187,237,237));

            // Check Even or odd
            //CheckEven();

            //Find Factorial
            //FactorialOfNum();

            // Simple Interest
            //Console.WriteLine("The simple interest is: " + SimpleInterest());

            // Compound Interest
            //Console.WriteLine("Compound interest is: " + Compound());

            // Armstrong
            //ArmstrongNumber();

            // Check Prime or not
            //PrimeNumber();

            //Print primes in an interval
            //PrimesInInterval();

            // Fibanocii Series
            FibSeries();

        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!!");
        }

        static void CheckEven()
        {
            var even = new CheckEvenOrOdd();
            Console.WriteLine("Enter a number to chech whether it is even or odd: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(even.CheckEven(num)==false) Console.WriteLine("It is an odd number");
            else Console.WriteLine("It is an even number");
        }

        static void FactorialOfNum()
        {
            var fact = new Factorial();
            Console.WriteLine("Enter a number to find factorial of it: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fact.FactorialOfNum(num));
        }

        static double SimpleInterest()
        {
            Console.WriteLine("Enter principal amount, time and ROI: ");
            int principal = Convert.ToInt32(Console.ReadLine());
            float time = Convert.ToSingle(Console.ReadLine());
            float rate = Convert.ToSingle(Console.ReadLine());

            var simpleInterest = new SimpleInterest();
            return simpleInterest.SI(principal, time, rate);
        }

        static double Compound()
        {
            Console.WriteLine("Enter pricipal, time and ROI");
            int principal = Convert.ToInt32(Console.ReadLine());
            double time = Convert.ToDouble(Console.ReadLine());
            double rate = Convert.ToDouble(Console.ReadLine());

            var compound = new CompoundInterest();
            return compound.CI(principal, time, rate);
        }

        static void ArmstrongNumber()
        {
            var arm = new Armstrong();
            Console.WriteLine("Enter a num to check for armstrong: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(arm.checkArmstrong(num)) Console.WriteLine("It is an armstrong number");
            else Console.WriteLine("It is not an armstrong number");
        }

        static void PrimeNumber()
        {
            var prime = new CheckPrime();
            Console.WriteLine("Enter a number to check it is prime or not: ");
            var num = Convert.ToInt32(Console.ReadLine());
            if (prime.PrimeOrNot(num)) Console.WriteLine("It is a prime Number");
            else Console.WriteLine("It is not a prime number");
        }

        static void PrimesInInterval()
        {
            Console.WriteLine("Enter the range (inclusive)");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            var prime = new CheckPrime();
            for(int i=a; i<=b; i++)
            {
                if(prime.PrimeOrNot(i)) Console.Write(i + " ");
            }
        }

        static void FibSeries()
        {
            Console.WriteLine("Enter a number to end fib series: ");
            int num = Convert.ToInt32(Console.ReadLine());

            var fib = new FibanociiSeries();
            fib.Fib(num);
        }
    }
}