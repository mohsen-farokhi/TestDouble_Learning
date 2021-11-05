namespace Sample.Test.TestDoubles.Stubs
{
    internal class ConfigurableStubWageRepository : Wage.IWageRepository
    {
        private decimal _wagePercent;

        private ConfigurableStubWageRepository()
        {
        }

        public static ConfigurableStubWageRepository CreateNewStub()
        {
            return new ConfigurableStubWageRepository();
        }

        public ConfigurableStubWageRepository WithWagePercent(decimal wagePercent)
        {
            _wagePercent = wagePercent;

            return this;
        }

        public decimal GetCurrentWagePercent()
        {
            return _wagePercent;
        }
    }
}
