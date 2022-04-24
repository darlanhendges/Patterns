using FluentAssertions;
using Patterns.Factory.Models;
using Xunit;

namespace Patterns.Test.Factory.Models
{
    public class ServerModelTests
    {
        [Fact]
        public void When_Info_Are_Invalid_Should_be_bitmap_valid()
        {
            //Act
            var serverBmp = new ServerBitmap();

            //Assert
            serverBmp.Name.Should().Be("ServerSky");
            serverBmp.Ip.Should().Be("192.168.1.3");
            serverBmp.ExtensionAllowed.Should().BeOfType<BitmapExtension>();
        }

        [Fact]
        public void When_Info_Are_Invalid_Should_be_png_valid()
        {
            //Act
            var serverBmp = new ServerPng();

            //Assert
            serverBmp.Name.Should().Be("ServerMoon");
            serverBmp.Ip.Should().Be("192.168.1.2");
            serverBmp.ExtensionAllowed.Should().BeOfType<PngExtension>();
        }

        [Fact]
        public void When_Info_Are_Invalid_Should_be_jpeg_valid()
        {
            //Act
            var serverBmp = new ServerJpeg();

            //Assert
            serverBmp.Name.Should().Be("ServerDog");
            serverBmp.Ip.Should().Be("192.168.1.1");
            serverBmp.ExtensionAllowed.Should().BeOfType<JpegExtension>();
        }

    }
}
