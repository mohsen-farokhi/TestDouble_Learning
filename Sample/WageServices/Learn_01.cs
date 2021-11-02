namespace Sample.WageServices.Learn_01
{
    public class WageService
    {
        public decimal Calculate(decimal amount)
        {
            var wageRepository = new WageRepository();

            var wagePercent = wageRepository.GetCurrentWagePecent();

            var wageValue = wagePercent * amount / 100;

            return amount - wageValue;
        }
    }

    public class WageRepository
    {
        public decimal GetCurrentWagePecent()
        {
            return 0.5M; // read from database
        }
    }
}
