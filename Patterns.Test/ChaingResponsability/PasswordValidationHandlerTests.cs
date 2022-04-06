using FluentAssertions;
using Patterns.ChainResponsability.ConcreteHandlers;
using Patterns.ChainResponsability.Request;
using System;
using Xunit;

namespace Patterns.Test.ChaingResponsability
{
    public class PasswordValidationHandlerTests
    {
        [Fact]
        public void When_Password_Is_Invalid_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { Password= String.Empty };

            //Act
            Action act = () => new PasswordValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_Password_Is_Invalid_And_Lower_Than_Is_Expected_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { Password = "123456" };

            //Act
            Action act = () => new PasswordValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_Password_Is_Valid_Then_Should_Be_Okay()
        {
            //Arrange
            var user = new User { Password = Generator.RandomString(10) };

            //Act
            Action act = () => new PasswordValidationHandler().Handle(user);

            //Assert
            act.Should().NotThrow<Exception>();
        }
    }
}
