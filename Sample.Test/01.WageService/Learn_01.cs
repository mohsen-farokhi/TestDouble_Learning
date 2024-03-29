﻿using FluentAssertions;
using Sample.Test.TestDoubles.Stubs;
using Xunit;

namespace Sample.Test.WageService.Learn_01
{
    public class DamageServiceTest
    {
        [Fact]
        public void wage_is_subtracted_from_amount()
        {
            var repository =  new StubWageRepository();

            var service = new Wage.WageService(repository);

            var actual = service.Calculate(amount: 1000000);

            actual.Should().Be(expected: 995000);
        }
    }
}
