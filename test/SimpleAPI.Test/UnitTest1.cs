using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController objValues = new ValuesController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = objValues.Get(1);
            Assert.Equal("Ganesh", returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
