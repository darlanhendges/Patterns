using FluentAssertions;
using Patterns.Factory.Abstract;
using Patterns.Factory.Concrete.Providers;
using Patterns.Factory.Interfaces.Providers;
using Patterns.Factory.Models;
using System;
using Xunit;

namespace Patterns.Test.Factory
{
    public class FactoryTests
    {
        [Fact]
        public void When_Info_Are_Valid_Should_be_png_valid()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();
            IProviderServerFactoryProvider _providerServerFactoryProvider = new ServerProviderFactory();
            Image image = new Image()
            {
                DateTime = DateTime.Now,
                Description = "Image 1",
                Name = "Img1",
                Extension = _extensionProviderFactory.GetExtension(".png")
            };


            //Act
            ServerProvider serverProvider = _providerServerFactoryProvider.CreateServerProvider(image.Extension);
            var result = serverProvider.SaveImage(image);

            //Assert
            serverProvider.Server.Should().BeOfType<ServerPng>();
            result.Should().Be(true);
        }

        [Fact]
        public void When_Info_Are_Valid_Should_be_bitmap_valid()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();
            IProviderServerFactoryProvider _providerServerFactoryProvider = new ServerProviderFactory();
            Image image = new Image()
            {
                DateTime = DateTime.Now,
                Description = "Image 1",
                Name = "Img1",
                Extension = _extensionProviderFactory.GetExtension(".bmp")
            };


            //Act
            ServerProvider serverProvider = _providerServerFactoryProvider.CreateServerProvider(image.Extension);
            var result = serverProvider.SaveImage(image);

            //Assert
            serverProvider.Server.Should().BeOfType<ServerBitmap>();
            result.Should().Be(true);
        }

        [Fact]
        public void When_Info_Are_Valid_Should_be_jpeg_valid()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();
            IProviderServerFactoryProvider _providerServerFactoryProvider = new ServerProviderFactory();
            Image image = new Image()
            {
                DateTime = DateTime.Now,
                Description = "Image 1",
                Name = "Img1",
                Extension = _extensionProviderFactory.GetExtension(".jpeg")
            };

            //Act
            ServerProvider serverProvider = _providerServerFactoryProvider.CreateServerProvider(image.Extension);
            var result = serverProvider.SaveImage(image);

            //Assert
            serverProvider.Server.Should().BeOfType<ServerJpeg>();
            result.Should().Be(true);
        }
    }
}


