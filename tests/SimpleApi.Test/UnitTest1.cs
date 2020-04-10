using System;
using SimpleApi.Controllers;
using Xunit;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        ValuesController valuesController = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = valuesController.Get(1);
            Assert.Equal("value", returnValue);
        }
    }
}
