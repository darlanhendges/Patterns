using FluentAssertions;
using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Concrete.Rules;
using Patterns.RuleEngine.Interfaces;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Patterns.Test.RuleEngine.Rules
{
    public class RuleSeniorDiscountTests
    {
        private readonly ITestOutputHelper output;

        public RuleSeniorDiscountTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(-46)]
        [InlineData(-47)]
        [InlineData(-57)]
        [InlineData(-67)]
        public void When_Is_Valid_Should_Be_15_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Now.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRule rule = new RuleSeniorDiscount();

            //Act
            var discount = rule.CalculateDiscountPercentage(customer);
            output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.15M);
        }


        [Theory]
        [InlineData(-45)]
        [InlineData(25)]
        [InlineData(10)]
        public void When_Is_Valid_Should_Be_0_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Today.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRule rule = new RuleSeniorDiscount();

            //Act
            var discount = rule.CalculateDiscountPercentage(customer);
            output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.0M);
        }
    }
}
