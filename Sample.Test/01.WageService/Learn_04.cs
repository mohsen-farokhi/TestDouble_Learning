using FluentAssertions;
using Xunit;

namespace Sample.Test.WageService.Learn_04
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
                TestDoubles.StubWageRepositories.Learn_03.StubWageRepository
                .CreateNewStub()
                .WithWagePercent(wagePercent);

            var service =
                new Sample.WageServices.Learn_02.WageService(repository);

            var actual = service.Calculate(amount);

            actual.Should().Be(expected);
        }
    }
}
