namespace ControlFlow
{
    public class Image
    {
        public void ImageMeasurements(int width, int height)
        {
            if(width>height) Console.WriteLine("Landscape");
            else Console.WriteLine("Portrait");
        }
    }
}