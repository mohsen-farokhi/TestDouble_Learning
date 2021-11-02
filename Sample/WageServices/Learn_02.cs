namespace Sample.WageServices.Learn_02
{
    public class WageService
    {
        private readonly IWageRepository _wageRepository;

        public WageService(IWageRepository wageRepository)
        {
            _wageRepository = wageRepository;
        }

        public decimal Calculate(decimal amount)
        {
            var wagePercent = 
                _wageRepository.GetCurrentWagePecent();

            var wageValue = wagePercent * amount / 100;

            return amount - wageValue;
        }
    }

    public interface IWageRepository
    {
        decimal GetCurrentWagePecent();
    }

    public class WageRepository : IWageRepository
    {
        public decimal GetCurrentWagePecent()
        {
            return 0.5M; // read from db
        }
    }
}
