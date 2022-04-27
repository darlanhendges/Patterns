using FluentAssertions;
using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Concrete.Rules;
using Patterns.RuleEngine.Interfaces;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Patterns.Test.RuleEngine.Rules
{
    public class GreaterThan18YearsDiscountTests
    {
        private readonly ITestOutputHelper output;

        public GreaterThan18YearsDiscountTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(-19)]
        [InlineData(-29)]
        public void When_Is_Valid_Should_Be_10_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Now.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRule rule = new RuleGreaterThan18YearsDiscount();

            //Act
            var discount = rule.CalculateDiscountPercentage(customer);
            output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.10M);
        }


        [Theory]
        [InlineData(17)]
        [InlineData(18)]
        public void When_Is_Valid_Should_Be_0_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Today.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRule rule = new RuleGreaterThan18YearsDiscount();

            //Act
            var discount = rule.CalculateDiscountPercentage(customer);
            output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.0M);
        }
    }
}
