using FluentAssertions;
using Xunit;

namespace Sample.Test.WageService.Learn_01
{
    public class DamageServiceTest
    {
        [Fact]
        public void wage_is_subtracted_from_amount()
        {
            var service = new Sample.WageServices.Learn_01.WageService();

            var calculatedAmount = service.Calculate(1000000);

            calculatedAmount.Should().Be(995000);
        }
    }
}
