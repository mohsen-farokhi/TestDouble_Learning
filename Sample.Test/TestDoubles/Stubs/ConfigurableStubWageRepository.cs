namespace Sample.Test.TestDoubles.Stubs
{
    internal class ConfigurableStubWageRepository : Wage.IWageRepository
    {
        private decimal _wagePercent;

        public void WithWagePercent(decimal wagePercent)
        {
            _wagePercent = wagePercent;
        }

        public decimal GetCurrentWagePercent()
        {
            return _wagePercent;
        }
    }
}
