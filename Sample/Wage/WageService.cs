namespace Sample.Wage
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
                _wageRepository.GetCurrentWagePercent();

            var wageValue = wagePercent * amount / 100;

            return amount - wageValue;
        }
    }
}
