namespace BasicPrograms
{
    public class CompoundInterest
    {
        public double CI(int principal,  double time, double ROI)
        {
            double amount = principal * (Math.Pow(1 + ROI/100, time));
            return amount - principal;
        }
    }
}