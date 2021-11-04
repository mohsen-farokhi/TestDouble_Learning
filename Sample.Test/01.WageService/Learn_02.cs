using FluentAssertions;
using Xunit;

namespace Sample.Test.WageService.Learn_02
{
    public class DamageServiceTest
    {
        [Fact]
        public void wage_is_subtracted_from_amount()
        {
            var repository = 
                new TestDoubles.StubWageRepositories.Learn_02.StubWageRepository();

            var service = 
                new Sample.WageServices.Learn_02.WageService(repository);

            var actual = service.Calculate(1000000);

            actual.Should().Be(995000);
        }
    }
}
