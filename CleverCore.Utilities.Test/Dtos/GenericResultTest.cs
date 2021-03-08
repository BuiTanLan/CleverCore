using CleverCore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleverCore.Utilities.Test.Dtos
{
    public class GenericResultTest
    {
        [Fact]
        public void Constructor_CreateObjectNotNull_ValidObjectNoParamDefault()
        {
            var genericResult = new GenericResult();
            Assert.NotNull(genericResult);
        }
    }
}
