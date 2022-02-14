using FluentAssertions;
using Sample.Wage;
using Xunit;

namespace Sample.Test.WageService.Learn_00
{
    public class DamageServiceTest
    {
        [Fact]
        public void wage_is_subtracted_from_amount()
        {
            // 1. Arrange 
            var repository = new WageRepository();
            var service = new Wage.WageService(repository);

            // 2. Act
            var actual = service.Calculate(amount: 1000000);

            // 3. Assert
            //Assert.Equal(expected: 995000, actual: actual);

            actual.Should().Be(expected: 995000);
        }
    }
}
