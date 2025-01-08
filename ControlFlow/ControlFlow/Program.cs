namespace ControlFlow
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ValidNumber();
            //MaxValue();
            //LandScapeOrPortrait();
            SpeedLimit();
        }

        static void ValidNumber()
        {
            var valid = new ValidNumber();
            Console.WriteLine("Enter a number: ");
            var num = Convert.ToInt32(Console.ReadLine());
            valid.Valid(num);
        }

        static void MaxValue()
        {
            var maxValue = new MaxOfTwo();
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The max value among " + a + "and " + b + " is: " + maxValue.MaxValue(a, b));
        }

        static void LandScapeOrPortrait()
        {
            var img = new Image();

            Console.WriteLine("Enter width and height of img: ");
            var width = Convert.ToInt32(Console.ReadLine());
            var height = Convert.ToInt32(Console.ReadLine());

            img.ImageMeasurements(width, height);
        }

        static void SpeedLimit()
        {
            var spCamara = new SpeedCamara();
            Console.WriteLine("Enter the speed Limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car: ");
            int speedOfCar = Convert.ToInt32(Console.ReadLine());

            spCamara.Speed(speedLimit, speedOfCar);
        }
    }
}