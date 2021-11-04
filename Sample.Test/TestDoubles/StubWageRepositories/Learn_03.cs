
namespace Sample.Test.TestDoubles.StubWageRepositories.Learn_03
{
    internal class StubWageRepository : Sample.WageServices.Learn_02.IWageRepository
    {
        private decimal _wagePercent;

        private StubWageRepository()
        {
        }

        public static StubWageRepository CreateNewStub()
        {
            return new StubWageRepository();
        }

        public StubWageRepository WithWagePercent(decimal wagePercent)
        {
            _wagePercent = wagePercent;

            return this;
        }

        public decimal GetCurrentWagePecent()
        {
            return _wagePercent;
        }
    }
}
