using FluentAssertions;
using Xunit;

namespace Sample.Test.WageServices
{
    public class Learn_01_Test
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
