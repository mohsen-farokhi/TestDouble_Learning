using FluentAssertions;
using Sample.Test.TestDoubles.Stubs;
using Xunit;

namespace Sample.Test.WageService.Learn_02
{
    public class DamageServiceTest
    {
        [Fact]
        public void wage_is_subtracted_from_amount()
        {
            var repository = new ConfigurableStubWageRepository();

            repository.WithWagePercent(0.5M);

            var service = new Wage.WageService(repository);

            var actual = service.Calculate(1000000);

            actual.Should().Be(995000);
        }
    }
}
