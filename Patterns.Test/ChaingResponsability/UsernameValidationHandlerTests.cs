using FluentAssertions;
using Patterns.ChainResponsability.ConcreteHandlers;
using Patterns.ChainResponsability.Request;
using System;
using Xunit;

namespace Patterns.Test.ChaingResponsability
{
    public class UsernameValidationHandlerTests
    {
        [Fact]
        public void When_Username_Is_Invalid_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { Username = String.Empty };

            //Act
            Action act = () => new UsernameValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_Username_Is_Ivalid_And_Is_Empty_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { Username = " " };

            //Act
            Action act = () => new UsernameValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_Username_Is_Valid_Then_Should_Be_Okay()
        {
            //Arrange
            var user = new User { Username = Generator.RandomString(10) };

            //Act
            Action act = () => new UsernameValidationHandler().Handle(user);

            //Assert
            act.Should().NotThrow<Exception>();
        }
    }
}
