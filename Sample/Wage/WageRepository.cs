namespace Sample.Wage
{
    public class WageRepository : IWageRepository
    {
        public decimal GetCurrentWagePercent()
        {
            // read from db
            System.Threading.Thread.Sleep(3000);

            return 0.5M;
        }
    }
}
