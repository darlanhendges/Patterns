using FluentAssertions;
using Patterns.Adapter.Concrete;
using Patterns.Adapter.Interfaces;
using Patterns.Adapter.Models;
using System;
using Xunit;

namespace Patterns.Test.Adapter
{
    public class LegacyAdapterTests
    {
        [Fact]
        public void When_Model_Is_Valid_Should_Be_Valid()
        {
            //Arrange
            ILegacyService service = new LegacyService();
            ILegacyAdapter adapter = new LegacyAdapter(service);
            var model = new ModelUpdated(1,"");

            //Act
            Action act = () => adapter.Add(model);

            //Assert
            act.Should().NotThrow<Exception>();
        }
    }
}
