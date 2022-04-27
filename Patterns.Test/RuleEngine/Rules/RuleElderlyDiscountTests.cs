using FluentAssertions;
using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Concrete.Rules;
using Patterns.RuleEngine.Interfaces;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Patterns.Test.RuleEngine.Rules
{
    public class RuleElderlyDiscountTests
    {
        private readonly ITestOutputHelper output;

        public RuleElderlyDiscountTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(-66)]
        [InlineData(-67)]
        [InlineData(-90)]
        public void When_Is_Valid_Should_Be_20_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Now.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRule rule = new RuleElderlyDiscount();

            //Act
            var discount = rule.CalculateDiscountPercentage(customer);
            output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.20M);
        }


        [Theory]
        [InlineData(0)]
        [InlineData(18)]
        [InlineData(66)]
        [InlineData(68)]
        public void When_Is_Valid_Should_Be_0_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Today.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRule rule = new RuleElderlyDiscount();

            //Act
            var discount = rule.CalculateDiscountPercentage(customer);
            output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.0M);
        }
    }
}
