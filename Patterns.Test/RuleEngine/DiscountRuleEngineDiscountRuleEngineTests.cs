using Patterns.RuleEngine.Interfaces;
using Patterns.RuleEngine.Concrete.Rules;
using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit;
using Patterns.RuleEngine.Concrete.Models;
using Patterns.RuleEngine.Concrete;
using FluentAssertions;

namespace Patterns.Test.RuleEngine
{
    public class DiscountRuleEngineDiscountRuleEngineTests
    {
        private readonly ITestOutputHelper _output;
        private readonly List<IDiscountRule> _rules = new();

        public DiscountRuleEngineDiscountRuleEngineTests(ITestOutputHelper output)
        {
            _rules = new List<IDiscountRule>()
            {
                 new RuleLowerThan18YearsDiscount(),
                 new RuleGreaterThan18YearsDiscount(),
                 new RuleSeniorDiscount(),
                 new RuleElderlyDiscount()
            };

            this._output = output;
        }

        [Theory]
        [InlineData(-15)]
        [InlineData(-16)]
        [InlineData(-17)]
        public void When_Is_Valid_Should_Be_05_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Now.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRuleEngine ruleEngile = new DiscountRuleEngine(_rules);

            //Act
            var discount = ruleEngile.CalculateDiscountPercentage(customer);
            _output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.05M);
        }

        [Theory]
        [InlineData(-19)]
        [InlineData(-20)]
        [InlineData(-21)]
        [InlineData(-44)]
        [InlineData(-45)]
        public void When_Is_Valid_Should_Be_10_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Now.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRuleEngine ruleEngile = new DiscountRuleEngine(_rules);

            //Act
            var discount = ruleEngile.CalculateDiscountPercentage(customer);
            _output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.10M);
        }

        [Theory]
        [InlineData(-46)]
        [InlineData(-47)]
        [InlineData(-48)]
        [InlineData(-49)]
        [InlineData(-65)]
        public void When_Is_Valid_Should_Be_15_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Now.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRuleEngine ruleEngile = new DiscountRuleEngine(_rules);

            //Act
            var discount = ruleEngile.CalculateDiscountPercentage(customer);
            _output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.15M);
        }

        [Theory]
        [InlineData(-66)]
        [InlineData(-67)]
        [InlineData(-68)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void When_Is_Valid_Should_Be_20_Valid(int years)
        {
            //Arrange
            var customer = new Customer()
            {
                Birthday = DateTime.Now.AddYears(years),
                Id = 1,
                Name = "Darlan"
            };

            IDiscountRuleEngine ruleEngile = new DiscountRuleEngine(_rules);

            //Act
            var discount = ruleEngile.CalculateDiscountPercentage(customer);
            _output.WriteLine("Birthday: {0}", customer.Birthday);

            //Assert
            discount.Should().Be(.20M);
        }
    }
}
