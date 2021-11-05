namespace Sample.Test.TestDoubles.Stubs
{
    internal class StubWageRepository : Wage.IWageRepository
    {
        public decimal GetCurrentWagePercent()
        {
            return 0.5M;
        }
    }
}
