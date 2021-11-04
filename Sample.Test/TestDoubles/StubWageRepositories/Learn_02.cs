
namespace Sample.Test.TestDoubles.StubWageRepositories.Learn_02
{
    internal class StubWageRepository : Sample.WageServices.Learn_02.IWageRepository
    {
        public decimal GetCurrentWagePecent()
        {
            return 0.5M;
        }
    }
}
