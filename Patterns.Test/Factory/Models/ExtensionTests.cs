using FluentAssertions;
using Patterns.Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Patterns.Test.Factory.Models
{
    public class ExtensionTests
    {
        [Fact]
        public void When_Info_Are_Invalid_Should_be_bitmap_valid()
        {
            //Act
            var extension = new BitmapExtension();

            //Assert
            extension.Name.Should().Be("Bitmap");
            extension.Extension.Should().Be(".bmp");
        }

        [Fact]
        public void When_Info_Are_Invalid_Should_be_png_valid()
        {
            //Act
            var extension = new PngExtension();

            //Assert
            extension.Name.Should().Be("Png");
            extension.Extension.Should().Be(".png");
        }

        [Fact]
        public void When_Info_Are_Invalid_Should_be_jpeg_valid()
        {
            //Act
            var extension = new JpegExtension();

            //Assert
            extension.Name.Should().Be("Jpeg");
            extension.Extension.Should().Be(".jpeg");
        }
    }
}
