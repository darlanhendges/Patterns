using FluentAssertions;
using Patterns.Factory.Concrete.Providers;
using Patterns.Factory.Concrete.Providers.Servers;
using Patterns.Factory.Interfaces.Providers;
using Patterns.Factory.Models;
using System;
using Xunit;

namespace Patterns.Test.Factory
{
    public class ServerProviderFactoryTests
    {
        [Fact]
        public void When_ImageType_Is_Valid_Should_be_Png()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();
            IProviderServerFactoryProvider _providerServerFactoryProvider = new ServerProviderFactory();

            //Act
            var serverProvider = _providerServerFactoryProvider.CreateServerProvider(new PngExtension());

            //Assert
            serverProvider.Should().BeOfType<PngServerProvider>()
                            .Which.Server.ExtensionAllowed.Name.Equals("png");
        }

        [Fact]
        public void When_ImageType_Is_Valid_Should_be_Bitmap()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();
            IProviderServerFactoryProvider _providerServerFactoryProvider = new ServerProviderFactory();

            //Act
            var serverProvider = _providerServerFactoryProvider.CreateServerProvider(new BitmapExtension());

            //Assert
            serverProvider.Should().BeOfType<BitmapServerProvider>()
                            .Which.Server.ExtensionAllowed.Name.Equals("bitmap");
        }

        [Fact]
        public void When_ImageType_Is_Valid_Should_be_Jpeg()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();
            IProviderServerFactoryProvider _providerServerFactoryProvider = new ServerProviderFactory();

            //Act
            var serverProvider = _providerServerFactoryProvider.CreateServerProvider(new JpegExtension());

            //Assert
            serverProvider.Should().BeOfType<JpegServerProvider>()
                            .Which.Server.ExtensionAllowed.Name.Equals("Jpeg");
        }

        [Fact]
        public void When_ImageType_Is_Invalid_Should_throw()
        {
            //Arrange
            IExtensionProviderFactory _extensionProviderFactory = new ExtensionProviderFactory();
            IProviderServerFactoryProvider _providerServerFactoryProvider = new ServerProviderFactory();

            //Act
            Action act = () => _providerServerFactoryProvider.CreateServerProvider(null);

            //Assert
            act.Should().Throw<Exception>();
        }
    }
}
