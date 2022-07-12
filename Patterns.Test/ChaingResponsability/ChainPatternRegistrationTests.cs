using FluentAssertions;
using Patterns.ChainResponsability;
using Patterns.ChainResponsability.ConcreteHandlers;
using Patterns.ChainResponsability.Request;
using System;
using Xunit;

namespace Patterns.Test.ChaingResponsability
{
    public class ChainPatternRegistrationTests
    {
        [Fact]
        public void When_Username_Is_Empty_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { Username = string.Empty };

            //Act
            Action act = () => new UsernameValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_Username_Is_Filled_Then_Exception_Should_NOT_Be_Thrown()
        {
            //Arrange
            var user = new User { Username = "Daniel Rusnok" };

            //Act
            Action act = () => new UsernameValidationHandler().Handle(user);

            //Assert
            act.Should().NotThrow<Exception>();
        }

        [Fact]
        public void When_Password_Is_Empty_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { Password = string.Empty };

            //Act
            Action act = () => new PasswordValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_Password_Is_Filled_Then_Exception_Should_NOT_Be_Thrown()
        {
            //Arrange
            var user = new User { Password = Guid.NewGuid().ToString() };

            //Act
            Action act = () => new PasswordValidationHandler().Handle(user);

            //Assert
            act.Should().NotThrow<Exception>();
        }

        [Fact]
        public void When_BirthDate_Is_NOT_Earlier_Than_18_Years_Ago_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { BirthDate = DateTime.Now };

            //Act
            Action act = () => new OnlyAdultValidationHandler().Handle(user);

            //Assert
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void When_BirthDate_Is_Earlier_Than_18_Years_Ago_Then_Exception_Should_Be_Thrown()
        {
            //Arrange
            var user = new User { BirthDate = DateTime.Now.AddYears(-20) };

            //Act
            Action act = () => new OnlyAdultValidationHandler().Handle(user);

            //Assert
            act.Should().NotThrow<Exception>();
        }

        [Fact]
        public void When_All_Properties_Are_valid_Then_Exception_Should_NOT_Be_Thrown()
        {
            //Arrange
            var user = new User
            {
                Username = Generator.RandomString(10),
                Password = Guid.NewGuid().ToString(),
                BirthDate = DateTime.Now.AddYears(-22)
            };

            //Act
            Action act = () => new ChainRegistrationProcessor().Register(user);

            //Assert
            act.Should().NotThrow<Exception>();
        }
    }
}
