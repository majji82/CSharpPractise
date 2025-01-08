namespace ControlFlow
{
    public class SpeedCamara
    {
        public void Speed(int speedLimit, int carSpeed)
        {
            if(carSpeed<speedLimit) Console.WriteLine("Ok");
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                if(demeritPoints<12) Console.WriteLine(demeritPoints);
                else Console.WriteLine("License Suspended");
            }
        }
    }
}