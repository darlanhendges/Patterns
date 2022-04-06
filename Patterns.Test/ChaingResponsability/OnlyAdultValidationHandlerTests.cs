using FluentAssertions;
using Patterns.ChainResponsability.ConcreteHandlers;
using Patterns.ChainResponsability.Request;
using System;
using Xunit;

namespace Patterns.Test.ChaingResponsability
{
    public class OnlyAdultValidationHandlerTest
    {
        [Fact]
        public void When_Age_Is_Invalid_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { BirthDate = DateTime.Now };

            //Act
            Action act = () => new OnlyAdultValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_Age_Is_Valid_Then_Exception_Should_Be_Okay()
        {
            //Arrange
            var user = new User { BirthDate = DateTime.Now.AddYears(-19) };

            //Act
            Action act = () => new OnlyAdultValidationHandler().Handle(user);

            //Assert
            act.Should().NotThrow<Exception>();
        }
    }
}
