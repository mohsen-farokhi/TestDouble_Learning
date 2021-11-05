using FluentAssertions;
using Sample.Test.TestDoubles.Stubs;
using Xunit;

namespace Sample.Test.WageService.Learn_03
{
    public class DamageServiceTest
    { 
        [InlineData(1000000, 0.5, 995000)]
        [InlineData(1000000, 1, 990000)]
        [Theory]
        public void wage_is_subtracted_from_amount
            (decimal amount, decimal wagePercent, decimal expected)
        {
            var repository = 
                ConfigurableStubWageRepository
                .CreateNewStub()
                .WithWagePercent(wagePercent);

            var service = new Wage.WageService(repository);

            var actual = service.Calculate(amount);

            // Output Verification
            actual.Should().Be(expected);
        }
    }
}
