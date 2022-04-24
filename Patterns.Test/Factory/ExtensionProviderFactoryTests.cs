using FluentAssertions;
using Patterns.Factory.Concrete.Providers;
using Patterns.Factory.Interfaces;
using Patterns.Factory.Interfaces.Providers;
using Patterns.Factory.Models;
using System;
using Xunit;

namespace Patterns.Test.Factory
{
    public class ExtensionProviderFactoryTests
    {
        [Fact]
        public void When_ImageType_Is_Invalid_Should_Throw_Exception()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();

            //Act
            Action act = () => _extensionProviderFactory.GetExtension(".randomType");

            //Assert
            act.Should().Throw<NotImplementedException>();
        }

        [Fact]
        public void When_ImageType_Is_Valid_Should_be_Png()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();

            //Act
            var target = _extensionProviderFactory.GetExtension(".png");

            //Assert
            target.Should()
                .NotBeNull()
                .And
                .BeOfType<PngExtension>().Which.Name.Equals("Png");

        }

        [Fact]
        public void When_ImageType_Is_Valid_Should_be_Bmp()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();

            //Act
            var target = _extensionProviderFactory.GetExtension(".bmp");

            //Assert
            target.Should()
                .NotBeNull()
                .And
                .BeOfType<BitmapExtension>().Which.Name.Equals("Bitmap");

        }

        [Fact]
        public void When_ImageType_Is_Valid_Should_be_Jpeg()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();

            //Act
            var target = _extensionProviderFactory.GetExtension(".jpeg");

            //Assert
            target.Should()
                .NotBeNull()
                .And
                .BeOfType<JpegExtension>().Which.Name.Equals("Jpeg");

        }
    }
}
