using FluentAssertions;
using Patterns.Builder.Abstract;
using Patterns.Builder.Concrete;
using System;
using Xunit;

namespace Patterns.Test.Builder
{
    public class BuilderTests
    {
        [Fact]
        public void When_Model_Is_Valid_Should_Be_Valid()
        {
            //Arrange
            string _rootName = "ul";
            IHtmlBuilder builder = new HtmlBuilder(_rootName);
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");

            //Act
            Action act = () => builder.ToString();

            //Assert
            act.Should().NotThrow<Exception>();
            act.Should().NotBeNull();
        }

        [Fact]
        public void When_Model_Is_Fluent_Valid_Should_Be_Valid()
        {
            //Arrange
            string _rootName = "ul";
            IHtmlBuilder builder = new HtmlBuilder(_rootName);
            builder.AddChildFluent("li", "hello")
                   .AddChildFluent("li", "world");

            //Act
            Action act = () => builder.ToString();

            //Assert
            act.Should().NotThrow<Exception>();
            act.Should().NotBeNull();
        }
    }
}
