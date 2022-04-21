using FluentAssertions;
using Patterns.Decorator.Abstraction;
using Patterns.Decorator.Concrete;
using System;
using Xunit;

namespace Patterns.Test.Decorator
{

    public class DecoratorTests
    {
        [Fact]
        public void When_Quantity_Is_Valid_Should_Be_Valid()
        {
            //Arrange
            IAccountService accountService = new AccountServiceLoggingDecorator(new AccountService(2));

            //Act
            Action act = () => accountService.DecreaseQuantity();

            //Assert
            act.Should().NotThrow<Exception>();
        }

        [Fact]
        public void When_Quantity_Is_Not_Valid_Should_Be_Throw_An_Exception()
        {
            //Arrange
            IAccountService accountService = new AccountServiceLoggingDecorator(new AccountService(0));

            //Act
            Action act = () => accountService.DecreaseQuantity();

            //Assert
            act.Should().Throw<Exception>();
        }
    }
}
