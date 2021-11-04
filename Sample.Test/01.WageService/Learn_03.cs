using FluentAssertions;
using Xunit;

namespace Sample.Test.WageService.Learn_03
{
    public class DamageServiceTest
    {
        [Fact]
        public void wage_is_subtracted_from_amount()
        {
            // 1. Setup
            var repository =
                TestDoubles.StubWageRepositories.Learn_03.StubWageRepository
                .CreateNewStub()
                .WithWagePercent(0.5M);

            //2. Install
            var service = 
                new Sample.WageServices.Learn_02.WageService(repository);

            var actual = service.Calculate(1000000);

            //3. Verify
            actual.Should().Be(995000);
        }
    }
}
