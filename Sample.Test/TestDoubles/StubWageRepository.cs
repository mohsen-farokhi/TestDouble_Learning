
namespace TestDoubleSample.Test.Testdoubles
{
    internal class StubWageRepository : Sample.WageServices.Learn_02.IWageRepository
    {
        private StubWageRepository()
        {
        }

        public decimal GetCurrentWagePecent()
        {
            throw new System.NotImplementedException();
        }
    }
}
